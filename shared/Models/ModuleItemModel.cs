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
    public class ModuleItemModel : ModelBase
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int ModuleId { get; set; }

        public ModuleModel? Module { get; set; }
    }
}
