using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace WebApplication1.Models
{
    public class StudentDatabaseContext : DbContext 
    {
      public DbSet<Student> students { get; set; }
    }
}