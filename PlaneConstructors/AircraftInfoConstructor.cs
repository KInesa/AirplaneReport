using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReport.PlaneConstructors
{

    public class AircraftInfoConstructor
    {
        AircraftRepository aircraftRepository = new AircraftRepository();
        public int PlaneId { get; private set; }
        public int ModelId { get; set; }
        public int CompanyId { get; set; }
        public string TailNumber { get; set; }


        public AircraftInfoConstructor(int id, int modelId, int companyId, string tailNumber)
        {
            PlaneId = id;
            ModelId = modelId;
            CompanyId = companyId;
            TailNumber = tailNumber;
        }
    }
}