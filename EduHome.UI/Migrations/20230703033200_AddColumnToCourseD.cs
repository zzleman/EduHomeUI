using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.UI.Migrations
{
    public partial class AddColumnToCourseD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbourDescription",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "AboutTitle",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "ApplyDescription",
                table: "CourseDetail");

            migrationBuilder.RenameColumn(
                name: "MainTitle",
                table: "CourseDetail",
                newName: "Skill");

            migrationBuilder.RenameColumn(
                name: "MainDescription",
                table: "CourseDetail",
                newName: "Language");

            migrationBuilder.RenameColumn(
                name: "CertificationTitle",
                table: "CourseDetail",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "CertificationDescription",
                table: "CourseDetail",
                newName: "ClassDuration");

            migrationBuilder.RenameColumn(
                name: "ApplyTitle",
                table: "CourseDetail",
                newName: "Assesments");

            migrationBuilder.AddColumn<int>(
                name: "Fee",
                table: "CourseDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "CourseDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Students",
                table: "CourseDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "Students",
                table: "CourseDetail");

            migrationBuilder.RenameColumn(
                name: "Skill",
                table: "CourseDetail",
                newName: "MainTitle");

            migrationBuilder.RenameColumn(
                name: "Language",
                table: "CourseDetail",
                newName: "MainDescription");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "CourseDetail",
                newName: "CertificationTitle");

            migrationBuilder.RenameColumn(
                name: "ClassDuration",
                table: "CourseDetail",
                newName: "CertificationDescription");

            migrationBuilder.RenameColumn(
                name: "Assesments",
                table: "CourseDetail",
                newName: "ApplyTitle");

            migrationBuilder.AddColumn<string>(
                name: "AbourDescription",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutTitle",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplyDescription",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
