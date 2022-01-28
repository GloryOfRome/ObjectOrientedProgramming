using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DiplomaCourse
    {
        public Diploma Diploma;
        public Course Course;

        public bool IsOptional;//是选修课
        public int NumOfCredits;//学分数

        public DiplomaCourse(Diploma d, Course c, bool optional, int credits)
        {
            Diploma = d;
            Course = c;
            IsOptional = optional;
            NumOfCredits = credits;
        }
    }
}
