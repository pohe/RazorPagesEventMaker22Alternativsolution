using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEventMaker22.Pages.Books
{
    public class Index : PageModel
    {
        public string BookShopName { get; set; }

        public void OnGet()
        {

            BookShopName = "Welcome to Pouls bookshop";
        }
    }
}
