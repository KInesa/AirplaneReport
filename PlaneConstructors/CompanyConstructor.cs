using Microsoft.VisualStudio.Services.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AirplaneReport.PlaneConstructors
{
    public class CompanyConstructor
    {
        public int Id { get; private set; }
        public string CompanyName { get; set; }
        public int? CountryId { get; set; }
    }
    public Company(int id, string name, int? countryId)
    {
        Id = id;
        CompanyName = name;
        CountryId = countryId;
    }
}
