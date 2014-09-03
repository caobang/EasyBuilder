using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Design
{
    [Table("Design_Page")]
    public class Design_Page : Entity
    {
        public string Name { get; set; }
        public Guid MenuKey { get; set; }

        [ForeignKey("MenuKey")]
        public virtual Design_Menu Menu { get; set; }
    }
}
