using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities
{
    public class EntityTree : EntitySort
    {
        public Nullable<Guid> ParentKey { get; set; }
    }
}
