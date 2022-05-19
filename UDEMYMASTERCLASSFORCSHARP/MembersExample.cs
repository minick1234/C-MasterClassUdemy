using System;
using System.Diagnostics;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class MembersExample
    {
        //members - public field
        public int age;

        //members - private field
        private readonly string memberName;

        public MembersExample()
        {
            age = 20;
            memberName = "Dominik";
            SalaryOfPerson = 60000;
            JobTitle = "Game Developer";
            Console.WriteLine("Hi this is a basic object created for the memebers example!");
        }

        //memebers - property - exposes jobTitle safely - properties start with a captial letter at all times
        public string JobTitle { get; set; }

        public int SalaryOfPerson { get; set; } = 20000;

        //For this example he shows how to use something called a destructor. This is something that can only exist once in the class unlike a constructor which can there can be multiple in one class.
        //This is also something called a finilizer, it cannot be inherited, overloaded and it cannot be called either. Its only there for when the members object is done all instructions and out of scope and then this is called as the last and final thing.
        //Another thing is this should not be used unless youre doing cleanup primarily or necessarily have something useful to do, otherwise it uses up alot of unnessacary performance.
        ~MembersExample()
        {
            //Called for cleaning up statements 
            //I cannot just use the console because it doesnt write it out, cause this process happens so quick! ~ side note this is better visualized in visual studio as it uses the cmd where here it uses the intelij output.
            Console.WriteLine("Reconstruction of members object taking place...");
            Debug.Write("this is the deconstruction of this object taking place...");
        }

        //Public member method - can be called from other classes when this class is instanced
        public void Introducing(bool isFriend)
        {
            if (isFriend)
                SharingPrivateInfo();
            else
                Console.WriteLine("Since you are not my friend, you are not allowed to see my salary!");
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine(
                "hi, my name is {0}, and my job title is {1}. I'm {2} years old and this is my salary, ${3}. Since you are my friend, i allow you to know.",
                memberName, JobTitle, age, SalaryOfPerson);
        }
    }

    public class membersExampleMainClass
    {
        // public static void Main(string[] args)
        // {
        //     bool redo;
        //     string answer;
        //     do
        //     {
        //         redo = false;
        //         Console.WriteLine("Hi there, are you my friend? (y or yes | n or no)");
        //         answer = Console.ReadLine();
        //         if (answer.Length <= 0)
        //         {
        //             Console.WriteLine("Don't be shy now boy, you gotta speak up.");
        //             redo = true;
        //         }
        //         else if (!(answer.ToLower().Trim().Equals("y") || answer.ToLower().Trim().Equals("yes")) &&
        //                  !(answer.ToLower().Trim().Equals("n") || answer.ToLower().Trim().Equals("no")))
        //         {
        //             Console.WriteLine("Boy what in the sweet holy fuck are you saying. try that again.");
        //             redo = true;
        //         }
        //     } while (redo);
        //
        //     var isFriend = answer.ToLower().Equals("y") || answer.ToLower().Equals("yes");
        //     var myExample = new MembersExample();
        //
        //     myExample.Introducing(isFriend);
        // }
    }
}