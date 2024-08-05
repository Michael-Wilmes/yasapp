using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yasapp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initalmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    DurationText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlannedEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RealEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationValidTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditPoints = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyProgram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyPlanner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyMonth = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyPlanner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyPlanner_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyProgramId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_StudyProgram_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExaminationId = table.Column<int>(type: "int", nullable: false),
                    PlannedExamination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfExamintation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReachedExaminationGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ECTSPointsReached = table.Column<bool>(type: "bit", nullable: false),
                    ModuleECTSPoints = table.Column<int>(type: "int", nullable: false),
                    StudyProgramId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Module_Examination_ExaminationId",
                        column: x => x.ExaminationId,
                        principalTable: "Examination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Module_StudyProgram_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyProgram",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentStudyProgram",
                columns: table => new
                {
                    StudentsId = table.Column<int>(type: "int", nullable: false),
                    StudyProgramsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStudyProgram", x => new { x.StudentsId, x.StudyProgramsId });
                    table.ForeignKey(
                        name: "FK_StudentStudyProgram_Student_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentStudyProgram_StudyProgram_StudyProgramsId",
                        column: x => x.StudyProgramsId,
                        principalTable: "StudyProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyPlanner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeekEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeekGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyPlannerId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyPlanner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeeklyPlanner_MonthlyPlanner_MonthlyPlannerId",
                        column: x => x.MonthlyPlannerId,
                        principalTable: "MonthlyPlanner",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WeeklyPlanner_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContactModule",
                columns: table => new
                {
                    ContactsId = table.Column<int>(type: "int", nullable: false),
                    ModulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactModule", x => new { x.ContactsId, x.ModulesId });
                    table.ForeignKey(
                        name: "FK_ContactModule_Contact_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactModule_Module_ModulesId",
                        column: x => x.ModulesId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleItem_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleStudent",
                columns: table => new
                {
                    ModulesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleStudent", x => new { x.ModulesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_ModuleStudent_Module_ModulesId",
                        column: x => x.ModulesId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleStudent_Student_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyPlanner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    WeeklyPlannerId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyPlanner_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DailyPlanner_WeeklyPlanner_WeeklyPlannerId",
                        column: x => x.WeeklyPlannerId,
                        principalTable: "WeeklyPlanner",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlannerTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CompletedPercentage = table.Column<int>(type: "int", nullable: false),
                    PlannedStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DailyPlannerId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannerTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannerTask_DailyPlanner_DailyPlannerId",
                        column: x => x.DailyPlannerId,
                        principalTable: "DailyPlanner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlannerTask_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_StudyProgramId",
                table: "Contact",
                column: "StudyProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactModule_ModulesId",
                table: "ContactModule",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyPlanner_StudentId",
                table: "DailyPlanner",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyPlanner_WeeklyPlannerId",
                table: "DailyPlanner",
                column: "WeeklyPlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_ExaminationId",
                table: "Module",
                column: "ExaminationId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_StudyProgramId",
                table: "Module",
                column: "StudyProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleItem_ModuleId",
                table: "ModuleItem",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleStudent_StudentsId",
                table: "ModuleStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyPlanner_StudentId",
                table: "MonthlyPlanner",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannerTask_DailyPlannerId",
                table: "PlannerTask",
                column: "DailyPlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannerTask_StudentId",
                table: "PlannerTask",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudyProgram_StudyProgramsId",
                table: "StudentStudyProgram",
                column: "StudyProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlanner_MonthlyPlannerId",
                table: "WeeklyPlanner",
                column: "MonthlyPlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlanner_StudentId",
                table: "WeeklyPlanner",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactModule");

            migrationBuilder.DropTable(
                name: "ModuleItem");

            migrationBuilder.DropTable(
                name: "ModuleStudent");

            migrationBuilder.DropTable(
                name: "PlannerTask");

            migrationBuilder.DropTable(
                name: "StudentStudyProgram");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "DailyPlanner");

            migrationBuilder.DropTable(
                name: "Examination");

            migrationBuilder.DropTable(
                name: "StudyProgram");

            migrationBuilder.DropTable(
                name: "WeeklyPlanner");

            migrationBuilder.DropTable(
                name: "MonthlyPlanner");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
