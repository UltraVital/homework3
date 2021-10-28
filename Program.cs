using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Bogus;


namespace homework3
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            var JobDetailsFaker = new Faker<Domain.JobDetails>()
                .RuleFor(x => x.JobSalary, f => f.Finance.Amount(100, 300))
                .RuleFor(x => x.JobTitle, f => f.Random.ListItem(new List<string>
                {
                    "Programmer",
                    "Business-Analyst",
                    "Manager",
                    "Designer",
                    "Tester",
                    "Other"
                }))
                .RuleFor(x => x.JobDescription, f => f.Random.ListItem(new List<string>
                {
                    "Application Development",
                    "Data Collection",
                    "Communication",
                    "Image Rendering",
                    "Quality Assurance",
                    "Other"
                }))
                .RuleFor(x => x.DismissalReason, f => f.Random.ListItem(new List<string>
                {
                    "FamilyReasons",
                    "ProfessionalGrowthLack",
                    "LowSalary",
                    "BadTeamMicroclimate",
                    "LackManagementUnderstanding",
                    "Other",
                    "null"

                }));

            var CandidateFaker = new Faker<Domain.Candidate>()
                .RuleFor(x => x.Id, Guid.NewGuid)
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName)
                .RuleFor(x => x.JobDetails, f => JobDetailsFaker);

             var text1 = JsonSerializer.Serialize(CandidateFaker.Generate(5));
                Console.WriteLine(text1);

            
            var CompanyFaker = new Faker<Domain.Company>()
                .RuleFor(x => x.Name, f => f.Company.CompanyName())
                .RuleFor(x => x.Address, f => f.Address.StreetAddress())
                .RuleFor(x => x.Country, f => f.Address.Country())
                .RuleFor(x => x.City, f => f.Address.City());

            var EmployeeFaker = new Faker<Domain.Employee>()
               .RuleFor(x => x.Id, Guid.NewGuid)
               .RuleFor(x => x.FirstName, f => f.Name.FirstName())
               .RuleFor(x => x.LastName, f => f.Name.LastName())
               .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName)
               .RuleFor(x => x.JobSalary, f => f.Finance.Amount(1000, 5000))
               .RuleFor(x => x.JobTitle, f => f.Random.ListItem(new List<string>
                {
                    "Programmer",
                    "Business-Analyst",
                    "Manager",
                    "Designer",
                    "Tester",
                    "Other"
                }))
               .RuleFor(x => x.JobDescription, f => f.Random.ListItem(new List<string>
                {
                    "Application Development",
                    "Data Collection",
                    "Communication",
                    "Image Rendering",
                    "Quality Assurance",
                    "Other"
                }))
               .RuleFor(x => x.Company, f => CompanyFaker);

            var text2 = JsonSerializer.Serialize(EmployeeFaker.Generate(5));
                Console.WriteLine(text2);

            
        }
        
    }
}
