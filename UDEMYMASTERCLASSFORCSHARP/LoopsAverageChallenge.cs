using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class LoopsAverageChallenge
    {
        private static void main(string[] args)
        {
            //This is the way done in a for loop
            var studentScore = 0;
            var notvalid = false;
            int totalScore = 0, totalStudentsScored = 0;
            for (var i = 0; studentScore != -1; i++)
            {
                do
                {
                    notvalid = false;
                    try
                    {
                        Console.WriteLine(
                            "Please enter in the student #{0} (int values between 0-20 or -1 to finish):\nScore:",
                            i + 1);
                        studentScore = int.Parse(Console.ReadLine());
                        if (studentScore > 20 || studentScore < 0 && studentScore != -1)
                            notvalid = true;
                    }
                    catch (FormatException e)
                    {
                        notvalid = true;
                    }

                    if (notvalid) Console.WriteLine("That is not a valid value! Try Again!");
                } while (notvalid);

                totalScore += studentScore;
                totalStudentsScored = i;
            }

            Console.WriteLine(
                "A total of {0} students scores was collected. The average score between all students is {1}",
                totalStudentsScored, totalScore / totalStudentsScored);
            Console.ReadLine();

            Console.WriteLine("***************************************************************************");

            //This can easily be done in a while loop as well, as it can say continue to loop until the input is -1
            //its easy to add the checks to make sure that its between 0 and 20 and a valid number but i just cant be bothered!
            int studentCount = 0, totalWhileLoopScore = 0, currentStudentScore = 0;

            Console.WriteLine("Please enter in the score for student #{0}): ", studentCount + 1);
            currentStudentScore = int.Parse(Console.ReadLine());

            if (currentStudentScore != -1)
            {
                studentCount++;
                totalWhileLoopScore += currentStudentScore;
            }

            while (currentStudentScore != -1)
            {
                Console.WriteLine("Please enter in student #{0} score:", studentCount + 1);
                currentStudentScore = int.Parse(Console.ReadLine());
                studentCount++;
                totalWhileLoopScore += currentStudentScore;
            }

            var response = totalWhileLoopScore <= 0
                ? "There was no scores inputted! The average therefore is 0"
                : " The average score between all students is: " + totalWhileLoopScore / (studentCount - 1);
            Console.WriteLine(response);
        }
    }
}