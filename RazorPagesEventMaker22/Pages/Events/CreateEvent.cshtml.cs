using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository repo;

        private IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public IFormFile Photo { get; set; }

        [BindProperty]
        public Event Event { get; set; }

        public SelectList CountryCodes { get; set; }
        public CreateEventModel(IEventRepository eventRepository, IWebHostEnvironment webHost, ICountryRepository cRepo)
        {
            webHostEnvironment = webHost;
            repo = eventRepository;
            List<Country> countries = cRepo.GetAllCountries();
            CountryCodes = new SelectList(countries, "Code", "Name");
        }

        public IActionResult OnGet()
        {
            return Page();

        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            if (Photo != null)
            {
                if (Event.EventImage != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "/images/EventImages", Event.EventImage);
                    System.IO.File.Delete(filePath);
                }

                Event.EventImage = ProcessUploadedFile();
            }
            repo.AddEvent(Event);
            return RedirectToPage("Index");
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/EventImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
