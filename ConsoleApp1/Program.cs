using System; // Imports the System namespace so we can use Console and basic types

namespace PackageExpressQuote // Defines a namespace to organize our code
{
    class Program // Defines the Program class (the main entry point container)
    {
        static void Main(string[] args) // Main method where the program starts running
        {
            // Display the required first line of the program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");

            // Read the user's input (as text) and convert it to a decimal number
            // Decimal is a good choice for money/quotes because it avoids many floating-point rounding issues
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // If weight is greater than 50, show the error message and end the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Stops the program immediately
            }

            // Prompt the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine()); // Read and convert width

            // Prompt the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine()); // Read and convert height

            // Prompt the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine()); // Read and convert length

            // Calculate the sum of dimensions to check if the package is too large
            decimal dimensionTotal = width + height + length;

            // If total dimensions are greater than 50, show the error message and end the program
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Stops the program immediately
            }

            // Multiply the three dimensions together to get the package "volume-like" value
            decimal dimensionProduct = width * height * length;

            // Multiply the dimension product by the weight as required by the quote formula
            decimal weightedProduct = dimensionProduct * weight;

            // Divide by 100 to get the final shipping quote
            decimal quote = weightedProduct / 100m; // 100m ensures the number is treated as a decimal literal

            // Display the quote formatted as currency with two decimal places 
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Display the closing thank-you message 
            Console.WriteLine("Thank you!");

            // Keep the console window open until the user presses Enter 
            Console.ReadLine();
        }
    }
}
