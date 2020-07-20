using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupedData.Application.Features.DeleteActivity;
using GroupedData.Application.Infrastructure;
using GroupedData.Presentation.Activity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrupedDataUI.Pages
{
    public class ActivityIndexModel : PageModel
    {
        private readonly IActivityPresentationRepository _presentationRepository;
        private readonly ICommandHandler<DeleteActivityCommand> _commandHandler;

        public ActivityIndexModel(IActivityPresentationRepository presentationRepository, ICommandHandler<DeleteActivityCommand> commandHandler)
        {
            _presentationRepository = presentationRepository;
            _commandHandler = commandHandler;
        }
        public IList<ActivityModel> Activities { get; set; }
        public void OnGet()
        {
            Activities = _presentationRepository.GetList().ToList();
        }
        public IActionResult OnPostDelete(Guid id)
        {
            _commandHandler.Handle(new DeleteActivityCommand(id));
            return RedirectToPage("ActivityIndex");
        }
        
    }
}