using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    class Enrolment
    {
        private string studentIndex;
        private string courseCode;
        private DateTime enrolledDate;
        private int marks;

        public string StudentIndex { get; set; }
        public string CourseCode { get; set; }
        public DateTime EnrolledDate { get; set; }
        public int Marks { get; set; }
    
    }
}
