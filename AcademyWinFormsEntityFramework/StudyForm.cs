using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWinFormsEntityFramework
{
    internal class StudyForm
    {
        public int StudyFormId { get; set; }
        public string Name { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
