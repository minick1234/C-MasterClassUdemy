using System;
using System.Linq;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class ArrayAsParameterExample
    {
        private static void main(string[] args)
        {
            int[] dickbag = {55, 77, 47, 97, 84, 63, 65, 72, 41};
            foreach (var studentGrade in dickbag) Console.WriteLine("This students grade was: {0}", studentGrade);

            Console.WriteLine("The total average of all the students at the end was: {0}", GetAverage(dickbag));

            //Without calling the clone on the other one, when it creates the happiness meter, and the values change inside that it stays persistant, this means that even if i copy it to the oldarray without using .clone then the values will just be updated with the new
            //values after the increasehappiness method is run
            //This further explains that but from a official documentations -- although i changed the codes variables to match my own
            /*
             If you tried to run the Method call IncreaseHappiness(happinessMeter);  without assigning it to happiness you might have realized, that happiness itself is changed. Why is that?
             Arrays are a reference type in C#. This means that each time an array is passed as an argument to any function, the reference (or pointer) to the argument is passed to the function. 
             Thus any modifications you make to the array in the function are made in the actual argument also
            */
            //overall this summarize that if i wanted to store initiale copies of arrays and change it but than reference the previous values i would need to clone it or keep some sort of copy of the array in order to do that or it will all change with that array
            int[] happinessMeter = {10, 5, 67, 43, 4, 5, 10, 45};
            var oldArray = (int[]) happinessMeter.Clone();

            //To iterate over 2 arrays inside of a foreach you must do something called zipping this means taking and combining them into one dynamic array which can reference both. -- for example
            //Below this creates a new collection type of ienumerable and zips both the happinessmeter and increased values into one. It also knows that oh and nh stand for newHappy and OldHappy values
            //This means now if i want to display one or the other value i can call inside the foreach whatever i name it for example foreach(var dick in oldAndNewHappiness) you can then say dick.OldHappy or dick.NewHappy
            var oldAndNewHappiness =
                oldArray.Zip(IncreaseHappiness(happinessMeter), (oh, nh) => new {OldHappy = oh, NewHappy = nh});
            //This takes that new collection and lets me print using the currentindex we are at in the loop so in this case 'happyValues' and then call the value i want, so happyValue.OldHappy or happyValue.NewHappy
            //This makes it easy to have two arrays in one foreach, even tho a for loop wouldve been easier too do this is still good to use becuase i know for sure i will always go over all the
            //values therefore its better too use although more difficult to pass multiple params into it
            foreach (var happyValues in oldAndNewHappiness)
                Console.WriteLine("The old happy value was {0}\tThe new happy value is now: {1}", happyValues.OldHappy,
                    happyValues.NewHappy);
        }

        private static int[] IncreaseHappiness(int[] happinessArray)
        {
            for (var i = 0; i < happinessArray.Length; i++) happinessArray[i] += 2;
            return happinessArray;
        }


        private static double GetAverage(int[] grades)
        {
            var size = grades.Length;
            double sum = 0;
            for (var i = 0; i < grades.Length; i++) sum += grades[i];

            return Math.Round(sum / grades.Length, 2);
        }
    }
}