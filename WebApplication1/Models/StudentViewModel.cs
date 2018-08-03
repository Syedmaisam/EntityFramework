using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StudentViewModel
    {
        public List<Student> getallstudent() {

            StudentDatabaseContext sdc = new StudentDatabaseContext();
            return sdc.students.ToList();

        }

    }
}