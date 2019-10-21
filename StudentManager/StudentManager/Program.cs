using System;
using System.Collections;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is *Student Manager* \n\n\n");

            ArrayList students = new ArrayList();
            ArrayList courses = new ArrayList();

            while (true)
            {
                Console.WriteLine("\n\nEnter student details");
                Console.WriteLine("Enter n to move to next step \n");

                Console.Write("Enter index number: ");
                string indexNumber = Console.ReadLine();
                if (indexNumber.Equals("n"))
                {
                    break;
                }
                Console.WriteLine("Index number: {0} ", indexNumber);

                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("First name: {0}", firstName);

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Last name: {0}", lastName);

                Student student = new Student();
                student.IndexNumber = indexNumber;
                student.FirstName = firstName;
                student.LastName = lastName;

                students.Add(student);
            }

            while (true)
            {
                Console.WriteLine("\n\nEnter course details");
                Console.WriteLine("Enter n to move to next step \n");

                Console.Write("Enter Course code: ");
                string code = Console.ReadLine();
                if (code.Equals("n"))
                {
                    break;
                }
                Console.WriteLine("Course code: {0}", code);

                Console.Write("Enter course description: ");
                string description = Console.ReadLine();
                Console.WriteLine("Course description: {0}", description);

                Course course = new Course();
                course.Code = code;
                course.Description = description;

                courses.Add(course);
            }

            Console.WriteLine("\n Registered students");
            foreach (Student student in students)
            {
                Console.WriteLine("Student index:{0} firstName:{1} lastName:{2}",
                    student.IndexNumber, student.FirstName, student.LastName);
            }

            Console.WriteLine("\n Available courses");
            foreach (Course course in courses)
            {
                Console.WriteLine("Course code:{0} description:{1}",
                    course.Code, course.Description);
            }

        }
    }
}
