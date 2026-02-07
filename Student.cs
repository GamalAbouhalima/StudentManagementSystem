
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public class Student
    {
        int StudentId { get;  set; }
        string Name { get; set; }
        int Age { get; set; }

       List<Course> Course= [];

        public Student(int studentId, string name, int age)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
           
        }

       //////////////////////////
        public void PrintDetails()
        {
           
            Console.WriteLine($"ID: {StudentId}, Name: {Name}, Age: {Age}, Courses: {Course.Count}");
        }

        //////////////////////////
        bool Enroll(Course course) 
        {
            if (!Course.Contains(course))
            {
                Course.Add(course);
                Console.WriteLine("Added");
                return true;
            }
            Console.WriteLine("Error");
            return false;
           
        }
        //////////////////////////


    }
}
