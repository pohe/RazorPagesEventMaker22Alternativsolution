using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Hotels
{
    public class IndexModel : PageModel
    {
        
        private IHotelRepository repo;
        public List<Hotel> Hotels { get; set; }

        public IndexModel(IHotelRepository hotelRepository)
        {
            repo = hotelRepository;
        }
        public void OnGet()
        {
            Hotels = repo.GetAllHotels();
        }
    }
}
