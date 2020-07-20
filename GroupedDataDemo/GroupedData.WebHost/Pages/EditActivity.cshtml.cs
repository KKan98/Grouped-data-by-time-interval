using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupedData.Application.Features.EditActivity;
using GroupedData.Application.Infrastructure;
using GroupedData.Presentation.Activity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroupedData.WebHost.Pages
{
    public class EditActivityModel : PageModel
    {
        private readonly IActivityPresentationRepository _activityPresentationRepository;
        private readonly ICommandHandler<EditActivityCommand> _commandHandler;

        public EditActivityModel(IActivityPresentationRepository activityPresentationRepository, ICommandHandler<EditActivityCommand> commandHandler)
        {
            _activityPresentationRepository = activityPresentationRepository;
            _commandHandler = commandHandler;
        }
        [BindProperty]
        public ActivityModel ActivityModel { get; set; }
        public void OnGet(Guid id)
        {
            ActivityModel = _activityPresentationRepository.Get(id);
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _commandHandler.Handle(new EditActivityCommand(ActivityModel.Id, ActivityModel.Activity, ActivityModel.Description, ActivityModel.Date));
            return RedirectToPage("/ActivityIndex");
        }
    }
}