using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode.ImageVerifyCode
{
    /// <summary>
    /// 该类提供一组属性和方法，用于根据设定的字符值来生成文字图像，比较常用的场景是用于验证码图片的生成。
    /// </summary>
    public class TextImageBuilder
    {
        private Font textFont;
        private int noiseNum;
        private int noiseLineNum;
        private int width;
        private int height;


        /// <summary>
        /// 默认的构造函数，初始化一个带有默认值的 RandomImageBuilder 实例。
        /// </summary>
        public TextImageBuilder() { }

        /// <summary>
        /// 按照指定的图片像素宽度和高度初始化一个 RandomImageBuilder 实例。
        /// </summary>
        /// <param name="width">指定的图片像素宽度</param>
        /// <param name="height">指定的图片像素高度</param>
        public TextImageBuilder(int width, int height)
        {
            this.width = width;
            this.height = height;
        }


        /// <summary>
        /// 生成含有指定字符串文本和噪点、噪音线的图片。
        /// </summary>
        /// <returns>生成的随机图片。</returns>
        public Image CreateImage()
        {
            Bitmap image = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(image);
            Random random = new Random();
            g.Clear(this.BackgroupColor);

            #region 画图片的背景噪音线
            int x1, y1, x2, y2;

            for (int i = 0; i < this.NoiseLineNum; i++)
            {
                x1 = random.Next(image.Width);
                y1 = random.Next(image.Height);
                x2 = random.Next(image.Width);
                y2 = random.Next(image.Height);
                g.DrawLine(new Pen(this.ColorNoiseLine), x1, y1, x2, y2);
            }
            #endregion

            #region 画图片的前景噪音点
            for (int i = 0; i < this.NoiseNum; i++)
            {
                x1 = random.Next(image.Width);
                y1 = random.Next(image.Height);
                image.SetPixel(x1, y1, this.ColorNoise);
            }
            #endregion

            g.DrawString(this.Text, this.TextFont, this.FontColor, 2, 2);
            g.Dispose();
            return image;
        }


        /// <summary>
        /// 获取或者设置随机生成的图片的文本文字的颜色。
        /// </summary>
        public Brush FontColor { get; set; }

        /// <summary>
        /// 获取或设置要随机生成的图片的背景颜色。
        /// </summary>
        public Color BackgroupColor { get; set; }

        /// <summary>
        /// 获取或设置要随机生成的图片的噪音点颜色。
        /// </summary>
        public Color ColorNoise { get; set; }

        /// <summary>
        /// 获取或设置要随机生成的图片的噪音线颜色。
        /// </summary>
        public Color ColorNoiseLine { get; set; }

        /// <summary>
        /// 获取或设置要随机生成的图片的文本字体。
        /// </summary>
        public Font TextFont
        {
            get { return this.textFont == null ? new Font("Arial", (float)this.Width / this.Text.Length, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)) : this.textFont; }
            set { textFont = value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的图片的噪点数量，默认为 100。
        /// </summary>
        public int NoiseNum
        {
            get { return this.noiseNum == 0 ? 100 : this.noiseNum; }
            set { this.noiseNum = value < 1 ? 100 : value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的图片的噪音线数量，默认为 25。
        /// </summary>
        public int NoiseLineNum
        {
            get { return this.noiseLineNum == 0 ? 25 : this.noiseLineNum; }
            set { this.noiseLineNum = value < 1 ? 25 : value; }
        }

        /// <summary>
        /// 随机生成的图片的宽度像素，默认为 48。
        /// </summary>
        public int Width
        {
            get { return this.width == 0 ? 48 : this.width; }
            set { this.width = value < 1 ? 48 : value; }
        }

        /// <summary>
        /// 随机生成的图片的长度像素，默认为 24。
        /// </summary>
        public int Height
        {
            get { return this.height == 0 ? 24 : this.height; }
            set { this.height = value < 1 ? 24 : value; }
        }

        /// <summary>
        /// 随机图片包含的字符。
        /// </summary>
        public string Text { get; set; }
    }
}