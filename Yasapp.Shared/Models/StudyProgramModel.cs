using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Shared.Models
{
    public class StudyProgramModel :ModelBase
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Degree { get; set; }
        public required string Faculty { get; set; }
        public required int CreditPoints { get; set; }

        public virtual Collection<ModuleModel>? Modules { get; set; }
        public virtual Collection<StudentModel>? Students { get; set; }
    }
}
