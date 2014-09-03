using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.Exceptions
{
    /// <summary>
    /// 业务异常对象
    /// </summary>
    public class EasyBuilderException : Exception
    {
        private string _code;
        public string Code
        {
            get
            {
                return this._code;
            }
        }
        public EasyBuilderException(string code, string message)
            : base(message)
        {
            this._code = code;
        }
        public EasyBuilderException(string code, string message, Exception e)
            : base(message, e)
        {
            this._code = code;
        }
    }
}
