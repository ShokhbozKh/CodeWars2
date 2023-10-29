namespace CodeWars2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Your function takes two arguments:

            current father's age (years)
            current age of his son (years)
            Сalculate how many years ago the father was twice as old as 
            his son (or in how many years he will be twice as old). 
            The answer is always greater or equal to 0, 
            no matter if it was in the past or it is in the future.
             * 
             */
            Console.WriteLine(TwiceAsOld(32, 14));

        }
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int counter = 0;
            // Add you code here.
            if(sonYears == 0)
            {
                return dadYears;
            }
            while (dadYears != 2*sonYears)
            {
                counter++;
                dadYears++;
                sonYears++;
            }
            return counter;
        }
    }
}