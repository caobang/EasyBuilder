using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode
{
    /// <summary>
    /// 提供一组属性和方法，用于生成随机字符串。
    /// </summary>
    public class RandomTextBuilder
    {
        private int len;
        private string range;
        private string last;


        public RandomTextBuilder() : this(4, "0123456789") { }

        public RandomTextBuilder(int length) : this(length, "0123456789") { }

        public RandomTextBuilder(string range) : this(4, range) { }

        /// <summary>
        /// 按照指定的长度和取值范围构造一个 RandomTextBuilder 实例。
        /// </summary>
        /// <param name="length"></param>
        /// <param name="rage"></param>
        public RandomTextBuilder(int length, string range)
        {
            if (length < 1)
            {
                throw new ArgumentOutOfRangeException("传入的参数 length 不合法，长度超出范围，初始化实例失败。");
            }
            if (string.IsNullOrWhiteSpace(range))
            {
                throw new ArgumentException("传入的参数 range 不合法，不包含任何字符，初始化实例失败。");
            }
            this.Length = length;
            this.Range = range;
        }



        /// <summary>
        /// 生成的随机字符串的默认长度，初始值为4。
        /// </summary>
        public int Length
        {
            get { return this.len == 0 ? 4 : this.len; }
            set { this.len = value < 1 ? 4 : value; }
        }

        /// <summary>
        /// 生成的随机字符串的字符取值范围，默认为“0123456789”。
        /// </summary>
        public string Range
        {
            get { return string.IsNullOrEmpty(this.range) ? "0123456789" : this.range; }
            set { this.range = string.IsNullOrEmpty(value) ? "0123456789" : value; }
        }

        /// <summary>
        /// 获取最近一次生成的随机字符串。
        /// </summary>
        public string LastBuildText
        {
            get { return this.last; }
        }


        /// <summary>
        /// 生成一个随机字符串。
        /// </summary>
        /// <returns>生成的随机字符串。</returns>
        public string CreateRandomText()
        {
            return this.CreateRandomText(this.Length, this.Range);
        }

        /// <summary>
        /// 按照指定的长度生成一个随即字符串。
        /// </summary>
        /// <param name="length">指定要生成的字符串的长度。</param>
        /// <returns>生成的随机字符串。</returns>
        public string CreateRandomText(int length)
        {
            return this.CreateRandomText(length, this.Range);
        }

        /// <summary>
        /// 按照指定的取值范围生成一个随即字符串。
        /// </summary>
        /// <param name="range">指定要生成的字符串的取值范围。</param>
        /// <returns>生成的随机字符串。</returns>
        public string CreateRandomText(string range)
        {
            return this.CreateRandomText(this.Length, range);
        }

        /// <summary>
        /// 按照指定的长度和取值范围生成一个随即字符串。
        /// </summary>
        /// <param name="length">指定要生成的字符串的长度。</param>
        /// <param name="range">指定要生成的字符串的取值范围。</param>
        /// <returns>生成的随机字符串。</returns>
        public string CreateRandomText(int length, string range)
        {
            if (length < 1)
            {
                throw new ArgumentOutOfRangeException("传入的参数 length 不合法，长度超出范围。");
            }
            if (string.IsNullOrEmpty(range))
            {
                throw new ArgumentException("传入的参数 range 不合法，不包含任何字符。");
            }
            string returnValue;
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(range.Substring(random.Next(DateTime.Now.Millisecond) % range.Length, 1));
            }
            returnValue = stringBuilder.ToString();
            this.last = returnValue;
            return returnValue;
        }
    }
}
