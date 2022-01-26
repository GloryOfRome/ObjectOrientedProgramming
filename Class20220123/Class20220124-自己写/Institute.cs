using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124_自己写
{
    class Institute
    {
        /*
         Create a new class "Institute", which contains a list of all courses, list of all students
         创建一个新类“学院”，其中包含所有课程的列表，所有学生的列表
         Write the following methods:编写以下方法：
         - Get a list of all full courses- 获取所有报名人数已经满了的课程的列表
         - Get a list of all students with max allowed credits- 获取所有具有最大允许学分的学生的列表
         - list of all students who are in 3 waitlists at least- 至少在 3 个候补名单中的所有学生名单
         - The course with the max number of students- 学生人数最多的课程
         - The course with max number of dropouts- 辍学人数最多的课程
         */
        public string Name;
        public List<Course> AllCourses;
        public List<Student> AllStudent;

        public Institute(string name)
        {
            this.Name = name;
            AllCourses = new List<Course>();
            AllStudent = new List<Student>();
        }
        public void GetALsitOfAllFullCourses()//获取所有报名人数已经满了的课程的列表
        {
            List<Course> fullCourseList = new List<Course>();
            foreach(var course in AllCourses)
            {
                if (course.EnrolledStudent.Count == course.MaxCapacity)
                    fullCourseList.Add(course);
            }
        }

        public List<Student> GetALsitOfAllStudentWithMaxAllowedCredits()//获取所有具有最大允许学分的学生的列表
        {
            List<Student> maxAllowedCreditsStudentList = new List<Student>();
            foreach (var student in AllStudent)
            {
                if (student.NumOfEnrolledCredit() == Student.MAX_ALLOW_CREDIT)
                    maxAllowedCreditsStudentList.Add(student);
            }
            return maxAllowedCreditsStudentList;
        }

        public List<Student> ListAllStudentsInThreeWaitlists()
        {
            //循环所有学生在waitinglist
        }
    }
}
