using System;
using System.Collections.Generic;

namespace UDEMYMASTERCLASSFORCSHARP.IEnumerableAndIEnumeratorExample1
{
    public class IEnumerableAndIEnumaratorExample1Main
    {
        // public static void main(string[] args)
        // {
        //     int collectionInt = 3;
        //
        //     //instead of using the var i can also store it as an Ienumerable of type int although i just use var cause i feel like it, but if i wanted to know the definite type it would be the Ienumerable<int>
        //     var thing = GetCollection(collectionInt);
        //     if (thing != null)
        //     {
        //         foreach (var collectionItem in thing)
        //         {
        //             Console.WriteLine(collectionItem);
        //         }
        //     }
        //     else
        //     {
        //         //this is handled inside of the getcollection function. It just prints a message from there, although it could be done here when null is caught.
        //     }
        // }


        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);
            numbersQueue.Enqueue(11);
            numbersQueue.Enqueue(12);

            Stack<int> numberStack = new Stack<int>();
            numberStack.Push(13);
            numberStack.Push(14);
            numberStack.Push(15);
            numberStack.Push(16);
            numberStack.Push(17);
            numberStack.Push(18);
            numberStack.Push(19);


            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else if (option == 3)
            {
                return numberStack;
            }
            else
            {
                Console.WriteLine("This is not a valid options please try to pick another.");
                return null;
            }
        }
    }
}