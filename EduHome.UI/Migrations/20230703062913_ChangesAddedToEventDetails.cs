using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.UI.Migrations
{
    public partial class ChangesAddedToEventDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Speaker_EventDetail_EventDetailId",
                table: "Speaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker");

            migrationBuilder.RenameTable(
                name: "Speaker",
                newName: "Speakers");

            migrationBuilder.RenameIndex(
                name: "IX_Speaker_EventDetailId",
                table: "Speakers",
                newName: "IX_Speakers_EventDetailId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "EventDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MainImgPath",
                table: "EventDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "EventDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "EventDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Speakers_EventDetail_EventDetailId",
                table: "Speakers",
                column: "EventDetailId",
                principalTable: "EventDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Speakers_EventDetail_EventDetailId",
                table: "Speakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "EventDetail");

            migrationBuilder.DropColumn(
                name: "MainImgPath",
                table: "EventDetail");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "EventDetail");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "EventDetail");

            migrationBuilder.RenameTable(
                name: "Speakers",
                newName: "Speaker");

            migrationBuilder.RenameIndex(
                name: "IX_Speakers_EventDetailId",
                table: "Speaker",
                newName: "IX_Speaker_EventDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Speaker_EventDetail_EventDetailId",
                table: "Speaker",
                column: "EventDetailId",
                principalTable: "EventDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
