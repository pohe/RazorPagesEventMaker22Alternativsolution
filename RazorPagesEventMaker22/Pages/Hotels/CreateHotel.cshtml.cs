using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Hotels
{
    public class CreateHotelModel : PageModel
    {
        private IHotelRepository _hotelRepository;
        private ICountryRepository _countryRepository;

        [BindProperty]
        public Hotel Hotel { get; set; }

        public string ErrorMessage { get; set; }

        public List<Country> Countries; 
        public SelectList CountryCodes { get; set; }


        [BindProperty]
        public List<String> AreChecked { get; set; }

        private List<string> _facilities; 

        public List<string> Facilities { get { return _facilities; } }

        public CreateHotelModel(IHotelRepository hotelRepository, ICountryRepository countryRepository)
        {
            ErrorMessage = "";

            _hotelRepository = hotelRepository;
            _countryRepository = countryRepository;
            Countries = _countryRepository.GetAllCountries();

            CountryCodes = new SelectList(Countries, "Code", "Name");

            _facilities = new List<string>();
            _facilities.Add("Swimmingpool");
            _facilities.Add("VIP area");
            _facilities.Add("Restaurant");
            _facilities.Add("Fittness room");
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //Hotel.CountryCode = CountryCode;
            Hotel.Facilities.AddRange(AreChecked);

            try
            {
                _hotelRepository.AddHotel(Hotel);
            }
            catch(IOException ioe)
            {
                ErrorMessage = "Fejl ved skrivning til fil " ; 
                return Page();
            }
            catch(Exception ex)
            {
                ErrorMessage = "Generel fejl";
                return Page();
            }
            return RedirectToPage("Index");
        }
    }
}
