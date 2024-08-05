using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Domain.Entities
{
    public class BaseEntity
    {
        [Key] public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public String CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String? UpdatedBy { get; set; }


    }
}
