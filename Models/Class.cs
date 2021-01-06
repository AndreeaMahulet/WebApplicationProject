using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationProject.Models
{
    public class Class
    {
        public int ID { get; set; }
        [Display(Name = "Locatii amfiteatre")]
        public String ClassName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data")]
        public DateTime Hours { get; set; }
        [Display(Name = "Ora")]
        public String Time { get; set; }
        [Display(Name = "Numele Cursului")]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$"), Required,
StringLength(50, MinimumLength = 3)]
        public string CourseName { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
