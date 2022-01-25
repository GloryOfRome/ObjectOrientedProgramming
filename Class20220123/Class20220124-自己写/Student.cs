using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124_自己写
{
    public static class TestStaticClass
    {
        public static string s;
        public static int i;
    }
    class Student
    {
        /*
         - Create a class "Student" that contains few student properties like (Name, Birthdate, Nationality) and 2 different constructors, one that takes only the name and another one that takes all the fields
        创建一个“学生”类，其中包含一些学生属性，如（姓名、出生日期、国籍）和 2 个不同的构造函数，一个只取名字，另一个取所有字段
         - In the Student class, create another property for Students called "Courses", which is a list of courses that a student is enrolled in
        在Student类中，为Student创建另一个名为“Courses”的属性，这是一个学生注册的课程列表
         - In Student class, write two functions, JoinCourse and LeaveCourse to handle the enrollment
        在 Student 类中，编写 JoinCourse 和 LeaveCourse 两个函数来处理注册
         - Also write a function PrintAllCourses in Student class
        还要在 Student 类中编写一个函数 PrintAllCourses
         - Change the Student class so the student can only have 15 credits of courses at the same time
        更改学生班级，使学生只能同时拥有15个学分的课程

        - Implement: A student who dropped out of a course can't register again for the same course.
        实施：退出课程的学生不能再次注册同一课程。
        - Add a max capacity for each course.
        为每门课程添加最大容量。
        - Add a WaitingList for each course,
        为每门课程添加等候名单，
            when a user is trying to join a full course,
            当用户尝试加入已经满员的课程时，
            they will be added to this waiting list,
            他们将被添加到这个等候名单中，
            once a user leaves a course that is full ,
            一旦用户离开已满的课程，
            The first user in the waiting list will be added to the course.
            等候名单中的第一个用户将被添加到课程中。

            Create a new class "Institute", which contains a list of all courses, list of all students
            创建一个新类“学院”，其中包含所有课程的列表，所有学生的列表
            Write the following methods:
            - Get a list of all full courses
            - Get a list of all students with max allowed credits
            - list of all students who are in 3 waitlists at least
            - The course with the max number of students
            - The course with max number of dropouts

            Create a collection (list) in the course to represent the grades of students in this course
            Create a collection in the student to represent the grades of this student in all his courses
            - Write a function to get the top student in a course
            - Write a function to get the best course (top grade) for a student
            - Write a function to get the GPA (from 0 to 4) of a student
            - Write a function to get the top student (top GPA)

         */

        public string Name;
        public string Nationality;
        public DateTime Birthdate;
        public List<Course> Courses = new List<Course>();
        public List<Course> DroppedOutCourses = new List<Course>();

        public static int NumOfStudentsInTheSystem;

        public int NumberOfEnrolledCredits;

        public Student(string name)
        {
            this.Name = name;
            NumberOfEnrolledCredits = 0;
            NumOfStudentsInTheSystem++;
        }

        public Student(string name, DateTime birthdate, string nationality)
        {
            this.Name = name;
            this.Birthdate = birthdate;
            this.Nationality = nationality;
            NumberOfEnrolledCredits = 0;
        }

        public void JoinCourse(Course courseToJoin)
        {
            if (courseToJoin.Students.Count >= courseToJoin.MaxCapacity)
            {
                Console.WriteLine("Sorry the course is full, you will be added to the waiting list..");
                courseToJoin.WatingQueue.Enqueue(this);
            }
            if (this.DroppedOutCourses.Contains(courseToJoin))
            {
                Console.WriteLine("You already dropped out from this course...can't join again");//您已退出此课程...无法再次加入
            }
            else if (!this.Courses.Contains(courseToJoin))
            {
                if (NumberOfEnrolledCredits + courseToJoin.NumberOfCredits <= 15)
                {
                    this.Courses.Add(courseToJoin);
                    courseToJoin.Students.Add(this);
                    this.NumberOfEnrolledCredits += courseToJoin.NumberOfCredits;
                }
                else
                    Console.WriteLine("You already reached the max allowed num of credits");
            }
            else
                Console.WriteLine("You are already enrolled in this course");
        }

        public void LeaveCourse(Course courseToLeave)
        {
            if (this.Courses.Contains(courseToLeave))
            {
                this.Courses.Remove(courseToLeave);
                this.DroppedOutCourses.Add(courseToLeave);
                courseToLeave.Students.Remove(this);// this referes to the student who called the method (student who is leaving the course)
                //this是指调用该方法的学生（即将离开课程的学生）

                while(courseToLeave.Students.Count< courseToLeave.MaxCapacity && courseToLeave.WatingQueue.Count > 0)
                {
                    Student firstStudentInTheQueue = courseToLeave.WatingQueue.Dequeue();
                    firstStudentInTheQueue.JoinCourse(courseToLeave);
                }
                this.NumberOfEnrolledCredits -= courseToLeave.NumberOfCredits;
            }
            else
            {
                Console.WriteLine("ERROR.....You are not enrolled in this course");
            }
        }

        public void PrintAllCourses()
        {
            Console.WriteLine($"Courses of student{this.Name}");
            foreach(var course in Courses)
                Console.WriteLine(course.Name);
        }

        public static void PrintTotalNumOfStudents()//static静态数据示例
        {
            Console.WriteLine($"The total number of students in the system are: {NumOfStudentsInTheSystem}");
        }
    }
}
