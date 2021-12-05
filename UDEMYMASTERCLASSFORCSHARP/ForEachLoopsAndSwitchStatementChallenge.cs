using System;
using System.Linq;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class ForEachLoopsAndSwitchStatementChallenge
    {
        // public static void Main(string[] args)
        // {
        //     var valid = false;
        //
        //     string inputValue;
        //     Console.WriteLine("Please enter in anything (integer, boolean, string)");
        //     inputValue = Console.ReadLine();
        //
        //     int selectedValidation;
        //     Console.WriteLine(
        //         "Please enter in the selected date type you wish to validate against your input.\n1)Press 1 for string\n2)Press 2 for integer\n3)Press 3 for boolean ");
        //     selectedValidation = int.Parse(Console.ReadLine());
        //
        //     //Can split some of this up since it is so repetive. Could also use with making those split up methods handle checking for proper conversions and error handling.
        //     switch (selectedValidation)
        //     {
        //         case 1:
        //             foreach (var c in inputValue)
        //             {
        //                 valid = char.IsLetter(c);
        //                 if (!valid) break;
        //             }
        //
        //             Console.WriteLine("Is this input a string: {0}", valid);
        //             break;
        //         case 2:
        //             valid = inputValue.All(char.IsDigit);
        //             Console.WriteLine("Is this input a valid numeric: {0}", valid);
        //             break;
        //         case 3:
        //             bool retFlag = false;
        //             valid = Boolean.TryParse(inputValue, out retFlag);
        //             Console.WriteLine("Is this input a valid boolean: {0}", valid);
        //             break;
        //         default:
        //             Console.WriteLine("That is not a valid decision too select, would you like to try again? (y or n)");
        //             //Implement this after if i want to but not necessary right now.
        //             break;
        //     }
        // }
    }
}