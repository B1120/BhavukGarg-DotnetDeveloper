using BhavukGarg_DotnetDeveloper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BhavukGarg_DotnetDeveloper.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Student
        public ActionResult Index(string searchString, string sortData)
        {
            ViewBag.ClassNameSortParm = String.IsNullOrEmpty(sortData) ? "ClassName_Asc" : "";
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortData) ? "FirstName_Desc" : "FirstName_Asc";
            ViewBag.LastNameSortParm = String.IsNullOrEmpty(sortData) ? "LastName_Desc" : "LastName_Asc";
            var studentList = from s in _context.Students
                              select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                studentList = studentList.Where(s => s.ClassName.Contains(searchString) || s.FirstName.Contains(searchString) || s.LastName.Contains(searchString));
            }
            switch (sortData)
            {
                case "ClassName_Asc":
                    studentList = studentList.OrderBy(x => x.ClassName);
                    break;
                case "FirstName_Asc":
                    studentList = studentList.OrderBy(x => x.FirstName);
                    break;
                case "FirstName_Desc":
                    studentList = studentList.OrderByDescending(x => x.FirstName);
                    break;
                case "LastName_Asc":
                    studentList = studentList.OrderBy(x => x.LastName);
                    break;
                case "LastName_Desc":
                    studentList = studentList.OrderByDescending(x => x.LastName);
                    break;
                default:
                    studentList = studentList.OrderBy(x => x.ClassName);
                    break;
            }
            return View(studentList);
        }
    }
}