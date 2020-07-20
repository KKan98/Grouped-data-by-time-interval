using GroupedData.Application.Infrastructure;
using GroupedData.Domain.Activity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GroupedData.Application.Features.DeleteActivity
{
    public class DeleteActivityCommandHandler : ICommandHandler<DeleteActivityCommand>
    {
        private readonly IActivityFactory _activityFactory;
        private readonly IActivityRepository _activityRepository;

        public DeleteActivityCommandHandler(IActivityFactory activityFactory, IActivityRepository activityRepository)
        {
            _activityFactory = activityFactory;
            _activityRepository = activityRepository;
        }
        public void Handle(DeleteActivityCommand command)
        {
            var activity = _activityFactory.Create(command.Id, _activityRepository);
            activity.Delete(_activityRepository);
        }
    }
}
