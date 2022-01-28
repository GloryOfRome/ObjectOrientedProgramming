using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Department//部门
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Institute Institute { get; set; }

        public List<Diploma> Diplomas { get; set; }

        public Department(Institute institute)
        {
            this.Institute = institute;
            this.Diplomas = new List<Diploma>();
        }
    }
}
