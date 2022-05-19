using System;
using System.Collections.Generic;

//This is a challenge to print out numbers which are even between 100 - 170 inclusive, if the number is even we add it to the list and then return it in the method.
namespace UDEMYMASTERCLASSFORCSHARP
{
    public class ListCodingChallenge
    {
        public static void main(string[] args)
        {
            var solutionList = new List<int>();
            solutionList = Solution();
            foreach (var number in solutionList)
                if (number < 170)
                    Console.Write(number + ",");
                else
                    Console.Write(number);
        }

        public static List<int> Solution()
        {
            var myList = new List<int>();

            for (var i = 100; i <= 170; i++)
                if (i % 2 == 0)
                    myList.Add(i);

            return myList;
        }
    }
}