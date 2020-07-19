using GroupedData.Infrastructure;
using System;

namespace GroupedData.Domain.Activity
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly IInMemoryDb<ActivityEntity> _inMemory;

        public ActivityRepository(IInMemoryDb<ActivityEntity> inMemory)
        {
            _inMemory = inMemory;
        }
        public ActivityEntity Get(Guid activityId)
        {
            return _inMemory.Get(activityId);
        }
        public void Save(ActivityEntity activity)
        {
            _inMemory.Add(activity);
        }
    }
}
