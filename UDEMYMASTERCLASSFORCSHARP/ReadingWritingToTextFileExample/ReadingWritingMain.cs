using System;
using System.IO;

namespace UDEMYMASTERCLASSFORCSHARP.ReadingWritingToTextFileExample
{
    public class ReadingWritingMain
    {
        public static void main(string[] args)
        {
            string[] linesToRead = File.ReadAllLines(@"C:\MYWHOLEASSDESKTOP\Input.txt");

            foreach (var line in linesToRead)
            {
                if (line.Contains("split"))
                {
                    string[] splittedstuff = line.Split();
                    foreach (var splitthing in splittedstuff)
                    {
                        Console.WriteLine("this is the split thing: " + splitthing + "\n");
                    }
                    Console.WriteLine("\n\n\n");

                    using (StreamWriter sw = new StreamWriter(@"C:\MYWHOLEASSDESKTOP\Output.txt", true))
                    {
                        sw.Write(splittedstuff[4] + " ");
                    }
                }
            }


            // string[] linesToWrite =
            // {
            //     "This is the first line", "This is the second line i am writing", "This is the third line i am writing"
            // };
            // File.WriteAllLines(@"C:\MYWHOLEASSDESKTOP\FileToRead2.txt", linesToWrite);
            //
            //
            // //this is another method of writing into a file.
            // //this is using somethind called a stream writer;
            //
            // /**
            //  * So from what i gather and understand we have to use the using here because it implements something called idisposable.
            //  * therefore we need to handle the opening and closing of the streamwriter and the valid options of doing so is by either running a try catch statement or
            //  * by doing this using statement and handling all the stuuf it does inside of the block statement. that way it does what its suppose to do.
            //  *
            //  * after doing some research this is something to do with the fact the streamwriter writes to a buffer before it goes to the final destination
            //  * so you need to basically flush it and the using keyword does that by calling the flush on it.
            //  */
            // using (StreamWriter sw = new StreamWriter(@"C:\MYWHOLEASSDESKTOP\FileToRead3.txt"))
            // {
            //     foreach (var line in linesToWrite)
            //     {
            //         if (line.Contains("third"))
            //         {
            //             sw.WriteLine(line);
            //             
            //         }
            //     }
            // }
            //
            // //tHIS IS one of the examples of reading all the text inside of a file. -- this is example 1
            // // string text = System.IO.File.ReadAllText(@"C:\MYWHOLEASSDESKTOP\FileToRead.txt");
            // //
            // // Console.WriteLine("This is everything inside of this stupid text file: \n\n" + text);
            //
            //
            // //this is example 2 by reading each line one by one.
            // // string[] lines = System.IO.File.ReadAllLines(@"C:\MYWHOLEASSDESKTOP\FileToRead.txt");
            // //
            // // Console.WriteLine("This is the content of the file line by line.");
            // // foreach (var line in lines)
            // // {
            // //     Console.WriteLine("The content of this line is : " + line);
            // // }
        }
    }
}