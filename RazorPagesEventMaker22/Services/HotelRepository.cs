using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    
    public class HotelRepository : IHotelRepository
    {
        private List<Hotel> _hotels;
        public HotelRepository()
        {
            _hotels = new List<Hotel>();
            Hotel h1 = new Hotel(1, "City Hotel", "street 123");
            Hotel h2 = new Hotel(2, "Scandic Roskilde", "Maglegårdsvej 1");
            _hotels.Add(h1);
            _hotels.Add(h2);

        }
        public void AddHotel(Hotel ho)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotels;
        }

        public Hotel GetHotel(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateHotel()
        {
            throw new NotImplementedException();
        }
    }
}
