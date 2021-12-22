using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class RandomNumAdditionsForMaya
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maya pick the math you would like to do:\n1.)Addition\n2.)Subtraction");
            int mathType = int.Parse(Console.ReadLine());
            switch (mathType)
            {
                case 1:
                    do
                    {
                        int[] generatedNums = GenerateRandomNums();
                        int sum = 0;
                        do
                        {
                            Console.WriteLine("Maya, what is the sum of {0} + {1}: ", generatedNums[0],
                                generatedNums[1]);
                            sum = int.Parse(Console.ReadLine());

                            if (IsCorrectAnswerAddition(sum, generatedNums))
                            {
                                Console.WriteLine(
                                    "That is correct maya good job! Time for next question.\n-------------------------------------------\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry maya but that is wrong. Try again.\n");
                            }
                        } while (true);
                    } while (true);

                    break;

                case 2:
                    do
                    {
                        int[] generatedNums = GenerateRandomNums();
                        int sum = 0;
                        do
                        {
                            Console.WriteLine("Maya, what is the sum of {0} - {1}: ", generatedNums[0],
                                generatedNums[1]);
                            sum = int.Parse(Console.ReadLine());

                            if (IsCorrectAnswerSubtraction(sum, generatedNums))
                            {
                                Console.WriteLine(
                                    "That is correct maya good job! Time for next question.\n-------------------------------------------\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry maya but that is wrong. Try again.\n");
                            }
                        } while (true);
                    } while (true);

                    break;
            }
        }

        public static int[] GenerateRandomNums()
        {
            int[] randNums = new int[2];
            Random randNum = new Random();
            int num1 = randNum.Next(0, 100);
            randNums[0] = num1;
            int num2 = randNum.Next(0, 100);
            randNums[1] = num2;
            return randNums;
        }

        public static bool IsCorrectAnswerAddition(int sum, int[] generatedNums)
        {
            int realSum = 0;
            realSum = generatedNums[0] + generatedNums[1];
            if (realSum == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCorrectAnswerSubtraction(int sum, int[] generatedNums)
        {
            int realSum = 0;
            realSum = generatedNums[0] - generatedNums[1];
            if (realSum == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}