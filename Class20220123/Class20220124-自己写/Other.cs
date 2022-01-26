using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Class1_IntrotoOOP
{
    /*

    - Create a class "Student" that contains few student
    properties like (Name, Birthdate, Nationality)
    and 2 different constructors, one that takes only
    the name and another one that takes all the fields



    - Create another class called "Course", a course has
    a Name, Duration in months, and number of credits.



    - In the Student class, create another property for
    Students called "Courses", which is a list of courses
    that a student is enrolled in



    - In Student class, write two functions, JoinCourse and
    LeaveCourse to handle the enrollment



    - Also write a function PrintAllCourses in Student class



    - Change the Student class so the student can only have
    15 credits of courses at the same time



    Session2:
    -Add a max capacity for each course
    -Add a waitingList for each course
    when a user is tring to join a full course,
    they will be added to this waiting list



    Create a new class "Institute", which contains a list of all courses, list of all students
    Write the following methods:
    - Get a list of all full courses
    - Get a list of all students with max allowed credits
    - list of all students who are in 3 waitlists at least
    - The course with the max number of students: OOP{18}, JS{12}, Algorithm{3}
    - The course with max number of dropouts




    Create a collection (list) in the course to represent the grades of students in this course:Dict<Student,grade>//某个课程的所有学生的对应成绩
    Create a collection in the student to represent the grades of this student in all his courses//某个学生的所有课程对应的成绩
    - Write a function to get the top student in a course
    - Write a function to get the best course (top grade) for a student
    - Write a function to get the GPA (from 0 to 4) of a student
    - Write a function to get the top student (top GPA)



    */
    class Institute
    {
        public List<Course> Courses = new List<Course>();
        public List<Student> Students = new List<Student>();



        public List<Course> GetALsitOfAllFullCourses()
        {
            List<Course> fullCourseList = new List<Course>();
            foreach (var course in Courses)
            {
                if (course.EnrolledStudent.Count == course.Capacity)
                {
                    fullCourseList.Add(course);
                }
            }



            return fullCourseList;
        }



        public List<Student> GetALsitOfAllStudentWithMaxAllowedCredits()
        {
            List<Student> maxAllowedCreditsStudentList = new List<Student>();
            foreach (var student in Students)
            {
                if (student.NumOfEnrolledCredit() == Student.MAX_ALLOW_CREDIT)
                {
                    maxAllowedCreditsStudentList.Add(student);
                }
            }



            return maxAllowedCreditsStudentList;
        }



        public List<Student> ListAllStudentsInThreeWaitlists()
        {
            //solution1:O(n^2)
            //List<Student> studentListInThreeWaitlists = new List<Student>();
            //foreach (var student in Students)
            //{
            // int waitingListCount = 0;
            // foreach (var course in Courses)
            // {
            // if (course.WaitingList.Contains(student))
            // waitingListCount++;
            // }
            // if(waitingListCount >= 3)
            // studentListInThreeWaitlists.Add(student);
            //}



            //return studentListInThreeWaitlists;
            // solution 2: O(n) , iterate only waitingList in courses, dict<student, freq>
            //OOP {{Bob}
            //Algorithm {Bob, Angela, Fulin}
            //Javascript {Angela, Bob}}
            //{Bob, Bob, Angela, Fulin, Angela, Bob}
            //{Bob, 3}
            //{Angela, 2}
            //{fulin, 1}
            Dictionary<Student, int> studentToWaitListDict = new Dictionary<Student, int>();



            List<Student> allCoursesWaitList = new List<Student>();
            foreach (var course in Courses)
            {
                allCoursesWaitList.AddRange(course.WaitingList);

            }
            foreach (var student in allCoursesWaitList)
            {
                if (!studentToWaitListDict.ContainsKey(student))
                {
                    studentToWaitListDict.Add(student, 1);
                }
                else
                {
                    studentToWaitListDict[student]++;
                }
            }



            foreach (var pair in studentToWaitListDict)
            {
                if (pair.Value >= 3)
                    allCoursesWaitList.Add(pair.Key);
            }
            return allCoursesWaitList;
        }



        public Course GetMaxNumOfStudentCours()
        {
            int max = 0;
            Course mostPopularCourse = new Course();
            foreach (var course in Courses)
            {
                if (course.EnrolledStudent.Count > max)
                {
                    max = course.EnrolledStudent.Count;
                    mostPopularCourse = course;
                }

            }
            return mostPopularCourse;
        }



        public Course GetMaxDropoutsCourse()
        {
            Course maxDropoutCourse = new Course();
            List<Course> dropoutCourseList = new List<Course>();
            Dictionary<Course, int> dropoutFreqDict = new Dictionary<Course, int>();
            int maxFreq = 0;
            //iterate all student list, add the dropout courses to dropoutCourseList{OOP, Algorithm, JavaScript, OOP}
            foreach (var student in Students)
                dropoutCourseList.AddRange(student.DropedOutCourse);//{oop,js, oop, js, oop, algorithm}
                                                                    //iterate the dropoutCourseList, put the dropout course and it's frequncy to the dict<Course, freq>
            foreach (var dropuoutCourse in dropoutCourseList)
            {
                if (!dropoutFreqDict.ContainsKey(dropuoutCourse))//{{oop,3},{js,2},{algorithm,1}}
                    dropoutFreqDict.Add(dropuoutCourse, 1);
                else
                    dropoutFreqDict[dropuoutCourse]++;



            }
            //iterate the dropoutFreqDict, find the max freq and the course
            foreach (var freqPair in dropoutFreqDict)
            {
                if (freqPair.Value > maxFreq)
                {
                    maxFreq = freqPair.Value;//3
                    maxDropoutCourse = freqPair.Key;//oop
                }
            }



            return maxDropoutCourse;



            //soluion2: create dropedOutStudentsList in Course class
            //List<student> dropedOutStudents = new List<student>();



        }
    }



    class Student
    {
        public string Name;
        public DateTime Bithdate;
        public string Nationality;
        public List<Course> Courses = new List<Course>();
        public List<Course> DropedOutCourse = new List<Course>();

        public Dictionary<Course, int> courseToGradeDict = new Dictionary<Course, int>();



        public static int NumOfStudentsInTheSyestem;// for whole Student, not specific studnet
        public const int MAX_ALLOW_CREDIT = 15;// const is static by default(for the whole type), Student.MaxAllowedCredits, Don't want to change the value



        public readonly string SIN; // LIKE const: can't change the value, const need the initial value, BUT readonly don't need it. IT'S NOT STATIC by default.



        public static readonly string NameOfInstitute;// for whole type && can't change the value when user input the value



        public Student(string sName)
        {
            this.Name = sName;
        }



        public Student(string sName, DateTime bod, string sNationality)
        {
            this.Name = sName;
            this.Bithdate = bod;
            this.Nationality = sNationality;
            Student.NumOfStudentsInTheSyestem++;
            SIN = Console.ReadLine();
        }



        public Student()
        {



        }



        public void JoinCourse(Course courseToJoin)
        {
            if (courseToJoin.Capacity > courseToJoin.EnrolledStudent.Count)
            {
                if (courseToJoin.WaitingList.Count == 0)
                {
                    if (DropedOutCourse.Contains(courseToJoin))
                    {
                        Console.WriteLine("You already droped out this course, cant join again");
                    }
                    if (!this.Courses.Contains(courseToJoin))
                    {
                        if (NumOfEnrolledCredit() + courseToJoin.Credits <= 15)
                        {
                            this.Courses.Add(courseToJoin);
                            courseToJoin.EnrolledStudent.Add(this);
                        }



                        else
                            Console.WriteLine("You already the max allowed num of credits");



                    }
                    else
                        Console.WriteLine("You are already enrolled in this course");
                }
                else if (this.Name == courseToJoin.WaitingList.Dequeue().Name)
                {
                    Course.EnrolledNum++;
                    courseToJoin.WaitingList.Dequeue();
                }
                else
                {
                    courseToJoin.WaitingList.Enqueue(this);
                    Console.WriteLine("There are {0} people in the waiting list, please wait for avaliable seat", courseToJoin.WaitingList.Count);
                }

            }
            else
            {
                courseToJoin.WaitingList.Enqueue(this);
                Console.WriteLine("You already have added in waiting list, it will be enrolled if there is any avaliable capacity");
            }


        }



        public void LeaveCourse(Course courseToLeave)
        {
            if (this.Courses.Contains(courseToLeave))
            {
                this.Courses.Remove(courseToLeave);
                DropedOutCourse.Add(courseToLeave);




                //When a student droped out, decrease the enrolled number
                //add the first waiting list student into the course
                courseToLeave.EnrolledStudent.Remove(this);
                while (Course.EnrolledNum < courseToLeave.Capacity && courseToLeave.WaitingList.Count > 0)
                {
                    Student firstStudentInWaitingList = courseToLeave.WaitingList.Dequeue();
                    firstStudentInWaitingList.JoinCourse(courseToLeave);
                }


            }
            else
            {
                Console.WriteLine("You haven't enrolled this course");
            }
        }




        public void PrintAllCourses()
        {
            Console.WriteLine("The student Name is {0}", this.Name);
            foreach (var course in Courses)
            {
                Console.WriteLine("The course name is: {0}", this.Courses);
            }
        }



        public int NumOfEnrolledCredit()
        {
            int totalCredit = 0;
            foreach (var course in Courses)
            {
                totalCredit += course.Credits;
            }
            return totalCredit;
        }



        //- Write a function to get the best course (top grade) for a student
        public Course GetTopGrade()
        {
            Course topCourse = new Course();
            int topGrade = 0;
            foreach (var courseToGradePair in courseToGradeDict)
            {
                if (courseToGradePair.Value > topGrade)
                {
                    topGrade = courseToGradePair.Value;
                    topCourse = courseToGradePair.Key;
                }
            }



            return topCourse;
        }



        //- Write a function to get the GPA (from 0 to 4) of a student
        public int GetGPA()
        {
            int gpa = 0;
            foreach (var courseToGradePair in courseToGradeDict)
            {



            }
            return gpa;
        }
    }



    class Course
    {
        public string Name;
        public int Duration;
        public int Credits;
        public int Capacity;
        public static int EnrolledNum;
        public List<Student> EnrolledStudent = new List<Student>();
        public Queue<Student> WaitingList = new Queue<Student>();




        public Dictionary<Student, int> studentToGradeDict = new Dictionary<Student, int>();



        //List<student> dropedOutStudents = new List<student>();



        public Course(String name, int duration, int credit, int capacity)
        {
            this.Name = name;
            this.Duration = duration;
            this.Credits = credit;
            this.Capacity = capacity;
        }



        public Course()
        {



        }



        //- Write a function to get the top student in a course
        public Student GetTopStudent()
        {
            Student topStudent = new Student();
            int topGrade = 0;
            foreach (var studentToGradePair in studentToGradeDict)
            {
                if (studentToGradePair.Value > topGrade)
                {
                    topGrade = studentToGradePair.Value;
                    topStudent = studentToGradePair.Key;
                }
            }



            return topStudent;
        }
    }



    class Car
    {
        //properties(Pascal case/Camel case)(C# CODING Convention)
        public string Make;
        public string Model;
        public int Year;
        public string Color;
        public bool IsRunning;



        //hide in the class whether you write or not with no parameters by default
        //no return type
        //same name with class
        //!every time you create an object, it will call this constructor method firstly.
        //parameter in the constructor can initialize the new object when creating it.
        //--you can have many constructor with different number of parameters
        //--you will disable the default constructor(no parameters one)
        //-- you can write out the default constructor if you need it.
        public Car()
        {



        }



        public void StartEngine()
        {
            Console.WriteLine("Starting the engine of {0} {1} {2}", Year, Make, Model);
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine("The car is now running...");
            }
            else
                Console.WriteLine("The car is already running...");
        }



        //methods
        public void Drive()
        {
            Console.WriteLine("We are driving the car now");
        }



        public void Honk()
        {



        }



        public void StopEngine()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("The car is now stoped...");
            }
            else
                Console.WriteLine("The car is already stoped...");
        }



        public string GetRunningStatus()
        {
            if (IsRunning)
                return "The car is running and ready to drive";
            else
                return "The car is not running, please all StartEngin method...";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //class(type, blueprint, has properties and methods)
            //object (entity, actual instance)
            //new keyword (factory, make a actual instance)



            //2.access modifiers(eg: SIN Access)
            //private: only class can usse inside itself.
            //protected: class and child class
            //internal: only in the namespace
            //anony: property->private(default), class-->(internal)
            //public: everyone



            //3.GetPropertyName/SetPropertyName method



            //4.namespace: whole project



            //5.constructor




            Car car = new Car();
            car.Make = "Mazda";
            car.Model = "CX5";
            car.Year = 2012;
            car.Color = "Red";



            car.StartEngine();
            car.Drive();
            car.StopEngine();



            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Rav4";
            car2.Year = DateTime.Now.Year;
            car2.Color = "Black";



            car2.StartEngine();
            car2.GetRunningStatus();



            Student st1 = new Student("Mike");
            Student st2 = new Student("Chris");




            Course c1 = new Course("OOP", 1, 3, 30);
            Course c2 = new Course("Algorithms", 1, 6, 25);



            st1.Nationality = "Canada";
            st1.Bithdate = new DateTime(1990, 1, 6);



            st1.JoinCourse(c2);



            st2.JoinCourse(c2);



            st1.JoinCourse(c1);



            Institute ins = new Institute();
            ins.GetALsitOfAllFullCourses();



            int x = 10; // create the value in STACK, VALUE TYPE
            Student s3 = new Student("Jay"); //REFERENCE TYPE, s3 is stored in STACK, BUT new student{name: Jay,...etc} stored in HEAP
                                             //string is a REFERENCE TYPE! BUT PASSED BY VALUE TYPE!!!!



            int num = 100;
            Console.WriteLine(num); //100
                                    //ChangeMyNumber(num);
            ChangeMyNumber(ref num);//REF KEY WORD, before ref, you should assign a value, ref之前就知道它的值，out是方法中才知道value?
            Console.WriteLine("The value of num after change is:" + num); //200



            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(3, 10);
            int valueInDictionary;
            if (dict.TryGetValue(3, out valueInDictionary))// TryGetValue returns bool value, but if you want to keep the value when it exists, you can use out KEY WORKD to store the value.
                Console.WriteLine(valueInDictionary);
            else
                Console.WriteLine("The key doesn't exist!");



            Console.ReadKey();
        }



        public static void ChangeMyNumber(ref int num)// will KEEP the NEW value
        {
            num = 200;
            Console.WriteLine(num);//200 WRONG, 100 CORECT
        }




    }
}