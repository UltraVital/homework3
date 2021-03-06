using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3.Domain
{
    public class Candidate 
    {
        
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public JobDetails JobDetails { get; set; }
    }

    public class JobDetails
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string DismissalReason { get; set; }
        public decimal JobSalary { get; set; }

    }
}
