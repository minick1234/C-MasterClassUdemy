using System;

namespace UDEMYMASTERCLASSFORCSHARP.InterfaceChallenge
{
    public class Gun : Weapon, IShootable
    {
        public Gun()
        {
        }

        public void Shoot()
        {
            Console.WriteLine("The GUN SAYS BANG");
        }
    }
}