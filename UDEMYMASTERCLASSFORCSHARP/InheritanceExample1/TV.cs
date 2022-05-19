using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample1
{
    public class TV : ElectricalDevice
    {

        public TV(bool isOn, string brandOfTv) : base(isOn, brandOfTv)
        {

        }

        public void WatchTV()
        {
            if (isItemOn)
            {
                Console.WriteLine("The tv is on, we can begin to watch our fav show.");
            }else if (!isItemOn)
            {
                Console.WriteLine("The tv is off, turn it on first before we can begin.");
            }
        }

    }
}