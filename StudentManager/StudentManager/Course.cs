using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    class Course
    {
        private string code;
        private string description;

        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        public string Description
        {
            get; set;
        }
    }
}
