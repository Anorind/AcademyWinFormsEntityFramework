using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWinFormsEntityFramework
{
    internal class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
