using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124_自己写
{
    class Course
    {
        /*
         - Create another class called "Course", a course has a Name, Duration in months, and number of credits.
             创建另一个名为“课程”的课程，课程有名称、持续时间（以月为单位）和学分数。
         */

        public string Name;
        public int Duration;
        public int NumberOfCredits;
        public int MaxCapacity;
        public List<Student> Students = new List<Student>();
        public Queue<Student> WatingQueue = new Queue<Student>();

        public Course(string name, int duration, int numberOfCredits, int maxCapacity)
        {
            this.Name = name;
            this.Duration = duration;
            this.NumberOfCredits = numberOfCredits;
            this.MaxCapacity = maxCapacity;
        }
    }
}
