using RazorPagesEventMaker22.Helpers;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    public class JsonHotelBookingRepository : IHotelBookingRepository
    {
        string filePath = @"Data\JsonHotelBookings.json";
        public void AddHotelBooking(HotelBooking hotelbooking)
        {
            List<HotelBooking> bookings = GetAllHotelBookings();
            List<int> bookingsIds = new List<int>();

            foreach (var b in bookings)
            {
                bookingsIds.Add(b.BookingId);
            }
            if (bookingsIds.Count != 0)
            {
                int start = bookingsIds.Max();
                hotelbooking.BookingId = start + 1;
            }
            else
            {
                hotelbooking.BookingId = 1;
            }
            bookings.Add(hotelbooking);
            JsonFileWriter.WriteToJsonHotelBooking(bookings, filePath);
        }

        public void DeleteHotelBooking(HotelBooking hotelBooking)
        {
            throw new NotImplementedException();
        }

        public List<HotelBooking> GetAllHotelBookings()
        {
            return JsonFileReader.ReadJsonHotelBookings(filePath);
        }

        public HotelBooking GetHotelBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public List<HotelBooking> GetHotelBookingByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
