using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ParserAttribute : Attribute
    {
        private string clsName;
        public string ClsName
        {
            get { return this.clsName; }
        }
        private string tagName;
        public string TagName
        {
            get { return this.tagName; }
        }
        public ParserAttribute(string clsName)
        {
            this.clsName = clsName;
            this.tagName = string.Empty;
        }
        public ParserAttribute(string clsName, string tagName)
        {
            this.clsName = clsName;
            this.tagName = tagName;
        }
    }
}
