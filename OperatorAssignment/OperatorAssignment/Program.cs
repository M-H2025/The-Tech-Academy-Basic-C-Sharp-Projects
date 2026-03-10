//Program.cs
using System;

namespace OperatorOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the first Employee object
            Employee employee1 = new Employee();

            //Assign values to employee1 properties
            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            //Instantiate the second Employee object
            Employee employee2 = new Employee();

            //Assign values to employee2 properties
            employee2.Id = 1;
            employee2.FirstName = "Sarah";
            employee2.LastName = "Brown";

            //Compare the two Employee objects using the overloaded == operator
            bool areEqual = employee1 == employee2;

            //Display the result of the comparison to the console
            Console.WriteLine("Are the two employees equal? " + areEqual);

            //Pause the console so the result stays visible
            Console.ReadLine();
        }
    }
}