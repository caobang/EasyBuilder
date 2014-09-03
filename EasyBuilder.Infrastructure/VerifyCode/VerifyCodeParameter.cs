using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode
{
    public class VerifyCodeParameter
    {
        private int textLength = 4;
        /// <summary>
        /// 随机生成的图片的字符长度，默认为 4。
        /// </summary>
        public int TextLength
        {
            get { return this.textLength; }
            set { this.textLength = value < 1 ? 4 : value; }
        }
        /// <summary>
        /// 获取或设置验证码的文本类型。
        /// </summary>
        public TextType TextType { get; set; }
    }
}
