using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{



    public class Program
        {
            public static void Main(string[] args)
            {
                var student1 = new Student() { Name = "Kto", Age = 54, Surname = "Nikto", WorkExpirience = 2, Course = 3};
                var student2 = new Student() { Name = "Dead", Age = 9, Surname = "Inside", WorkExpirience = 0, Course = 1 };
                var student3 = new Student() { Name = "Kaneki", Age = 18, Surname = "Kent", WorkExpirience = 3, Course = 5 };
                var student4 = new Student() { Name = "Lelouch", Age = 17, Surname = "Lamperouge", WorkExpirience = 0, Course = 1 };
                var student5 = new Student() { Name = "Dot", Age = 54, Surname = "Net", WorkExpirience = 7, Course = 6 };
                var student6 = new Student() { Name = "Lagami", Age = 17, Surname = "Jiait", WorkExpirience = 0, Course = 1 };
                var employer = new Employer("Animeshnik");
                employer.AddEmployee(student2);
                employer.AddEmployee(student4);
                employer.AddEmployee(student1);
                employer.AddEmployee(student6);
            foreach (var worker in employer.Employee)
                {
                    employer.CountSalary(employer.Employee.IndexOf(worker));
                }
        }
        }
}
