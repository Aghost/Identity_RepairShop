using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace Razor_Identity.Pages.PartLists
{
    public class DetailsModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public DetailsModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public PartList PartList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PartList = await _context.PartLists.FirstOrDefaultAsync(m => m.Id == id);

            if (PartList == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
