using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace Razor_Identity.Pages.RepairOrders
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public IndexModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<RepairOrder> RepairOrder { get;set; }

        public async Task OnGetAsync()
        {
            RepairOrder = await _context.RepairOrders
                .Include(r => r.PartList).ToListAsync();
        }
    }
}
