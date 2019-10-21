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

            while (true)
            {
                Console.WriteLine("\n\nEnter student details");
                Console.WriteLine("Enter q to exit \n");

                Console.Write("Index number: ");
                string indexNumber = Console.ReadLine();
                if (indexNumber.Equals("q"))
                {
                    break;
                }
                Console.WriteLine("Index Number: " + indexNumber);

                Console.Write("First name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("First name: " + firstName);

                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Last name: " + lastName);

                Student student = new Student();
                student.IndexNumber = indexNumber;
                student.FirstName = firstName;
                student.LastName = lastName;

                students.Add(student);
            }

            Console.WriteLine("Registered students");
            foreach (Student student in students)
            {
                Console.WriteLine("Student index:{0} firstName:{1} lastName:{2}",
                    student.IndexNumber, student.FirstName, student.LastName);
            }

        }
    }
}
