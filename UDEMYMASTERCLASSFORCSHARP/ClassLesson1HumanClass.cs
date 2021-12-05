using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    //A class is a blueprint representing a object which its components and functionality can be broken down inside.
    //An example is a human, we have many components like body parts and everything which all function inside a huiman but under different systems
    //Foor this example ill stay simple and we can see the creation of our human consists of first name last name and a
    //age and this is information for our human object which is different for every single human object we want to make.
    public class ClassLesson1HumanClass
    {
        public enum EyeColourOfHuman
        {
            Red,
            Blue,
            Green,
            Brown
        }

        private int _age;
        private EyeColourOfHuman _currentHumansEyeColour = EyeColourOfHuman.Blue;
        private string _firstName = "John";
        private string _lastName = "Doe";
        
        //now adding my first constructor.
        //This is the thing called when we create an object, if we define it with no parameters then it can be created empty
        //Otherwise we must define the arguements that the parameters want when we create the object if we add any parameters.

        public ClassLesson1HumanClass()
        {
            //This is left empty on purpose as this is my default constructor with no parameters.
        }

        public ClassLesson1HumanClass(string firstName, string lastName, EyeColourOfHuman eyeColour, int age)
        {
            SetTheFirstName(firstName);
            SetTheLastName(lastName);
            SetHumansEyeColour(eyeColour);
            SetPersonsAge(age);
        }

        //I know for each of the methods i dont need to use the 'this'. but i do that just in case i make two of the same
        //variable names, so it can distinguish between the methods variable and the global variable!

        public EyeColourOfHuman GetHumansEyeColour()
        {
            return _currentHumansEyeColour;
        }

        public void SetHumansEyeColour(EyeColourOfHuman usersInputtedColour)
        {
            _currentHumansEyeColour = usersInputtedColour;
        }


        public string GetFirstName()
        {
            return _firstName;
        }


        public void SetTheFirstName(string firstNameToSetTo)
        {
            _firstName = firstNameToSetTo;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetTheLastName(string lastNameToSetTo)
        {
            _lastName = lastNameToSetTo;
        }


        public int GetPersonsAge()
        {
            return _age;
        }

        public void SetPersonsAge(int ageToSetTo)
        {
            _age = ageToSetTo;
        }

        public override string ToString()
        {
            return "The human you have created has a first name of " + GetFirstName() +
                   " and a last name of " + GetLastName() + " the person has a eye colour of " +
                   GetHumansEyeColour() +
                   " and their age is currently: " + GetPersonsAge();
        }
    }
}