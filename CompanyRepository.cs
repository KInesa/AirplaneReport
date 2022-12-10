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
        private List<CompanyConstructor> companies = new List<CompanyConstructor>();
        public CompanyRepository()
        {
            companies.Add(new CompanyConstructor(1874, "ST AEROSPACE ENGINEERING PTE LTD", 64));
            companies.Add(new CompanyConstructor(1875, "HANSAIR LOGISTICS INC.", 3));
            companies.Add(new CompanyConstructor(1876, "3K AVIATION CONSULTING & LOGISTICS", 42));
            companies.Add(new CompanyConstructor(1877, "SAISA AIRCRAFT.", 129));
            companies.Add(new CompanyConstructor(1878, "JH AVIATION", 136));
            companies.Add(new CompanyConstructor(1879, "PPS CONSULTING INC", 3));
        }

        public List<CompanyConstructor> Retrieve()
        {

            return companies;
        }
        public CompanyConstructor Retrieve(int companyId)
        {
            foreach (CompanyConstructor company in companies)
            {
                if (company.Id == companyId)
                {
                    return company;
                }
            }
            return null;
        }
    }
}
