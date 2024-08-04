using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yasapp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class minorchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserIdent",
                table: "WeeklyPlanner");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "WeeklyPlanner");

            migrationBuilder.DropColumn(
                name: "UserIdent",
                table: "PlannerTask");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "PlannerTask");

            migrationBuilder.DropColumn(
                name: "UserIdent",
                table: "MonthlyPlanning");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "MonthlyPlanning");

            migrationBuilder.DropColumn(
                name: "UserIdent",
                table: "DailyPlanner");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "DailyPlanner");

            migrationBuilder.RenameColumn(
                name: "StudentMailAdress",
                table: "Student",
                newName: "StudentMailAddress");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Student",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "StudentMailAddress",
                table: "Student",
                newName: "StudentMailAdress");

            migrationBuilder.AddColumn<Guid>(
                name: "UserIdent",
                table: "WeeklyPlanner",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "WeeklyPlanner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserIdent",
                table: "PlannerTask",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "PlannerTask",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserIdent",
                table: "MonthlyPlanning",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "MonthlyPlanning",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserIdent",
                table: "DailyPlanner",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "DailyPlanner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
