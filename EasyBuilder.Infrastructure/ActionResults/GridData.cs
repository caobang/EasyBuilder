using System.Collections;

namespace EasyBuilder.Infrastructure.ActionResults
{
    public class GridData
    {
        public int total { set; get; }
        public IEnumerable rows { set; get; }
    }
}
