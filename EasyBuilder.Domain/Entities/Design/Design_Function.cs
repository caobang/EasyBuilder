using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Design
{
    [Table("Design_Function")]
    public class Design_Function : Entity
    {
        public string Script { get; set; }
    }
}
