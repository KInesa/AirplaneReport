using AirplaneReport.PlaneConstructors;
using Microsoft.VisualStudio.Services.CircuitBreaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReport
{
    
        public class CompanyRepository
        {
            CompanyConstructor companyConstructor = new CompanyConstructor();

            private List<Company> companies = new List<Company>();
            public CompanyRepository()
            {
            companies.Add(new Company(1874, "ST AEROSPACE ENGINEERING PTE LTD", 64));
            companies.Add(new Company(1875, "HANSAIR LOGISTICS INC.", 3));
            companies.Add(new Company(1876, "3K AVIATION CONSULTING & LOGISTICS", 42));
            companies.Add(new Company(1877, "SAISA AIRCRAFT.", 129));
            companies.Add(new Company(1878, "JH AVIATION", 136));
            companies.Add(new Company(1879, "PPS CONSULTING INC", 3));
            }
        }
}
