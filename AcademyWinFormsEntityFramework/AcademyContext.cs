using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWinFormsEntityFramework
{
    internal class AcademyContext: DbContext
    {
        public AcademyContext() : base("AcadConn") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudyForm> StudyForms { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
