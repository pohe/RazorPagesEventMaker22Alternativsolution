using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Interfaces
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotel(int id);

        void AddHotel(Hotel ho);

        void UpdateHotel();

    }
}
