using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities.Masterdata
{
    public class Module : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int ExaminationId { get; set; }

        [ForeignKey("ExaminationId")]
        public virtual Examination? KindOfExamination { get; set; }

        public DateTime? PlannedExamination { get; set; }
        public DateTime? DateOfExamintation { get; set; }

        public string? ReachedExaminationGrade { get; set; }

        public bool ECTSPointsReached { get; set; } = false;

        public int ModuleECTSPoints { get; set; } = 0;

        public virtual ICollection<ModuleItem>? ModuleItems { get; set; }

        public virtual Collection<Student>? Students { get; set; }

        public virtual Collection<Contact>? Contacts { get; set; }

        public int StudyProgramId { get; set; }

        [ForeignKey(nameof(StudyProgramId))]
        public virtual StudyProgram? StudyProgram { get; set; }
    }
}
