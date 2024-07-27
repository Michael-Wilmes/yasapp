using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities
{
    public class StudentModuleMapping
    {
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public virtual Student? Student {get;set;}

        public int ModuleId { get; set; }
        [ForeignKey(nameof(ModuleId))]
        public virtual Module? Module { get; set; }
    }
}
