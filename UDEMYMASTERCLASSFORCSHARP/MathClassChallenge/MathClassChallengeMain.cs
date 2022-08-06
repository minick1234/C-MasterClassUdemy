using System;
using System.Threading.Channels;

namespace UDEMYMASTERCLASSFORCSHARP.MathClassChallenge
{
    public class MathClassChallengeMain
    {
        public static void Main(string[] args)
        {
            double valueOfAngle;
            Console.WriteLine("Please input the angle in which you would like to display the cos,sine,and tan of:\n");
            double.TryParse(Console.ReadLine(), out valueOfAngle);
            if (!double.TryParse(Console.ReadLine(), out valueOfAngle) || valueOfAngle is > 180 or < 0)
            {
                Console.WriteLine("Check the input");
                return;
            }

            valueOfAngle = ConvertToRadians(valueOfAngle);

            Console.WriteLine(SineOfX(valueOfAngle));
            Console.WriteLine(CosineOfX(valueOfAngle));
            Console.WriteLine(TangentOfX(valueOfAngle));
        }


        //All 3 of these calculation functions below expect a radian therefore when we do the calculations we
        //we always convert it first.
        public static string CosineOfX(double radianAngle)
        {
            double newValue = Math.Cos(radianAngle);
            return "Cos = " + newValue;
        }

        public static string SineOfX(double radianAngle)
        {
            double newValue = Math.Sin(radianAngle);
            return "Sine = " + newValue;
        }

        public static string TangentOfX(double radianAngle)
        {
            double newValue = Math.Tan(radianAngle);
            return "Tg = " + newValue;
        }

        public static double ConvertToRadians(double angle)
        {
            return (MathF.PI / 180) * angle;
        }
    }
}