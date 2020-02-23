using System;

//https://www.buraksenyurt.com/post/Tasarc4b1m-Desenleri-Composite
//https://www.geeksforgeeks.org/composite-design-pattern/
namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Director softwareTeamDirector = new Director("SoftwareTeamDirector");
            softwareTeamDirector.AddEmployees(new Developer("Developer1"),
                new Developer("Developer2"),
                new Manager("SoftwareTeamManager"));

            Director marketingDirector = new Director("MarketingDirector");
            marketingDirector.AddEmployees(new Manager("MarketingManager"));

            Director companyDirector = new Director("CompanyDirector");
            companyDirector.AddEmployees(softwareTeamDirector, marketingDirector);

            companyDirector.ShowEmployeeDetails();
        }
    }
}