using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode
{
    /// <summary>
    /// 表示验证码的输出类型。
    /// </summary>
    public enum VerifyCodeType
    {
        /// <summary>
        /// 通过 HttpResponse 响应流输出。
        /// </summary>
        HttpResponse = 0,

        /// <summary>
        /// 通过手机短信方式输出。
        /// </summary>
        MobileMessage = 1,

        /// <summary>
        /// 通过电子邮件方式输出。
        /// </summary>
        Email = 2
    }
}
