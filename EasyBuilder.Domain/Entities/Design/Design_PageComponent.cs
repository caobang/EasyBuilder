using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Design
{
    [Table("Design_PageComponent")]
    public class Design_PageComponent : EntityTree
    {
        public Guid PageKey { get; set; }
        [ForeignKey("PageKey")]
        public virtual Design_Page Page { get; set; }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string Text { get; set; }

        public Guid BuilderKey { get; set; }
        [ForeignKey("BuilderKey")]
        public virtual Design_Builder Builder { get; set; }
    }
}
