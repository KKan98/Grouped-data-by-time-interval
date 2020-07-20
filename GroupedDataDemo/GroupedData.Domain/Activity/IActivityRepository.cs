using GroupedData.Infrastructure;
using System;

namespace GroupedData.Domain.Activity
{
    public interface IActivityRepository
    {
        void Save(ActivityEntity activity);
        ActivityEntity Get(Guid activityId);
        void Update(Guid id, string activity, string description, string date);
    }
}