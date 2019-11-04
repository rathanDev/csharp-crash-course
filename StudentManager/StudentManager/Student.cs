using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    class Student
    {
        private string indexNumber;
        private string firstName;
        private string lastName;

        public string IndexNumber
        {
            get{ return this.indexNumber; }
            set{ this.indexNumber = value; }
        }
        public string FirstName
        {
            get { return this.firstName;}
            set { this.firstName = value;}
        }
        public string LastName
        {
            get { return this.lastName;}
            set { this.lastName = value; }
        }

        public Student(string index)
        {
            this.indexNumber = index;
        }

        public Student(string index, string first, string last)
        {
            this.indexNumber = index;
            this.firstName = first;
            this.lastName = last;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Student other = (Student)obj;
            return indexNumber == other.indexNumber;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
