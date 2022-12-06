using RazorPagesEventMaker22.Models;
using System.Text.Json;

namespace RazorPagesEventMaker22.Helpers
{
    public class JsonFileReader
    {
        public static List<Event> ReadJson(string jsonFileName)
        {
            using(var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Event>>(indata);
            }
        }

        public static List<Country> ReadJsonCountry(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Country>>(indata);
            }
        }

        public static List<User> ReadJsonUsers(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<User>>(indata);
            }
        }
    }
}
