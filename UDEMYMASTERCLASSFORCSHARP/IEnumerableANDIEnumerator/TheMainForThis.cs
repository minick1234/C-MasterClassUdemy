using System;
using System.Collections;
using System.Collections.Generic;
using UDEMYMASTERCLASSFORCSHARP.VirtualAndOverrideExample;

namespace UDEMYMASTERCLASSFORCSHARP.IEnumerableANDIEnumerator
{
    public class TheMainForThis
    {
        //There is two types of Ienumerable collections 
        //1. IENUMERABLE <T> for generic collections
        //2. IENUMERABLE for non generic collections

        /**
         * The Ienumerable<T> contains a single method that you must implement when implementing this interface;
         * GetEnumerator(), which returns an Ienumerator<T> object;
         * The returned Ienumerator<T> provides the ability to iterate through the collection by exposing a current propertyy that points at the object we are currently at
         * in the collection
         *
         * In short form a Ienumerable returns an ienumerator object.
         */
        class Dog
        {
            public string Name { get; set; }

            public bool IsNaughtyDog { get; set; }

            public Dog()
            {
                Name = "Oreo";
                IsNaughtyDog = false;
            }

            public Dog(string name, bool isNaughty)
            {
                Name = name;
                IsNaughtyDog = isNaughty;
            }

            //this method will print how many treats the dog recieved
            public void GiveTreats(int NumberOfTreats)
            {
                //Print out a message containing ther number of treats and the name of the dog.
                Console.WriteLine("{0} has recieved {1} treats", this.Name, NumberOfTreats);
            }
        }


        class DogShelter : IEnumerable<Dog>
        {
            public List<Dog> dogs;


            public DogShelter()
            {
                //create the new list when the dog shelter object is made.
                dogs = new List<Dog>();

                // //add these dogs to the list by default
                // dogs.Add(new Dog("oreo", false));
                // dogs.Add(new Dog("archie", true));
                // dogs.Add(new Dog("shadow", true));
                // dogs.Add(new Dog("casper", false));

                //this can also be done differently instead of adding to the list we can initialize like : - the way above is valid but this is better.
                dogs = new List<Dog>()
                {
                    new Dog("oreo", false),
                    new Dog("archie", true),
                    new Dog("shadow", true),
                    new Dog("casper", false)
                }; //- this way is probably more efficient as well since it is not calling the add method multiple times.
            }

            //a simple understanding of a ienumerator is that it is a iteration of an  object in a collection. in the case below, we have a list that we are returning the iterated value of from that list in order to be able to use it in the main class.
            //this is done because we want to pass the class as a shelter, but if we wanted to avoid using the ienumerable implementation we could call in the main shelter.dogs although this means this class is a enumerable collection primarily for the dog shelter.

            //this is returning a simple iteration over the dogs list. calling the enumerator of the current dog object.
            public IEnumerator<Dog> GetEnumerator()
            {
                return dogs.GetEnumerator();
            }


            //this is primarily used if the collection is none generic, it just calls the method above though in this case since the type is dog object. Then we just return the dog iterated object.
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }


        /// When is it recommended to use the IEnumerable Interface:
        /// - Your collection represents a massive database table,
        /// you don't want co copy the entire thing into memory and cause performance issues in your application, but you still want to display the items and see what they contain
        /// -----------------------------------------------------------------------------
        /// When is it not recommended to use the IEnumerable Interface:
        /// when you need the results right away and are possibly mutating / editing the objects later on.
        /// In this case, it is better to use an Array or a List even though it is less performant.
        /// </summary>
        public static void main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (var dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreats(5);
                }
                else if (dog.IsNaughtyDog)
                {
                    dog.GiveTreats(1);
                }
            }
        }
    }
}