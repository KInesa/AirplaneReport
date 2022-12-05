using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AirplaneReport.PlaneConstructors
{
    public class PlaneModels
    { 
        

        public int Id { get; private set; }
        public string ModelNumber { get; set; }
        public string Description { get; set; }
    }
    public AircraftModel(int id, string number, string description)
    {
        Id = id;
        ModelNumber = number;
        Description = description;
    }
}
