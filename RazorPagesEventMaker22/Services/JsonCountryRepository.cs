using RazorPagesEventMaker22.Helpers;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    public class JsonCountryRepository : ICountryRepository
    {
        string filePath = @"Data\JsonCountries.json";
        //string filePath =@"C:\Users\EASJ\OneDrive - Zealand Sjællands Erhvervsakademi(1)\Dokumenter\UV\SWC2020E\MineRazorProgrammer\RazorPagesEventMaker11frem\RazorPagesEventMaker\Data\JsonCountries.json";

        public List<Country> GetAllCountries()
        {
            return JsonFileReader.ReadJsonCountry(filePath);
        }

        public string GetCountryName(string code)
        {
            foreach (Country c in GetAllCountries())
            {
                if (c.Code == code)
                    return c.Name;
            }
            return "";
        }
        public Country GetCountry(string code)
        {
            foreach (Country c in GetAllCountries())
            {
                if (c.Code == code)
                    return c;
            }
            return new Country();
        }

        public void DeleteCountry(string code)
        {
            throw new NotImplementedException();
        }


        public void AddCountry(Country country)
        {
            List<Country> countries = GetAllCountries();
            countries.Add(country);
            JsonFileWriter.WriteToJsonCountry(countries, filePath);
        }

    }
}
