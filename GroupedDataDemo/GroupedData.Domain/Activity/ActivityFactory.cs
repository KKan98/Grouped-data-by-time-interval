using System;

namespace GroupedData.Domain.Activity
{
    public class ActivityFactory : IActivityFactory
    {
        public Activity Create(string commandActivity, string commandDescription, string commandDate)
        {
            return new Activity(commandActivity, commandDescription, commandDate);
        }
        public Activity Create(Guid id, IActivityRepository activityRepository)
        {
            return new Activity(id, activityRepository);
        }
    }
}
