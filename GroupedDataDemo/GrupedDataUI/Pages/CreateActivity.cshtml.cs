using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrupedDataUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrupedDataUI.Pages
{
    public class CreateActivityModel : PageModel
    {
        [BindProperty]
        public ActivityModel ActivityModel { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/ActivitiesOverview");
        }
    }
}