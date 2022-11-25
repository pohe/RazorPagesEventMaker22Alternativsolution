using System.Diagnostics.Metrics;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountries();
        Country GetCountry(string code);
        void DeleteCountry(string code);
        void AddCountry(Country country);
    }
}
