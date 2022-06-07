using System.Linq;
using static System.Char;

namespace Kats.CodeWars
{
    public static class StringSorter
    {
        //e.g., "is2 Thi1s T4est 3a"
        public static string Order(string words)
        {
            var arr = words.Split(" ");
            Array.Sort(arr, CompareStringsByNumericCharacter);
            return String.Join(" ", arr);
        }

        private static int CompareStringsByNumericCharacter(string a, string b)
        =>  GetDigit(a).CompareTo(GetDigit(b));
        

        private static char GetDigit(string s) 
        => s.FirstOrDefault<char>(@char => IsNumber(@char));
    }
}