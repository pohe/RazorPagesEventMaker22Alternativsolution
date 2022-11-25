using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEventMaker22.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //public void OnGet()
        //{
        //    Message = "Welcome to your first RazorPAge App";
        //}
        public IActionResult OnGet()
        {
            Message = "Welcome to your first RazorPAge App";
            return Page();
        }
    }
}