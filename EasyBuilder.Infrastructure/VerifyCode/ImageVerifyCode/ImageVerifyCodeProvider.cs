using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EasyBuilder.Infrastructure.VerifyCode.ImageVerifyCode
{
    public class ImageVerifyCodeProvider : VerifyCodeProvider
    {
        private ImageVerifyCodeParameter _parameter;
        public ImageVerifyCodeProvider(ImageVerifyCodeParameter parameter)
        {
            this._parameter = parameter;
        }

        /// <summary>
        /// 生成验证码功能
        /// </summary>
        /// <returns></returns>
        public override string CreateVerifyCode()
        {
            string randomString = base.GetRandomString(_parameter);
            //生成图片
            TextImageBuilder builder = new TextImageBuilder(_parameter.ImageWidth, _parameter.ImageHeight);
            builder.Text = randomString;
            builder.TextFont = _parameter.TextFont;
            builder.FontColor = _parameter.FontColor;
            builder.NoiseNum = _parameter.NoiseNum;
            builder.NoiseLineNum = _parameter.NoiseLineNum;
            builder.ColorNoise = _parameter.ColorNoise;
            builder.ColorNoiseLine = _parameter.ColorNoiseLine;
            builder.BackgroupColor = _parameter.BackgroupColor;
            //保存到输出流
            builder.CreateImage().Save(HttpContext.Current.Response.OutputStream, ImageFormat.Gif);

            return randomString;
        }
    }
}
