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
        PlaneModels planeModels = new PlaneModels();    

        private List<AircraftModel> aircraftModels = new List<AircraftModel>();

        public AircraftModelRepository()
        {
            aircraftModels.Add(new AircraftModel(3, "B737-300", "BOEING 737-300"));
            aircraftModels.Add(new AircraftModel(4, "B737-400", "BOEING 737-400"));
            aircraftModels.Add(new AircraftModel(5, "B737-500", "BOEING 737-500"));
            aircraftModels.Add(new AircraftModel(6, "B737-700", "BOEING 737-700 "));
            aircraftModels.Add(new AircraftModel(7, "B737-800", "BOEING 737-800"));
            aircraftModels.Add(new AircraftModel(1, "A320", "AIRBUS A320"));
        }
        public List<AircraftModel> Retrieve()
        {
            return aircraftModels;
        }
        public AircraftModel Retrieve(int id)
        {
            foreach (AircraftModel aircraftModel in aircraftModels)
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

