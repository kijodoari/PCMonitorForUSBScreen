﻿using System;
using System.IO.Ports;
using System.Management;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace USBScreen
{

    //the device for this class is https://item.taobao.com/item.htm?spm=a1z09.2.0.0.1fe82e8dugX098&id=638243141111&_u=jcj8c444ae
    //the PNPDeviceID for this device is USB35INCHIPSV2
    public class Device3_5:IUSBScreen
    {
        public string COMName { get; private set; }

        public string PNPDeviceID  { get; private set; } = "USB35INCHIPSV2";



        public SerialPort SerialPort { get; private set; }

        public int ScreenWidth { get; private set; } = 480;

        public int ScreenHeight { get; private set; } = 320;

        public eScreenStatus Status { get; private set; } = eScreenStatus.UnKnown;


        private static Device3_5 instance;


        private Device3_5(int width,int height)
        {
            this.ScreenWidth = width;
            this.ScreenHeight = height;
        }


        //参数只支持  480 320 或 320 480
        //添加 pnpdeviceid 参数，用于读取主题配置中的 pnpdeviceid 定义
        public static Device3_5 GetInstance(int width, int height)
        {
            //TODO 检查参数


            if (instance == null) instance = new Device3_5(width,height);
            return instance;
        }


        //连接
        public void Connect()
        {
            try
            {
                if (this.SerialPort == null)
                {
                    using (var searcher = new ManagementObjectSearcher("select * from Win32_SerialPort"))
                    {
                        var mos = searcher.Get();
                        //查找 PNPDeviceID 包含 USB35INCHIPSV2 的对象
                        var obj = mos.Cast<ManagementObject>().Where(mo => mo.Properties.Cast<PropertyData>().Any(pd => pd.Name == "PNPDeviceID" && pd.Value.ToString().Contains(this.PNPDeviceID))).FirstOrDefault();

                        if (obj == null)
                        {
                            this.Status = eScreenStatus.NotFound;
                            //throw new Exception("未找到设备串口。");
                        }
                        else
                        {
                            this.COMName = obj.Properties["DeviceID"].Value.ToString();
                            this.SerialPort = new SerialPort(this.COMName)
                            {
                                DtrEnable = true,
                                RtsEnable = true,
                                ReadTimeout = 1000,
                                BaudRate = 115200,
                                DataBits = 8,
                                StopBits = StopBits.One,
                                Parity = Parity.None
                            };

                            //尝试打开
                            this.SerialPort.Open(); //打开不成功视为连接不成功

                            this.Status = eScreenStatus.Connected;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                this.Status = eScreenStatus.Error;
            }
        }

        //释放
        public void Dispose()
        {
            if (this.SerialPort != null)
            {
                this.SerialPort.Close();
                this.SerialPort.Dispose();
            }
            Device3_5.instance = null;
        }

        //关闭，熄灭屏幕
        public void Shutdown()
        {
            sendCMD(108, 0, 0, 0, 0);
        }

        //开启，即点亮屏幕
        public void Startup()
        {
            sendCMD(109, 0, 0, 0, 0);

            //设置默认的显示方式
            //this.AjustScreen(false, true, true);
        }

        //重启
        public void Restart()
        {
            this.sendCMD(101, 0, 0, 0, 0);
            Thread.Sleep(3000);
        }

        public void RenderBitmap(Bitmap img, int posX, int posY)
        {
            //检查渲染内容是否超过屏幕
            if ((img.Width + posX > this.ScreenWidth) || (img.Height + posY > this.ScreenHeight))
            {
                throw new Exception("渲染的图片超出屏幕");
            }

            //注意！由于设备未知的原因，渲染bitmap时，img的宽度需要是偶数？4的整数，更具图片的stride
            //上面的问题已经解决

            this.sendCMD(197, posX, posY, posX + img.Width - 1 , posY + img.Height - 1 );

            this.writeToSerialPort(getBytesFromBitmap(img));

            Thread.Sleep(10);

        }


        //坐标数组中的格式为 [x0,y0,x1,y1,x2,y2.....]
        //坐标值最大为一个字节 既不能超过255
        public void RenderPixels(int offsetX,int offsetY, Color pixelColor, byte[] coordinates)
        {
            int each_length = 56;
            int bytes_sended = 0;

            var colorValue = getColorValue(pixelColor);
            byte colorH = (byte)(colorValue >> 8);//颜色的高八位数据
            byte colorL = (byte)(colorValue & (int)byte.MaxValue);//颜色的低八位数据


            while (bytes_sended < coordinates.Length)
            {
                var param_bytes = new byte[64];

                var bytes_count_tosend_this_time = each_length;

                if (bytes_sended + each_length > coordinates.Length)
                    bytes_count_tosend_this_time = coordinates.Length - bytes_sended;

                param_bytes[6] = colorH;
                param_bytes[7] = colorL;

                //像素坐标信息每次传送56个
                Array.Copy(coordinates, bytes_sended, param_bytes, 8, bytes_count_tosend_this_time);

                sendCMD(195, offsetX, offsetY, bytes_count_tosend_this_time, 0, param_bytes);

                bytes_sended += bytes_count_tosend_this_time;
            }
            
        }

        public void RenderPixels(Color pixelColor, IEnumerable<Point> points)
        {
            if (points == null || points.Count() == 0) return;
            var inscope_point_bytes = new List<byte>();
            //需要对坐标值大于255的数据使用 offset来绘制
            var outscope_points = new List<Point>();
            var outscope_point_bytes = new List<byte>();
            foreach (var p in points)
            {
                if (p.X < 256 && p.Y < 256)
                {
                    inscope_point_bytes.Add((byte)p.X);
                    inscope_point_bytes.Add((byte)p.Y);
                }
                else
                {
                    outscope_points.Add(p);
                }
            }

            RenderPixels(0, 0, pixelColor, inscope_point_bytes.ToArray());

            if (outscope_points.Count > 0)
            {
                //对于字节坐标区域外的数据选取一个合适的offset
                var min_X = outscope_points.OrderBy(p => p.X).FirstOrDefault().X;
                var max_X = outscope_points.OrderByDescending(p => p.X).FirstOrDefault().X;

                if (max_X - min_X > 255)
                {
                    throw new Exception("offset 设置无法满足所有坐标点，既两个坐标点的Y轴跨度太大");
                }

                var min_Y = outscope_points.OrderBy(p => p.Y).FirstOrDefault().Y;
                var max_Y = outscope_points.OrderByDescending(p => p.Y).FirstOrDefault().Y;

                if (max_X - min_X > 255)
                {
                    throw new Exception("offset 设置无法满足所有坐标点，既两个坐标点的Y轴跨度太大");
                }

                //若无异常 则取min_X 和 min_Y 作为 offset
                foreach (var op in outscope_points)
                {
                    outscope_point_bytes.Add((byte)(op.X - min_X));
                    outscope_point_bytes.Add((byte)(op.Y - min_Y));
                }

                RenderPixels(min_X, min_Y, pixelColor, outscope_point_bytes.ToArray());

            }


        }


        public void SetMirror(bool isMirror)
        {
            if (isMirror)
            {
                sendCMD122(1);
            }
            else
            {
                sendCMD122(0);
            }
        }

        public void SetLandscapeDisplay(bool isInvert)
        {
            int cmd_num = 3;
            int width = 320;
            int height = 480;
            //横屏 + 180度 3
            if (isInvert)
            {
                cmd_num = 3;
            }
            //横屏 + 0度   2
            else if (!isInvert)
            {
                cmd_num = 2;
            }

            sendCMD121(cmd_num, width, height);
        }

        public void SetVerticalDisplay(bool isInvert)
        {
            int cmd_num = 1;
            int width = 480;
            int height = 320;
            //竖屏 + 180度 1
            if (isInvert)
            {
                cmd_num = 1;
            }
            //竖屏 + 0度   0
            else if (!isInvert)
            {
                cmd_num = 0;
            }

            sendCMD121(cmd_num, width, height);
        }


        //value值为0到255， 值越小越亮 , 传入的 brightness 为 1~100 越高越亮
        public void SetBrightness(int brightness)
        {
            this.Connect();
            this.Startup();

            int device_bright_value = 255 - (int)(255 * brightness / 100);

            this.sendCMD(110, device_bright_value, 0, 0, 0);
        }


        //=============================================================================================


        //通用发送指令方法
        private void sendCMD(int cmd_code, int left, int top, int right, int bottom, byte[] bytes = null, int delay = 10)
        {
            if (bytes == null)
            {
                bytes = new byte[6];
            }

            bytes[0] = (byte)(left >> 2);
            bytes[1] = (byte)(((left & 3) << 6) + (top >> 4));
            bytes[2] = (byte)(((top & 15) << 4) + (right >> 6));
            bytes[3] = (byte)(((right & 63) << 2) + (bottom >> 8));
            bytes[4] = (byte)(bottom & (int)byte.MaxValue);
            bytes[5] = (byte)cmd_code;

            this.writeToSerialPort(bytes);

            Thread.Sleep(delay);

        }

        //旋转，需配合额外数据(像素)
        //横屏 + 0度   2
        //横屏 + 180度 3
        //竖屏 + 0度   0
        //竖屏 + 180度 1
        private void sendCMD121(int landScape_invert, int width, int height)
        {
            landScape_invert += 100;
            byte[] byte_0 = new byte[16];
            byte_0[6] = (byte)landScape_invert;
            byte_0[7] = (byte)(width >> 8);
            byte_0[8] = (byte)(width & (int)byte.MaxValue);
            byte_0[9] = (byte)(height >> 8);
            byte_0[10] = (byte)(height & (int)byte.MaxValue);
            this.sendCMD(121, 0, 0, 0, 0, byte_0);
        }


        //是否镜像
        private void sendCMD122(int mode_num)
        {
            byte[] byte_0 = new byte[16];
            byte_0[6] = (byte)mode_num;
            this.sendCMD(122, 0, 0, 0, 0, byte_0);
        }

        //获取颜色对应的整数值
        private int getColorValue(Color color)
        {
            return (int)color.R << 8 & 63488 | (int)color.G << 3 & 2016 | (int)color.B >> 3;
        }

        //获取适用于渲染的图片字节数组
        private byte[] getBytesFromBitmap(Bitmap bitmap)
        {
            int size = bitmap.Width * bitmap.Height;
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            var bitmap_data = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format16bppRgb565);


            var pixel_bytes = new byte[size * 2];
            if(bitmap_data.Stride == bitmap.Width * 2)
            {
                Marshal.Copy(bitmap_data.Scan0, pixel_bytes, 0, pixel_bytes.Length);
            }
            else
            {
                var raw_bytes = new byte[bitmap_data.Stride * bitmap.Height];
                Marshal.Copy(bitmap_data.Scan0, raw_bytes, 0, raw_bytes.Length);

                //拷贝raw_bytes到pixel_bytes 跳过stride补齐字节
                for (int r = 0; r < bitmap.Height; r++)
                {
                    for (int c = 0; c < bitmap.Width * 2; c++)
                    {
                        var p_idx = (r * bitmap.Width * 2) + c;
                        var r_idx = (r * bitmap_data.Stride) + c;
                        pixel_bytes[p_idx] = raw_bytes[r_idx];
                    }
                }

            }

            bitmap.UnlockBits(bitmap_data);
            return pixel_bytes;
        }


        private void writeToSerialPort(byte[] bytes)
        {
            if (this.Status == eScreenStatus.Connected)
            {

                //发送数据
                if (!this.SerialPort.IsOpen) this.SerialPort.Open();

                this.SerialPort.Write(bytes, 0, bytes.Length);

            }

        }

        public void SendCMD(byte[] data)
        {
            throw new NotImplementedException();
        }

        //public void AjustScreen(bool isMirror, bool isLandscape, bool isInvert)
        //{

        //    if (isMirror)
        //    {
        //        sendCMD122(1);
        //    }
        //    else
        //    {
        //        sendCMD122(0);

        //    }

        //    int cmd_num = 3;
        //    //横屏 + 180度 3
        //    if (isLandscape && isInvert)
        //    {
        //        cmd_num = 3;
        //        this.ScreenWidth = 480;
        //        this.ScreenHeight = 320;
        //    }
        //    //横屏 + 0度   2
        //    else if (isLandscape && !isInvert)
        //    {
        //        cmd_num = 2;
        //        this.ScreenWidth = 480;
        //        this.ScreenHeight = 320;
        //    }
        //    //竖屏 + 180度 1
        //    else if (!isLandscape && isInvert)
        //    {
        //        cmd_num = 1;
        //        this.ScreenWidth = 320;
        //        this.ScreenHeight = 480;
        //    }
        //    //竖屏 + 0度   0
        //    else if (!isLandscape && !isInvert)
        //    {
        //        cmd_num = 0;
        //        this.ScreenWidth = 320;
        //        this.ScreenHeight = 480;
        //    }

        //    sendCMD121(cmd_num, this.ScreenWidth, this.ScreenHeight);

        //}
    }


}
