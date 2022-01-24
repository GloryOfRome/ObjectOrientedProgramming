using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220123
{
    public static class TestStaticClass
    {
        public static string s;
        public static int i;
    }
    class Student
    {
        public string Name;
        public string Nationality;
        public DateTime Birthdate;
        public List<Course> Courses = new List<Course>();
        public List<Course> DroppedOutCourses = new List<Course>();

        public static int NumOfStudentsInTheSystem;

        public int NumOfEnrolledCredits;

        public Student(string name)
        {
            this.Name = name;
            NumOfEnrolledCredits = 0;

            NumOfStudentsInTheSystem++;
        }
        public Student(string name, string nationality, DateTime bd)
        {
            this.Name = name;
            this.Nationality = nationality;
            this.Birthdate = bd;
            NumOfEnrolledCredits = 0;
        }

        public void JoinCourse(Course courseToJoin)
        {
            if (courseToJoin.Students.Count >= courseToJoin.MaxCapacity)
            {
                Console.WriteLine("Sorry the course is full, you will be added to the waiting list..");
                courseToJoin.WaitingQueue.Enqueue(this);
            }
            if (this.DroppedOutCourses.Contains(courseToJoin))
            {
                Console.WriteLine("You already dropped out from this course...can't join again");
            }
            else if (!this.Courses.Contains(courseToJoin))
            {
                if (NumOfEnrolledCredits + courseToJoin.NumOfCredits <= 15)
                {
                    this.Courses.Add(courseToJoin);
                    courseToJoin.Students.Add(this);
                    this.NumOfEnrolledCredits += courseToJoin.NumOfCredits;
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
                courseToLeave.Students.Remove(this); // this referes to the student who called the method (student who is leaving the course)

                while (courseToLeave.Students.Count < courseToLeave.MaxCapacity && courseToLeave.WaitingQueue.Count > 0)
                {
                    Student firstStudentInTheQueue = courseToLeave.WaitingQueue.Dequeue();
                    firstStudentInTheQueue.JoinCourse(courseToLeave);

                }
                this.NumOfEnrolledCredits -= courseToLeave.NumOfCredits;
            }
            else
            {
                Console.WriteLine("ERROR....You are not enrolled in this course");
            }
        }
        public void PrintCourses()
        {
            Console.WriteLine("Courses of student {0}", this.Name);
            foreach (var course in this.Courses)
                Console.WriteLine(course.Name);
        }
        public static void PrintTotalNumOfStudents()
        {
            Console.WriteLine("The total number of students in the system are: " + NumOfStudentsInTheSystem);

        }
    }

    class Course
    {
        public string Name;
        public int Duration;
        public int NumOfCredits;
        public int MaxCapacity;
        public List<Student> Students = new List<Student>();
        public Queue<Student> WaitingQueue = new Queue<Student>();

        public Course(string name, int duration, int credits, int maxcapacity)
        {
            this.Name = name;
            this.Duration = duration;
            this.NumOfCredits = credits;
            this.MaxCapacity = maxcapacity;
        }
    }
}
