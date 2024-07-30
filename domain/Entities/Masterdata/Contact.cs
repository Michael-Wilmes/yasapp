using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities.Masterdata
{
    public class Contact : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Remark { get; set; }


        public int StudyProgramId { get; set; }

        [ForeignKey(nameof(StudyProgramId))]
        public StudyProgram? StudyProgram { get; set; }

        public virtual ICollection<Module>? Modules {get;set;}

    }
}
