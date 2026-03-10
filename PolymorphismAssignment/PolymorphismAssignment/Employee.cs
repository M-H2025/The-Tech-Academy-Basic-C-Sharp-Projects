//Employee.cs
using System;

namespace AbstractClassesAssignment
{
    //Employee inherits from Person AND implements the IQuittable interface
    public class Employee : Person, IQuittable
    {
        //Property that stores the employee ID
        public int Id { get; set; }

        //Override the SayName method from the abstract Person class
        public override void SayName()
        {
            //Print the employee's full name to the console
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //Implement the Quit() method required by the IQuittable interface
        public void Quit()
        {
            //Display a message when the employee quits
            Console.WriteLine(firstName + " " + lastName + " has quit the job.");
        }
    }
}
