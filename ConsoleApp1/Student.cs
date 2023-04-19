using ConsoleApp1;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestKalan.Models
{
    public class Student //student ba address yek b yek........ba women chand b chand
    {
       
        public int Id { get; set; }
        public string Name { get; set; }  
        
        public Adress Adress { get; set; }  
        public List<Women> womens { get; set; }
        public List<StudentCourses> courses { get; set; }
    }
}
