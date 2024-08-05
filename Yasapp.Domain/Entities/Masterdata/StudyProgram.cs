using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Domain.Entities.Masterdata
{
    public class StudyProgram : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Degree { get; set; }
        public required string Faculty { get; set; }
        public required int CreditPoints { get; set; }

        public virtual Collection<Module>? Modules { get; set; }
        public virtual Collection<Student>? Students { get; set; }
    }
}
