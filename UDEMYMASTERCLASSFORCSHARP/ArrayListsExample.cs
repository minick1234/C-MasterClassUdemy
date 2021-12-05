using System;
using System.Collections;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class ArrayListsExample
    {
        private static void main(string[] args)
        {
            //These are collections - they differ from arrays because they can dynamically chaneg and increase in size , where as an array cannot. Once the size is set then it is not changeable unless you do a bunch of funky stuff like copying the vlaues to another array and then back
            //but thats a complete hassle when you can just opt in to use some sort of collection type. - it is also capable of storing multiple types without needing to define and storing those types all in one arraylist meaning you can have a string, int and double all stored in one arraylist.
            //There are also lists that can be used which is the same thign as it is a collection - so it would be var blah = new list<>(); although a list you must define the type inside of the <> to make sure the list knows what it is storing.
            //A dictionary is equivaLANT TO a hashmap but it is a collection as well, but it has a relative hash value for each object.
            //This is a undefined amount of object arraylist
            var myArrayList = new ArrayList();
            //This arrayList has a size of 100
            var myArrayList2 = new ArrayList(10);

            //Add the element to the arraylist
            myArrayList.Add(31.4);
            myArrayList.Add("dick");
            myArrayList.Add(55);
            myArrayList.Add(-10);
            myArrayList.Add(563634);
            myArrayList.Add(1240);

            myArrayList2.Add(535649821734);
            myArrayList2.Add('c');
            myArrayList2.Add("ccc");
            myArrayList2.Add(-1242424242420);
            myArrayList2.Add(54434656755);
            myArrayList2.Add(-10543656876);
            myArrayList2.Add(525435345235);
            myArrayList2.Add(-33131313110);
            myArrayList2.Add(5667658686);
            myArrayList2.Add(52647645);

            //Remove an element from the list this is determined by the specific value or the index.. 
            myArrayList.Remove(31.4);
            myArrayList.RemoveAt(3);

            //How to know the size of ther array list comparedd to an array the keyword difference is count instead of length.
            Console.WriteLine(myArrayList.Count);

            double sumofAllNumbers = 0;

            //The reason we use object inside is because we want to be able to display any time of datatype and if i changed it to string or something else it would only display that in the list.
            //It could also be var instead of object which is relatively the same thing , as var fills itself in depending on the datatype needed. -- usually the most preferable choice.
            foreach (Object myObject in myArrayList)
            {
                if (myObject is int)
                {
                    //This is a conversion to make sure that the object becomes a double from whatever its interpreted as.
                    sumofAllNumbers += Convert.ToDouble(myObject);
                }else if(myObject is double)
                {
                    sumofAllNumbers += Convert.ToDouble(myObject);
                }else if (myObject is string)
                {
                    Console.WriteLine(myObject);
                }
            }
            Console.WriteLine("The sum of all the values in the arraylist together is : {0}", sumofAllNumbers);
        }
    }
}