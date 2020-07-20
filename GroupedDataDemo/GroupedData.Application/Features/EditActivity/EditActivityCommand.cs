using System;
using System.Collections.Generic;
using System.Text;

namespace GroupedData.Application.Features.EditActivity
{
    public class EditActivityCommand
    {
        public EditActivityCommand(Guid id, string activity, string description, string date)
        {
            Id = id;
            Activity = activity;
            Description = description;
            Date = date;
        }
        public Guid Id { get; }
        public string Activity { get; }
        public string Description { get; }
        public string Date { get; }
    }
}
