namespace Kats.CodeWars.Csharp
{
    public static class BusSleepers
    {
        ///<summary>Each int array contains a pair of people who get 
        ///onto the bus and people who get off.
        ///This method sums the people who were left after the last stop.</summary>
        public static int GetSleepingPeopleCount(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Select(arr => arr[0] - arr[1]).Sum();
        }
    }
}