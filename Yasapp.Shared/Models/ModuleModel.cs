using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Shared.Models
{
    public  class ModuleModel : ModelBase
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int ExaminationId { get; set; }

        public  ExaminationModel? KindOfExamination { get; set; }

        public DateTime? PlannedExamination { get; set; }
        public DateTime? DateOfExamination { get; set; }

        public string? ReachedExaminationGrade { get; set; }

        public bool ECTSPointsReached { get; set; } = false;

        public int ModuleECTSPoints { get; set; } = 0;

        public IEnumerable<ModuleItemModel>? ModuleItems { get; set; }

        public Collection<StudentModel>? Students { get; set; }

        public virtual Collection<ContactModel>? Contacts { get; set; }

        public int StudyProgramId { get; set; }

        public  StudyProgramModel? StudyProgram { get; set; }
    }
}
