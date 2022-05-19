using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample1
{
    public class Radio : ElectricalDevice
    {

        //The reason we use the : base is because it is the same constructor as our inherited class so we dont have to make another body for this constructor when we already have these properties.
        //The name of the base parameters is what we are passing to the base constructor based on this current constructors parameters.
        public Radio(bool isOn, string brandOfRadio) : base(isOn, brandOfRadio)
        {
 
        }

        public void ListenRadio()
        {
            if (isItemOn)
            {
                Console.WriteLine("Listening to the radio.");
            }
            else if (!isItemOn)
            {
                Console.WriteLine("Radio is switched off, please switch it on first.");
            }
        }
    }
}