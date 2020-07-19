using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrupedDataUI.Models
{
    public class ActivityModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the activity")]
        public string Activity { get; set; }
        public string Description { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
