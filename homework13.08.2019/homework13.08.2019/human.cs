using System;
using System.Collections.Generic;
using System.Text;

namespace homework13._08._2019
{
    class Human
    {
        protected string FirstName;
        protected string LastName;
        protected string BDate;
        public Human(string firsName,string lastName,string bDate)
        {
            FirstName = firsName;
            LastName = lastName;
            BDate = bDate;
        }
        public virtual string GetInfo()
        {
            return string.Format("First Name: {0}, Last Name: {1}, Birth date : {2}",FirstName, LastName, BDate);
        }
    }
    class Abiturient : Human
    {
        protected int Zno1;
        protected int Zno2;
        protected int Zno3;
        protected double Atestat;
        public Abiturient(string firsName, string lastName, string bDate, int zno1, int zno2, int zno3, double atestat) :
            base(firsName,lastName,bDate)
        {
            Zno1 = zno1;
            Zno2 = zno2;
            Zno3 = zno3;
            Atestat = atestat;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " |||" + " ZNO1: " + Zno1 + " |||" + " ZNO2: " + Zno2 + " |||" + " ZNO3: " + Zno3 + " |||" + " Бал документа про освіту: " + Atestat + "|||";
        }
       
    }
    class Student : Human
    {
        protected int Course;
        protected string Group;
        protected string Faculty;
        protected string Univercity;
        public Student(string firsName, string lastName, string bDate,int course,string group,string faculty,string university) :
            base(firsName, lastName, bDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            Univercity = university;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " |||" + " Course: " + Course + " |||" + " Group: " + Group + " |||" + " Faculty: " + Faculty + " |||" + " University: " + Univercity + "|||";
        }
    }
    class Teacher : Human
    {
        protected string Post;
        protected string Department;
        protected string University;
        public Teacher(string firsName, string lastName, string bDate,string post,string department,string university):
            base(firsName, lastName, bDate)
        {
            Post = post;
            Department = department;
            University = university;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " |||" + " Post: " + Post + " |||" + " Department: " + Department + " |||" + " University: " + University + "|||";
        }
    }
}
