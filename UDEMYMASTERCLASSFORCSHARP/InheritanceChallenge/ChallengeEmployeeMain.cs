using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceChallenge
{
    public class ChallengeEmployeeMain
    {
        public static void main()
        {
            Employee emp1 = new Employee("Software Developer", "Maya", 45.50f);
            Boss Boss1 = new Boss("CEO", "Dominik", 100.25f, "Buggati");
            Trainee Trainee1 = new Trainee("Software Developer Intern", "Alex", 25f, 20, 40);

            Console.WriteLine(emp1.ToString());
            emp1.Work();
            emp1.PauseWork();

            Console.WriteLine(Boss1.ToString());
            Boss1.Work();
            Boss1.Lead();
            Boss1.PauseWork();

            Console.WriteLine(Trainee1.ToString());
            Trainee1.Work();
            Trainee1.Learn();
            Trainee1.PauseWork();
        }
    }
}