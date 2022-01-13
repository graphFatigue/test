using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    static class MyExtensions
    {
        public static void CountSalary(this Employer employer, int index)
        {
            Random rnd = new Random();
            int value = rnd.Next(1000, 2000);
            Console.WriteLine("Salary for " + (employer.Employee[index]).Name + ' '+ (employer.Employee[index]).Surname + " = " + value);
        }
    }
}
