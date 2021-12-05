using System;
using System.Collections.Generic;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class ArrayListVsList
    {
        private static void main(string[] args)
        {
            //This is immutable - and limited to one type.
            int[] scores = {1, 2, 3, 4, 5, 6};

            //Not immutable and able to expand and decrease dynamically, also not limited to one type can store multiple types of objects.
            //which can then be seperated between
            var myList = new List<int> {1, 2, 3, 4, 5, 6};
            myList.Add(0);
            myList.Add(32);
            //This also has the functionality of letting you sort your array although this only works if alll the values or of the same type. if i had a string and tried to call this it would provide me with a error cause it needs to either be casted first.
            //or i have to implement my own sorting algorithm to sort it all, this would need my own implementation and not work with the current sorting method,
            myList.Sort();
            
            foreach (var blah in myList)
            {
                Console.WriteLine("The value is: {0}", blah);
            }
        }
    }
}