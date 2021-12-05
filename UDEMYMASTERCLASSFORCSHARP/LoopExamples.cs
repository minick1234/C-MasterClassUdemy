using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class LoopExamples
    {
        public static void main(string[] args)
        {
            /*
                //The difference between all three loops is :
             * A while loop only runs when the conidtion is true and never otherwise
             * A do while always runs at least once.
             * A for loop needs to meet the specific conditiosn as well and is good for arrays and lists.
             * A for each is ideal only for lists and arrays and should be used when you are definitely iterating
             * over all the items in that list.
             */
            BreakAndContinueExample();
            Console.WriteLine(
                "Which looping example would you like to see?\n1.)The For Loop Example\n2.)The While Loop Example" +
                "\n3.)The Do While Example\n4.)The For Each Loop Example\n5.)Odd numbers to 20");
            var loopExampleWanted = int.Parse(Console.ReadLine());
            switch (loopExampleWanted)
            {
                case 1:
                    FirstLoopIntroExamples();
                    break;
                case 2:
                    WhileLoopExample();
                    break;
                case 3:
                    DoWhileExample();
                    break;
                case 4:
                    ForEachExample();
                    break;
                case 5:
                    ChallengeLoopHeWanted();
                    break;
                default:
                    Console.WriteLine("Sorry but that is not a valid loop example value!");
                    break;
            }
        }

        private static void FirstLoopIntroExamples()
        {
            //Make sure to always be sure my condition is valid and that the increment is also valid so i dont get caught in a infinite loop!
            for (var i = 0; i < 15; i++) Console.WriteLine("This is the {0} time I have looped!", i + 1);
        }

        private static void WhileLoopExample()
        {
            var counter = 0;
            while (counter < 15)
            {
                Console.WriteLine("This is the while loop example looping for the {0} time.", counter + 1);
                counter++; // Make sure to never leave the counter out of a do while or while loop as it will infinitely loop!
            }
        }

        private static void DoWhileExample()
        {
            var counter = 0;
            do
            {
                Console.WriteLine("This is the do while loop example looping for the {0} time.", counter + 1);
                counter++; // Make sure to never leave the counter out of a do while or while loop as it will infinitely loop!
            } while (counter < 15);
        }

        //He doesnt actually do this in this lesson but i feel its useful and good practice anyway!
        private static void ForEachExample()
        {
            int[] randomNums = {10, 15, 35, 9, 1111, 14552, 244253, 023423, 56353, 5242};
            foreach (var thisNum in randomNums)
                Console.WriteLine("The number i have currently selected from the array: {0}", thisNum);
        }

        private static void HisStrangeWhileExample()
        {
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("The number we are at: {0}", counter);
                counter++;
            }

            Console.ReadLine();
        }

        private static void HisStrangeWhileChallenge()
        {
            //Another way to do this is just increase the value when its empty and if something is entered than i should end it but to each your own!
            //Cant be bothered to write it out both ways. since its common sense and i know how to do it if i wanted too at this point!

            //Idk to me this whole thing would be better done with a do while loop instead its cause he wants us to do a really basic buggy version!
            //But i cant it goes against my will. So if it were up to me this would be better programmed in a do while but i copied him smhh..
            var counter = 0;
            Console.WriteLine(
                "Please enter in the name of the passengers, when ready to move on, press enter with nothing typed.");
            Console.Write(counter + 1 + ":)");
            var shouldIContinue = Console.ReadLine();
            while (shouldIContinue.Length > 0)
            {
                counter++;
                Console.Write(counter + 1 + ":)");
                shouldIContinue = Console.ReadLine();
            }

            if (shouldIContinue.Length <= 0) counter--;

            Console.WriteLine("The bus now has :{0} people on it!", counter + 1);
            Console.ReadLine();
        }


        private static void HisStrangeDoWhileExample()
        {
            var lenghtOfText = 0;
            var wholeText = "";

            do
            {
                Console.WriteLine("Please enter in your friends name: ");
                var friendsname = Console.ReadLine();
                var currentNameLenght = friendsname.Length;
                lenghtOfText += currentNameLenght;
                wholeText += friendsname;
            } while (lenghtOfText < 20);

            Console.WriteLine("Thanks that was enough! The names together are: {0}" +
                              " and the total length of the names was: {1}", wholeText, wholeText.Length);
            Console.ReadLine();
        }


        private static void ChallengeLoopHeWanted()
        {
            for (var i = 0; i < 20; i++)
                if (i % 2 == 1)
                    Console.WriteLine("The odd number being displayed is: {0}", i);

            // //The second way to do this is easier but not as programmy ;) this is more hardcoded!
            // for (int i = 0; i < 20; i+=2)
            // {
            //     Console.WriteLine("The odd number being displayed is: {0}", i);
            // } // This is also his example but my way is better and more expandable!

            Console.ReadLine();
        }

        private static void BreakAndContinueExample()
        {
            //A continue takes the code bit and brings you right back to the top of that loop meaning you can move on to the next iteration!
            //Break ends the loop at the current point. So whenever a break is run into this is where we stop running from.

            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                {
                    Console.WriteLine(
                        "{0}) We are now at 8 so we stop early. But did you notice that 5 and 3 were missing?", i);
                    break;
                }

                switch (i)
                {
                    case 3:
                        continue;
                        // It shouldnt print this since the statement is after the continue therefore, we should be at the top already and not able to read this!
                        Console.WriteLine("{0}) We have made it to iteration 3 and continued!", i);
                        break;
                    case 5:
                        continue;
                        // It shouldnt print this since the statement is after the continue therefore, we should be at the top already and not able to read this!
                        Console.WriteLine("{0})We have made it to iteration 5 and continued!", i);
                        break;
                    default:
                        Console.WriteLine("{0}) This is running normally!", i);
                        break;
                }
            }
        }
    }
}