using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mmaCrudPin.Migrations
{
    public partial class initalMma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mmaFighters",
                columns: table => new
                {
                    fighterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    figtherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mmaFighters", x => x.fighterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mmaFighters");
        }
    }
}
