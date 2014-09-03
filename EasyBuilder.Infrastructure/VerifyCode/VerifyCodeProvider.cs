using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode
{
    public abstract class VerifyCodeProvider
    {
        public abstract string CreateVerifyCode();
        public string GetRandomString(VerifyCodeParameter parameter)
        {
            VerifyCodeBuilder builder = new VerifyCodeBuilder(parameter);
            return builder.GetRandomString();
        }
    }
}