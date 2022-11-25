using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public SelectList CountryCodes { get; set; }
        public CreateEventModel(IEventRepository fakeEventRepository, ICountryRepository cRepo)
        {
            repo = fakeEventRepository;
            List<Country> countries = cRepo.GetAllCountries();
            CountryCodes = new SelectList(countries, "Code", "Name");
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
            repo.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
