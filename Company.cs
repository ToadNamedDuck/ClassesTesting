using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        /*

            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            if (Employees != null)
            {
                foreach (Employee employee in Employees)
                {
                    Console.WriteLine($"{employee.FullName} has been a {employee.Title} since {employee.StartDate}");
                }
            }
            else
            {
                Console.WriteLine("There are no employees at this company.");
            }
        }
    }
}