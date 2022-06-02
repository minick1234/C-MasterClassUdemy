using System;

namespace UDEMYMASTERCLASSFORCSHARP.InterfaceExample
{
    public class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }


        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        public Ticket()
        {
            this.DurationInHours = 5;
        }


        public bool Equals(Ticket other)
        {
            try
            {
                return this.DurationInHours == other.DurationInHours;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("The Ticket to compare to cannot be null.");
                return false;
            }
        }
    }
}