using System;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Features> features{ get; set; }
        public DbSet<Services> services { get; set; }
    }
}

