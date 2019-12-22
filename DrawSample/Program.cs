using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace DrawSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap(200, 100);        //生成一个像素图“画板”

            using (Graphics g = Graphics.FromImage(image))
            {
                g.Clear(Color.AliceBlue);                   //添加底色

                g.DrawLine(new Pen(Color.Black), new Point(0, 0), new Point(100, 50)); //画直线
                g.DrawString("hello, luckystack",           //绘制字符串
                    new Font("宋体", 14),                   //指定字体
                    //new TextureBrush(image,null,imageAttr:new System.Drawing.Imaging.ImageAttributes(
                    new SolidBrush(Color.DarkRed),          //绘制时使用的刷子
                    new PointF(5, 6)                        //左上角定位
                );
            };     //在画板的基础上生成一个绘图对象

            image.SetPixel(195, 95, Color.BlueViolet);  //绘制一个像素的点

            image.Save(@"C:\17bang\hello.jpg", ImageFormat.Jpeg);   //保存到文件
        }
    }
}
