using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.UI.Migrations
{
    public partial class CreatteCourseDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "courseDetailId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbourDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplyTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDetail_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_courseDetailId",
                table: "Courses",
                column: "courseDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetail_EventId",
                table: "CourseDetail",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseDetail_courseDetailId",
                table: "Courses",
                column: "courseDetailId",
                principalTable: "CourseDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseDetail_courseDetailId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CourseDetail");

            migrationBuilder.DropIndex(
                name: "IX_Courses_courseDetailId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "courseDetailId",
                table: "Courses");
        }
    }
}
