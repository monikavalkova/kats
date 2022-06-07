using System.Text.RegularExpressions;

namespace CodeWars.Csharp
{
    public static class Validator
    {
        public static bool ValidatePIN(string input)
        { 
            return (input.Length == 4 || input.Length == 6) 
                && input.All(c => Char.IsDigit(c));
        }
    }
}