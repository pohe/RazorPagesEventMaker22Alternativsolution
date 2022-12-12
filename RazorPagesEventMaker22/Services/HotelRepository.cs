using RazorPagesEventMaker22.Helpers;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    
    public class HotelRepository : IHotelRepository
    {
        string filePath = @"Data\JsonHotels.json";

       
        public void AddHotel(Hotel ho)
        {
            List<Hotel> hotels = GetAllHotels();
            List<int> hotelIds = new List<int>();

            foreach (var h in hotels)
            {
                hotelIds.Add(h.Id);
            }
            if (hotelIds.Count != 0)
            {
                int start = hotelIds.Max();
                ho.Id = start + 1;
            }
            else
            {
                ho.Id = 1;
            }
            hotels.Add(ho);
            JsonFileWriter.WriteToJsonHotel(hotels, filePath);
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
