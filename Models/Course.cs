using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationProject.Models
{
    public class Course
    {
        public int ID { get; set; }
        [Display(Name = "Numele Cursului")]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$"), Required,
StringLength(50, MinimumLength = 3)]
        public string CourseName { get; set; }
       
        [Display(Name = "Profesor")]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele profesorului trebuie sa fie de forma ' Nume Prenume'"), Required, StringLength(50, MinimumLength = 6)]
        public String Profesor { get; set; }
        [Display(Name = "Numar Credite")]
        public int Nr_credite { get; set; }
        [Display(Name = "Valoare Credit")]
        public int Val_credite { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
