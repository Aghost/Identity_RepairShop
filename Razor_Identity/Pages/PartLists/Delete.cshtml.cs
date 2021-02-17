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
    public class DeleteModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public DeleteModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PartList = await _context.PartLists.FindAsync(id);

            if (PartList != null)
            {
                _context.PartLists.Remove(PartList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
