using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEventMaker22.Pages.Cars
{
    public class IndexModel : PageModel
    {
        public string CarInformation { get; set; }

        public IndexModel()
        {
            CarInformation += "From constructor";
        }

        public void OnGet()
        {

            CarInformation +="Pouls autoshop from OnGet";
        }
    }
}
