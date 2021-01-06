using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationProject.Models
{
    public class Teacher
    {
        public int ID { get; set; }
     
        public int StudentID { get; set; }
        [Display(Name = "Nr. matricol student")]
        public Student Student { get; set; }
        public int ClassID { get; set; }
        [Display(Name = "Cod sala curs")]
        public Class Class{ get; set; }
        
    }
}
