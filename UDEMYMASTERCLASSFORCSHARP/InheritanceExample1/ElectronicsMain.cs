using System;
using System.Security.Cryptography.X509Certificates;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample1
{
    public class ElectronicsMain
    {
        public static void main(string[] args)
        {
            TV tv1 = new TV(true, "Sony");
            Radio radio1 = new Radio(true, "Sony");
            
            Console.WriteLine(tv1.isItemOn);
            Console.WriteLine(tv1.brandOfItem);
            tv1.WatchTV();
            tv1.SwitchOff();
            tv1.WatchTV();
            tv1.SwitchOn();
            
            Console.WriteLine(radio1.isItemOn);
            Console.WriteLine(radio1.brandOfItem);
            radio1.ListenRadio();
            radio1.SwitchOff();
            radio1.ListenRadio();
            tv1.WatchTV();
            radio1.SwitchOn();
            radio1.ListenRadio();

            
            
        }
    }
}