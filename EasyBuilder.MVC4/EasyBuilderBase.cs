using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    public abstract class EasyBuilderBase : IEasyBuilder
    {
        public string Tag { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string Text { get; set; }
        public object attrData { get; set; }
        public Function OnClick { get; set; }
        private string unique;
        public EasyBuilderBase()
        {
            this.unique = GuidTo16String();
        }
        private string GuidTo16String()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
                i *= ((int)b + 1);
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
        private List<object> innerlist;
        private string CreateDomAttr(string dom,string value)
        {
            string str = string.Empty;
            if (!string.IsNullOrEmpty(value))
                str = string.Format("{0}=\"{1}\" ", dom, value);
            return str;
        }
        public virtual MvcHtmlString Html()
        {
            var attr = this.GetType().GetCustomAttribute<ParserAttribute>();
            if (attr != null)
            {
                if (!string.IsNullOrEmpty(Class))
                    Class = string.Format("{0} {1}", attr.ClsName, Class);
                else
                    Class = attr.ClsName;
                Tag = attr.TagName;
            }
            string strId = this.CreateDomAttr("id", Id);
            string strName = this.CreateDomAttr("name", Name);
            string strValue = this.CreateDomAttr("value", Value);
            string strClass = this.CreateDomAttr("class", Class);
            string strStyle = this.CreateDomAttr("style", Style);
            string strDataOptions = this.CreateDomAttr("data-options", this.Parser());
            string strOnClick = this.CreateDomAttr("onclick", OnClick == null ? null : Function.Eval("javascript:" + OnClick.Script).Script);
            string strAttr = string.Empty;
            if (this.attrData != null)
            {
                PropertyInfo[] infos = this.attrData.GetType().GetProperties();
                foreach (PropertyInfo info in infos)
                {
                    strAttr += this.CreateDomAttr(info.Name, info.GetValue(this.attrData).ToString());
                }
            }
            StringBuilder sb = new StringBuilder();
            if (innerlist != null)
            {
                foreach (object inner in innerlist)
                {
                    if (inner is IEasyBuilder)
                        sb.Append((inner as IEasyBuilder).Html());
                    else
                        sb.Append(inner.ToString());
                }
                innerlist.Clear();
            }
            string html = string.Format("<{0} {1}{2}{3}{4}{5}{6}{7}{8}easybuilder-unique=\"{9}\" >{10}{11}</{0}>", string.IsNullOrEmpty(Tag) ? "div" : Tag, strId, strName, strClass, strStyle, strDataOptions, strValue, strOnClick, strAttr, this.unique, Text, sb.ToString());
            return MvcHtmlString.Create(html);
        }
        public virtual IEasyBuilder Append(IEasyBuilder builder)
        {
            if (innerlist == null)
                innerlist = new List<object>();
            innerlist.Add(builder);
            return this;
        }
        public virtual IEasyBuilder Append(string html)
        {
            if (innerlist == null)
                innerlist = new List<object>();
            innerlist.Add(html);
            return this;
        }
        /// <summary>
        /// 执行方法
        /// </summary>
        public MvcHtmlString Do(string method, object param = null)
        {
            string parser = string.Empty;
            var attr = this.GetType().GetCustomAttribute<ParserAttribute>();
            if (attr != null)
                parser = attr.ClsName.Replace("easyui-", "");
            string paramstr = param == null ? string.Empty : "," + param.Parser();
            string html = string.Format("$('*[easybuilder-unique=\\'{0}\\']').{1}('{2}'{3});", this.unique, parser, method, paramstr);
            return MvcHtmlString.Create(html);
        }
        /// <summary>
        /// 获取Jquery对象
        /// </summary>
        public string Get()
        {
            string parser = string.Empty;
            return string.Format("$('*[easybuilder-unique=\\'{0}\\']')", this.unique);
        }
        /// <summary>
        /// 获取Jquery选择器
        /// </summary>
        public string GetSelector()
        {
            string parser = string.Empty;
            return string.Format("*[easybuilder-unique=\\'{0}\\']", this.unique);
        }
    }
}
