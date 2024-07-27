using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Domain.Entities
{
    public class DailyPlanner : BaseEntityWithStudent
    {
        public DateOnly Date {  get; set; }

        public List<PlannerGoal>? PlannedGoals { get; set; }
    }
}
