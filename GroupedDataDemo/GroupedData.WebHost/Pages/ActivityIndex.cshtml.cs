using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupedData.Presentation.Activity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrupedDataUI.Pages
{
    public class ActivityIndexModel : PageModel
    {
        private readonly IActivityPresentationRepository _presentationRepository;

        public ActivityIndexModel(IActivityPresentationRepository presentationRepository)
        {
            _presentationRepository = presentationRepository;
        }
        public IList<ActivityModel> Activities { get; set; }
        public void OnGet()
        {
            Activities = _presentationRepository.GetList().ToList();
        }
        
    }
}