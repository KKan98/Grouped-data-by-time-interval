using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupedData.Infrastructure
{
    public class InMemoryActivity : IInMemoryDb<ActivityEntity>
    {
        private readonly List<ActivityEntity> _activityEntities;

        public InMemoryActivity()
        {
            _activityEntities = ActivityData();
        }
        public ActivityEntity Get(Guid id)
        {
            return _activityEntities.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<ActivityEntity> GetAll()
        {
            return _activityEntities;
        }
        public void Add(ActivityEntity entity)
        {
            _activityEntities.Add(entity);
        }
        private List<ActivityEntity> ActivityData()
        {
            var activityEntities = new List<ActivityEntity>();

            activityEntities.Add(new ActivityEntity(Guid.NewGuid(), "Bieg dystansowy", "Stadion olimpijski", "19:07:2020"));
            activityEntities.Add(new ActivityEntity(Guid.NewGuid(), "Jazda konna", "Kon nazywal sie Plotka", "20:07:2020:"));

            return activityEntities;
        }
    }
}
