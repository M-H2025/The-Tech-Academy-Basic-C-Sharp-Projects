//Program.cs
using System;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of type IQuittable
            //Employee implements IQuittable, so it can be assigned to this interface type
            IQuittable quitter = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };

            //Call the Quit method using the interface reference
            quitter.Quit();

            //Pause the program so the console window stays open
            Console.ReadLine();
        }
    }
}
