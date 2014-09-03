using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode.ImageVerifyCode
{
    public class ImageVerifyCodeParameter : VerifyCodeParameter
    {
        private int width = 60;
        private int height = 24;
        private int noiseNum = 50;
        private int noiseLineNum = 10;
        private Font textFont = new Font("Arial", 13, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular));
        private Color colorNoise = Color.Blue;
        private Color colorNoiseLine = Color.Green;
        private Color backgroupColor = Color.White;
        private Brush fontColor = Brushes.Black;

        /// <summary>
        /// 获取或设置验证码文本文字的颜色，默认为 Brushes.Black。
        /// </summary>
        public Brush FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的验证码的噪音点颜色，默认为 Color.Blue。
        /// </summary>
        public Color ColorNoise
        {
            get { return colorNoise; }
            set { colorNoise = value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的图片的噪音线颜色，默认为 Color.Green。
        /// </summary>
        public Color ColorNoiseLine
        {
            get { return colorNoiseLine; }
            set { colorNoiseLine = value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的图片的文本字体，默认为 Font("Arial", 13, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))。
        /// </summary>
        public Font TextFont
        {
            get { return this.textFont; }
            set { textFont = value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的图片的噪点数量，默认为 50。
        /// </summary>
        public int NoiseNum
        {
            get { return this.noiseNum == 0 ? 100 : this.noiseNum; }
            set { this.noiseNum = value < 1 ? 100 : value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的图片的噪音线数量，默认为 10。
        /// </summary>
        public int NoiseLineNum
        {
            get { return this.noiseLineNum == 0 ? 25 : this.noiseLineNum; }
            set { this.noiseLineNum = value < 1 ? 25 : value; }
        }


        /// <summary>
        /// 随机生成的图片的宽度像素，默认为 48。
        /// </summary>
        public int ImageWidth
        {
            get { return this.width == 0 ? 48 : this.width; }
            set { this.width = value < 1 ? 48 : value; }
        }

        /// <summary>
        /// 随机生成的图片的长度像素，默认为 24。
        /// </summary>
        public int ImageHeight
        {
            get { return this.height == 0 ? 24 : this.height; }
            set { this.height = value < 1 ? 24 : value; }
        }

        /// <summary>
        /// 获取或设置要随机生成的验证码的背景颜色，默认为 Color.White。
        /// </summary>
        public Color BackgroupColor
        {
            get { return backgroupColor; }
            set { backgroupColor = value; }
        }

    }
}
