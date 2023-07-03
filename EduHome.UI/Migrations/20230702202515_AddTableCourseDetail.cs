using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.UI.Migrations
{
    public partial class AddTableCourseDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetail_Events_EventId",
                table: "CourseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseDetail_courseDetailId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_courseDetailId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseDetail_EventId",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "courseDetailId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "CourseDetail",
                newName: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetail_CourseId",
                table: "CourseDetail",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetail_Courses_CourseId",
                table: "CourseDetail",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetail_Courses_CourseId",
                table: "CourseDetail");

            migrationBuilder.DropIndex(
                name: "IX_CourseDetail_CourseId",
                table: "CourseDetail");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseDetail",
                newName: "EventId");

            migrationBuilder.AddColumn<int>(
                name: "courseDetailId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_courseDetailId",
                table: "Courses",
                column: "courseDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetail_EventId",
                table: "CourseDetail",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetail_Events_EventId",
                table: "CourseDetail",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseDetail_courseDetailId",
                table: "Courses",
                column: "courseDetailId",
                principalTable: "CourseDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
