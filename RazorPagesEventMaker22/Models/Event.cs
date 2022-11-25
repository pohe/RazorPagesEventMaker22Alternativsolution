using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesEventMaker22.Models
{
    public class Event
    {
        public int Id { get; set; }

        [DisplayName("Landekode")]
        public string CountryCode { get; set; }

        [Display(Name="Event Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public string City { get; set; }

        [Required(ErrorMessage ="The date is required")]
        //[Range(typeof(DateTime), "14/11/2022", "14/11/2023", 
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DateTime { get; set; }

        public Event()
        {

        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                Event aNotherEvent = (Event)obj;

                if (this.Id == aNotherEvent.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
