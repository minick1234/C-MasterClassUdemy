using System;
using System.Collections.Generic;

namespace UDEMYMASTERCLASSFORCSHARP.IEnumerableAndIEnumeratorExample1
{
    public class Example2OfIenumerableandIenumeratore
    {
        public static void main(string[] args)
        {
            //create a list of numbers and assign it values. In this case from 1 - 10
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);
            stack.Push(16);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(17);
            queue.Enqueue(18);
            queue.Enqueue(19);
            queue.Enqueue(20);
            queue.Enqueue(21);
            queue.Enqueue(22);
            queue.Enqueue(23);

            int[] arrayOfNums = { 11, 11, 11, 111, 11, 11, 11, 111111 };

            //call the CollectionSum method which takes in a collection of type int, the collection is a Ienumerable so it can be a list, queue, stack, array,  or whatever collection i choose.
            CollectionSum(numbers);
            CollectionSum(queue);
            CollectionSum(stack);
            CollectionSum(arrayOfNums);
        }

        //the method here takes a ienumerable collection of type int, it goes over every single Ienumerable value in the collection and stores the value into the sum, and when it is finished we print the total value of the lists sum;
        //In the main method above i do this with 4 different collections and print a different sum based on the values each of the collections pass.
        public static void CollectionSum(IEnumerable<int> anyCollectionToSumFrom)
        {
            int sum = 0;
            foreach (var number in anyCollectionToSumFrom)
            {
                sum += number;
            }

            Console.WriteLine("The sum of all the numbers in the collection are : {0}\n\n", sum);
        }
    }
}