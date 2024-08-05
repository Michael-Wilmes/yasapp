using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities.Masterdata;

namespace Yasapp.Domain.Entities.StudyPlanning
{
    public class DailyPlanner : BaseEntityWithStudent
    {
        public DateOnly Date { get; set; }

        public List<PlannerTask>? Tasks { get; set; }
    }
}
