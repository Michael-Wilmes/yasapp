using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities.Masterdata
{
    public class BaseEntityWithStudent : BaseEntity
    {
        
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public virtual Student? Student { get; set; }
    }
}
