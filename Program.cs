using System;
using System.Collections.Generic;

namespace bangazon
{
    class Program
    {

        static void Main(string[] args)
        {
            // create a list of department in the company
            List<Department> departments = new List<Department>();

            // create some departments and add them to the list of departments
            HumanResourcesDept HR = new HumanResourcesDept("HR", "Mr. Safewords", 15);
            departments.Add(HR);

            MarketingDept Marketing = new MarketingDept("Marketing", "Mr. Overshare", 20);
            departments.Add(Marketing);

            ITDept IT = new ITDept("IT", "Mr. Configuration", 5);
            departments.Add(IT);

            // use methdos on each department to add policies, plans and computers
            HR.AddPolicy("Hiring", "You can only hire people who say positive words.");
            HR.AddPolicy("Firing", "HR can fire anyone who make someone else feel uncomfortable.");

            Marketing.AddPlan("Social Media", "We will do hourly posts on all social media channels sharing how positive our company culture is and how happy all of our employees are.");
            Marketing.AddPlan("Print Media", "We will purchase full page ads in all local magazines explaining that we are the happiest place to work.");

            IT.AddComputer("Computer1", "HR desk 1");
            IT.AddComputer("Computer2", "HR desk 2");
            IT.AddComputer("Computer3", "Marketing couch 1");
            IT.AddComputer("Computer4", "Marketing loveseat 2");
            IT.AddComputer("Computer5", "IT cube 1");
            IT.AddComputer("Computer6", "IT cube 2");
            IT.AddComputer("Computer7", "IT cube 3");

            // print the list of plans, policies and computers to the console
            HR.ListPolicies();
            Marketing.ListPlans();
            IT.ListComputers();

            // loop through all the departments and print their info to console
            foreach (Department dept in departments)
            {
                Console.WriteLine($"{dept.ToString()}");
            }

            // set a default budget for all departments
            double baseBudget = 75000.00;

            // Some departments get the base $75,000.00 budget, but others
            // will be adjusted up or down depending on the logic you wrote
            // in each class.
            foreach (Department d in departments)
            {
                d.SetBudget(baseBudget);
                Console.WriteLine($" {d.ToString()}");
            }

            
            // create some employees using the Employee class
            Employee Gary = new Employee("Gary", "Force");
            Employee Steve = new Employee("Steve", "Henry");
            Employee Peter = new Employee("Peter", "Haps");
            HRDayShiftEmployee Rebecca = new HRDayShiftEmployee("Rebecca", "Smith", "8-5", 3);
            HRDayShiftEmployee Lisa = new HRDayShiftEmployee("Lisa", "Pit", "8-5", 3);
            HRNightShiftEmployee Forest = new HRNightShiftEmployee("Forest", "Gump", "5-12", 1);
            Employee Hal = new Employee("Hal", "Dab");
            Employee Richard = new Employee("Richard", "Phillipe");
            Employee Ginny = new Employee("Ginny", "Gump");

            // Add employees to the department class that they work in
            IT.AddEmployee(Gary);
            IT.AddEmployee(Steve);
            IT.AddEmployee(Peter);

            HR.AddEmployee(Rebecca);
            HR.AddEmployee(Lisa);
            HR.AddEmployee(Forest);

            Marketing.AddEmployee(Hal);
            Marketing.AddEmployee(Richard);
            Marketing.AddEmployee(Ginny);


            // create a list of lunch companions
            List<Employee> lunchCompanions = new List<Employee>
            {
                Steve, Peter, Rebecca, Lisa, Hal
            };

            // send Gary to go eat a bunch of things
            Gary.eat();
            Gary.eat("pizza");
            Gary.eat(lunchCompanions);
            Gary.eat("pasta", lunchCompanions);



            // Print each department and it's employees to the console
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Department: {HR.Name}");
            foreach (Employee emp in HR.Employees)
            {
                Console.WriteLine(emp);

            }
            Console.WriteLine();

            foreach (Employee emp in IT.Employees)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();
            
            // Console.WriteLine($"Department: {IT.Name}");
            // foreach (Employee emp in IT.Employees)
            // {
            //     Console.WriteLine($"    {emp.Name}");
            // }
            // Console.WriteLine();
            
            // Console.WriteLine($"Department: {Marketing.Name}");
            // foreach (Employee emp in Marketing.Employees)
            // {
            //     Console.WriteLine($"    {emp.Name}");
            // }
            // Console.WriteLine();

        }
    }
}
