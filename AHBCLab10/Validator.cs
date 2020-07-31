using System;
using System.Collections.Generic;
using System.Text;

namespace AHBCLab10
{
    class Validator
    {
        /// <summary>
        /// Validates that a given string can be parsed to a double
        /// </summary>
        /// <param name="input">User string to be parsed to double</param>
        /// <returns>True if string can be parsed, false if it can't</returns>
        public static bool ValidateDouble(string input)
        {
            var valid = double.TryParse(input, out double number);
            if (number <= 0) valid = false;

            if(!valid) Console.WriteLine("\nInvalid input. Please try again.\n");

            return valid;
        }


        /// <summary>
        /// Validates that a given string is a correct response to
        /// the user wanting to continue
        /// </summary>
        /// <param name="input">User inputted string</param>
        /// <returns>True if the user string matches with accepted responses,
        /// false if there's no match</returns>
        public static bool ValidateContinue(string input)
        {
            List<string> continueValues = new List<string>
            {
                "yes",
                "y",
                "no",
                "n"
            };

            var valid = continueValues.Contains(input.ToLower());

            if (!valid) Console.WriteLine("\nInvalid input. Please try again.\n");

            return valid;
        }               
    }
}
