﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GroupedData.Infrastructure
{
    public class ActivityEntity
    {
        public Guid Id { get; set; }
        public string Activity { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public bool IsDeleted { get; set; }

        public ActivityEntity(Guid id, string activity, string description, string date, bool isDeleted = false)
        {
            Id = id;
            Activity = activity;
            Description = description;
            Date = date;
            IsDeleted = isDeleted;
        }
    }
}
