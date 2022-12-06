using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReport.PlaneConstructors
{
    public class AllPlainesInfo
    {

        private int aircraftTailNumber { get; set; }

        private int modelNumber { get; set; }

        private string modelDescription { get; set; }

        private string ownerCompanyName { get; set; }

        private int companyCountryCode { get; set; }

        private string companyCountryNam { get; set; }

        public AllPlainesInfo(int aircraftTailNumber, int modelNumber, string modelDescription,
            string ownerCompanyName, int companyCountryCode, string companyCountryNam)
        {
            this.aircraftTailNumber = aircraftTailNumber;
            this.modelNumber = modelNumber;
            this.modelDescription = modelDescription;
            this.ownerCompanyName = ownerCompanyName;
            this.companyCountryCode = companyCountryCode;
            this.companyCountryNam = companyCountryNam;

        }
    }
}
