using System;
using Microsoft.EntityFrameworkCore;
using PITONChallenge.Entity.Concrete;

namespace PITONChallenge.DataAccess
{
	public class Context : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=362412;Host=localhost;Port=1224;Database=PitonDb;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<MissionCategory> MissionCategories { get; set; }
        

    }
}

