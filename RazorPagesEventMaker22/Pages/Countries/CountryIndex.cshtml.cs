using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Countries
{
    public class CountryIndexModel : PageModel
    {
        public List<Country> Countries { get; private set; }

        public CountryIndexModel(ICountryRepository repository)
        {
            Countries = repository.GetAllCountries();
        }

        public void OnGet()
        {
        }
    }
}
