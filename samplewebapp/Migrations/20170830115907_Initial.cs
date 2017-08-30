using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace samplewebapp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicYear",
                columns: table => new
                {
                    AcademicYearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(type: "int", nullable: false),
                    YearCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicYear", x => x.AcademicYearId);
                });

            migrationBuilder.CreateTable(
                name: "College",
                columns: table => new
                {
                    CollegeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CollegName = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CollegeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_College", x => x.CollegeId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "StudentEnrollment",
                columns: table => new
                {
                    StudentEnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcademicYearId = table.Column<int>(type: "int", nullable: false),
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    EnrolledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrollment", x => x.StudentEnrollmentId);
                    table.ForeignKey(
                        name: "FK_StudentEnrollment_AcademicYear_AcademicYearId",
                        column: x => x.AcademicYearId,
                        principalTable: "AcademicYear",
                        principalColumn: "AcademicYearId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentEnrollment_College_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "College",
                        principalColumn: "CollegeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentEnrollment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentEnrollment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollment_AcademicYearId",
                table: "StudentEnrollment",
                column: "AcademicYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollment_CollegeId",
                table: "StudentEnrollment",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollment_CourseId",
                table: "StudentEnrollment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollment_StudentId",
                table: "StudentEnrollment",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentEnrollment");

            migrationBuilder.DropTable(
                name: "AcademicYear");

            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
