using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Events
{
    public class DeleteEventModel : PageModel
    {
        private IEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public DeleteEventModel(IEventRepository fakeEventRepository)
        {
            this.repo = fakeEventRepository;
        }

        public void OnGet(int id)
        {
            Event = repo.GetEvent(id);
        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            repo.DeleteEvent(Event);
            return RedirectToPage("Index");
        }

    }
}
