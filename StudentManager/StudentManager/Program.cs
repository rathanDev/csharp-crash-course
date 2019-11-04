using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList students = new ArrayList();
            ArrayList courses = new ArrayList();
            ArrayList enrolments = new ArrayList();

            const string enterStudentDetailsLabel = "Enter student details";
            const string nextOrPopulateLabel = "       (n-next p-populate)";
            const string enterStudentIndexLabel = "Enter student index number: ";
            const string enterFirstNameLabel = "Enter first name: ";
            const string enterLastNameLabel = "Enter last name: ";
            const string enterCourseDetailsLabel = "Enter course details";
            const string enterCourseCodeLabel = "Enter Course code: ";
            const string enterCourseDescriptionLabel = "Enter course description: ";
            const string addEnrollmentsLabel = "Add Enrollments";
            const string enterMarksLabel = "Enter Marks: ";
            const string enterValidMarksLabel = "Please enter a valid marks";
            const string registeredStudentsLabel = "Registered students";
            const string availableCoursesLabel = "Available courses";
            const string enrollmentsLabel = "Enrolments";
            const string summaryLabel = "Summary";
            const string errorInvalidStudentIndex = "Error: Please enter a valid student index number";
            const string errorInvalidCourse = "Error: Invalid course code";
            const string splitLabel = "----------------------------------------------------";
            const string welcomeLabel = "*** ---------- Student Manager ---------- ***";

            Console.WriteLine(welcomeLabel + "\n\n");

            while (true)
            {
                Console.WriteLine("\n" + enterStudentDetailsLabel + nextOrPopulateLabel);

                Console.Write(enterStudentIndexLabel);
                string indexNumber = Console.ReadLine();
                if (indexNumber.Equals("n"))
                {
                    break;
                }
                if (indexNumber.Equals("p"))
                {
                    Student s1 = new Student("s1", "s1f1", "s1l1");
                    students.Add(s1);

                    Student s2 = new Student("s2", "s2f1", "s2l1");
                    students.Add(s2);

                    break;
                }

                Console.Write(enterFirstNameLabel);
                string firstName = Console.ReadLine();

                Console.Write(enterLastNameLabel);
                string lastName = Console.ReadLine();
              
                Student student = new Student(indexNumber, firstName, lastName);

                students.Add(student);
            }

            while (true)
            {
                Console.WriteLine("\n\n" + enterCourseDetailsLabel + nextOrPopulateLabel);

                Console.Write(enterCourseCodeLabel);
                string code = Console.ReadLine();
                if (code.Equals("n"))
                {
                    break;
                }
                if (code.Equals("p"))
                {
                    Course c1 = new Course("c1", "c1d");
                    courses.Add(c1);

                    Course c2 = new Course("c2", "c2d");
                    courses.Add(c2);

                    break;
                }

                Console.Write(enterCourseDescriptionLabel);
                string description = Console.ReadLine();

                Course course = new Course(code, description);
                courses.Add(course);
            }

            while (true)
            {
                Console.WriteLine("\n\n" + addEnrollmentsLabel + nextOrPopulateLabel);

                Console.Write(enterStudentIndexLabel);

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
                if (!students.Contains(new Student(studentIndex)))
                {
                    Console.WriteLine(errorInvalidStudentIndex);
                    continue;
                }

                Console.Write(enterCourseCodeLabel);
                string courseCode = Console.ReadLine();

                if (!courses.Contains(new Course(courseCode)))
                {
                    Console.WriteLine(errorInvalidCourse);
                    continue;
                }

                int marks = 0;
                bool validMarks = false;
                do
                {
                    Console.Write(enterMarksLabel);
                    string marksInString = Console.ReadLine();
                    validMarks = Int32.TryParse(marksInString, out marks);
                    if(!validMarks)
                    {
                        Console.WriteLine(enterValidMarksLabel);
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

            Console.WriteLine("\n" + splitLabel);

            Console.WriteLine("\n" + registeredStudentsLabel);
            foreach (Student student in students)
            {
                Console.WriteLine("Student index:{0} firstName:{1} lastName:{2}",
                    student.IndexNumber, student.FirstName, student.LastName);
            }

            Console.WriteLine("\n" + availableCoursesLabel);
            foreach (Course course in courses)
            {
                Console.WriteLine("Course code:{0} description:{1}",
                    course.Code, course.Description);
            }

            IDictionary<string, int> marksDict = new Dictionary<string, int>();

            Console.WriteLine("\n" + enrollmentsLabel);
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

            Console.WriteLine("\n" + summaryLabel);
            foreach(KeyValuePair<string, int> item in marksDict)
            {
                Console.WriteLine("Student {0} totalMarks:{1}", item.Key, item.Value);
            }

            Console.WriteLine("\n" + splitLabel);

        }
    }
}
