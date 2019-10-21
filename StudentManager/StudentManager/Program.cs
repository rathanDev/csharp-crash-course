using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is *Student Manager* \n\n\n");

            ArrayList students = new ArrayList();
            ArrayList courses = new ArrayList();
            ArrayList enrolments = new ArrayList();

            while (true)
            {
                Console.WriteLine("\n\nEnter student details");
                Console.WriteLine("n-next p-populate\n");

                Console.Write("Enter index number: ");
                string indexNumber = Console.ReadLine();
                if (indexNumber.Equals("n"))
                {
                    break;
                }
                if (indexNumber.Equals("p"))
                {
                    Student s1 = new Student();
                    s1.IndexNumber = "s1";
                    s1.FirstName = "s1";
                    s1.LastName = "s1";
                    students.Add(s1);

                    Student s2 = new Student();
                    s2.IndexNumber = "s2";
                    s2.FirstName = "s2";
                    s2.LastName = "s2";
                    students.Add(s2);

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
                Console.WriteLine("n-next p-populate \n");

                Console.Write("Enter Course code: ");
                string code = Console.ReadLine();
                if (code.Equals("n"))
                {
                    break;
                }
                if (code.Equals("p"))
                {
                    Course c1 = new Course();
                    c1.Code = "c1";
                    c1.Description = "c1";
                    courses.Add(c1);

                    Course c2 = new Course();
                    c2.Code = "c2";
                    c2.Description = "c2";
                    courses.Add(c2);

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

            while (true)
            {
                Console.WriteLine("\n\nAdd Enrolments");
                Console.WriteLine("n-next p-populate\n");

                Console.Write("Enter student index number: ");
                string studentIndex = Console.ReadLine();
                if (studentIndex.Equals("n"))
                {
                    break;
                }
                if (studentIndex.Equals("p"))
                {
                    Enrolment e1 = new Enrolment();
                    e1.StudentIndex = "s1";
                    e1.CourseCode = "c1";
                    e1.Marks = 1;
                    enrolments.Add(e1);

                    Enrolment e11 = new Enrolment();
                    e11.StudentIndex = "s1";
                    e11.CourseCode = "c2";
                    e11.Marks = 12;
                    enrolments.Add(e11);

                    Enrolment e2 = new Enrolment();
                    e2.StudentIndex = "s2";
                    e2.CourseCode = "c1";
                    e2.Marks = 2;
                    enrolments.Add(e2);

                    Enrolment e22 = new Enrolment();
                    e22.StudentIndex = "s2";
                    e22.CourseCode = "c2";
                    e22.Marks = 22;
                    enrolments.Add(e22);

                    break;
                }
                Console.WriteLine("Index number: {0} ", studentIndex);

                Console.Write("Enter course code: ");
                string courseCode = Console.ReadLine();
                Console.WriteLine("Course code: {0}", courseCode);

                int marks = 0;
                bool validMarks = false;
                do
                {
                    Console.Write("Enter Marks: ");
                    string marksInString = Console.ReadLine();
                    validMarks = Int32.TryParse(marksInString, out marks);
                    if(!validMarks)
                    {
                        Console.WriteLine("Please enter a valid marks");
                    }
                }
                while (!validMarks);

                Console.WriteLine("Marks: {0}", marks);

                Enrolment enrolment = new Enrolment();
                enrolment.StudentIndex = studentIndex;
                enrolment.CourseCode = courseCode;
                enrolment.Marks = marks;

                enrolments.Add(enrolment);
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

            IDictionary<string, int> marksDict = new Dictionary<string, int>();

            Console.WriteLine("\n Enrolments");
            foreach (Enrolment enrolment in enrolments)
            {
                Console.WriteLine("Enrolment studentIndex:{0} courseCode:{1} marks:{2}",
                    enrolment.StudentIndex, enrolment.CourseCode, enrolment.Marks);

                int totalMarks = 0;
                if(marksDict.TryGetValue(enrolment.StudentIndex, out totalMarks)) 
                {
                    totalMarks = totalMarks + enrolment.Marks;
                } 
                else
                {
                    totalMarks = enrolment.Marks;
                }
                marksDict[enrolment.StudentIndex] = totalMarks;
            }

            Console.WriteLine("\n Summary");
            foreach(KeyValuePair<string, int> item in marksDict)
            {
                Console.WriteLine("Student {0} totalMarks:{1}", item.Key, item.Value);
            }

        }
    }
}
