using System.Text;
using System.Linq;

namespace Kats.CodeWars
{
    public class DescendingOrder
    {
        public static int OrderDigitsDesc(int num)
        {
            var orderedCharacters = num.ToString().ToCharArray().OrderByDescending(c => c).ToArray();
            return int.Parse(new StringBuilder().Append(orderedCharacters).ToString());  
        }
    }

}

