using AirplaneReport.PlaneConstructors;
using Microsoft.VisualStudio.Services.Profile;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace AirplaneReport
{

    public class CountryRepository
    {
        public List<CountryConstructor> countryCodes = new List<CountryConstructor>();
        public CountryRepository()
        {
            countryCodes.Add(new CountryConstructor(1, "LT", "Lithuania", "Europe"));
            countryCodes.Add(new CountryConstructor(5, "DE", "Germany", "Europe"));
            countryCodes.Add(new CountryConstructor(3, "US", "USA", "North America"));
            countryCodes.Add(new CountryConstructor(16, "AT", "Austria", "Europe"));
            countryCodes.Add(new CountryConstructor(17, "ZW", "Zimbabwe", "Africa"));
            countryCodes.Add(new CountryConstructor(18, "ZR", "Zaire", "Africa"));

        }
        private List<CountryConstructor> Retrieve()
        {

            return countryCodes;
        }
        public CountryConstructor Retrieve(int countryId)
        {
            foreach (CountryConstructor country in countryCodes)
            {
                if (country.Id == countryId)
                {
                    return country;
                }
            }
            return null;
        }
    }
}
