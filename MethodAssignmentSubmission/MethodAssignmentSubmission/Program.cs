using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations math = new MathOperations();

            // Call the method using positional parameters
            math.DoMath(5, 10);

            // Call the method again using named parameters
            math.DoMath(firstNumber: 7, secondNumber: 20);

            // Pause the console so the user can see the output
            Console.ReadLine();
        }
    }
}