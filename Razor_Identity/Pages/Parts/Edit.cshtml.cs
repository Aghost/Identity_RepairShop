﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace Razor_Identity.Pages.Parts
{
    public class EditModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public EditModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Part Part { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Part = await _context.Parts.FirstOrDefaultAsync(m => m.Id == id);

            if (Part == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Part).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartExists(Part.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PartExists(int id)
        {
            return _context.Parts.Any(e => e.Id == id);
        }
    }
}
