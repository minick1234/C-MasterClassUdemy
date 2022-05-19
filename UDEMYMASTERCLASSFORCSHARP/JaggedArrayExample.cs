using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class JaggedArrayExample
    {
        private static void main(string[] args)
        {
            //A Jagged array is a array which stores arrays inside that array meaning for example as seen below, we have a jagged array of size 3
            //for the locations we set each one a new array with a different size at at location for example index 0 is a size of 5 and index 1 is 3 and so on.
            //This means i can store arrays of stuff inside of arrays to have multiple items kept in a huge list
            //declaring a jagged array with a size of 3 
            var myJaggedArray = new int[3][];

            myJaggedArray[0] = new int[5];
            myJaggedArray[1] = new int[3];
            myJaggedArray[2] = new int[2];

            //A way to set the values inside of the index 0 location without making a size would be done like -
            //This means now all the vallues i have listed are stored in the array of myjaggedarray at location 0, inside of the new array i made there.
            myJaggedArray[0] = new[]
            {
                3, 5, 5, 6, 7, 8, 1, 4, 5, 6
            };


            //An alternative way to add information into a jagged array compleltly is too do it inside the jagged array - for example
            int[][] jaggedArray2 =
            {
                new[] {56, 45, 43523, 5, 75, 767, 5, 645, 35, 2342, 421, 44, 757, 57, 57, 57575},
                new[] {5, 5, 6, 74, 535, 35, 353, 474, 634, 345, 47, 4}
            };

            //below now is a example of how to print those arrays values, although the jagged array only has values stored inside of the first index,
            //that means the rest will be 0 this is because we defaulted them sizes before of the type int and when you have a int value it auto sets the default value if not set to 0
            for (var i = 0; i < myJaggedArray.Length; i++)
            for (var j = 0; j < myJaggedArray[i].Length; j++)
                Console.WriteLine("the value located at this part of the array is: {0}", myJaggedArray[i][j]);

            myJaggedArray[1] = new[]
            {
                5, 6, 7, 8, 4, 24, 2, 764, 53, 52, 1212, 35, 34, 4, 1231, 563, 54, 534, 2
            };

            myJaggedArray[2] = new[]
            {
                211313131, 524143132, 1244235256, 1424312315, 5124131, 1152640008, 146486
            };

            //Now that thye have been set if we loop over all the jagged array again and print out the information now we will be getting all the values of all the whole array.
            for (var i = 0; i < myJaggedArray.Length; i++)
            for (var j = 0; j < myJaggedArray[i].Length; j++)
                Console.WriteLine("the value located at this part of the array is: {0}", myJaggedArray[i][j]);
        }
    }
}