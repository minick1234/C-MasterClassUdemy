using System;
using System.Collections;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class HashTablesChallenge
    {
        public static void main()
        {
            Student[] students = new Student[7];
            students[0] = new Student(1, "Derek", 88);
            students[1] = new Student(2, "Dominik", 95);
            students[2] = new Student(3, "Aneta", 85);
            students[3] = new Student(4, "Maya", 55);
            students[4] = new Student(5, "Alex", 68);
            students[5] = new Student(1, "FailureStudent", 11);
            students[6] = new Student(2, "FailureStudent2", 32);

            
            
            Hashtable studentTable = new Hashtable();
            foreach (var student in students)
            {
                if (studentTable.ContainsKey(student.studentID))
                {
                    Console.WriteLine("Sorry, a student with the id of: {0}, already exists\n", student.studentID);
                }
                else
                {
                    studentTable.Add(student.studentID, student);
                }
            }

            foreach (Student studentsStoredInTable in studentTable.Values)
            {
                Console.WriteLine(
                    "The id of the student is: {0}\nThe name of the student is:{1}\nThe GPA of the student is: {2}\n",
                    studentsStoredInTable.studentID, studentsStoredInTable.StudentName, studentsStoredInTable.GPA);
            }
        }
    }

    public class Student
    {
        public string StudentName { get; set; }
        public float GPA { get; set; }
        public int studentID { get; set; }

        public Student(int studentId, string studentName, float GPA)
        {
            this.StudentName = studentName;
            this.studentID = studentId;
            this.GPA = GPA;
        }
    }
}