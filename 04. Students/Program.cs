using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of students.
            List<Student> infoAboutStudents = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split(" ");
                string firstName = tokens[0];
                string lastName = tokens[1];
                string age = tokens[2];
                string homeTown = tokens[3];
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown

                };
                infoAboutStudents.Add(student);
                
                line = Console.ReadLine();
            }
            //Read a city name and print only students which are from the given city.
            string cityName = Console.ReadLine();
            foreach (Student student in infoAboutStudents)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }

            }
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
