using AirplaneReport.PlaneConstructors;
using Microsoft.VisualStudio.Services.CircuitBreaker;
using Microsoft.VisualStudio.Services.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReport
{
    internal class GenerateReport
    {
        private AircraftRepository _aircraftRepository;
        private AircraftModelRepository _aircraftModelRepository;
        private CompanyRepository _companyRepository;
        private CountryRepository _countryRepository;
        public GenerateReport(AircraftRepository aircraftRepository,
            AircraftModelRepository aircraftModelRepository,
            CompanyRepository companyRepository,
            CountryRepository countryRepository)
        {
            _aircraftRepository = aircraftRepository;
            _aircraftModelRepository = aircraftModelRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
        }

        public List<AllPlainesInfo> GenerateReportAircraftInEurope()
        {
            List<Aircraft> lektuvai = _aircraftRepository.Retrieve();
            List<AllPlainesInfo> ataskaita = new List<AllPlainesInfo>();

            foreach (var vienasLektuvas in lektuvai)
            {
                Company lektuvoKompanija = _companyRepository.Retrieve(vienasLektuvas.CompanyId);
                Country lektuvoSalis = _countryRepository.Retrieve(lektuvoKompanija.CountryId);
                AircraftModel lektuvoModelis = _aircraftModelRepository.Retrieve(vienasLektuvas.ModelId);
                if (lektuvoSalis.Continent == "Europe")
                {
                    AllPlainesInfo eilute = new AllPlainesInfo();
                    eilute.AircraftTailNumber = vienasLektuvas.TailNumber;
                    eilute.ModelNumber = lektuvoModelis.Number;
                    eilute.ModelDescription = lektuvoModelis.Description;
                    eilute.OwnerCompanyName = lektuvoKompanija.Name;
                    eilute.CompanyCountryCode = lektuvoSalis.Code;
                    eilute.CompanyCountryName = lektuvoSalis.Name;
                    ataskaita.Add(eilute);
                }
            }
            return ataskaita;
        }

    }
}
