using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace yasapp.Domain.Entities.Masterdata
{
    //inhalte der Module 
    public class ModuleItem : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public int ModuleId { get; set; }

        [ForeignKey(nameof(ModuleId))]
        public Module? Module { get; set; }
    }
}
