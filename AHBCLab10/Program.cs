using System;
using System.Security.Cryptography.X509Certificates;

namespace AHBCLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int circleCount = 0;
            Circle circle;
            bool userContinue = true;


            Console.WriteLine("Welcome to Justin's Circle Tester");

            while (userContinue)
            {

                double radius;
                string userInput;

                do
                {
                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("Enter circle radius: ");
                    userInput = Console.ReadLine();
                } while (!Validator.ValidateDouble(userInput));

                radius = double.Parse(userInput);
                circle = new Circle(radius);
                circleCount++;

                Console.WriteLine($"\nCircumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area:          {circle.CalculateFormattedArea()}\n");

                do
                {
                    Console.WriteLine("Would you like to continue? (yes/no)");
                    userInput = Console.ReadLine();
                } while (!Validator.ValidateContinue(userInput));

                if (userInput.Equals("no", StringComparison.CurrentCultureIgnoreCase) ||
                    userInput.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    userContinue = false;
                }
            }


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Goodbye! You made {circleCount} circles.");
            Console.WriteLine("-----------------------------------------");
        }
    }
}
