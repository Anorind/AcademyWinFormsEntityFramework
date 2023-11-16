using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWinFormsEntityFramework
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
