using System;

namespace UDEMYMASTERCLASSFORCSHARP.InterfaceExample
{
    public class InterfaceMainExample
    {
        public static void main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(5);
            Ticket t3 = new Ticket(3);
            Ticket t4 = new Ticket(10);
            Ticket t5 = null;

            Console.WriteLine("Ticket 1 comparisons to all");
            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1.Equals(t3));
            Console.WriteLine(t1.Equals(t4));

            Console.WriteLine("Ticket 2 comparisons to all");
            Console.WriteLine(t2.Equals(t3));
            Console.WriteLine(t2.Equals(t1));
            Console.WriteLine(t2.Equals(t4));

            Console.WriteLine("Ticket 3 comparisons to all");
            Console.WriteLine(t3.Equals(t2));
            Console.WriteLine(t3.Equals(t1));
            Console.WriteLine(t3.Equals(t4));

            Console.WriteLine("Ticket 4 comparisons to all");
            Console.WriteLine(t4.Equals(t2));
            Console.WriteLine(t4.Equals(t1));
            Console.WriteLine(t4.Equals(t3));

            Console.WriteLine("Comparing the t1 to a t5 that is null. Automatically throwing false.");
            Console.WriteLine(t1.Equals(t5));
        }
    }
}