using System.Web.Mvc;

namespace EasyBuilder.Infrastructure.ActionResults
{
    public class DataResult : JsonResult
    {
        public DataResult(object data)
        {
            this.Data = data;
        }
    }
}
