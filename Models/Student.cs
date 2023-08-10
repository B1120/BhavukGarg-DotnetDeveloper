using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BhavukGarg_DotnetDeveloper.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int RollNo { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public double Percentage { get; set; }
    }
}