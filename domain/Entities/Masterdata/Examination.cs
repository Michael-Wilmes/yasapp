using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities.Masterdata
{
    public class Examination : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int? Duration { get; set; }

        public string? DurationText { get; set; }

    }
}
