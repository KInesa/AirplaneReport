using AirplaneReport.PlaneConstructors;
using Microsoft.VisualStudio.Services.Profile;

namespace AirplaneReport
{
    internal class Program
    {
        AircraftModelRepository AircraftModelRepository = new AircraftModelRepository();    
        AircraftRepository AircraftRepository = new AircraftRepository();   
        CountryRepository CountryRepository = new CountryRepository();  
        CompanyRepository CompanyRepository = new CompanyRepository();  

        static void Main(string[] args)
        {
            CountryConstructor Retrieve(string Countinent)
            {
                foreach (CountryConstructor countinent in Countinent)
                {
                    if (Countinent == "Europe")
                    {
                        return Countinent;
                    }
                }
                return null;
            }



        }
    }
}