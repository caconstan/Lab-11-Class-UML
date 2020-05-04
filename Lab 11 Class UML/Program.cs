using System;
using System.Collections.Generic;

namespace Lab_11_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Person> personList = new List<Person>
            {
                new Student("Annie","12 Maple Lane","English", 2019, 100),
                new Student("Bobbie","1223 Maple Lane","Sports Education", 2018, 150),
                new Student("Charlie","15 Oak St.","Mathematics", 2017, 200),
                new Staff("Darren","324 Juniper Lane", "School of Arts & Sciences", 90000),
                new Staff("Elena","45 Main St","School of Engineering", 100000)
            };

            foreach (Person p in personList)
            {
                Console.WriteLine( p.ToString() );
            }
        }
    }

    class Staff : Person
    {
        private string school = "University of Michigan"; // GO BLUE!!!
        private double pay = 1000000; // expect the best :D

        public string School { get; set; }
        public double Pay { get; set; }

        public Staff()
        {
            //default constructor
        }
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }

        public override string ToString()
        {
            return "Staff[" + base.ToString() + ",school=" + School + ",pay=" + Pay + "]";
        }
    }

    class Student : Person
    {
        private string program = "Computer Science";
        private int year = 2020;
        private double fee = 100.00;

        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student()
        {
            //default constructor
        }
        public Student(string name, string address, string program,int year, double fee) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public override string ToString()
        {
            return "Student[" + base.ToString() + ",program=" + Program + ",year=" + Year + ",fee=" + Fee + "]";
        }
    }
    class Person
    {
        private string name = "John Doe";
        private string address = "101 Main St.";
        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {
            //default constructor
        }
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public override string ToString()
        {
            return "Person[name=" + Name + ",address=" + Address + "]";
        }
    }
}
