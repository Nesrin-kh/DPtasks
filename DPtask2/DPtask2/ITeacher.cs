using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    internal interface ITeacher
    {
        void Show();
    }

    class Teacher : ITeacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Teacher Name: " + Name);
        }
    }

    // Decorator Base
    abstract class TeacherDecorator : ITeacher
    {
        protected ITeacher teacher;

        public TeacherDecorator(ITeacher teacher)
        {
            this.teacher = teacher;
        }

        public virtual void Show()
        {
            teacher.Show();
        }
    }

    // Salary Decorator
    class SalaryDecorator : TeacherDecorator
    {
        private double salary;

        public SalaryDecorator(ITeacher teacher, double salary) : base(teacher)
        {
            this.salary = salary;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Salary: " + salary);
        }
    }

    // Nationality Decorator
    class NationalityDecorator : TeacherDecorator
    {
        private string nationality;

        public NationalityDecorator(ITeacher teacher, string nationality) : base(teacher)
        {
            this.nationality = nationality;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Nationality: " + nationality);
        }
    }

    // Street Decorator
    class StreetDecorator : TeacherDecorator
    {
        private string street;

        public StreetDecorator(ITeacher teacher, string street) : base(teacher)
        {
            this.street = street;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Street: " + street);
        }
    }
}
