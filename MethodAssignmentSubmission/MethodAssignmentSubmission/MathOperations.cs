using System;

namespace MethodAssignment
{
    // This class contains a method that performs a math operation
    public class MathOperations
    {
        // This method returns nothing and takes two integers as parameters
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first number (multiply it by 2)
            int result = firstNumber * 2;

            // Display the result of the math operation to the console
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second number to the screen 
            Console.WriteLine("Second number received: " + secondNumber);
        }
    }
}
