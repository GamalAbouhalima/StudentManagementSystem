
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    internal class Instructor 
    {

        int InstructorId { get; set; }
        string Name { get; set; }
        string Specialization { get; set; }

        public Instructor(int instructorId, string name, string specialization)
        {
            InstructorId = instructorId;
            Name = name;
            Specialization = specialization;
        }
       public void PrintDetails()
        {
            Console.WriteLine($"ID: {InstructorId}, Name: {Name},Specialization: {Specialization}");
        }
    }
}
