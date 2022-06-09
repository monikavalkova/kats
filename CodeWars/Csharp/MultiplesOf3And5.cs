namespace CodeWars.Csharp.MultiplesOf3And5
{
    public static class MultiplesOf3And5
    {
        public static int SumDivisiblesBy3And5(int value)
        {
            if (value < 2) return 0;
            var sum = 0;
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}