using System.ComponentModel;

namespace RazorPagesEventMaker22.Models
{
    public class Hotel
    {
        public Hotel(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
            Facilities = new List<string>();
        }

        public Hotel()
        {
            Facilities = new List<string>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [DisplayName("Landekode")]
        public string CountryCode { get; set; }

        public List<string> Facilities { get; set; }

        public string Description { get; set; }
    }
}
