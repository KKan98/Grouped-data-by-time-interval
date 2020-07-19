using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GroupedData.Presentation.Activity
{
    public class ActivityModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Enter the activity")]
        public string Activity { get; set; }
        public string Description { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
