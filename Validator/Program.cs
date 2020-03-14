using System;
using System.Text.RegularExpressions;

namespace Validator
{
    class Program
    {
        private static int numberdfkjokjskjs_;

        static void Main(string[] args)
        {
            //static void PinNumberValidator()
            //{
            //    //-A valid pin code can be between 4 and 8 digits inclusive.
            //    //-A valid pin code can only be numerical digits.
            //    //-Your method should return true if the pin is valid.

            //    Console.WriteLine("Enter A Pin between 4 to 8 Numbers");
            //    var pinInput = Console.ReadLine();

            //    if (pinInput.Length > 3 && pinInput.Length < 9)
            //    {
            //        int number;
            //        bool success = int.TryParse(pinInput, out number);

            //        if (success)
            //        {
            //            Console.WriteLine("Your PIN is saved.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Pin may only contain numbers");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a pin between 4 to 8 characters pertaining of only numbers");
            //    };
            //}

            //PinNumberValidator();

            static void PhoneNumberValidator()
            {
                //Build a method that will determine if a phone number is valid
                //- A valid phone number must be 10 digits.
                //- A valid phone number may include spaces, dashes, or parenthesis.
                //- A valid phone number in any area code does not start with 555.

                Console.WriteLine("Please enter your 10 digit phone number. () and - are acctepted");
                var phone = Console.ReadLine();
                var match = Regex.IsMatch(phone, @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}");

                if (phone.Substring(5, 4).Contains("555"))
                {
                    Console.WriteLine("Invalid Phone Number: 555 is not accepted");
                }
                else if (match)
                {
                    foreach (var p in phone)
                    {
                        if (p == '(' || p == ')' || p == '-' || p == ' ')
                        {
                            continue;
                        }
                        if (char.IsDigit(p))
                        {
                            char.GetNumericValue(p);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Phone Number");
                        }
                    }
                    Console.WriteLine($"Your phone number: {phone} was accepted");

                }
                else
                {
                    Console.WriteLine("Please enter your 10 digit phone number. () and - are acctepted");
                }
            }
            PhoneNumberValidator();
            



            Console.ReadKey();
        }
    }
}
