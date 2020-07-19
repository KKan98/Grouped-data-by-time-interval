using GroupedData.Application.Infrastructure;
using GroupedData.Domain.Activity;


namespace GroupedData.Application.Features.RegistrationActivity
{
    public class RegistrationActivityCommandHandler : ICommandHandler<RegistrationActivityCommand>
    {
        private readonly IActivityFactory _activityFactory;
        private readonly IActivityRepository _activityRepository;

        public RegistrationActivityCommandHandler(IActivityFactory activityFactory, IActivityRepository activityRepository)
        {
            _activityFactory = activityFactory;
            _activityRepository = activityRepository;
        }
        public void Handle(RegistrationActivityCommand command)
        {
            var activity = _activityFactory.Create(command.Activity, command.Description, command.Date);
            activity.Register(_activityRepository);
        }
    }
}
