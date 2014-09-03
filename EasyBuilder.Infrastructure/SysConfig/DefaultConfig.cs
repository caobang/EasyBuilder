using EasyBuilder.Core.Cryptographies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.SysConfig
{
    public static class DefaultConfig
    {
        /// <summary>
        /// 默认密码
        /// </summary>
        public static string Password = Cryptography.MD5.CreateHash("123");

    }
}
