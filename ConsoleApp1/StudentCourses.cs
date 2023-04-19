using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestKalan.Models;

namespace ConsoleApp1
{
    public class StudentCourses
    {
        public int Id { get; set; }


        [ForeignKey("student")]
        public int StudentId { get; set; }

        [ForeignKey("course")]
        public int CourseId { get; set; }

        public Course course { get; set; }

        public Student student { get; set; }
    }
}
