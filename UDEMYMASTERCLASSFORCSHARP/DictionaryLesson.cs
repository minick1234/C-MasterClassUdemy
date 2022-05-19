using System;
using System.Collections.Generic;
using System.Linq;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class DictionaryLesson
    {
        public static void main(string[] args)
        {
            Employee[] employees =
            {
                new("CEO", "Dominik", 21, 100),
                new("Sale Clerk", "Berg", 23, 21),
                new("Sale Clerk", "John", 26, 15),
                new("Sale Clerk", "Derek", 46, 14),
                new("Manager", "Alex", 8, 18),
                new("Assistant Manager", "Maya", 8, 25),
                new("Financial Adivsor", "Aneta", 45, 32)
            };


            var dic = new Dictionary<int, string>();

            var employeeDirctory = new Dictionary<string, Employee>();
            var roleCounter = 1;
            foreach (var employee in employees)
                if (employeeDirctory.ContainsKey(employee.Role))
                {
                    var tempEmployeeRole = employee.Role + "-" + roleCounter;
                    employeeDirctory.Add(tempEmployeeRole, employee);
                    roleCounter++;
                }
                else
                {
                    employeeDirctory.Add(employee.Role, employee);
                }

            //to find something in the dictionary we can either loop or we can do something like this 
            var emp1FromDictionary = employeeDirctory["Sale Clerk-1"]; //we can use the keys value to search
            foreach (var roles in employeeDirctory)
            {
                Console.WriteLine(roles.Key); //prints the role name from the dictionary as stored.
                Console.WriteLine(roles.Value
                    .Role); // print the role of the current employee as saved previously, this means the key is different
            }

            Console.WriteLine(emp1FromDictionary.Name);
            foreach (var curEmployee in employeeDirctory.Values)
                Console.WriteLine(
                    "The employees name is: {0}\nThe employees Role is: {1}\nThe employees age is: {2}\nThe employees rate is: {3}",
                    curEmployee.Name, curEmployee.Role, curEmployee.Age, curEmployee.Rate);

            //here is another way to test if a value exists in the dictionary using tryKeyValue -
            //the out in the if statement means send the result out and be able to use it,
            //out is specifically useful for any methods that return multiple values, it returns each as a reference.

            //This one doesnt work and should show the not found statement and the next example shows it working and printing the correct employee
            Employee resultedEmployee = null;
            if (employeeDirctory.TryGetValue("Intern", out resultedEmployee))
                Console.WriteLine(
                    "The employees name is: {0}\nThe employees Role is: {1}\nThe employees age is: {2}\nThe employees rate is: {3}",
                    resultedEmployee.Name, resultedEmployee.Role, resultedEmployee.Age, resultedEmployee.Rate);
            else
                Console.WriteLine("The key does not exist inside of the dictionary list");

            Employee resultedEmployee2 = null;
            if (employeeDirctory.TryGetValue("CEO", out resultedEmployee2))
                Console.WriteLine(
                    "The employees name is: {0}\nThe employees Role is: {1}\nThe employees age is: {2}\nThe employees rate is: {3}",
                    resultedEmployee2.Name, resultedEmployee2.Role, resultedEmployee2.Age, resultedEmployee2.Rate);
            else
                Console.WriteLine("The key does not exist inside of the dictionary list");

            //The example below shows how you can use a keyValuepair and check for element at a certain index.
            //using the keyvaluepair with the elementAt we have to implement linq, linq is really good with working with collections efficiently.
            //Below we make a new keyvalue pair based on the string and employee like our dictionary,
            //using this we grab the element at index i from the for loop and make a temp employee to retrieve the value from the key pair value
            //This allows us to access the elements of the value and print out the specific information of each element
            //speaking in technical terms the key of any collection or dictionary, even if we use a string just like this case
            //it has a secret int value which is its location in the list, so technically the key value of our string also can be referenced from a int value even though its a string - if that makes sense.
            //this is why the element at works because its using the int num value of the dictionary location, and it returns the pair of the key and value for the dictionary of that item.
            //Another thing to note is that hashtables start at index 1 of the items list where a dictionary will store it at the 0 index. this can be seen in the cw of the key and i print
            //as for hashtables refer to the hashtable example to see the index of the first item starting at one when trying to print it from the for loop, where
            //if i try to print it from the 0 there is nothing that exists at that location
            for (var i = 0; i < employeeDirctory.Count; i++)
            {
                var keyValuePairOfEmployee = employeeDirctory.ElementAt(i);
                Console.WriteLine("the cur employee key is: {0}, while i of the for loop is: {1}",
                    keyValuePairOfEmployee.Key, i);
                var tempEmployeeFromKeyValuePair = keyValuePairOfEmployee.Value;
                Console.WriteLine(
                    "The employees name is: {0}\nThe employees Role is: {1}\nThe employees age is: {2}\nThe employees rate is: {3}",
                    tempEmployeeFromKeyValuePair.Name, tempEmployeeFromKeyValuePair.Role,
                    tempEmployeeFromKeyValuePair.Age, tempEmployeeFromKeyValuePair.Rate);
            }

            //Another way to update a employee role without calling the items is to just call the dictionary item using the key or index
            //then create a new employee and set the constructor values with the correct arguements needed.
            var keyToUpdate = "Manager";
            Employee empToUpdate = null;
            if (employeeDirctory.TryGetValue(keyToUpdate, out empToUpdate))
            {
                empToUpdate.Age = 333;
                empToUpdate.Name = "UpdatedRandomName";
                empToUpdate.Rate = 9999;
                empToUpdate.Role = "ANewRole";

                Console.WriteLine(
                    "The employees name is: {0}\nThe employees Role is: {1}\nThe employees age is: {2}\nThe employees rate is: {3}",
                    empToUpdate.Name, empToUpdate.Role,
                    empToUpdate.Age, empToUpdate.Rate);
            }
            else
            {
                Console.WriteLine("sorry but the key you want to update doesnt exist.");
            }


            //You can also remove the dictionary item using the index position but this is the simple fast way right now cause im lazy
            //The reaspm we cannot remove the role based on the value inputted below is because when we try to remove using that
            //it is only calling the string of the object at that location and not the legit key of the dictionary,
            //because the name of the key value is still the same before we changed the role.
            //so it is still Manager. using this will delete the ANewRole
            //A way to bypass this is call the keyvalue pair and instead of trying to get the value in the if statement is just delete it based on the object that finds this new role.
            //A key in a dictionary collection in c# cannot be edited or changed. the only way to do that is to remove it from the collection and then add it in using the new key. doign that it will avoid all of these issues, and cause less confusion
            // string keyToRemoveUsingRoleName = "ANewRole";
            var keyToRemoveUsingRoleName = "Manager";

            Employee empToRemove = null;
            if (employeeDirctory.TryGetValue(keyToRemoveUsingRoleName, out empToUpdate))
            {
                employeeDirctory.Remove(empToRemove.Role);
                Console.WriteLine("The employee was successfully removed");
            }
            else
            {
                Console.WriteLine("sorry but the key you want to update doesnt exist.");
            }

            //without usign the collections.value part, it will return a key pair value which means we would have to assign that to a employee object based on the value - example below 
            //commented out. but since i use the .values in the foreach it returns a employee object at the position
            foreach (var newEmployeeList in employeeDirctory.Values)
                //this would be used if the employeedirorty.values wasnt used, plus i would have to change the cw to use this employeeobject 
                //Employee exampleEmployeeValue = newEmployeeList.Value;
                Console.WriteLine(
                    "The employees name is: {0}\nThe employees Role is: {1}\nThe employees age is: {2}\nThe employees rate is: {3}",
                    newEmployeeList.Name, newEmployeeList.Role,
                    newEmployeeList.Age, newEmployeeList.Rate);
        }
    }

    internal class Employee
    {
        public Employee(string role, string name, int age, float rate)
        {
            Role = role;
            Name = name;
            Age = age;
            Rate = rate;
        }

        //Properties like age name and role for each employee. - could also include rate in the consturctor but set it seperate.
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        //Yearly salary = rate/h * number of days * number of weeks * number of months
        public float Salary => Rate * 8 * 5 * 4 * 12;
    }
}