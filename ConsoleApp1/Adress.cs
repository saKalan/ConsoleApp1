using System.ComponentModel.DataAnnotations.Schema;

namespace TestKalan.Models
{
    public class Adress
    {
        [ForeignKey("Student")]
        public int Id { get; set; }
        public string Title { get; set; }  
        public Student Student { get; set; }
        
    }
}
