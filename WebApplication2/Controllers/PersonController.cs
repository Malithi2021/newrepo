using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    
    public class PersonController : Controller
    {
        
        public ActionResult Index()
        {
            var people = new List<Person>();
            people.Add(new Person() { No=1,Name="Malithi", LastName="Perera" , Age=21, Dept="it" , Salary=2000});
            people.Add(new Person() { No = 2, Name = "Malithi", LastName = "Perera", Age = 21, Dept = "it", Salary = 2000 });
            people.Add(new Person() { No = 3, Name = "Malithi", LastName = "Perera", Age = 21, Dept = "it", Salary = 2000 });
            people.Add(new Person() { No = 4, Name = "Malithi", LastName = "Perera", Age = 21, Dept = "it", Salary = 2000 });
            people.Add(new Person() { No = 5, Name = "Malithi", LastName = "Perera", Age = 21, Dept = "it", Salary = 2000 });
            people.Add(new Person() { No = 6, Name = "Malithi", LastName = "Perera", Age = 21, Dept = "it", Salary = 2000 });
            return View(people);
        }

        public ActionResult CreateNew()
        {
           
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
    

   
}