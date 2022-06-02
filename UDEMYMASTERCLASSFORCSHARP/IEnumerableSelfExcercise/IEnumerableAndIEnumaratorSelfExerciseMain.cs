using System;
using System.Collections;
using System.Collections.Generic;

namespace UDEMYMASTERCLASSFORCSHARP.IEnumerableSelfExcercise
{
    public class IEnumerableAndIEnumaratorSelfExerciseMain
    {
        public static void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();
            foreach (var contactInPhoneBook in MyPhoneBook)
            {
                contactInPhoneBook.Call();
            }
        }
    }

    public class PhoneBook : IEnumerable<Contacts>
    {
        private List<Contacts> contactsList;

        public PhoneBook()
        {
            contactsList = new List<Contacts>()
            {
                new Contacts("Dominik", "4168194055"),
                new Contacts("Aneta", "6475182951"),
                new Contacts("Dariusz", "9054624914"),
                new Contacts("Brooke", "9058068002")
            };
        }


        public IEnumerator<Contacts> GetEnumerator()
        {
            //this returns this contact list with the current contact we are iterating at.
            return contactsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    //this could also be made into a ienumerator which i can set the move next, reset and current object methods. although i am going simple and just making a base object
    public class Contacts
    {
        private string _Name { get; set; }
        private string _PhoneNumber { get; set; }

        public Contacts(string name, string phoneNumber)
        {
            _Name = name;
            _PhoneNumber = phoneNumber;
        }

        public Contacts()
        {
            _Name = "Dominik";
            _PhoneNumber = "4168194055";
        }

        public void Call()
        {
            Console.WriteLine("Making a call to {0}, at the phone number {1}", _Name, _PhoneNumber);
        }
    }
}