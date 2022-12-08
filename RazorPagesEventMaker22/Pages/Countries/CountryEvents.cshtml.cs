using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Countries
{
    public class CountryEventsModel : PageModel
    {
        private IEventRepository repo;
        private ICountryRepository countryRepository;
        public Country Country { get; set; }

        public List<Event> Events { get; set; }

        public CountryEventsModel(IEventRepository repository, ICountryRepository conRepo)
        {
            repo = repository;
            countryRepository = conRepo;
        }
        public void OnGet(string code)
        {
            Events = repo.SearchEventByCode(code);
            Country = countryRepository.GetCountry(code);

        }
    }
}
