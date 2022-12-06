using RazorPagesEventMaker22.Helpers;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    public class UserService : IUserService
    {
        string JsonFileName = @"Data\JsonUsers.json";

        public List<User> GetAllUsers()
        {
            return JsonFileReader.ReadJsonUsers(JsonFileName);
        }
    }
}
