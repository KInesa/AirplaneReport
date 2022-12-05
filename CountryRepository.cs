using AirplaneReport.PlaneConstructors;
using Microsoft.VisualStudio.Services.Profile;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneReport
{

    public class CountryRepository
    {
        CountryConstructor countryConstructor = new CountryConstructor();

        private List<Country> countryCodes = new List<Country>();
        public CountryRepository()
        {
            countryCodes.Add(new Country(1, "LT", "Lithuania", "Europe"));
            countryCodes.Add(new Country(5, "DE", "Germany", "Europe"));
            countryCodes.Add(new Country(3, "US", "USA", "North America"));
            countryCodes.Add(new Country(16, "AT", "Austria", "Europe"));
            countryCodes.Add(new Country(17, "ZW", "Zimbabwe", "Africa"));
            countryCodes.Add(new Country(18, "ZR", "Zaire", "Africa"));

        }
    }
}
