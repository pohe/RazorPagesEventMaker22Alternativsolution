namespace RazorPagesEventMaker22.Models
{
    public class HotelBooking
    {
        public int BookingId { get; set; }
        public int HotelId { get; set; }
        public int UserID { get; set; }

        public DateTime DateTime { get; set; }

        public int NumberOfDays { get; set; }
    }
}
