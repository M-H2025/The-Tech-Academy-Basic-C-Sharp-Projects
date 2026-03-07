using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperation1 math = new MathOperation1();

            // Ask the user for a number
            Console.WriteLine("Enter a number:");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the method
            int result = math.DoMath(userNumber);

            // Print result
            Console.WriteLine("The result is: " + result);

            Console.ReadLine();
        }
    }
}