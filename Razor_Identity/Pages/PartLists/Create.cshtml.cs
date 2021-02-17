using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace Razor_Identity.Pages.PartLists
{
    public class CreateModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public CreateModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PartList PartList { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PartLists.Add(PartList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
