﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClashCalculator.Database.Migrations
{
    [DbContext(typeof(ClashCalculatorContext))]
    partial class CocCalculatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CocCalculator.Domain.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuildingType");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Version");

                    b.HasKey("Id")
                        .HasName("BuildingId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("CocCalculator.Domain.BuildingUpgrade", b =>
                {
                    b.Property<int>("BuildingId");

                    b.Property<int>("Level");

                    b.Property<int>("Amount");

                    b.Property<int>("RequirementLevel");

                    b.Property<int>("Resource");

                    b.Property<long>("TimeInTicks");

                    b.HasKey("BuildingId", "Level");

                    b.ToTable("BuildingUpgrades");
                });

            modelBuilder.Entity("CocCalculator.Domain.Troop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.Property<int>("Version");

                    b.HasKey("Id")
                        .HasName("TroopId");

                    b.ToTable("Troops");
                });

            modelBuilder.Entity("CocCalculator.Domain.TroopResearch", b =>
                {
                    b.Property<int>("TroopId");

                    b.Property<int>("Level");

                    b.Property<int>("Amount");

                    b.Property<int>("DamagePerSecond");

                    b.Property<int>("Hitpoint");

                    b.Property<int>("RequirementLevel");

                    b.Property<int>("Resource");

                    b.Property<long>("TimeInTicks");

                    b.Property<int>("UnitsPerCamp");

                    b.HasKey("TroopId", "Level");

                    b.ToTable("TroopResearches");
                });

            modelBuilder.Entity("CocCalculator.Domain.BuildingUpgrade", b =>
                {
                    b.HasOne("CocCalculator.Domain.Building", "Building")
                        .WithMany("BuildingUpgrades")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CocCalculator.Domain.TroopResearch", b =>
                {
                    b.HasOne("CocCalculator.Domain.Troop", "Troop")
                        .WithMany("TroopResearches")
                        .HasForeignKey("TroopId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
