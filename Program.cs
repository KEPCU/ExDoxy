using System;

namespace ExDoxy {
    ///Base class for student and worker class
    public class Person
    {
        public string Name { get; private set;} = "";
        int DNI { get; private set;} = 10000000;
    }

    /// Basic class for teachers, administrative staff, cleaning, security, dean, etc.
    public class Worker : Person
    {
        double Salary { get; set;} = 800.0;
    }

    public class University
    {
        public string Name { get; set;} = "";
        List<Student> Students { get; set;} = new List<Student>();
        public List<Worker> Workers { get; set;} = new List<Worker>();
        public List<Career> Careers { get; set;} = new List<Career>();

        void AddStudent (Student newStudent) {
            Students.Add(newStudent);
        } 

        void AddWorker(Worker newWorker) {
            Workers.Add(newWorker);
        } 

        void AddCareer (Career newCareer) {
            Careers.Add(myStudent);
        } 
    }

    public class Career
    {
        public string Name { get; set;} = "";
        List<Student> Students { get; set;} = new List<Student>();
        public List<Teacher> Teachers { get; set;} = new List<Teacher>();
        public List<Curse> Curses { get; set;} = new List<Curse>();

        ///To add a student, it is taken into account if he will take all the courses or not.
        void AddStudent (Student newStudent, Enrollment type) {
            Students.Add(newStudent);
            
            switch (type) {
                case Enrollment.Default: 
                    foreach (var curse in Curses) {
                        curse.AddStudent(newStudent);
                    } 
                    break;
                case Enrollment.Custom: 
                    foreach (var curse in Curses) {
                        curse.AddStudent(newStudent);
                    } 
                    break;
                case Disapproved: 
                    foreach (var curse in Curses) {
                        curse.AddStudent(newStudent);
                    }
                    break;
                default:  
                    break;  
                }
        } 

        ///Enum for determine the type of enrollment and enrollment in courses
        public enum Enrollment
        {
            Default,
            Custom,
            Disapproved,
        }
    }

    public class Syllabus
    {
        public string Title { get; set;} = "";
        public string Authors { get; set;} = "";
        public string Partners { get; set;} = "";
        public DateTime Data { get; set;} = "";
        public List<string> Partners { get; set;} = new List<string>();
    }

    public class Curse
    {
        Syllabus Syllabus;
        public double Credits { get; set;} = 0.0;
        string ID { get; private set;} = "";
        public string Name { get; set;} = "";
        List<Student> Students { get; set;} = new List<Student>();
        public Teacher Teacher { get; set;} = new Teacher();

        void AddStudent (Student newStudent) {
            Students.Add(newStudent);
        } 

        void UpdateSyllabus (Syllabus newSyllabus) {
            Syllabus = newSyllabus;
        } 
    }

    public class Student : Person
    {
        double Qualify { get; set;} = 0.0;
        public double Credits { get; set;} = 0.0;
        public string Email { get; set;} = "example@uni.edu.co";
        List<string> ApprovedCourses { get; set;} = new List<string>();
        List<string> DisapprovedCourses { get; set;} = new List<string>();
        List<string> PendingCourses { get; set;} = new List<string>();

        public Student (string name, int dni, string email) {
            Name = name;
            DNI = dni;
            Email = email;
        }
    }

    public class Rector : Worker
    {
        public string Email { get; set;} = "example@uni.edu.co";
        public Rector (string name, int dni, string email) {
            Name = name;
            DNI = dni;
            Email = email;
        }
    }

    public class Dean : Worker
    {
        string MySschool = "";;
        public string Email { get; set;} = "example@uni.edu.co";
        public Dean (string name, int dni, string email) {
            Name = name;
            DNI = dni;
            Email = email;
        }
    }

    public class Teacher : Worker
    {
        public string Email { get; set;} = "example@uni.edu.co";
        public List<Curse> Curses { get; set;} = new List<Curse>();
        public Teacher (string name, int dni, string email) {
            Name = name;
            DNI = dni;
            Email = email;
        }
    
        public Student Qualify(Student myStudent) {
            Console.WriteLine("enter qualification: ");
            double qualify = double.Parse(Console.ReadLine());
            Student.Qualify = qualify;
            return myStudent;
        } 
    }

    public class Administrative : Worker
    {
        public string Email { get; set;} = "example@uni.edu.co";

        public Administrative (string name, int dni, string email) {
            Name = name;
            DNI = dni;
            Email = email;
        }
    }

    ///Cleaning staff, security, etc.
    public class Concierge : Worker
    {
        public Concierge (string name, int dni) {
            Name = name;
            DNI = dni;
        }
    }
} 

