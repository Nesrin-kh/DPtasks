using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    interface ICountryService
    {
        List<string> GetCountries();
    }
    class CountryService : ICountryService
    {
        public List<string> GetCountries()
        {
            Console.WriteLine("Fetching countries from server...");
            return new List<string> { "Egypt", "USA", "France" };
        }
    }

    // Proxy
    class CountryProxy : ICountryService
    {
        private CountryService service;
        private List<string> cache;

        public List<string> GetCountries()
        {
            if (cache == null)
            {
                service = new CountryService();
                cache = service.GetCountries();
            }
            else
            {
                Console.WriteLine("Returning cached countries...");
            }

            return cache;
        }
    }
}