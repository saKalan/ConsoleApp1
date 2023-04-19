using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestKalan.Models;

namespace ConsoleApp1
{
    public class Women
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("student")]
        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}
