using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Events
{
    public class EditEventModel : PageModel
    {

        private IEventRepository repo;

       

        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel(IEventRepository fakeEventRepository)
        {
            this.repo = fakeEventRepository;
        }

        public IActionResult OnGet(int id)
        {
            Event = repo.GetEvent(id);
            return Page();

        }


        public IActionResult OnGetEvent(string evname)
        {
            Event = repo.GetEvent(evname);
            return Page();

        }

        public IActionResult OnPostEdit()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.UpdateEvent(Event);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.DeleteEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
