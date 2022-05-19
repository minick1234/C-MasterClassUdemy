namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample1
{
    public class ElectricalDevice
    {
        public bool isItemOn = false;
        public string brandOfItem = "Nothing";
        
        public ElectricalDevice(bool isOn, string brand)
        {
            isItemOn = isOn;
            brandOfItem = brand;
        }

        public ElectricalDevice()
        {
            
        }
        
        public void SwitchOn()
        {
            isItemOn = true;
        }

        public void SwitchOff()
        {
            isItemOn = false;
        }
        
        
        
    }
}