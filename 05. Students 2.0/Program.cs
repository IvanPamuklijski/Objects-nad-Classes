using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of students.
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split(" ");
                string firstName = tokens[0];
                string lastName = tokens[1];
                string age = tokens[2];
                string homeTown = tokens[3];
                //Check if the given student already exists.
                if (IsStudenExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                }
                else
                {

                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown

                    };
                    students.Add(student);
                }

                line = Console.ReadLine();
            }
            //Read a city name and print only students which are from the given city.
            string cityName = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }

            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStuden = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStuden = student;
                }

            }
            return existingStuden;
        }

        //Makink a method to check is the Student already exist
        private static bool IsStudenExisting(List<Student> studens, string firstName, string lastName)
        {
            foreach (Student student in studens)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
                return false;
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }

}
