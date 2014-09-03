using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.VerifyCode
{
    public class VerifyCodeBuilder
    {
        private VerifyCodeParameter _parameter;
        public VerifyCodeBuilder(VerifyCodeParameter parameter)
        {
            this._parameter = parameter;
        }
        public string GetRandomString()
        {
            string result = null;
            switch (_parameter.TextType)
            {
                case TextType.Calculate:
                    result = this.getCalculateRandomString();
                    break;
                case TextType.Mix:
                    result = this.getMixRandomString(_parameter.TextLength);
                    break;
                case TextType.Number:
                    result = this.getNumberRandomString(_parameter.TextLength);
                    break;
                case TextType.Upper:
                    result = this.getUpperRandomString(_parameter.TextLength);
                    break;
                case TextType.Lower:
                    result = this.getLowerRandomString(_parameter.TextLength);
                    break;
                case TextType.Word:
                    result = this.getWordRandomString(_parameter.TextLength);
                    break;
                default:
                    result = this.getWordRandomString(_parameter.TextLength);
                    break;
            }
            return result;
        }
        private string getMixRandomString(int length)
        {
            string returnValue = null;
            RandomTextBuilder textBuilder = new RandomTextBuilder();
            string range = "0123456789abcdefghigklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            returnValue = textBuilder.CreateRandomText(length, range);
            return returnValue;
        }

        private string getUpperRandomString(int length)
        {
            string returnValue = null;
            RandomTextBuilder textBuilder = new RandomTextBuilder();
            string range = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            returnValue = textBuilder.CreateRandomText(length, range);
            return returnValue;
        }

        private string getLowerRandomString(int length)
        {
            string returnValue = null;
            RandomTextBuilder textBuilder = new RandomTextBuilder();
            string range = "abcdefghigklmnopqrstuvwxyz";
            returnValue = textBuilder.CreateRandomText(length, range);
            return returnValue;
        }

        private string getWordRandomString(int length)
        {
            string returnValue = null;
            RandomTextBuilder textBuilder = new RandomTextBuilder();
            string range = "abcdefghigklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            returnValue = textBuilder.CreateRandomText(length, range);
            return returnValue;
        }

        private string getNumberRandomString(int length)
        {
            string returnValue = null;
            RandomTextBuilder textBuilder = new RandomTextBuilder();
            string range = "0123456789";
            returnValue = textBuilder.CreateRandomText(length, range);
            return returnValue;
        }

        private string getCalculateRandomString()
        {
            string returnValue = null;
            RandomTextBuilder textBuilder = new RandomTextBuilder();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(textBuilder.CreateRandomText(1, "0123456789"));
            stringBuilder.Append(textBuilder.CreateRandomText(1, "+-*"));
            stringBuilder.Append(textBuilder.CreateRandomText(1, "0123456789"));
            returnValue = stringBuilder.ToString();
            return returnValue;
        }
    }
}
