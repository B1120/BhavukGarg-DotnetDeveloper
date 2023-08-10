using BhavukGarg_DotnetDeveloper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BhavukGarg_DotnetDeveloper
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("connectionStrg") 
        { }
        public DbSet<Student> Students { get; set; }
    }
}