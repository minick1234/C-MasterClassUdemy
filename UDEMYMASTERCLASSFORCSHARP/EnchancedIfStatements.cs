using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    class Program
    {
        static void main(string[] args)
        {
            /**
             * This is a way to make enchanced if statements these are a simplar alternative to if statements to avoid writingh out the whole statement.
             * an example of a enchanced if statement is :
             * condition ? first_expression : second_expreession
             * The condition has to be a boolean value that can be set to true or false. Nothing else.
             * The expression of a ? b : c ? d : e
             * is evaluated as a ? b : ( c ? d : e )
             * not as (a ? b : c) ? d : e
             * This is because the value of a is the conditional so anything that is evaulated for the "c" is
             * now the false evaulation. Meaning if its false it also does another expression
             * check to decide which false item to show in this case its d or e
             */

            //This is the example of the harder challenge!
            TernaryOperatorChallenge();
            //This is the example from the previous challenge
            //HisChallengeExample();
            //These are the other examples i had!
            //otherExamples();
        }

        public static void otherExamples()
        {
            Console.WriteLine("Please enter in the individuals age.");
            int age = Int32.Parse(Console.ReadLine());
            string response = age >= 19 ? "old enough" : "not old enough";

            //The reason i use a  inside squiggly bracket is because that is related to the first variable that way
            //i can avoid making +'s between the strings and just have one with the variable changing the string value.
            Console.WriteLine("The persons is {0} for the bar",
                response); //i need to start using the {} for variables more often!

            //The longer equivalent of that same statement is 
            Console.WriteLine("Please enter in the individuals age:");
            int age2 = Int32.Parse(Console.ReadLine());

            string response2;

            if (age >= 19)
            {
                response2 = "Old enough!";
            }
            else
            {
                response2 = "not old enough!";
            }

            Console.WriteLine("The person is {0} for the bar!", response2);
        }

        public static void HisChallengeExample()
        {
            Console.WriteLine("Please enter in the tempature in celcius: ");
            float temp = float.Parse(Console.ReadLine());
            string stateOfMatter = temp < 0 ? "solid" : (temp >= 100 ? "gas" : "liquid");
            Console.WriteLine("With the temp being {0} degrees celcius, means that the state of matter is {1}", temp,
                stateOfMatter);
        }

        public static void TernaryOperatorChallenge()
        {
            //A second way to solve this problem is als oto use the int.tryparse
            //Thats if i dont want to use a try catch, it will make sure to parse the input to a int and if its not we can loop like we did here till they do put an int!
            //Either way works and is fine so it shouldnt matter in the long run!
            //The tryparse returns a bool so i could have another if statement just checking before it reloops! using the enchanced if statement method!

            bool NotValidInput;
            int temp = 0;
            
            do
            {
                NotValidInput = false;
                try
                {
                    Console.WriteLine("Please enter in the current temp in celcius: ");
                    temp = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    NotValidInput = true;
                    Console.WriteLine("This is not a valid tempature value!... \nTry again.");
                }
            } while (NotValidInput);

            string response = temp <= 15
                ? "It is too cold here!"
                : (temp >= 16 && temp <= 28 ? "It is ok temp!" : "it is hot here!");
            Console.WriteLine("The current expression for tempature is: {0}", response);
        }
    }
}