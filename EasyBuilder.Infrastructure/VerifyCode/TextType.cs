using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode
{
    /// <summary>
    /// 表示验证码的文本内容类型。
    /// </summary>
    public enum TextType
    {
        /// <summary>
        /// 表示数字和字母的混合类型，默认值。
        /// </summary>
        Mix = 0,

        /// <summary>
        /// 表示纯数字类型。
        /// </summary>
        Number = 1,

        /// <summary>
        /// 表示大写字符
        /// </summary>
        Upper = 2,

        /// <summary>
        /// 表示小写字符
        /// </summary>
        Lower = 3,

        /// <summary>
        /// 表示大小写字母混合类型。
        /// </summary>
        Word = 4,

        /// <summary>
        /// 表示简单的数学表达式类型。
        /// </summary>
        Calculate = 5,

    }
}
