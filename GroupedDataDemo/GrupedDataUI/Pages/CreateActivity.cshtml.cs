using GroupedData.Application.Features;
using GroupedData.Application.Infrastructure;
using GroupedData.Presentation.Activity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroupedDataUI.Pages
{
    public class CreateActivityModel : PageModel
    {
        private readonly ICommandHandler<RegistrationActivityCommand> _commandHandler;

        public CreateActivityModel(ICommandHandler<RegistrationActivityCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _commandHandler.Handle(new RegistrationActivityCommand(ActivityModel.Activity, ActivityModel.Description, ActivityModel.Date));
            return RedirectToPage("/ActivityIndex");
        }

        [BindProperty]
        public ActivityModel ActivityModel { get; set; }
    }
}