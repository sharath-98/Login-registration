﻿using LoginApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<SalesLeadEntity> SalesLead { get; set; }
    }
}
