using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class JaggedArrayChallenge
    {
        //Create a jagged array which contains 3 friends arrays in which two family members should be stored
        //introduce family members from different families to eachother via console. (three introductions)
        private static void main(string[] args)
        {
            string[][] jaggedFriendsArray =
            {
                new[] {"dominik", "brooke", "alisha"},
                new[] {"martha", "stewart", "dingle"},
                new[] {"james", "linus", "sam"}
                
            };
            
            //Another way to make a new family is tooo add it to the list from an array outside the list -- for example 
            // string[] joeFamily = new string[] {"dick", "bag", "cheese" };
            //
            // string[][] k = new string[][]
            // {
            //     new string[]{"handgrenade","holymoly"},
            //     joeFamily
            // };
            // this will then now include the array of joe family which is dick bag and cheese meaning if i print thAT then those values will be displayed.
            
            for (var i = 0; i < jaggedFriendsArray.Length; i++)
            for (var j = 0; j < jaggedFriendsArray[i].Length; j++)
                if (i == 0)
                {
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("{0} i'd want to introduce you to, {1}, {2}, and {3}",
                        jaggedFriendsArray[i][j], jaggedFriendsArray[i + 1][0], jaggedFriendsArray[i + 1][1],
                        jaggedFriendsArray[i + 1][2]);
                    Console.WriteLine("while were at it, {0} i'd also like to introduce you to, {1}, {2}, and {3}",
                        jaggedFriendsArray[i][j], jaggedFriendsArray[i + 2][0], jaggedFriendsArray[i + 2][1],
                        jaggedFriendsArray[i + 2][2]);
                }
                else if (i == 1)
                {
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("{0} i'd want to introduce you to, {1}, {2}, and {3}",
                        jaggedFriendsArray[i][j], jaggedFriendsArray[i + 1][0], jaggedFriendsArray[i + 1][1],
                        jaggedFriendsArray[i + 1][2]);
                    Console.WriteLine("while were at it, {0} i'd also like to introduce you to, {1}, {2}, and {3}",
                        jaggedFriendsArray[i][j], jaggedFriendsArray[i - 1][0], jaggedFriendsArray[i - 1][1],
                        jaggedFriendsArray[i - 1][2]);
                }
                else if (i == 2)
                {
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("{0} i'd want to introduce you to, {1}, {2}, and {3}",
                        jaggedFriendsArray[i][j], jaggedFriendsArray[i - 1][0], jaggedFriendsArray[i - 1][1],
                        jaggedFriendsArray[i - 1][2]);
                    Console.WriteLine("while were at it, {0} i'd also like to introduce you to, {1}, {2}, and {3}",
                        jaggedFriendsArray[i][j], jaggedFriendsArray[i - 2][0], jaggedFriendsArray[i - 2][1],
                        jaggedFriendsArray[i - 2][2]);
                }
        }
    }
}