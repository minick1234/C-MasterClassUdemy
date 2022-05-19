using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class RandomNumAdditionsForMaya
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Maya pick the math you would like to do:\n1.)Addition\n2.)Subtraction");
            var mathType = int.Parse(Console.ReadLine());
            switch (mathType)
            {
                case 1:
                    do
                    {
                        var generatedNums = GenerateRandomNums();
                        var sum = 0;
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

                            Console.WriteLine("Sorry maya but that is wrong. Try again.\n");
                        } while (true);
                    } while (true);

                    break;

                case 2:
                    do
                    {
                        var generatedNums = GenerateRandomNums();
                        var sum = 0;
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

                            Console.WriteLine("Sorry maya but that is wrong. Try again.\n");
                        } while (true);
                    } while (true);

                    break;
            }
        }

        public static int[] GenerateRandomNums()
        {
            var randNums = new int[2];
            var randNum = new Random();
            var num1 = randNum.Next(0, 100);
            randNums[0] = num1;
            var num2 = randNum.Next(0, 100);
            randNums[1] = num2;
            return randNums;
        }

        public static bool IsCorrectAnswerAddition(int sum, int[] generatedNums)
        {
            var realSum = 0;
            realSum = generatedNums[0] + generatedNums[1];
            if (realSum == sum)
                return true;
            return false;
        }

        public static bool IsCorrectAnswerSubtraction(int sum, int[] generatedNums)
        {
            var realSum = 0;
            realSum = generatedNums[0] - generatedNums[1];
            if (realSum == sum)
                return true;
            return false;
        }
    }
}