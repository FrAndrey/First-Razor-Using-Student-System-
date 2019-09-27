using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public string CourseCode { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool FullTime { get; set; }
        public double Gpa { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }

        public Student (string course,string email,string first, bool full,double gppaa, string lastname,int id)
        {
            CourseCode = course;
            Email = email;
            FirstName = first;
            FullTime = full;
            Gpa = gppaa;
            LastName = lastname;
            StudentId = id;
        }
    }
}
