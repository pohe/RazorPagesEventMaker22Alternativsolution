using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Hotels
{
    public class IndexModel : PageModel
    {
        public string ErrorMessage { get; set; }

        private IHotelRepository repo;
        public List<Hotel> Hotels { get; set; }

        public IndexModel(IHotelRepository hotelRepository)
        {
            ErrorMessage = "";
            repo = hotelRepository;
        }
        public void OnGet()
        {
            try
            {
                Hotels = repo.GetAllHotels();
            }
            catch (IOException ioe)
            {
                ErrorMessage = "Fejl ved læsning fra fil ";
            }
            catch (Exception ex)
            {
                ErrorMessage = "Generel fejl";
            }
        }
    }
}
