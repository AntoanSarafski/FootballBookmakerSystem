using Microsoft.VisualBasic;
using P01_StudentSystem.P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }

        public ICollection<Homework> Homeworks { get; set; }
    }
}
