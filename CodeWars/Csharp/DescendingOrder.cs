using System.Linq;

namespace Kats.CodeWars
{
    public class DescendingOrder
    {
        public static int OrderDigitsDesc(int num)
        {
            var orderedCharacters = num.ToString().OrderByDescending(c => c);
            return int.Parse(string.Concat(orderedCharacters));  
        }
    }
}

