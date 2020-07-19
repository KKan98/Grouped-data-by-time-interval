using System;
using System.Collections.Generic;
using System.Text;

namespace GrupedData.Domain.Activity
{
    public interface IActivityFactory
    {
        Activity Create(string commandActivity, string commandDescription, string commandDate);
        Activity Create(Guid id, IActivityRepository activityRepository);
    }
}
