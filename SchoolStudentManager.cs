using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    public class SchoolStudentManager
    {
        List<Student> students = [];
        List<Course> courses = [];
        List<Instructor> instractors = [];

       public  bool AddStuden (Student student)
        {
            students.Add (student);
            return true;
        }
         bool AddCourse(Course course)
        {
            courses.Add (course);
            return true;
        }
         bool AddInstructor(Instructor instructor)
        {
            instractors.Add (instructor);
            return true;
        }
       
    }
}
