using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace RazorPagesEventMaker22.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Udfyld dit navn"), DisplayName("Navn")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Angiv telefonnummer"), DisplayName("Telefonnummer")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Udfyld mailaddresse"), DisplayName("Mailaddresse")]
        public string Email { get; set; }
        [DisplayName("Kodeord")]
        public string Password { get; set; }       

    }
}
