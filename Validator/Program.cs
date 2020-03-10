using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //-A valid pin code can be between 4 and 8 digits inclusive.
            //-A valid pin code can only be numerical digits.
            //-Your method should return true if the pin is valid.

            Console.WriteLine("Enter A Pin between 4 to 8 Numbers");
            var pinInput = Console.ReadLine();

            if (pinInput.Length > 3 && pinInput.Length < 9 )
            {
                int number;
                bool success = int.TryParse(pinInput, out number);

                    if (success)
                    {
                        Console.WriteLine("Your PIN is saved.");
                    }
                    else
                    {
                        Console.WriteLine("Pin may only contain numbers");
                    }
            }
            else
            {
                Console.WriteLine("Please enter a pin between 4 to 8 characters pertaining of only numbers");
            };

            Console.ReadKey();
        }
    }
}
