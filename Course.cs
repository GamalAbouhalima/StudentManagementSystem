using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    internal class Course
    {
        public int CourseId { get; private set; }
        public string Title { get; private set; }
        public Instructor Instructor { get; set; }


        public Course(int courseId, string title, Instructor instructor)
        {
            CourseId = courseId;
            Title = title;
            Instructor = instructor;
        }
        public void DisplayCourseInfo()
        {
            
            Console.WriteLine($"ID: {CourseId}, Title: {Title},Instructor: {Instructor}");
        }

    }
}