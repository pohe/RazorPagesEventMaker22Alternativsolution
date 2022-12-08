using RazorPagesEventMaker22.Helpers;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    
    public class HotelRepository : IHotelRepository
    {
        string filePath = @"Data\JsonHotels.json";

        private List<Hotel> _hotels;
       
        public void AddHotel(Hotel ho)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetAllHotels()
        {
            return JsonFileReader.ReadJsonHotels(filePath);
        }

        public Hotel GetHotel(int id)
        {
            foreach (Hotel h in GetAllHotels())
            {
                if (h.Id == id)
                    return h;
            }
            return new Hotel();
        }

        public void UpdateHotel()
        {
            throw new NotImplementedException();
        }
    }
}
