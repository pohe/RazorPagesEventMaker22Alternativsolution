using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;
using RazorPagesEventMaker22.Services;

namespace RazorPagesEventMaker22.Pages.Users
{
    public class LoginModel : PageModel
    {
       
        private IUserService userService;
        private LogInService logInService;
        public string AccessDenied = "";
        [BindProperty]
        public User User { get; set; }

        public LoginModel(IUserService service, LogInService logIn)
        {
            userService = service;
            logInService = logIn;

        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            foreach (User user in userService.GetAllUsers())
            {
                if (user.Email == User.Email)
                {
                    if (user.Password == User.Password)
                    {
                        logInService.UserLogIn(user);
                        return RedirectToPage("/Index");
                    }
                }
                AccessDenied = "Email/kodeord er ikke korrekt";
            }
            return Page();
        }
    }
}
