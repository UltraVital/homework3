using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3.Domain
{
    public class Employee 
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal JobSalary { get; set; }
        public Company Company { get; set; }
        
    }

    public class Company
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

    }

    
}
