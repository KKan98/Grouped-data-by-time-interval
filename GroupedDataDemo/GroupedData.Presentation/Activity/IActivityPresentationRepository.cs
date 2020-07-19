using System;
using System.Collections.Generic;

namespace GroupedData.Presentation.Activity
{
    public interface IActivityPresentationRepository
    {
        ActivityModel Get(Guid id);
        IEnumerable<ActivityModel> GetList();
    }
}
