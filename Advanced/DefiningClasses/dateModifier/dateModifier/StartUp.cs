using System;
using System.Data;

namespace dateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate =  Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dates = new DateModifier();

            dates.FirstDate = DateTime.Parse(firstDate);
            dates.SecondDate = DateTime.Parse(secondDate);

            Console.WriteLine(dates.GetDifferenceDays());
        }
    }
}
