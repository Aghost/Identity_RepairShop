using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace Razor_Identity.Pages.Parts
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public IndexModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Part> Part { get;set; }

        public async Task OnGetAsync()
        {
            Part = await _context.Parts.ToListAsync();
        }
    }
}
