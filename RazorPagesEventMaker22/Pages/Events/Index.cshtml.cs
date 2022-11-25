using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IEventRepository repo;

        [BindProperty(SupportsGet =true)]
        public string FilterCriteria { get; set; }
        public List<Event> Events { get; private set; }

        public IndexModel(IEventRepository fakeEventRepository)
        {
            repo = fakeEventRepository;
        }
        public IActionResult OnGet()
        {
            Events = repo.GetAllEvents();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Events = repo.FilterEvents(FilterCriteria);
            }
            return Page();
        }

        //public void OnPost()
        //{
        //    if (!string.IsNullOrEmpty(FilterCriteria))
        //    {
        //        Events = repo.FilterEvents(FilterCriteria);
        //    }
        //}
    }
}
