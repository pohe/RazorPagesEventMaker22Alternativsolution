using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Interfaces
{
    public interface IHotelBookingRepository
    {
        List<HotelBooking> GetAllHotelBookings();
        void AddHotelBooking(HotelBooking hotelbooking);
        HotelBooking GetHotelBookingById(int id);
        List<HotelBooking> GetHotelBookingByUserId(int userId);
       
        void DeleteHotelBooking(HotelBooking hotelBooking);
        
    }
}
