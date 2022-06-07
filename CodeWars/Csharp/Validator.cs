
using System.Text.RegularExpressions;

namespace CodeWars.Csharp
{
    public static class Validator
    {
        public static bool ValidatePIN(string pin)
        { 
            return (pin.Length == 4 || pin.Length == 6) 
                && pin.All(c => Char.IsDigit(c));
        }

        public static bool ValidatePINWithRegex(string pin)
        {
            // \d -> digit
            // {n} -> amount of characters
            //  |  -> alternative
            // \z -> at end of string
            return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
        }
    }
}