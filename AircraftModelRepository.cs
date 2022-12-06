using AirplaneReport.PlaneConstructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReport
{
    
    public class AircraftModelRepository
    {

        private List<PlaneModels> aircraftModels = new List<PlaneModels>();

        public AircraftModelRepository()
        {
            aircraftModels.Add(new PlaneModels(3, "B737-300", "BOEING 737-300"));
            aircraftModels.Add(new PlaneModels(4, "B737-400", "BOEING 737-400"));
            aircraftModels.Add(new PlaneModels(5, "B737-500", "BOEING 737-500"));
            aircraftModels.Add(new PlaneModels(6, "B737-700", "BOEING 737-700 "));
            aircraftModels.Add(new PlaneModels(7, "B737-800", "BOEING 737-800"));
            aircraftModels.Add(new PlaneModels(1, "A320", "AIRBUS A320"));
        }

        public List<PlaneModels> Retrieve()
        {
            return aircraftModels;
        }
        public PlaneModels Retrieve(int id)
        {
            foreach (PlaneModels aircraftModel in aircraftModels)
            {
                if (aircraftModel.Id == id)
                {
                    return aircraftModel;
                }
            }
            return null;
        }
    }
}

