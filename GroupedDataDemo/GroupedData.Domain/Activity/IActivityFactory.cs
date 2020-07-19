using System;

namespace GroupedData.Domain.Activity
{
    public interface IActivityFactory
    {
        Activity Create(string commandActivity, string commandDescription, string commandDate);
        Activity Create(Guid id, IActivityRepository activityRepository);
    }
}
