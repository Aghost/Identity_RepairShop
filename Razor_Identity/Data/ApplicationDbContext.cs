using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Razor_Identity.Models;

namespace Razor_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartList> PartLists { get; set; }
        public DbSet<RepairOrder> RepairOrders { get; set; }
    }
}
