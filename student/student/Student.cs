using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Course { get; set; }
        public int WorkExpirience { get; set; }


        private int SoftSkillsEstimation(int patience, int endurance, int ingenuity)
        {
            return patience + endurance + ingenuity;
        }

        public int CommonEstimation(int patience, int endurance, int ingenuity, int hardSkills)
        {
            return SoftSkillsEstimation(patience, endurance, ingenuity) + hardSkills;
        }

        public int CommonEstimation(int hardSkills)
        {
            return hardSkills;
        }

    }
}

