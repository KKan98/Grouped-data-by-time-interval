using GroupedData.Infrastructure;
using System;
using System.Collections.Generic;

namespace GroupedData.Presentation.Activity
{
    public class ActivityPresentationRepository : IActivityPresentationRepository
    {
        private readonly IInMemoryDb<ActivityEntity> _inMemory;

        public ActivityPresentationRepository(IInMemoryDb<ActivityEntity> inMemory)
        {
            _inMemory = inMemory;
        }
        public ActivityModel Get(Guid id)
        {
            var entity = _inMemory.Get(id);
            ActivityModel activity = new ActivityModel();

            activity.Id = entity.Id;
            activity.Activity = entity.Activity;
            activity.Description = entity.Description;
            activity.Date = entity.Date;
            return activity;
        }
        public IEnumerable<ActivityModel> GetList()
        {
            var entities = _inMemory.GetAll();
            var activities = new List<ActivityModel>();
            foreach (var entity in entities)
            {
                var activity = new ActivityModel();

                activity.Activity = entity.Activity;
                activity.Description = entity.Description;
                activity.Date = entity.Date;

                activities.Add(activity);
            }
            return activities;
        }
    }
}
