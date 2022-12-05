using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AirplaneReport.PlaneConstructors
{
    public class CountryConstructor
    {
        public int Id { get; private set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
    }
 
    public Country(int countryId, string countryCode, string countryName, string continent)
    {
        Id = countryId;
        Code = countryCode;
        Name = countryName;
        Continent = continent;
    }
}
