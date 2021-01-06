using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationProject.Data;
using WebApplicationProject.Models;

namespace WebApplicationProject.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly WebApplicationProject.Data.WebApplicationProjectContext _context;

        public CreateModel(WebApplicationProject.Data.WebApplicationProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CourseID"] = new SelectList(_context.Set<Course>(), "ID", "CourseName");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
