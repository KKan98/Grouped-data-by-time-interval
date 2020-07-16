using System;
using System.Collections.Generic;
using System.Text;

namespace GrupedData.Application.Features
{
    class RegistrationActivityCommand
    {
        public RegistrationActivityCommand(string activity, string description, string date)
        {
            Activity = activity;
            Description = description;
            Date = date;
        }
        public string Activity { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
