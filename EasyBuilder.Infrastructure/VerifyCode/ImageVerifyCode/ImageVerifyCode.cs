using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode.ImageVerifyCode
{
    public class ImageVerifyCode : VerifyCode
    {
        private Image _image;
        public ImageVerifyCode(string text, Image image)
        {
            this.Text = text;
            this._image = image;
        }
        public Image Image
        {
            get
            {
                return this._image;
            }
        }
    }
}
