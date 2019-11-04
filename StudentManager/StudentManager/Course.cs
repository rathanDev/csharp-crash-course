using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    class Course
    {
        private string code;
        private string description;

        public Course(string code)
        {
            this.code = code;
        }

        public Course(string code, string desc)
        {
            this.code = code;
            this.description = desc;
        }

        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return code == ((Course)obj).code;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
