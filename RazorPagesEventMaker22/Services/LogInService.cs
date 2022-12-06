using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    
    public class LogInService
    {
        private User _loggedInUser;

        public void UserLogIn(User user)
        {
            _loggedInUser = user;
        }
        public void UserLogOut()
        {
            _loggedInUser = null;
        }
        public User GetLoggedUser()
        {
            return _loggedInUser;
        }
    }
}
