using System;

namespace ExDoxy {
    public class Person
    {
        public string Name { get; private set;} = "";
        public int DNI { get; private set;} = 10000000;
    }

    public class Worker : Person
    {
        public double Salary { get; set;} = 0.0;
        public int DNI { get; private set;} = 10000000;
    }

    public class University
    {
        public string Name { get; set;} = "";
        public List<Student> Students { get; set;} = new List<Student>();
        public List<Worker> Workers { get; set;} = new List<Worker>();
        public List<Career> Careers { get; set;} = new List<Career>();

        public void AddStudent (Student newStudent) {
            Students.Add(newStudent);
        } 

        public void AddWorker(Worker newWorker) {
            Workers.Add(newWorker);
        } 

        public void AddCareer (Career newCareer) {
            Careers.Add(myStudent);
        } 
    }

    public class Career
    {
        public string Name { get; set;} = "";
        public List<Student> Students { get; set;} = new List<Student>();
        public List<Teacher> Teachers { get; set;} = new List<Teacher>();
        public List<Curse> Curses { get; set;} = new List<Curse>();

        public void AddStudent (Student newStudent, Enrollment type) {
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

        public enum Enrollment
        {
            Default,
            Custom,
            Disapproved,
        }
    }

    public class Curse
    {
        public string ID { get; private set;} = "";
        public string Name { get; set;} = "";
        public List<Student> Students { get; set;} = new List<Student>();
        public Teacher Teacher { get; set;} = new Teacher();

        public void AddStudent (Student newStudent) {
            Students.Add(newStudent);
        } 
    }

    public class Student : Person
    {
        public double Qualify { get; set;} = 0.0;

        public Student (string name, int dni) {
            Name = name;
            DNI = dni;
        }
    }

    public class Dean : Worker
    {
        public Dean (string name, int dni) {
            Name = name;
            DNI = dni;
        }
    }

    public class Teacher : Worker
    {
        public Teacher (string name, int dni) {
            Name = name;
            DNI = dni;
        }
        public List<Curse> Curses { get; set;} = new List<Curse>();

        public Student Qualify(Student myStudent) {
            Console.WriteLine("enter qualification: ");
            double qualify = double.Parse(Console.ReadLine());
            Student.Qualify = qualify;
            return myStudent;
        } 
    }

    public class Administrative : Worker
    {
        public Administrative (string name, int dni) {
            Name = name;
            DNI = dni;
        }
    }

    public class Concierge : Worker
    {
        public Concierge (string name, int dni) {
            Name = name;
            DNI = dni;
        }
    }
    
    /*
    class Program {
        static void Main(string[] args){
            Student studentOne = new Student("Sony", 65478932);
        }
    }
    */
} 

