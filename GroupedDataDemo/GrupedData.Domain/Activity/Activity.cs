using System;
using GrupedData.Infrastructure;

namespace GroupedData.Domain.Activity
{
    public class Activity
    {
        private readonly string _commandActivity;
        private readonly string _commandDescription;
        private readonly string _commandDate;
        private Guid _id;


        public Activity(Guid id, IActivityRepository activityRepository)
        {
            var activity = activityRepository.Get(id);
            _id = id;
            _commandActivity = activity.Activity;
            _commandDescription = activity.Description;
            _commandDate = activity.Date;
        }

        public Activity(string commandActivity, string commandDescription, string commandDate)
        {
            _id = Guid.NewGuid();
            _commandActivity = commandActivity;
            _commandDescription = commandDescription;
            _commandDate = commandDate;
        }
        public void Register(IActivityRepository activityRepository)
        {
            activityRepository.Save(new ActivityEntity(_id, _commandActivity, _commandDescription, _commandDate));
        }
    }
}
