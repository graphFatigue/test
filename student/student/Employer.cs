using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Employer
    {
        public string Name { get; set; }
        //public Student[] Employee { get; set; }
        public List<Student> Employee { get; set; } = new List<Student>();

        public Employer(string name)
        {
            Name = name;
        }

        public void AddEmployee(Student student)
        {
            Employee.Add(student);
        }
    }
}
