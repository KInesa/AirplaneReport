using AirplaneReport.PlaneConstructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReport
{
    public class AircraftRepository
    {
        AircraftInfoConstructor AircraftInfoConstructor = new AircraftInfoConstructor();

        private List<Aircraft> aircrafts = new List<Aircraft>();

        public AircraftRepository()
        {
            aircrafts.Add(new Aircraft(43, 3, 6202, "PK-BBB"));
            aircrafts.Add(new Aircraft(44, 1, 1120, "TC-KLA"));
            aircrafts.Add(new Aircraft(45, 1, 1120, "EI-FDM"));
            aircrafts.Add(new Aircraft(46, 8, 1120, "EI-ETJ"));
            aircrafts.Add(new Aircraft(47, 8, 1120, "EI-ETH"));
            aircrafts.Add(new Aircraft(48, 8, 1120, "EI-ETK"));
        }
    }
}