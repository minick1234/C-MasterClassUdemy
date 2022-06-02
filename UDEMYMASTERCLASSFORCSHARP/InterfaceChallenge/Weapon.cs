using System;

namespace UDEMYMASTERCLASSFORCSHARP.InterfaceChallenge
{
    public class Weapon
    {
        protected string _NameOfWeapon { get; set; }

        public Weapon(string nameOfWeapon)
        {
            this._NameOfWeapon = nameOfWeapon;
        }

        public Weapon()
        {
            this._NameOfWeapon = "Shotgun";
        }

        public void Label()
        {
            Console.WriteLine($"The name of the weapon is {this._NameOfWeapon}");
        }
        
    }
}