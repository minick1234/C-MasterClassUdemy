using System;

namespace UDEMYMASTERCLASSFORCSHARP.EnumsExample
{
    public class EnumsExampleMain
    {
        enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        enum Months
        {
            Jan,
            Feb,
            Mar,
            April,
            May,
            June,
            July,
            Aug,
            Sept,
            Oct,
            Nov,
            Dec
        };

        private static Day day = Day.Monday;
        private static Months month1 = Months.April;

        public static void main(string[] args)
        {
            day = Day.Monday;
            Day day2 = Day.Friday;

            Day day3 = Day.Friday;

            if (day2 == day3)
            {
                Console.WriteLine("this is something that is indeed true in this thing.");
            }

            Console.WriteLine(Day.Friday);

            Console.WriteLine((int)Day.Friday);
        }
    }
}