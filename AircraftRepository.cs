using AirplaneReport.PlaneConstructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReport
{
    public class AircraftRepository
    {
        
        private List<AircraftInfoConstructor> aircrafts = new List<AircraftInfoConstructor>();

        public AircraftRepository()
        {
            aircrafts.Add(new AircraftInfoConstructor(43, 3, 6202, "PK-BBB"));
            aircrafts.Add(new AircraftInfoConstructor(44, 1, 1120, "TC-KLA"));
            aircrafts.Add(new AircraftInfoConstructor(45, 1, 1120, "EI-FDM"));
            aircrafts.Add(new AircraftInfoConstructor(46, 8, 1120, "EI-ETJ"));
            aircrafts.Add(new AircraftInfoConstructor(47, 8, 1120, "EI-ETH"));
            aircrafts.Add(new AircraftInfoConstructor(48, 8, 1120, "EI-ETK"));
        }
        public List<AircraftInfoConstructor> Retrieve()
        {

            return aircrafts;
        }
        public AircraftInfoConstructor Retrieve(int aircraftId)
        {
            foreach (AircraftInfoConstructor aircraft in aircrafts)
            {
                if (aircraft.PlaneId == aircraftId)
                {
                    return aircraft;
                }
            }
            return null;
        }
    }
}