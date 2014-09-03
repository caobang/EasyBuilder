using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.DataExtension
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class OrderMapperAttribute : Attribute
    {
        private string fieldName;
        /// <summary>
        /// 映射字段名
        /// </summary>
        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }
    }
}
