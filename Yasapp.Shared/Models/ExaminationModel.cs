using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasapp.Shared.Models
{
    public class ExaminationModel : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Duration { get; set; }
        public string? DurationText { get; set; }

    }
}
