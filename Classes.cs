using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
                Company doHickeyIndsutries = new Company("Do-Hickey Industries", DateTime.Now);
            // Create three employees
                Employee Cullen = new Employee("Cullen", "Ruscin", "Bat-Rider", DateTime.Now);
                Employee Mike = new Employee("Mike", "Stu", "Beast Tamer", DateTime.Now);
                Employee Connor = new Employee("Connor", "Getty", "Warrior of the Far Lands", DateTime.Now);
            // Assign the employees to the company
                doHickeyIndsutries.Employees.Add(Cullen);
                doHickeyIndsutries.Employees.Add(Mike);
                doHickeyIndsutries.Employees.Add(Connor);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            doHickeyIndsutries.ListEmployees();
        }
    }
}