using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataAccess_Demo.Models;

namespace DataAccess_Demo.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly DataAccess_Demo.Models.SchoolContext _context;

        public IndexModel(DataAccess_Demo.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
