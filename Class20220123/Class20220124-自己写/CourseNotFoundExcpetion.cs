using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124_自己写
{
    class CourseNotFoundExcpetion:Exception
    {
        public CourseNotFoundExcpetion() { }

        public CourseNotFoundExcpetion(string message): base(message) { }
    }
}
