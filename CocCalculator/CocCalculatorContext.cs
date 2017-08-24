using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CocCalculator.Domain;
using Microsoft.EntityFrameworkCore;

namespace CocCalculator.Database
{
    public class CocCalculatorContext : DbContext
    {
        public CocCalculatorContext(DbContextOptions<CocCalculatorContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>()
                .HasKey(b => b.Id).HasName("BuildingId");
            modelBuilder.Entity<Building>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<BuildingUpgrade>()
                .HasKey(k => new { k.BuildingId, k.Level });

            modelBuilder.Entity<Troop>()
                .HasKey(b => b.Id).HasName("TroopId");
            modelBuilder.Entity<Troop>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<TroopResearch>()
                .HasKey(k => new { k.TroopId, k.Level });

        }
        
        #region DbSet
        public DbSet<Building> Buildings { get; set; }
        public DbSet<BuildingUpgrade> BuildingUpgrades { get; set; }
        public DbSet<Troop> Troops { get; set; }
        public DbSet<TroopResearch> TroopResearches { get; set; }
        #endregion
    }
}
