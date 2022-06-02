using System;

namespace UDEMYMASTERCLASSFORCSHARP.InterfaceChallenge
{
    public class InterfaceChallengeMain
    {
        public static void main(string[] args)
        {
            Gun pist = new Gun();

            // test for methods
            pist.Label();
            pist.Shoot();

            // verifying the interface and the parent class
            if (pist is IShootable && pist is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        }
    }
}