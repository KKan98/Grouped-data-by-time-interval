using GroupedData.Application.Infrastructure;
using GroupedData.Domain.Activity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupedData.Application.Features.EditActivity
{
    public class EditActivityCommandHandler : ICommandHandler<EditActivityCommand>
    {
        private readonly IActivityFactory _activityFactory;
        private readonly IActivityRepository _activityRepository;
        
        public EditActivityCommandHandler(IActivityFactory activityFactory, IActivityRepository activityRepository)
        {
            _activityFactory = activityFactory;
            _activityRepository = activityRepository;
        }
        public void Handle(EditActivityCommand command)
        {
            var activity = _activityFactory.Create(command.Id, _activityRepository);
            activity.Update(command.Activity, command.Description, command.Date, _activityRepository);
        }
    }
}
