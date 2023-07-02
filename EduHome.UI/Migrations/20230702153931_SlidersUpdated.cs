using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.UI.Migrations
{
    public partial class SlidersUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "More",
                table: "Sliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "More",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
