using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities.Masterdata;

namespace Yasapp.Domain.Entities.StudyPlanning
{
    public class PlannerTask : BaseEntityWithStudent
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Status { get; set; } = "open";

        public bool IsCompleted { get; set; } = false;

        public int CompletedPercentage { get; set; } = 0;

        [Required]
        public DateTime PlannedStart { get; set; }

        [Required]
        public DateTime PlannedEnd { get; set; }

        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public int DailyPlannerId { get; set; }

        [ForeignKey(nameof(DailyPlannerId))]
        public virtual DailyPlanner? DailyPlanner { get; set; }

    }
}
