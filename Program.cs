namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Add Student (hint: start with empty list of courses)
             2. Add Instructor
             3. Add Course (hint: select the instructor by id)*/

            SchoolStudentManager school = new SchoolStudentManager();

            while (true)
            {
                Console.WriteLine("\n========== Student Management System ==========");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find Student by ID");
                Console.WriteLine("9. Find Course by ID");
                Console.WriteLine("10. Update Student Information");
                Console.WriteLine("11. Delete Student");
                Console.WriteLine("12. Check if Student Enrolled in Course (Bonus)");
                Console.WriteLine("13. Get Instructor Name by Course Name (Bonus)");
                Console.WriteLine("14. Show All People (Polymorphism Demo)");
                Console.WriteLine("15. Exit");
                Console.Write("\n Enter Input :  ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Add Student
                        Console.Write("Student ID: ");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name: ");
                        string studentName = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());


                        Student newStudent = new Student(studentId, studentName, age);
                        if (SchoolStudentManager.Add(newStudent))
                            Console.WriteLine("تم إضافة الطالب بنجاح!");
                        Console.WriteLine("Student Added");
                        break;

                    case 2: // Add Instructor
                        Console.Write("Instructor ID: ");
                        int instructorId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name: ");
                        string instructorName = Console.ReadLine();
                        Console.Write("Specialization: ");
                        string specialization = Console.ReadLine();

                        Instructor In1 = new Instructor(instructorId, instructorName, specialization);
                        Console.WriteLine("Instractor Added");
                        break;
                    case 3:
                        // Add Course

                        break;
                }
            }
        }
    }
}
