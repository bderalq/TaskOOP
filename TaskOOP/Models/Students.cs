using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP.Models
{
    internal class Students
    {
        // student class 
        public string Student(string name, string major, double gpa)
        {
            return "Name is : " + name + 
                ". Major is : " + major + 
                ". GPA is : " + gpa;
        } 

        // inheritance 
        public string GraduateStudent(string name, string major, double gpa, string dissertation, string award)
        {
            return "Name is : " + name +
                 ". Major is : " + major +
                ". GPA is = " + gpa +
                ". Dissertation Title : " + dissertation +
                ". Award Title : ";
        }
    }
}
