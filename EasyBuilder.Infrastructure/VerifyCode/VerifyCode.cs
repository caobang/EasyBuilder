using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode
{
    public class VerifyCode
    {
        private string _text;
        public string Text
        {
            get
            {
                return this._text;
            }
            protected set
            {
                this._text = value;
            }
        }
    }
}
