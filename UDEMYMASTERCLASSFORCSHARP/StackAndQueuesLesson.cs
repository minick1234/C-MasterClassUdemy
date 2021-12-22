using System;
using System.Collections;
//using generics means we need to assign a type to the collection, we can use the non generic collection but that allows in any type of item into the stack
//using this we are able to specify the item type we want to sort into the stack.
using System.Collections.Generic;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class StackAndQueuesLesson
    {
        public static void main(string[] args)
        {
            //new stack of type ints, we can have a non generic stack if we want but this forms it in the type of ints
            Stack<int> stackOfInts = new Stack<int>();

            //lets say at the begining of a stack we try to pop something from the stack before anything is added,
            //if this is done the program will throw an invalidOperationException due to the stack being empty while trying to perform a pop.
            // a good way to make sure to avoid this in some type of dyanmic program where we arent sure if something is in the stack
            //is by adding a simple check to make sure the count of the stack is greater than 0 before we attempt to pop from it. this will prevent errors.
            if (stackOfInts.Count > 0)
            {
                stackOfInts.Pop();
            }

            //push the value of 1 into the stack.
            stackOfInts.Push(1);
            Console.WriteLine("Top value of the stack is: {0}", stackOfInts.Peek());

            stackOfInts.Push(2);
            Console.WriteLine("Top value of the stack is: {0}", stackOfInts.Peek());

            stackOfInts.Push(3);
            Console.WriteLine("Top value of the stack is: {0}", stackOfInts.Peek());

            stackOfInts.Push(4);
            Console.WriteLine("Top value of the stack is: {0}", stackOfInts.Peek());

            //The item which is last added in the list and is the current top of the stack gets popped out, in this case its the 
            //4 which is above. we can save the popped item and then write it out to the console.
            int poppedInt = stackOfInts.Pop();
            Console.WriteLine("The popped int in the stack:{0}", poppedInt);
            //or we can just print it from the stackofInts.pop right away.
            //The only difference between peek and pop is that peek checks the top value without removing it from the stack where stack removes it from the collection
            //now if we peek into the list again we can see that since we popped out the 4, when we peek into the top of the stack before adding the next push, the value will now be 3.
            //this is because 4 is now popped and removed from the collection
            Console.WriteLine("Top value of the stack is: {0}", stackOfInts.Peek());

            stackOfInts.Push(5);
            Console.WriteLine("Top value of the stack is: {0}", stackOfInts.Peek());

            stackOfInts.Push(6);
            //when using a stack the last item added is the first item displayed in this case the 6.
            //this is because the stack is a collection which is Last in First out.
            //where as a queue is a collection in which is first in first out.
            Console.WriteLine("Top value of the stack is: {0}", stackOfInts.Peek());

            //this is a simple example of popping each item in the stack and displaying it while the stack actually has stuff still left to pop.
            while (stackOfInts.Count > 0)
            {
                int tempInt = stackOfInts.Pop();
                Console.WriteLine("The current stacks popped int is: {0}", tempInt);
                Console.WriteLine("The remaining count of stack items is: {0}\n", stackOfInts.Count);
            }

            if (stackOfInts.Count == 0)
            {
                Console.WriteLine("The stack is out of stuff to pop and is now empty.");
            }

            //this is a simple example of reversing the array of nums using a stack.
            //could be done differently but this was implemented fast by me.
            int[] numbers = { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> reverseNums = new Stack<int>();
            foreach (var num in numbers)
            {
                //add the numbers in to the stack. the last number in is the top of the stack.
                reverseNums.Push(num);
            }

            int[] reversedArray = new int[reverseNums.Count];
            //the reason we store the size of the stack is because if we called the size of the stack in the forloop
            //the stack gets popped every loop meaning the size is reduced by 1
            //so eventually it will get to where i = the size of the count - the amount of loops done and it will skip
            //the left over nums in the stack. so to make sure we loop each element we store the original size and loop that
            int counter = reverseNums.Count;
            //if i wanted i could use a foreach and make a counter for the i location to just iterate the stack count using the foreach
            //and increase the counter by 1 to add it to the correct index location of the reversedArray but my way works just about the same.
            for (int i = 0; i < counter; i++)
            {
                reversedArray[i] = reverseNums.Pop();
            }

            Console.WriteLine("The nums in reverse order are: ");
            foreach (var num in reversedArray)
            {
                Console.WriteLine(num + "\t");
            }
        }
    }
}