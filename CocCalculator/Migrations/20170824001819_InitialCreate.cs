using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CocCalculator.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuildingType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BuildingId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Troops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TroopId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingUpgrades",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    RequirementLevel = table.Column<int>(type: "int", nullable: false),
                    Resource = table.Column<int>(type: "int", nullable: false),
                    TimeInTicks = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingUpgrades", x => new { x.BuildingId, x.Level });
                    table.ForeignKey(
                        name: "FK_BuildingUpgrades_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TroopResearches",
                columns: table => new
                {
                    TroopId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DamagePerSecond = table.Column<int>(type: "int", nullable: false),
                    Hitpoint = table.Column<int>(type: "int", nullable: false),
                    RequirementLevel = table.Column<int>(type: "int", nullable: false),
                    Resource = table.Column<int>(type: "int", nullable: false),
                    TimeInTicks = table.Column<long>(type: "bigint", nullable: false),
                    UnitsPerCamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TroopResearches", x => new { x.TroopId, x.Level });
                    table.ForeignKey(
                        name: "FK_TroopResearches_Troops_TroopId",
                        column: x => x.TroopId,
                        principalTable: "Troops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingUpgrades");

            migrationBuilder.DropTable(
                name: "TroopResearches");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Troops");
        }
    }
}
