using Microsoft.EntityFrameworkCore.Migrations;

namespace mmaCrudPin.Migrations
{
    public partial class recordAndAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "worth_salary",
                table: "mmaFighters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "age",
                table: "mmaFighters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mma_record",
                table: "mmaFighters",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "mmaFighters");

            migrationBuilder.DropColumn(
                name: "mma_record",
                table: "mmaFighters");

            migrationBuilder.AlterColumn<string>(
                name: "worth_salary",
                table: "mmaFighters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
