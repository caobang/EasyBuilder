using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities
{
    public abstract class Entity
    {
        [Key]
        public Guid Key { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ID { get; set; }
        public Nullable<Byte> Type { get; set; }
        public Nullable<Byte> Flag { get; set; }
        public Nullable<Byte> Status { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
        public Nullable<int> CreateUser { get; set; }
        public Nullable<DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUser { get; set; }
        public string Remark { get; set; }
    }
}
