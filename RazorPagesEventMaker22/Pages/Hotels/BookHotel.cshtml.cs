using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;
using RazorPagesEventMaker22.Services;

namespace RazorPagesEventMaker22.Pages.Hotels
{
    public class BookHotelModel : PageModel
    {
        private IHotelRepository _hotelRepository;
        private LogInService _logInService;
        private IHotelBookingRepository _hotelBookingRepository;
        public User User { get; set; }

        public SelectList HotelNames { get; set; }

        [BindProperty]
        public HotelBooking HotelBooking { get; set; }


        public BookHotelModel(IHotelRepository hotelRepo, LogInService logInService, IHotelBookingRepository bookingRepository)
        {
            _hotelBookingRepository = bookingRepository;
            _hotelRepository= hotelRepo;
            _logInService = logInService;
            List<Hotel> Hotels = _hotelRepository.GetAllHotels();
            HotelNames = new SelectList(Hotels, "Id", "Name");
        }
        public IActionResult OnGet()
        {
            if (_logInService.GetLoggedUser() == null)
                return RedirectToPage("Users/Login");
            else
            {
                User = _logInService.GetLoggedUser();
                return Page();
            }
            
        }

        public IActionResult  OnPost()
        {
            HotelBooking.UserID = _logInService.GetLoggedUser().UserId;
            _hotelBookingRepository.AddHotelBooking(HotelBooking);
            return Page();
        }
    }
}
