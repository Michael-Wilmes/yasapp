using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Shared.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Remark { get; set; }
        public int StudyProgramId { get; set; }

        [ForeignKey(nameof(StudyProgramId))]
        public StudyProgramModel? StudyProgram { get; set; }

        public virtual ICollection<ModuleModel>? Modules { get; set; }
    }
}
