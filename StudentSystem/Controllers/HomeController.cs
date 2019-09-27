using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentSystem.Models;

namespace StudentSystem.Controllers
{
    public class HomeController : Controller
    {



        public ViewResult Index()
        {
            Student testStudent = new Student("IT", "andrey@mail.ru", "Andrey", true, 4.05, "Paramonov", 301); 
            return View(testStudent);

        }
      
        public ViewResult ListStudent()
        {
            Student bob = new Student("IT", "bob@mail.ru", "Bob", true, 4.05, "Milasovich", 302);
            Student fred = new Student("Mec", "fred@mail.ru", "Fred", false, 3.05, "Fra", 303);
            Student josh = new Student("Hosp", "josh@mail.ru", "Josh", true, 3.55, "Bur", 304);
            Student melissa = new Student("Cook", "melissa@mail.ru", "Melissa", false, 2.95, "Mak", 304);

            List<Student> students = new List<Student>();
            students.Add(bob);
            students.Add(fred);
            students.Add(josh);
            students.Add(melissa);

            return View(students);
        }



    }
}
