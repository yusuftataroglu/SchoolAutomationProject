using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAutomationProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Capacity = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCourses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MobilePhone = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    WorkPhone = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    GraduatedSchool = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false),
                    IsPreRegistered = table.Column<bool>(type: "bit", nullable: false),
                    TotalAbsenceCount = table.Column<short>(type: "smallint", nullable: true),
                    ContinuationStatus = table.Column<int>(type: "int", nullable: true),
                    ClassroomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassroomMainCourses",
                columns: table => new
                {
                    ClassroomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomMainCourses", x => new { x.ClassroomId, x.MainCourseId });
                    table.ForeignKey(
                        name: "FK_ClassroomMainCourses_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassroomMainCourses_MainCourses_MainCourseId",
                        column: x => x.MainCourseId,
                        principalTable: "MainCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCourses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    WeeklyHour = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    MainCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCourses_MainCourses_MainCourseId",
                        column: x => x.MainCourseId,
                        principalTable: "MainCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MainCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teachers_MainCourses_MainCourseId",
                        column: x => x.MainCourseId,
                        principalTable: "MainCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Achievements_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DiscontinuedStudents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscontinuedStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscontinuedStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentStudents",
                columns: table => new
                {
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentStudents", x => new { x.ParentId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_ParentStudents_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttendanceStatus = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attendances_SubCourses_SubCourseId",
                        column: x => x.SubCourseId,
                        principalTable: "SubCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    ExamNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Grades_SubCourses_SubCourseId",
                        column: x => x.SubCourseId,
                        principalTable: "SubCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassroomTeachers",
                columns: table => new
                {
                    ClassroomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomTeachers", x => new { x.ClassroomId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_ClassroomTeachers_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassroomTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    TimeSlot = table.Column<byte>(type: "tinyint", nullable: false),
                    Classroom = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSchedules_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5836daf9-1a03-4190-872a-4fdc42cf4a50", null, "Admin", "ADMIN" },
                    { "86e143a4-b96a-4821-9dad-28747c241f22", null, "Student", "STUDENT" },
                    { "bd6a6979-cbb1-4c4a-93f0-19a73a3cdcfc", null, "Teacher", "TEACHER" },
                    { "bdac7a93-f4a4-4d94-a5ab-b4e6ccc7643f", null, "Parent", "PARENT" }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Capacity", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(5810), "192.168.1.3", "10-A", null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(5808), "192.168.1.2", "9-B", null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(5802), "192.168.1.1", "9-A", null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(5812), "192.168.1.4", "10-B", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3711), "192.168.1.1", "Matematik", null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3719), "192.168.1.2", "Türkçe", null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3721), "192.168.1.3", "Biyoloji", null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3723), "192.168.1.4", "Fizik", null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3726), "192.168.1.5", "Kimya", null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3728), "192.168.1.6", "Tarih", null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3741), "192.168.1.7", "Coğrafya", null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3743), "192.168.1.8", "İngilizce", null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3746), "192.168.1.9", "Müzik", null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(3749), "192.168.1.10", "Görsel Sanatlar", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5872), "192.168.1.3", "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5886), "192.168.1.8", "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5878), "192.168.1.5", "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5869), "192.168.1.2", "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5876), "192.168.1.4", "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5888), "192.168.1.9", "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5882), "192.168.1.6", "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5884), "192.168.1.7", "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5891), "192.168.1.10", "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(5865), "192.168.1.1", "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(7229), "192.168.1.5", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(7227), "192.168.1.4", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(7220), "192.168.1.2", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(7213), "192.168.1.1", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(7225), "192.168.1.3", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ClassroomMainCourses",
                columns: new[] { "ClassroomId", "MainCourseId" },
                values: new object[,]
                {
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("77777777-7777-7777-7777-777777777777") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("99999999-9999-9999-9999-999999999999") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("77777777-7777-7777-7777-777777777777") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("99999999-9999-9999-9999-999999999999") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("77777777-7777-7777-7777-777777777777") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("99999999-9999-9999-9999-999999999999") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("77777777-7777-7777-7777-777777777777") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("99999999-9999-9999-9999-999999999999") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassroomId", "ContinuationStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "FirstName", "GPA", "Gender", "GraduatedSchool", "IsPreRegistered", "LastName", "RegistrationNumber", "TotalAbsenceCount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8794), "192.168.1.11", "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", "110-24", null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8769), "192.168.1.6", "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", "105-24", null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8733), "192.168.1.1", "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", "100-24", null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8773), "192.168.1.7", "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", "106-24", null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8799), "192.168.1.12", "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", "111-24", null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8777), "192.168.1.8", "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", "107-24", null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8789), "192.168.1.10", "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", "109-24", null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8751), "192.168.1.4", "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", "103-24", null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8765), "192.168.1.5", "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", "104-24", null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8740), "192.168.1.2", "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", "101-24", null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8748), "192.168.1.3", "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", "102-24", null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(8783), "192.168.1.9", "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", "108-24", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(29), "192.168.1.13", new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1), "192.168.1.2", new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(36), "192.168.1.16", new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(31), "192.168.1.14", new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(14), "192.168.1.7", new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3), "192.168.1.3", new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(22), "192.168.1.10", new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(39), "192.168.1.17", new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(45), "192.168.1.19", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(27), "192.168.1.12", new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(18), "192.168.1.9", new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(42), "192.168.1.18", new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(8), "192.168.1.5", new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(6), "192.168.1.4", new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(34), "192.168.1.15", new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(25), "192.168.1.11", new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(11), "192.168.1.6", new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(9996), "192.168.1.1", new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(16), "192.168.1.8", new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(47), "192.168.1.20", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "FirstName", "LastName", "MainCourseId", "Title", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1299), "192.168.1.5", "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1307), "192.168.1.10", "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Uzman Öğretmen", null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1310), "192.168.1.11", "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1286), "192.168.1.2", "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1295), "192.168.1.4", "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1290), "192.168.1.3", "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1279), "192.168.1.1", "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1316), "192.168.1.13", "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1312), "192.168.1.12", "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Başöğretmen", null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1318), "192.168.1.14", "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Uzman Öğretmen", null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(1304), "192.168.1.6", "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("05d72949-c784-4e94-b718-87241134a40a"), "Computer47", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2630), "192.168.1.37", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("07b91ac4-5631-4fbe-a9df-3670f7820936"), "Computer30", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2540), "192.168.1.80", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("07ec2f43-6909-4f74-919c-65e31e6ccb23"), "Computer23", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2503), "192.168.1.94", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("0b06e9b2-876e-4102-94db-4863cc5658fb"), "Computer43", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2612), "192.168.1.44", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("0b8b1fc4-8945-4f8d-9038-182e05580e89"), "Computer40", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2589), "192.168.1.18", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("0fc1f110-d994-46e6-bb1a-2c6ec44ea21d"), "Computer8", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2375), "192.168.1.43", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("1372ac45-7122-4821-babf-890948b609d2"), "Computer21", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2494), "192.168.1.82", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("1703fc84-6f65-4266-9bcd-ba3b82502a55"), "Computer59", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2687), "192.168.1.74", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("2788eba4-29a5-426a-a364-a9fb87f7e79b"), "Computer17", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2474), "192.168.1.98", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("28229f56-10ab-46fb-ad42-b749a668677e"), "Computer57", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2677), "192.168.1.35", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("2883ead2-f95d-4320-8642-d036a7320372"), "Computer27", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2523), "192.168.1.57", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("2e392cab-8564-4460-bd66-71ba771dbd4f"), "Computer51", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2650), "192.168.1.3", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("2ea43fe2-b693-443a-9c1b-3e72a0c57b38"), "Computer41", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2600), "192.168.1.16", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("31b82d6f-b394-4399-b408-45528a97bf29"), "Computer15", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2437), "192.168.1.85", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("35595510-b6be-407f-b92e-3c380d6148dd"), "Computer13", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2428), "192.168.1.51", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("38d48d77-3e35-425e-9d14-6d87b7e42a8f"), "Computer50", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2644), "192.168.1.84", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("42cb69cb-c8dc-4810-9c3c-ed377784d56d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2333), "192.168.1.50", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("4bf92112-2047-460e-ad4c-2dff5ef72411"), "Computer42", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2605), "192.168.1.67", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("4f711458-f77d-412a-92c1-7bc9401b5dde"), "Computer6", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2366), "192.168.1.65", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("5035774b-d798-488f-8458-e69ff569a59f"), "Computer31", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2545), "192.168.1.41", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("5478f20d-6d2e-4681-a61c-2054597bd219"), "Computer10", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2385), "192.168.1.26", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("54f73fcc-224e-4a56-a063-476097d1fa54"), "Computer35", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2566), "192.168.1.89", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("611bec3d-71da-44e3-9207-29bd811bbc8c"), "Computer55", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2668), "192.168.1.14", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("64bd2a90-0fb8-4bd2-ad80-a33caffaed66"), "Computer9", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2380), "192.168.1.89", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("65498a32-e16b-4c46-bba8-1a22dd8a3984"), "Computer24", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2508), "192.168.1.23", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("68618fae-44ce-4b03-b30e-3a7dd240f1ba"), "Computer26", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2517), "192.168.1.20", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("68a732d7-5904-48af-bf0f-e2de371c2cfa"), "Computer56", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2672), "192.168.1.73", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("6e64b48f-3521-4e6a-87d3-21bd0bdb828a"), "Computer12", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2402), "192.168.1.29", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("6efa88e1-036a-4f99-8618-3fad1640fa85"), "Computer39", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2584), "192.168.1.22", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("73e0fb7c-28d3-431c-a0a5-5398e637c4e5"), "Computer22", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2499), "192.168.1.65", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("782655c8-cd21-4ae2-b144-3e5db079eece"), "Computer28", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2528), "192.168.1.56", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("7a08a31d-4228-4474-b70a-9360bb29f933"), "Computer20", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2490), "192.168.1.61", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("82541ed3-1eed-4fb7-92b1-2063a89aaeaa"), "Computer58", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2681), "192.168.1.50", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("831bc5f3-289c-4d3d-baf9-c3d59f93ef82"), "Computer34", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2559), "192.168.1.3", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("8473d110-cc98-407b-b544-5e1623864f68"), "Computer49", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2639), "192.168.1.21", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("85034fde-fbca-40ea-9c37-45c20d74fd13"), "Computer18", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2479), "192.168.1.64", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("9611b7fb-86d7-4b10-b030-f3146c77fb0f"), "Computer29", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2535), "192.168.1.19", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("a6ed196c-0505-4170-8fa3-6142aab87b62"), "Computer46", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2625), "192.168.1.20", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("a7224309-8a80-4762-b37d-54704d147314"), "Computer48", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2634), "192.168.1.25", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("a8a7c683-b3ce-4f1c-8b20-b9b6afaf9317"), "Computer25", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2513), "192.168.1.24", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("a9f833c7-94f0-422a-bdbd-dfd772fb70a2"), "Computer53", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2659), "192.168.1.21", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("aae0b97c-e261-487b-b398-e0409f97e6dc"), "Computer36", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2570), "192.168.1.71", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("adec7191-0b0b-4cd3-ad51-f7f2ea07cef7"), "Computer11", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2398), "192.168.1.30", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("bf411359-5c09-456a-8d24-c28415ce73b3"), "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2356), "192.168.1.19", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("c432af90-eeac-4fc2-943d-d76a2cf10808"), "Computer16", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2467), "192.168.1.76", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("ca355643-ba2d-463f-966f-b9b37323b46d"), "Computer14", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2432), "192.168.1.15", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("cb1f15e8-ae61-4224-8781-b8cbe36dbe5f"), "Computer37", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2575), "192.168.1.57", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("cb41311c-ef66-48d5-b91b-433df042d39d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2287), "192.168.1.47", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("cb7fa31a-15b6-47bf-a1b6-0aaa1bf9f419"), "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2351), "192.168.1.46", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("d38395b1-4e3e-4712-8c24-88e082576210"), "Computer38", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2580), "192.168.1.35", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("d58ef295-6cbe-48bb-9e51-162f84fd4ab7"), "Computer54", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2663), "192.168.1.14", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("d8474f19-48ee-4378-9250-111938e91bcf"), "Computer33", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2553), "192.168.1.29", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("dded616a-8a36-400c-ad7d-087fd1b7ed58"), "Computer7", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2371), "192.168.1.96", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("e2150b14-9d77-4162-ae6a-7d8744a06b7c"), "Computer32", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2549), "192.168.1.36", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("e5f5ed9d-f0fd-4207-8a04-340d72fb8c55"), "Computer19", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2485), "192.168.1.54", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("e7dbc830-bcec-4417-8ded-4b22b7ea07d6"), "Computer52", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2654), "192.168.1.51", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("f7963111-0ff2-40ea-883c-e7b0cb1e5879"), "Computer44", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2616), "192.168.1.8", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("f863341a-9431-4115-9461-0c5366f137c8"), "Computer45", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2621), "192.168.1.4", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("f94469c4-85d1-44f4-97d1-30b282a7ca62"), "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2361), "192.168.1.26", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("ffc97338-6138-4d5e-a7b4-5ded519c7976"), "Computer60", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(2692), "192.168.1.34", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("02d86747-63b3-4dc2-8642-ecfb685a506c"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4157), "192.168.1.40", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0e91f3cb-8b65-40d4-ad71-25c7379e09ea"), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer5", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4211), "192.168.1.36", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("10b7be68-e79b-458a-804e-4efda43b5f0e"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer14", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4277), "192.168.1.52", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("12b7b0e4-99d1-4aee-8048-c90712eebd13"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer25", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4353), "192.168.1.78", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("143ca64f-c5b4-47e0-baa7-9b09e270a16a"), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer10", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4248), "192.168.1.5", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("15afca8c-13db-4ed1-850f-c3434b9a3dd9"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4177), "192.168.1.95", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("172bf091-6874-49bf-a697-fcebcfc03155"), new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer13", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4272), "192.168.1.42", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2b79cca0-ac04-4122-829e-658676fe0a30"), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer21", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4331), "192.168.1.72", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("31484d4a-06fd-4d27-af38-45a40412cafa"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer20", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4325), "192.168.1.66", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("32700e6f-1614-4d57-9523-e6bef5eecd31"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer32", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4394), "192.168.1.38", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("38021f24-06bb-46d9-be23-fbe1c4935b9d"), new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer19", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4316), "192.168.1.46", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4a3be450-a6d3-4b53-8aed-061e6929c284"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer40", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4448), "192.168.1.80", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4b6801eb-8658-42a7-871d-faf9c62a2f68"), new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer27", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4366), "192.168.1.51", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5492eddc-2150-4cdd-b61f-22b74fb993a9"), new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer37", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4431), "192.168.1.34", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("57d0c09a-f438-471b-9f05-a8d73e8ba6a9"), new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer4", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4201), "192.168.1.36", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5b7ab322-1824-48fd-9048-8b7751988f6e"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer29", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4379), "192.168.1.32", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5df7906f-acef-4218-ba67-0a35cbeb2056"), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer36", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4426), "192.168.1.20", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6a18e761-4f62-4dcb-af0a-0f44ccf34753"), new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer31", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4389), "192.168.1.60", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7187070a-f8f6-4daa-8b1c-9115eda5030d"), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer39", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4443), "192.168.1.30", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7b379356-0111-4650-ad2e-148591490905"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer28", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4373), "192.168.1.78", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("82f81ebb-4ec6-4b7f-a01b-e7b094ff161d"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer8", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4234), "192.168.1.99", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("84b4c309-6170-4a8b-ad9a-dc99e5cf827a"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer34", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4406), "192.168.1.32", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("963e3161-6e25-4208-b969-be02524d5354"), new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer12", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4264), "192.168.1.77", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a10aaeda-7b70-452d-ac6d-4c08a1a81ee7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer9", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4240), "192.168.1.2", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("aa38cc70-58f7-432d-a790-8a621c558124"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer22", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4337), "192.168.1.78", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ad2b797e-a1eb-45e5-8868-ad1c228cc7ee"), new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer23", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4342), "192.168.1.11", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ae9b59ae-27b1-455c-8fe2-60a4f61d8f39"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4184), "192.168.1.57", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("bad9cf26-0a5e-455f-bbc5-1747f9ad33e4"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer3", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4190), "192.168.1.94", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("bd102e00-eb1e-4029-a2cf-673f674e8a69"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer18", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4304), "192.168.1.38", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c2edf138-d4fc-4f69-b98f-246d9cd321e9"), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer6", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4217), "192.168.1.87", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c5d13bba-62f5-4726-8529-2295ee25d1a5"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer38", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4436), "192.168.1.65", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d06d5e28-4f2b-4415-8de1-d2477e1f0ebb"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer16", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4292), "192.168.1.48", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d479bca6-a6e4-4442-9953-6ff4b7c0c3ae"), new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer7", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4222), "192.168.1.97", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e064cdf2-0af7-4a98-a932-ece4235716b7"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer26", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4361), "192.168.1.71", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e5b5005c-9cb2-489d-ab1f-b36c5d8b755b"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer24", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4348), "192.168.1.96", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e7c90604-013e-4df0-9232-9d7ea2bb18ef"), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer17", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4298), "192.168.1.32", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e841d418-e90d-49e5-88fe-866bd7454777"), new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer11", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4254), "192.168.1.30", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e8b792c9-5b60-4f55-852b-cecaeb7873ac"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer15", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4283), "192.168.1.67", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ea6811a4-aba9-459d-abc4-8c63340a3ff4"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer41", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4453), "192.168.1.44", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ea6f9b4a-c3bc-42bf-aa62-6edd9e2af0f3"), new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer35", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4412), "192.168.1.48", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("eabe8289-0b2d-4fe3-a532-827ac5ca348b"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer30", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4384), "192.168.1.81", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f67eec62-9c1b-4169-8b59-b8544ede3379"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer33", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(4401), "192.168.1.20", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ClassroomTeachers",
                columns: new[] { "ClassroomId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("35cced10-9fc1-4413-9e09-080b408b23c3") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("4eca2d83-365e-4926-b42c-2415618b5e19") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("a444db40-a494-4e3d-91d1-eea2779bf147") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c") },
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("35cced10-9fc1-4413-9e09-080b408b23c3") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("4eca2d83-365e-4926-b42c-2415618b5e19") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("a444db40-a494-4e3d-91d1-eea2779bf147") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c") },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("35cced10-9fc1-4413-9e09-080b408b23c3") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("4eca2d83-365e-4926-b42c-2415618b5e19") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("a444db40-a494-4e3d-91d1-eea2779bf147") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c") },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("35cced10-9fc1-4413-9e09-080b408b23c3") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("4eca2d83-365e-4926-b42c-2415618b5e19") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("a444db40-a494-4e3d-91d1-eea2779bf147") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c") },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41") }
                });

            migrationBuilder.InsertData(
                table: "DiscontinuedStudents",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("bb94e780-1674-428a-9b98-1f132eb0728d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(5896), "192.168.1.59", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null },
                    { new Guid("eafdaa0a-5d2a-4169-839a-fb03b499a103"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(5949), "192.168.1.13", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("0021a854-4036-48ae-85c0-1257d076ba36"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9852), "192.168.1.86", (byte)3, 45.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("00221ce2-607c-4dca-b7ab-92b72f0a3888"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8811), "192.168.1.68", (byte)2, 64.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("00cba99c-49a0-484f-b9e2-2cb6c16a694b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8652), "192.168.1.42", (byte)2, 87.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("01444fdd-cf37-44b2-8e83-091aa43f34be"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8002), "192.168.1.62", (byte)1, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("018d60c1-d9e7-490b-ba94-76a4b60aff24"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(911), "192.168.1.26", (byte)3, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("01b95aac-5b0a-4f80-8e32-2e50c95b63a8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7883), "192.168.1.48", (byte)1, 73.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("01c10500-f160-46de-89e2-81f75cabb79d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9676), "192.168.1.95", (byte)2, 94.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0293151e-fe80-4387-a2cc-cd6d82e86d66"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9232), "192.168.1.95", (byte)2, 51.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("02d0c241-665d-4bda-b2af-20c37ce3f2b1"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(123), "192.168.1.31", (byte)3, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("02e383c5-57e0-44d4-9863-577a97b8a5ed"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9256), "192.168.1.23", (byte)2, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("030f1d28-6bff-486b-a52d-db649ecc3d76"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7292), "192.168.1.84", (byte)1, 4.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("03c04d49-6e63-4617-b0f6-17c772bc8190"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7916), "192.168.1.79", (byte)1, 34.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("04019db8-e7fa-49f9-8406-c1a341712d4b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8109), "192.168.1.26", (byte)1, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("04f08061-09cf-4fda-bfd9-9894958f0a90"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9514), "192.168.1.32", (byte)2, 61.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("050afecc-fd4c-4aca-9f4d-eacf1a99e2df"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9568), "192.168.1.54", (byte)2, 74.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("05d57313-fa53-47ee-af76-8770eaf8bbfc"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8036), "192.168.1.33", (byte)1, 24.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("05fbf01c-7a0a-4795-8e04-8e91a754f48d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7216), "192.168.1.94", (byte)1, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("06606e75-69da-478a-b005-7bdd1cddd5e1"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8276), "192.168.1.86", (byte)1, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("06829a72-9d45-468c-b328-d8f4f4e0816e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8825), "192.168.1.77", (byte)2, 99.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("086eeb3b-f620-4ae2-bd86-4d877a919291"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9204), "192.168.1.31", (byte)2, 95.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("08a15f2b-3b8d-4736-87c5-0e73c6ca2d93"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7397), "192.168.1.56", (byte)1, 93.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("09bb2139-3f78-4327-a167-2c6fbe62e8b9"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9356), "192.168.1.38", (byte)2, 62.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0a363ca6-76a5-4dda-9b89-cd29b7e8d260"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8609), "192.168.1.40", (byte)2, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0a3b3bb0-874b-4eeb-849c-93dfaf14e55d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9981), "192.168.1.10", (byte)3, 37.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0a700480-33eb-455d-a488-6ddb519dd459"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8553), "192.168.1.30", (byte)2, 0.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0aa7f0f3-bdeb-4380-b982-8b9d7c83ff39"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9055), "192.168.1.19", (byte)2, 33.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0b250a0d-75e2-44cf-b000-e8404163db8f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9051), "192.168.1.41", (byte)2, 31.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0b97e5b1-6438-4de7-93f1-2a3eed92862d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(550), "192.168.1.37", (byte)3, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("0bb94d7c-c7ad-4ae7-b223-b7b388e8cf78"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9313), "192.168.1.74", (byte)2, 63.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0bcb7486-37ec-49eb-85a5-6193457bd765"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7393), "192.168.1.36", (byte)1, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0c06bf90-76d4-4b77-83a6-67a3e0677948"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(377), "192.168.1.23", (byte)3, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0d1b90f1-c465-4790-b0f5-c85986d74da8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8032), "192.168.1.30", (byte)1, 25.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0d541345-f022-4fc7-a0a3-ce053b2af270"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9762), "192.168.1.34", (byte)3, 35.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0dae0ab7-3ce3-4b97-9721-7742ef3e93db"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8180), "192.168.1.62", (byte)1, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0dd2ea07-0b48-4b95-91ac-f154c923086a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(102), "192.168.1.7", (byte)3, 9.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0de34d31-af74-49d8-b3a2-1f9cdba2596b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9519), "192.168.1.17", (byte)2, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0e19080e-dbb1-43af-89ee-1d7710116473"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7876), "192.168.1.20", (byte)1, 5.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0e2c4f53-76ef-4a3a-8eae-eb2121ac921b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(974), "192.168.1.72", (byte)3, 6.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0e4cce6d-be88-4df1-a4aa-80703c522972"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8461), "192.168.1.43", (byte)2, 73.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0ea6ad76-1f49-4385-98b7-32f1f6396bbb"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(457), "192.168.1.35", (byte)3, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0f740c0f-784f-4fcd-be19-07a80c78654e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9824), "192.168.1.32", (byte)3, 80.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0fb35093-ff5e-4542-bab9-3c70c4ccf113"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9081), "192.168.1.99", (byte)2, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0fd8d08d-5658-416c-bc31-8021f9ecb783"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(668), "192.168.1.81", (byte)3, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0feaf67d-ef75-496a-a972-2d8164837015"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8712), "192.168.1.27", (byte)2, 80.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("1019c630-f673-41b3-9be4-4b96deefa8a5"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9856), "192.168.1.95", (byte)3, 56.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("104f89f2-9888-43b6-91c8-dd70bbfaf2a9"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9697), "192.168.1.47", (byte)3, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("109d2cf6-944b-44aa-9635-88cdc520f297"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(203), "192.168.1.77", (byte)3, 87.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("110f3085-cac8-4e84-b547-2ed3d3283ca7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9510), "192.168.1.79", (byte)2, 59.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("12022d88-9c42-4fd6-bdf9-ce32a13469ed"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(935), "192.168.1.86", (byte)3, 72.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("12764040-c11e-4108-9496-49612c522f85"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9017), "192.168.1.81", (byte)2, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("12d88873-c1a3-434d-a066-b09fd081e799"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9577), "192.168.1.98", (byte)2, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("12fc04f1-e936-4cbe-a0eb-ffeb0984c37f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(411), "192.168.1.42", (byte)3, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("138243e5-3739-4d97-b706-cc234407e357"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7441), "192.168.1.84", (byte)1, 24.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("14abb032-0e13-4c23-b516-9f3af9edfdf1"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9986), "192.168.1.56", (byte)3, 1.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("14ae3368-6d35-4a94-bafa-45ea102452f8"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8605), "192.168.1.5", (byte)2, 78.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("15caf960-c0e3-4186-b6c5-d6868bd885b6"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9847), "192.168.1.72", (byte)3, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("15ede89c-3cba-4fc5-8875-e7d50a2b54e9"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8755), "192.168.1.25", (byte)2, 19.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1673ce62-ac19-492e-b442-d24c8f470dcf"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9179), "192.168.1.64", (byte)2, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("17a1b7c6-59f0-4d40-aa2a-c8bef01eabbf"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7487), "192.168.1.6", (byte)1, 15.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("17a3c658-1602-4ee2-b0b4-682c7b253a8d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7826), "192.168.1.50", (byte)1, 12.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("17ce9397-a8f2-4a17-acb4-04574302982d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8415), "192.168.1.70", (byte)1, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("17e24c2c-58a6-4b05-bd3a-48599d486c65"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8219), "192.168.1.13", (byte)1, 5.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("17fc0bc0-7b56-41f1-9cf4-70951d0f26ea"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7787), "192.168.1.70", (byte)1, 79.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("18a2cafb-e122-4d91-9ffe-f1c648f9d2af"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8377), "192.168.1.15", (byte)1, 25.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("18e14673-b116-44f7-b77e-731df419050c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9692), "192.168.1.22", (byte)3, 61.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("197f9c79-c649-48ae-9c4d-752bb16503dd"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8113), "192.168.1.71", (byte)1, 5.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1a3a0dff-4dd0-410d-a4b0-6f1fb72125e5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7516), "192.168.1.24", (byte)1, 44.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1a59c166-f09f-4a11-a02d-9b227dbacb44"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8829), "192.168.1.73", (byte)2, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1a6ef5f4-b088-494c-9bf5-b0c1c11a2076"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7511), "192.168.1.26", (byte)1, 58.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1ac7700d-87c2-4e5c-a139-c88c755683db"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8922), "192.168.1.90", (byte)2, 32.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1ad0e795-5225-4df3-904e-ec29c94b7081"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8228), "192.168.1.52", (byte)1, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1b1de6bb-a0f8-4bd3-9d92-be846be11e46"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9638), "192.168.1.78", (byte)2, 23.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1b22908b-ff19-43e7-914e-32f8c4ceb758"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9619), "192.168.1.11", (byte)2, 17.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1b47c93a-4253-4f28-a7f8-b6d767eeae18"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7781), "192.168.1.91", (byte)1, 25.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1b7e2437-6761-48ed-987f-199e4ecc889c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(285), "192.168.1.67", (byte)3, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1ba119f9-c64e-44c5-b70d-a60742a14d7d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(217), "192.168.1.98", (byte)3, 44.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1ba3b75f-ca98-45f6-ac66-080d8172adc9"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8075), "192.168.1.15", (byte)1, 52.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1bd6769a-e7b5-4b92-8fee-2913114eebbd"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7724), "192.168.1.69", (byte)1, 32.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1bff358b-1dd0-4cde-9c75-8122c56279f2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7574), "192.168.1.78", (byte)1, 82.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1c5533c2-5473-4890-b1a1-66bfe89e174f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(482), "192.168.1.88", (byte)3, 17.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1c576862-4167-4459-b09d-f69a513cc032"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8393), "192.168.1.50", (byte)1, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1c6fbfdb-8c43-4665-b927-16b15e94bb33"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(922), "192.168.1.90", (byte)3, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1cdf4cf3-1752-4043-bc0e-3ac9322a3c21"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7830), "192.168.1.63", (byte)1, 96.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1d553b47-6271-4961-966d-f8e775b88c4d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7676), "192.168.1.14", (byte)1, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1da6739a-1410-4dd1-8058-f3f50585181d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8844), "192.168.1.26", (byte)2, 13.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1e0f4cf4-dc44-42ca-b822-b9829f297eb4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8887), "192.168.1.93", (byte)2, 32.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("1f17aefd-2898-434e-9c80-b6c020b29d38"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(304), "192.168.1.31", (byte)3, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1f28b091-bc52-4095-9464-143043253f23"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(954), "192.168.1.29", (byte)3, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1f6fb34a-eb82-4b7b-a61e-9c2ec0e26045"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(452), "192.168.1.45", (byte)3, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1f7018d8-f2de-4687-8920-00ca97d6a256"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(979), "192.168.1.29", (byte)3, 87.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("20914d2d-94c0-435b-839d-4ad61a9bea31"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(54), "192.168.1.84", (byte)3, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("213c9b88-168d-46dd-8959-62b489067d13"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(687), "192.168.1.60", (byte)3, 52.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("21aaaa9d-fd8f-4861-b0d9-a8d42eb60c44"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(799), "192.168.1.9", (byte)3, 58.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("21c0ceff-95f6-41e5-87ce-295045445c9d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9184), "192.168.1.4", (byte)2, 23.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("23222ca0-c8d7-4499-b751-a7ca20264fed"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(691), "192.168.1.46", (byte)3, 1.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("233c6f16-ca9e-43ce-9d2e-a6600d9891eb"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9715), "192.168.1.82", (byte)3, 59.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("233d4950-16cf-4b0b-a6ff-ec4dc534dce4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9170), "192.168.1.96", (byte)2, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("2373ad8c-8223-41f9-a807-880dede1fb2e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8634), "192.168.1.27", (byte)2, 77.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2379e896-afca-4efd-9aa9-de8cf222ff09"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8958), "192.168.1.8", (byte)2, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("23d91035-a147-47eb-939f-4154a56c0f46"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(774), "192.168.1.43", (byte)3, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("23f0159d-7551-4d4e-9eb2-a51e3685664d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9591), "192.168.1.61", (byte)2, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("23f41e59-c8f9-4734-8037-1ffa677a1097"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7358), "192.168.1.62", (byte)1, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("2464da66-eaec-434c-9eeb-89e7659f99fd"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9596), "192.168.1.59", (byte)2, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("247ef769-4b67-43c4-bae1-57c3cbaf397e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9804), "192.168.1.54", (byte)3, 39.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("248f3415-bfb5-480a-b0c4-d269bac20ae6"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7225), "192.168.1.7", (byte)1, 34.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2613384d-260c-425d-8b5f-7109f01454b1"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(149), "192.168.1.7", (byte)3, 77.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("26514dad-e098-4d48-b725-2786b96fcb0b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8673), "192.168.1.97", (byte)2, 58.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("268483c1-1956-4b60-bc69-4705f059647c"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7491), "192.168.1.70", (byte)1, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("26d1c0fd-5146-4a73-8823-a61fb444b734"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8237), "192.168.1.56", (byte)1, 47.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("279f0716-b4e7-4571-9238-f8edbf2cdb82"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(926), "192.168.1.9", (byte)3, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("28408751-3485-42a2-9984-671ebd525960"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8008), "192.168.1.77", (byte)1, 23.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2857d9e4-96c2-45a9-b20e-6b3d84354cf7"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9953), "192.168.1.19", (byte)3, 57.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("28a3f22c-8353-486d-a6a5-63a7739df4d6"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9553), "192.168.1.35", (byte)2, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("297b1cab-2f75-4ce4-88e3-340f8db7059e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9405), "192.168.1.98", (byte)2, 93.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("299212e3-6469-438c-b617-b8b8598d63de"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(260), "192.168.1.22", (byte)3, 15.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2a297825-81ef-4ee9-9710-0162fda62240"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9060), "192.168.1.91", (byte)2, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2a8c84e2-5504-4bca-b8b7-ebff3ebd04b1"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9647), "192.168.1.32", (byte)2, 56.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2b1244a8-6a8a-4881-a541-82c872331f83"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9908), "192.168.1.66", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2b7498f0-9547-4817-bcee-60dd4ef58e6d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9159), "192.168.1.12", (byte)2, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2ba1ae6d-94ed-4d7c-9403-883a9189b6a6"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8892), "192.168.1.37", (byte)2, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2cacdf20-0bff-449e-b95c-7c51d47f3429"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(629), "192.168.1.2", (byte)3, 4.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2cb7762e-1f9f-4c2e-86d9-c7c623d48da6"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9453), "192.168.1.40", (byte)2, 40.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2d2c469d-159a-479a-be26-d2d5bb0cb196"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(159), "192.168.1.44", (byte)3, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2ddfdf39-dd74-49eb-9db5-dd32370e5304"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9667), "192.168.1.2", (byte)2, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2e7713b9-4372-4df3-b125-66f1465a467b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9299), "192.168.1.61", (byte)2, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2f34a8e9-bd31-425e-8104-fed52d6732ca"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7247), "192.168.1.23", (byte)1, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2f3f31f3-2d93-4ed4-8ef9-138584e5a771"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9942), "192.168.1.75", (byte)3, 14.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2f835e02-9f5a-4c1a-a202-a395f3230810"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(721), "192.168.1.41", (byte)3, 57.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2f87528a-31aa-4dea-ba8d-1b9fac8bdf95"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8465), "192.168.1.12", (byte)2, 90.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2f8ec966-3df3-4b70-977f-eb449ae5477a"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8916), "192.168.1.77", (byte)2, 36.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2fa3869f-77f0-4c86-af27-82c0ec0c7bfe"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9758), "192.168.1.56", (byte)3, 10.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("30b09fde-e228-4f5f-98fe-a47e0348b79d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7925), "192.168.1.43", (byte)1, 11.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("31d28e12-030d-4e46-b05d-22e95482d0cb"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(502), "192.168.1.42", (byte)3, 31.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("320bdbdf-6917-4418-8e5f-e6346ab9bf71"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8301), "192.168.1.8", (byte)1, 66.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("327f70d2-f292-4573-8b2d-97f2d706a282"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8623), "192.168.1.1", (byte)2, 81.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3373fd5b-0b70-4ba4-9e46-a89302039283"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9862), "192.168.1.92", (byte)3, 4.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3467e512-7445-4938-9265-0af2252edeba"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(183), "192.168.1.82", (byte)3, 60.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("346e0163-76ce-45cc-9a0d-3802d7355aeb"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(34), "192.168.1.50", (byte)3, 28.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("34767a08-b91c-4121-bb62-489263c789e4"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7477), "192.168.1.50", (byte)1, 99.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("34d0766f-8b02-4ece-97da-8387754a9ca5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8305), "192.168.1.68", (byte)1, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("34e14f99-23bc-481e-b9c1-2e5f1beb552e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8061), "192.168.1.93", (byte)1, 65.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("35679b69-4adc-44af-944f-be23a7f06504"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9399), "192.168.1.58", (byte)2, 64.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("358e9085-20e2-4bcd-be32-9faaee518abf"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9069), "192.168.1.90", (byte)2, 96.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("35bff124-73bc-4dd3-b0f9-27a4d78c1653"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7353), "192.168.1.53", (byte)1, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("36854a26-4b21-4db2-bda4-dcab5a63f104"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(554), "192.168.1.4", (byte)3, 33.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("368bba71-dd6d-41da-a930-31dfd7500d7c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(883), "192.168.1.81", (byte)3, 95.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("36e34f66-3e7d-4c4c-81ac-cd97248e2294"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(192), "192.168.1.82", (byte)3, 7.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("370b49ec-1887-4bdc-9729-e553ab50eda1"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9274), "192.168.1.4", (byte)2, 40.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3736b238-9f7c-45a5-b761-8873273969f4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9261), "192.168.1.44", (byte)2, 37.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3946a76d-beaf-4c7b-ad39-698ac2f807da"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(867), "192.168.1.36", (byte)3, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3aba157f-b09c-4a74-b06a-f579518359b5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7656), "192.168.1.99", (byte)1, 1.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3ba91387-64b3-443b-a928-95b8a11591de"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(541), "192.168.1.67", (byte)3, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3bdc0005-cf95-41e9-a460-1b248930438f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8577), "192.168.1.97", (byte)2, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3ca7bbf6-fd7a-4232-9fd7-905a76842c3e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(579), "192.168.1.3", (byte)3, 51.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("3cd93ba1-3056-4422-a109-84fc22f2e121"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8095), "192.168.1.49", (byte)1, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3d8175f8-6fcb-4c08-a7f4-234e147ffa53"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8614), "192.168.1.74", (byte)2, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3dd88802-0d42-417e-82ef-e21547dbd728"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8349), "192.168.1.54", (byte)1, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3e1e9181-2243-4c31-a444-2cada388ad52"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7482), "192.168.1.27", (byte)1, 98.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3e1f6e44-f4da-405a-a67b-6f2abd7df27b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7321), "192.168.1.93", (byte)1, 20.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("3e5fff77-2359-46a1-b1b2-6fd94965ac25"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7546), "192.168.1.44", (byte)1, 86.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3f37d094-a185-428a-8c29-6f527481d995"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8223), "192.168.1.36", (byte)1, 11.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3fa8a7a3-8f92-45a1-9bbf-1ede8c64e150"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(486), "192.168.1.22", (byte)3, 22.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3fefc93b-7f45-457e-9e48-0883bf40a117"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9842), "192.168.1.18", (byte)3, 77.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("40cb17f4-c1d7-4b99-8fec-0b4da47e3bc0"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9557), "192.168.1.69", (byte)2, 72.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("42280cc3-dfbc-45fe-a22e-1b426435e6d1"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7417), "192.168.1.10", (byte)1, 66.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("427ff416-3b0f-4b56-a45d-6d88f2efd826"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8867), "192.168.1.48", (byte)2, 58.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4308d846-0b0d-4679-8468-77ad8c1a5f7f"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7599), "192.168.1.59", (byte)1, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("43492de8-7b08-48ba-b612-c7d2105ad16b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7910), "192.168.1.85", (byte)1, 68.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("43695e2b-e43f-473e-b7e3-fe349c049b15"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9799), "192.168.1.88", (byte)3, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4383c9d3-1d76-41d8-a058-fac876d0d312"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(11), "192.168.1.29", (byte)3, 13.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("43a74e1e-e4db-486a-ad59-fee380e459f8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8099), "192.168.1.77", (byte)1, 41.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("447d6844-1058-4aea-9879-8fc9e065ad69"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8175), "192.168.1.16", (byte)1, 52.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("44978b1e-474b-4606-bec4-e63f0b961577"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7198), "192.168.1.99", (byte)1, 29.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("45194911-fd19-497e-a383-2836995037de"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(770), "192.168.1.33", (byte)3, 76.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("456e58ff-b0fe-401b-b218-dcc7efec0f26"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(747), "192.168.1.87", (byte)3, 58.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("458fb1be-b970-4b21-a8c3-0b792407127e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(677), "192.168.1.87", (byte)3, 63.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("45c2a785-778a-4b51-b140-400994a5ff09"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8522), "192.168.1.41", (byte)2, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("45f5d2ec-af94-41b3-819c-c674ed9f0330"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9740), "192.168.1.54", (byte)3, 84.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("4611502f-8afd-4fd4-b5ce-11fa647562e0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7458), "192.168.1.8", (byte)1, 15.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4634ce8b-1231-4867-adfc-dc2690455327"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8518), "192.168.1.86", (byte)2, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("46b35bd7-1937-4de4-a647-9d63593bff66"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8214), "192.168.1.51", (byte)1, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("4702e43a-a599-42a8-81b8-9a0e517b48d3"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8568), "192.168.1.12", (byte)2, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("470e05c0-dd2e-41b9-8050-da99ee563c4e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(88), "192.168.1.9", (byte)3, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("475ed570-5bd8-469f-8ce4-8b949fb6fdb8"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8772), "192.168.1.41", (byte)2, 72.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("48075e12-a1ca-4b64-a328-dafba0e2803d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7969), "192.168.1.88", (byte)1, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("482313e0-a156-4092-8980-55952b5854fc"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9924), "192.168.1.89", (byte)3, 87.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("485ea321-da65-474b-85eb-a8b641fe838d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7423), "192.168.1.68", (byte)1, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("487791ea-dd5f-4eed-8e3f-6c826cd2e170"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9283), "192.168.1.39", (byte)2, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("49138119-f35b-4789-a3e9-492f3720a987"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9035), "192.168.1.6", (byte)2, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("49510c71-cc48-42af-ad36-70cebe2c6ca0"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9394), "192.168.1.18", (byte)2, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4af642f8-4e0d-4a29-8b3e-f9ec0b8b1ad1"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8431), "192.168.1.65", (byte)1, 48.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4b41a601-b1f0-45c4-8ed7-d0b14ad0c48e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9485), "192.168.1.32", (byte)2, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4b80b85e-817f-4560-b8dd-1e991330aebc"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(20), "192.168.1.37", (byte)3, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("4c188ccd-81f9-4481-8675-65a3dffb577e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(421), "192.168.1.74", (byte)3, 49.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4c22bfff-3b67-4e40-89c3-771ace012838"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(887), "192.168.1.18", (byte)3, 37.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4c2f7b41-a366-443b-bac6-effdefadc637"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8262), "192.168.1.69", (byte)1, 63.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4c388895-6f0c-4806-9153-460cf2eb63c5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7844), "192.168.1.86", (byte)1, 15.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4d13c12f-09da-4813-a472-d40cb1d06119"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9548), "192.168.1.96", (byte)2, 29.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4d462d04-c776-4077-96ea-832e42978592"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8449), "192.168.1.33", (byte)1, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4d76ae48-3012-428a-8687-9e2b8779db6b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(111), "192.168.1.49", (byte)3, 86.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4e1137ac-97f4-4c0b-888f-6387adb9ee40"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9242), "192.168.1.68", (byte)2, 1.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4e4e27d1-c465-4524-92dd-4e4fb367d99b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9218), "192.168.1.42", (byte)2, 91.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4e78d92a-a858-4608-9de3-46e7f030f60a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8291), "192.168.1.55", (byte)1, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("4f64581d-363f-4b98-8947-4523e6e9f486"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8562), "192.168.1.42", (byte)2, 6.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4f9ba113-1287-4c7a-a8f9-6f57ebdbfa00"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8373), "192.168.1.42", (byte)1, 18.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4fdbcf18-3c9e-4a94-995c-70e200d5cc49"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8600), "192.168.1.57", (byte)2, 13.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("500b637f-84b7-4960-944b-f88248f1f63e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9189), "192.168.1.95", (byte)2, 33.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("509019ff-452e-4295-94d3-b23e4e16fc20"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8547), "192.168.1.61", (byte)2, 59.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("50b4adae-edbf-40da-a6e1-df777c20c616"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8725), "192.168.1.40", (byte)2, 77.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("51371e80-ecf9-446a-85d8-d374d3655ed8"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9505), "192.168.1.6", (byte)2, 86.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("514a1d0f-120f-49f3-b4a1-edf6882a48ce"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7306), "192.168.1.14", (byte)1, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("51ee9474-62f2-4638-b27e-56ffc9bde823"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9795), "192.168.1.63", (byte)3, 85.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5250d5eb-5b65-4942-89eb-8593fafd3a3b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7930), "192.168.1.11", (byte)1, 86.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("536046aa-a563-4d26-a989-37b376afee12"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7278), "192.168.1.85", (byte)1, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("53989641-89f2-4359-adce-8066fb23fd7c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9492), "192.168.1.34", (byte)2, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("53a51e35-9f71-492a-a9a9-b58e9ae27b6b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(940), "192.168.1.12", (byte)3, 42.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("540849e1-d3b0-495c-8f77-3ec5e097d5b3"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8806), "192.168.1.79", (byte)2, 81.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("544cef46-c80c-41d2-88b6-f72c08db5fb2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8066), "192.168.1.43", (byte)1, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5490e03c-6633-4f99-a823-2354111d8aa2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7608), "192.168.1.80", (byte)1, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5499485e-45db-43f7-ad39-9797509590ee"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9046), "192.168.1.66", (byte)2, 1.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5501c78f-24ca-408c-bb55-954925839a0a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7312), "192.168.1.38", (byte)1, 6.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5524e055-c5af-47f4-88fc-abfae49e2f01"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9829), "192.168.1.65", (byte)3, 46.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("559fe90b-68af-48b6-8a25-a49b3a7977f6"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(756), "192.168.1.69", (byte)3, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("55e6663a-06cd-4393-9f84-90b106e1d69e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9813), "192.168.1.38", (byte)3, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("562083fd-1c46-4afb-b72d-6e52cb8d23bc"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(343), "192.168.1.71", (byte)3, 77.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("56610580-88fa-4fc3-acd4-399e73d14c74"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9662), "192.168.1.2", (byte)2, 4.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("56d0def9-b57f-4177-88dd-8e95d4f6f30b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(318), "192.168.1.36", (byte)3, 90.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("56dfe714-7594-4415-8652-4d72c6cab18a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(313), "192.168.1.91", (byte)3, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("56f9d5df-d328-42fa-a332-c6569162f878"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(373), "192.168.1.66", (byte)3, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5706bc50-bac5-4477-baf1-4331762267ba"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8411), "192.168.1.48", (byte)1, 37.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("57949fa1-4b64-491f-9443-ffd5ff909900"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(329), "192.168.1.25", (byte)3, 91.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("57c3ce4d-3b70-476b-87a2-8ab3e373d66f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9894), "192.168.1.88", (byte)3, 16.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("58de8f4c-95c8-439f-81d9-de4bff8508b7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9120), "192.168.1.57", (byte)2, 50.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("59764826-8141-4b33-a94c-0b980db331ab"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8791), "192.168.1.64", (byte)2, 69.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5ab58886-03cd-4a80-b723-d887fa0c94d7"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7672), "192.168.1.36", (byte)1, 29.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("5b4171cd-ba6a-4086-ae8d-bdade553a3df"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(40), "192.168.1.93", (byte)3, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5c513f9c-5b79-4aa3-b428-cdb6bc65ade4"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(536), "192.168.1.1", (byte)3, 45.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5cdd2863-7520-4546-b4d5-3899b354276b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(208), "192.168.1.33", (byte)3, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5d2def5c-dfc9-42ee-a47c-d6e98b88f07b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(760), "192.168.1.82", (byte)3, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5d7603cc-5dc1-4c66-9a9d-b4f9a9b1dfbe"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7681), "192.168.1.11", (byte)1, 71.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("5d7893d9-6417-4a66-aa87-15bad4eb8ead"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7556), "192.168.1.79", (byte)1, 27.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5db0abd1-c227-4be5-8415-29c8c45aee72"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7710), "192.168.1.30", (byte)1, 83.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5e393062-9cd4-48ee-a5db-c164d315e64d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8454), "192.168.1.47", (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5e874897-ffae-4bba-889d-d632029d32be"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7805), "192.168.1.10", (byte)1, 95.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5ec4d595-ea82-41ac-9375-04f938a9fc16"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7220), "192.168.1.56", (byte)1, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5ed19ada-8b3f-492a-8606-42a161419fb9"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9127), "192.168.1.43", (byte)2, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5ee74d8a-6a47-4486-83a5-fcf29f6b6c10"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(391), "192.168.1.16", (byte)3, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5fa03d5e-0acd-4d96-aba5-8e30359a4173"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8558), "192.168.1.78", (byte)2, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5fa0d6c4-0dd8-4be4-8b55-a3385528ead2"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(309), "192.168.1.39", (byte)3, 40.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5fc9df68-7f4a-4869-9eb5-db2282d96a6e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(231), "192.168.1.47", (byte)3, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6088e42b-82a8-456d-bf37-d2ae6b39119a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7896), "192.168.1.18", (byte)1, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("60939596-34e0-4436-bc71-96c43e7af982"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9642), "192.168.1.29", (byte)2, 24.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("61191f6a-eee1-41ce-9856-bdde5d6d925c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8896), "192.168.1.56", (byte)2, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("612104c6-4a9e-4424-8abd-2a94d8a89140"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8383), "192.168.1.74", (byte)1, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("6121df28-a5b1-4a1c-8118-e7397611e0de"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7865), "192.168.1.78", (byte)1, 62.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6191773d-9058-4804-8da2-b087fc655d20"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9681), "192.168.1.30", (byte)2, 51.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("619e1746-db29-423f-b2e1-c14d75c46265"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7647), "192.168.1.8", (byte)1, 91.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("61ded2f9-0d4b-445f-99fc-98055ed18522"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(280), "192.168.1.93", (byte)3, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6225ac6b-0be3-4947-951d-40ec35fbfba4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9317), "192.168.1.5", (byte)2, 79.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6257b7ec-15d3-43d8-a91d-2ca8e293bff0"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(516), "192.168.1.41", (byte)3, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("625a28f4-4473-46ab-8f9e-6a2e1fa934e2"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(765), "192.168.1.16", (byte)3, 76.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6350cad7-8bc4-4299-a78e-259ba59f8714"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8266), "192.168.1.69", (byte)1, 30.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("637279ff-0583-4817-8910-37b5f1cee032"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8581), "192.168.1.21", (byte)2, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("63aca6c9-98eb-4989-9191-05ce7596f7d9"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8750), "192.168.1.64", (byte)2, 35.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("63c71602-5ab9-437d-a3fd-0a29a09c9e6d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(84), "192.168.1.89", (byte)3, 23.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("63cbb89f-483f-4138-bd88-6b720e12c894"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9141), "192.168.1.87", (byte)2, 17.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("63f01341-8a33-4a2b-a4a2-45c8aecfedb5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7892), "192.168.1.49", (byte)1, 29.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("64542e91-26b4-4377-bbb2-a1235053033c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(29), "192.168.1.74", (byte)3, 30.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("64651235-63cf-417d-b441-985e9035828e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8209), "192.168.1.57", (byte)1, 4.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("64bc2285-f232-4e9c-9b76-b137453b801c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8531), "192.168.1.81", (byte)2, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("65a5d595-a977-4360-97a2-7711ec96ce50"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(430), "192.168.1.71", (byte)3, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("660b1c74-a63e-4272-a26e-51d92e70fa17"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9154), "192.168.1.77", (byte)2, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("66dc4cc1-c417-4d18-815b-142bffc62ce4"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(425), "192.168.1.73", (byte)3, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6779b06d-6774-40e1-82d5-1335d7778c8e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8133), "192.168.1.86", (byte)1, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("67bdf5e9-99ce-4603-a170-22dbc66a1757"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9380), "192.168.1.86", (byte)2, 68.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("67d6e87e-6f9d-45b8-b7f4-d3ccbffc2f4e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7507), "192.168.1.52", (byte)1, 86.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("67dde1b3-ae4a-4a99-abca-ba003838bab0"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9131), "192.168.1.59", (byte)2, 70.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("687a2584-daa3-4a81-8d24-c4efa2733db4"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7767), "192.168.1.30", (byte)1, 97.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("68e2a28b-7dbf-497f-856b-6f8a3c6d0dce"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8253), "192.168.1.98", (byte)1, 12.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("694ac717-f558-4436-a5f8-cfe578f547e1"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7921), "192.168.1.73", (byte)1, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("69a61a33-46c2-4265-8dc1-17786419fe84"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9496), "192.168.1.95", (byte)2, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("69a827ff-f975-4ccc-ad2d-a48f4ac0cabf"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(269), "192.168.1.14", (byte)3, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("69c47501-910d-4102-a2a8-58676b3ff4aa"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8147), "192.168.1.21", (byte)1, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("6aaf609b-062a-4939-9cb3-3c42d2469c9f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(382), "192.168.1.90", (byte)3, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6b334336-6f17-47c5-9060-3efed50d15f5"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(154), "192.168.1.67", (byte)3, 91.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6c48edbd-867e-4783-9a65-c5320fc171cf"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7565), "192.168.1.57", (byte)1, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6ca954b1-7600-46ac-b543-72c4c89d9aa8"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8541), "192.168.1.31", (byte)2, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6cb83210-4bbf-48c7-8d8e-38f6c10d60b6"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7436), "192.168.1.22", (byte)1, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("6cf6ece2-b01c-4966-8a38-20828e67d30e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7719), "192.168.1.60", (byte)1, 62.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("6d3b8ff4-b539-4ec0-809e-750de53e0ee7"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(352), "192.168.1.38", (byte)3, 17.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6d90ab1d-2a56-496e-a73d-4a5280429cbe"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(73), "192.168.1.56", (byte)3, 9.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6db425e5-31a9-4e62-a136-034756bfc4cc"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9095), "192.168.1.66", (byte)2, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("6e043d40-17a6-445c-9b67-5d10453d2d55"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8730), "192.168.1.91", (byte)2, 63.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6e78926e-bea6-4335-9b51-a50fa6a187bd"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9213), "192.168.1.97", (byte)2, 69.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6e86c920-3b9c-49e7-a23e-5018045a87c9"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8815), "192.168.1.8", (byte)2, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6f693ba1-6eb9-4b8b-b3c1-2f7c59626c1a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8422), "192.168.1.49", (byte)1, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6fb5f69c-0655-47a8-a7d9-8c8b20ca00cc"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(222), "192.168.1.81", (byte)3, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("70641be4-bf8e-4d44-8d97-3c82aa32b0a7"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7317), "192.168.1.39", (byte)1, 81.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("70faf9bf-7977-4d20-aebe-c52bf155036d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(988), "192.168.1.64", (byte)3, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("71ff43fb-d80a-42c6-985a-bde84bd6b52f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9026), "192.168.1.28", (byte)2, 58.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("73ab5f5a-8bba-4cdf-a3de-8b122bf47ac9"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(400), "192.168.1.98", (byte)3, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("73b60328-b191-427b-b5f4-977980b50fca"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(712), "192.168.1.15", (byte)3, 12.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7400624a-bef6-4fbf-aa3d-0f523a406605"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8983), "192.168.1.11", (byte)2, 59.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("746ef360-dde0-4dcb-8b39-a39acb295e85"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8435), "192.168.1.70", (byte)1, 48.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("74858a19-5aea-47b9-8d7f-fd021a84677e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8572), "192.168.1.25", (byte)2, 28.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("75aadbc9-0a2c-4726-be7a-5db71de8411e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7243), "192.168.1.78", (byte)1, 46.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7628444f-b2c1-47e5-bb70-e6806550ed3e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8795), "192.168.1.13", (byte)2, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("770456d0-2efa-4323-9ac1-024f5d3d6d3e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9458), "192.168.1.14", (byte)2, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("77983e58-5e82-4468-a8b0-732024c15000"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9174), "192.168.1.67", (byte)2, 31.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7878f4de-5091-4507-b7a1-14c1af104d0a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9753), "192.168.1.30", (byte)3, 82.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7a099bda-5ee6-4e99-883e-4b1f776abfbc"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(624), "192.168.1.53", (byte)3, 66.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7a3796b2-587a-4d4a-a95b-d24497bbea8f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(396), "192.168.1.3", (byte)3, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7a478cf0-3207-4702-bc9a-b8bc824a26f5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8939), "192.168.1.15", (byte)2, 40.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7a80eebb-3779-4d83-834d-05b495bbe7e8"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9990), "192.168.1.98", (byte)3, 80.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7a9e9c5e-4865-44b3-8744-27fbdf1ac6e5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7935), "192.168.1.80", (byte)1, 61.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7aa71030-d14d-483d-9c76-4ec49cdf1d43"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(892), "192.168.1.90", (byte)3, 85.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7aee67ab-23de-43a6-8f72-3a9f2ce3d3e0"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(588), "192.168.1.88", (byte)3, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7b215add-2d5e-4b71-8c69-b519306c205b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8721), "192.168.1.22", (byte)2, 10.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7b6f1cc7-432c-4c98-980b-2c41f16a2e16"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9501), "192.168.1.73", (byte)2, 31.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7baee6b5-e419-48b2-9927-737b8e2d07fe"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7964), "192.168.1.26", (byte)1, 50.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("7be0a740-7a10-4563-903f-cc8ac20e56e5"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(226), "192.168.1.91", (byte)3, 68.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7c20264f-9ebb-4f2a-b17e-897a58d5e4c2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8056), "192.168.1.88", (byte)1, 39.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7c953ec5-aa43-4ea2-8489-7935d13f131b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9724), "192.168.1.87", (byte)3, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7ca09ed8-a4eb-4555-9099-a1a1ed066d74"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(256), "192.168.1.33", (byte)3, 55.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7cce8a8d-a5d8-46ba-9987-8524669ab941"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8129), "192.168.1.92", (byte)1, 55.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7dc48a12-8765-4dd4-be26-1100f7183bd2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7819), "192.168.1.69", (byte)1, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7e0a2699-dc88-491f-9caa-da3a058c1a29"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8047), "192.168.1.47", (byte)1, 16.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7e7a71d7-83fd-4754-a2ec-c131aad27509"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(140), "192.168.1.61", (byte)3, 4.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7f54cac9-aa14-4bcf-b933-51787c6c55fd"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8735), "192.168.1.84", (byte)2, 33.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7fa848e5-db56-49f4-a360-a825bae5380e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(6), "192.168.1.21", (byte)3, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("803cf7b4-8d3f-4824-a429-ee5d1e76965a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7297), "192.168.1.41", (byte)1, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("80db68a2-75d0-4105-84a1-82a3562bada5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8648), "192.168.1.56", (byte)2, 41.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8134dac2-60ad-4ad0-988a-2aa7f026f650"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9322), "192.168.1.64", (byte)2, 49.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("81554cc1-48c1-4808-b4f2-d550e37e6b7c"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7973), "192.168.1.78", (byte)1, 46.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8165b6fe-ba54-45a3-9049-7f314768df67"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8488), "192.168.1.38", (byte)2, 52.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8203bde3-5c21-4727-b62e-bde71e7bd61f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8499), "192.168.1.86", (byte)2, 40.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8211ea24-02e3-4007-a139-d1f2411eb918"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8682), "192.168.1.21", (byte)2, 19.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("8219d5c8-3a0e-4e9c-8336-7af3bcf184a9"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7694), "192.168.1.17", (byte)1, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8243fa52-7778-44e3-a7bd-03aae9ad9760"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(212), "192.168.1.73", (byte)3, 76.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("827a5dcd-5f57-41f7-855f-6539149a23f6"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(511), "192.168.1.87", (byte)3, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("829783f3-4bbb-4037-8976-f91ff748a5a4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8969), "192.168.1.22", (byte)2, 42.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("82b122a2-a68f-4160-a0d3-905bf3100a7f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8905), "192.168.1.53", (byte)2, 44.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("82c8e4d6-fd23-4f27-9456-46fdbcf97cc5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9209), "192.168.1.37", (byte)2, 12.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("83c37257-2484-4807-b438-95a08cf098d1"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7579), "192.168.1.72", (byte)1, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("83cc24b3-8336-4447-b5a5-91d9e9a466a5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8849), "192.168.1.92", (byte)2, 33.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("83ccd7ad-21e0-4c44-a7f2-4dc14f5a3f26"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(97), "192.168.1.46", (byte)3, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("84176231-3d57-4ffc-840e-12eee5c4471a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(118), "192.168.1.19", (byte)3, 2.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("845a16c5-d37f-47f6-b170-1fd96cc68a52"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8944), "192.168.1.93", (byte)2, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8460c141-e7e5-4187-8c76-650cba966d5e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(606), "192.168.1.9", (byte)3, 20.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("84b37273-1d43-47a0-bef7-fb1bd5e5f70f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8479), "192.168.1.67", (byte)2, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8513db31-1aeb-4b77-9a18-28c4ac20d2a3"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8628), "192.168.1.92", (byte)2, 17.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("85262619-9319-45bf-90a6-47ed17604b7a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7944), "192.168.1.42", (byte)1, 0.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("8549af25-59bf-4210-b0db-fde99ec59438"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(945), "192.168.1.3", (byte)3, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8578725c-2f90-4d29-a3bf-d33ef2077df4"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9928), "192.168.1.87", (byte)3, 13.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("85969fd8-6cba-40de-a234-880eaf9f6f82"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9624), "192.168.1.9", (byte)2, 71.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("85e3c5fc-2b35-40e3-8cb9-7346d5c21475"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9808), "192.168.1.97", (byte)3, 12.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8606ce99-c243-40b3-b063-99ba28464298"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7363), "192.168.1.35", (byte)1, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("868f7ff3-7e40-49f0-b3fa-5421aa08e50a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7604), "192.168.1.82", (byte)1, 94.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("86cc1228-0930-4ff8-8d83-2ffe770a0ad4"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7585), "192.168.1.78", (byte)1, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("86f986e0-f9d3-4579-9049-4c6a46abf06b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(334), "192.168.1.61", (byte)3, 27.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("87c3434d-e279-4c8f-9222-a8bfb015338d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(564), "192.168.1.2", (byte)3, 42.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("88b268b3-9da2-4af3-a6f5-fea6c17e314e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9031), "192.168.1.54", (byte)2, 69.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("88c60e52-42ae-4487-b078-c61ac5d9d923"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7446), "192.168.1.13", (byte)1, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("88eafc73-963d-467b-be9b-87a972e23e69"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8041), "192.168.1.49", (byte)1, 8.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("897e4ee8-9284-45e0-9d03-d02b575e3acb"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(949), "192.168.1.31", (byte)3, 41.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8a3c8128-e99b-4a9a-a0a3-40e915009831"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7406), "192.168.1.62", (byte)1, 53.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("8a5058ec-a6c2-43d9-b437-7ac6732a3c07"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7758), "192.168.1.86", (byte)1, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8a705b74-34d3-4bda-953d-96d00b10de0a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(969), "192.168.1.66", (byte)3, 59.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8a79d70e-de85-4dcd-90fb-c494dc2e80d4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9653), "192.168.1.76", (byte)2, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8a82ffc3-d731-45fe-8f11-e077f875de97"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7266), "192.168.1.64", (byte)1, 46.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8aa45f0c-815f-4c36-8ddd-5bf0d1bb5576"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9111), "192.168.1.20", (byte)2, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8aadc8b2-4016-4a33-a5b7-a402b85e861f"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7835), "192.168.1.91", (byte)1, 45.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("8ae30e64-5c9a-4378-b3cc-1812230c2b2b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8248), "192.168.1.79", (byte)1, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8b6af8e2-8ea2-4b34-b0d9-5215ca33a550"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7552), "192.168.1.49", (byte)1, 27.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8b74e3cf-56f8-4219-9cae-116a61c86398"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9198), "192.168.1.13", (byte)2, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8c0d83cb-4ec8-41e6-b3e7-bdbb14b44050"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8022), "192.168.1.37", (byte)1, 11.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8c6f9423-428c-44e3-8672-bc3b946a45da"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7662), "192.168.1.28", (byte)1, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8c8b6993-1f70-4f36-bd6e-9174e4af449c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(568), "192.168.1.40", (byte)3, 64.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8d3d8d66-34e7-4003-9433-08f0c2b83d61"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(446), "192.168.1.5", (byte)3, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8dcc2fa8-ae14-40f8-8782-1c6ced591c08"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7776), "192.168.1.98", (byte)1, 39.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8dd6bbfd-168f-4003-a452-d9a4e1746a74"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9328), "192.168.1.71", (byte)2, 41.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8e185eaa-9beb-41e4-8dd4-c4532eb9d2f4"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8368), "192.168.1.96", (byte)1, 21.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8e7dc3f9-0164-41c8-9426-466cc9b13dfb"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(931), "192.168.1.58", (byte)3, 97.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8f0637b2-9110-4048-8ac7-d58a60f58a4e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8242), "192.168.1.68", (byte)1, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8f3f095c-0b95-4c85-861a-4a8b8e3d0780"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(63), "192.168.1.32", (byte)3, 16.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9003770c-74e6-4cc0-91eb-c548ddb45eb1"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9735), "192.168.1.37", (byte)3, 84.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9040ab6d-ffc6-47d0-8534-86b42b0fe9d1"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9467), "192.168.1.91", (byte)2, 29.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("90c595bb-0d0e-4c5b-8599-64be71bae12c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9790), "192.168.1.7", (byte)3, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("90d43d2a-08fd-4348-a3d8-65826f2b4608"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9145), "192.168.1.12", (byte)2, 80.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("910de342-f2ca-4522-909b-4db56a46fa27"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9938), "192.168.1.63", (byte)3, 35.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("91264138-77e2-4f24-b2f1-88fdff93fa2d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9294), "192.168.1.59", (byte)2, 18.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("925af7de-c474-4cc3-9058-da22b78d7d07"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(707), "192.168.1.77", (byte)3, 3.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("92af4574-eb67-45cc-9dbe-12f562e34f5d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8079), "192.168.1.11", (byte)1, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("92e832ca-0cef-404e-8f76-16c0ca3188cf"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8492), "192.168.1.62", (byte)2, 71.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("92f52bfb-67af-465f-82c2-bff804561d2d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9074), "192.168.1.70", (byte)2, 40.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("931e468d-f5b8-4f60-bb22-bf5900086b07"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7955), "192.168.1.9", (byte)1, 53.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("937cba20-eca8-433d-b8dd-f4c82998cd0f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(251), "192.168.1.5", (byte)3, 44.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("94c97f7f-834e-42be-99e5-f656a397575f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(362), "192.168.1.15", (byte)3, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("950aa9f4-961e-41ca-9a4f-ea2c0344accb"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7997), "192.168.1.34", (byte)1, 43.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("95212957-6464-4282-8782-9f61d47b62a8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7959), "192.168.1.28", (byte)1, 90.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("959ab941-8534-49ee-bfd7-4aa12a32c0a3"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9007), "192.168.1.80", (byte)2, 76.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("959d072d-6bcd-47c0-8c1e-578b6a323a94"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(525), "192.168.1.70", (byte)3, 71.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("95ce946a-6f49-4c65-a14b-58d393e46390"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7204), "192.168.1.17", (byte)1, 34.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("962b6d28-25b0-464d-be54-461a9ce3fcd5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8639), "192.168.1.26", (byte)2, 28.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("968ff85b-dee6-4aa7-9ee4-756e9366fbc3"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9967), "192.168.1.71", (byte)3, 2.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("969af9e2-44a0-4b40-bbd8-8a80497b4b70"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8678), "192.168.1.78", (byte)2, 71.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("96ed6bdb-e6cd-4d27-b081-b5a5e262c296"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8701), "192.168.1.27", (byte)2, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("97e6d8ae-cded-4676-92e0-d2d5c2c7dcc6"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8280), "192.168.1.3", (byte)1, 63.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9811c175-908c-4fa5-87f7-0c2ac7a0fb88"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8964), "192.168.1.85", (byte)2, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("986b43d4-f505-4a2b-bafc-a527dfb1ac2a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9749), "192.168.1.8", (byte)3, 75.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("991b2998-b753-4115-9eb9-9aae23bcf5fd"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(742), "192.168.1.23", (byte)3, 82.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("997bdf32-7bd4-41ac-8b68-4035b7518bd0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8287), "192.168.1.60", (byte)1, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("998b5269-5beb-4983-bd6c-f52257b86808"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(197), "192.168.1.23", (byte)3, 82.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9a04529b-305d-42fb-8ee0-db8d65c4c5ec"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(520), "192.168.1.7", (byte)3, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("9af4b01c-d3ef-4231-8221-50183fd068df"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(597), "192.168.1.74", (byte)3, 35.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9b0e6f33-60f6-4d8b-8e4d-712e2206578b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8070), "192.168.1.3", (byte)1, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9b4f5017-1247-46e3-9867-6b2e6a7b0fca"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(613), "192.168.1.82", (byte)3, 62.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9b9ad96c-5620-44da-a196-55ac0631b0bc"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7301), "192.168.1.59", (byte)1, 40.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9bdae825-ce50-44b0-9926-ac969c5bdee7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9085), "192.168.1.39", (byte)2, 1.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9c0a7266-5f0b-4d0b-89c9-9d4a4ff98608"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7594), "192.168.1.20", (byte)1, 22.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9c6ae24a-6f1c-4641-9b2f-b72e9a073f13"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7704), "192.168.1.39", (byte)1, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9c8bd115-370e-4b2a-82b4-7dba0d1ad71a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8185), "192.168.1.2", (byte)1, 7.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9cda14de-d701-4a7f-b10f-26eeaacfd9e7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8858), "192.168.1.51", (byte)2, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9ce0c59e-a4d0-4bb8-904d-85c29d57d314"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7561), "192.168.1.19", (byte)1, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9cf37518-b798-424f-b727-32d012bc2063"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9977), "192.168.1.68", (byte)3, 23.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9f000aa5-0c46-4615-b36b-74d4931724d3"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(872), "192.168.1.65", (byte)3, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9f19687c-197d-4067-9149-3c6368f269c3"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7287), "192.168.1.58", (byte)1, 40.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9fccf9d9-4d80-4387-b0a0-6b5329b3db87"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8052), "192.168.1.45", (byte)1, 35.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a02a5e01-a267-419a-8939-dce275cb2081"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8744), "192.168.1.34", (byte)2, 85.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a0538b14-c649-484d-87d6-c53fc41c526a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8198), "192.168.1.88", (byte)1, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a0e5208e-f334-45b2-b237-f2404ae09683"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9914), "192.168.1.46", (byte)3, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a10f2d22-e786-4d51-aed5-d3cfb9041ab5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8296), "192.168.1.45", (byte)1, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a2ac68a7-3356-4a32-a634-511b37b57d36"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7521), "192.168.1.28", (byte)1, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a2daa6a5-9d64-472e-8dd2-19e533d5881d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9471), "192.168.1.85", (byte)2, 95.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a303fe1b-b9fb-45da-ba4b-0e6d893f5b65"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9476), "192.168.1.59", (byte)2, 58.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a304107f-3fc7-44e7-bd3f-2318b7186d1d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7984), "192.168.1.14", (byte)1, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a34f7b20-4d0b-4841-b154-c055b8cdd06f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(338), "192.168.1.66", (byte)3, 64.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a39ab8f4-8f2c-4d24-b347-2d95147294c8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7232), "192.168.1.19", (byte)1, 56.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a3dca5e0-350e-4e78-9572-11cd02aadfe6"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(915), "192.168.1.24", (byte)3, 12.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a3e55de6-b5d2-44f9-aa44-4e10236f6b61"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7272), "192.168.1.14", (byte)1, 82.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a4f7acee-c10b-4052-9ef9-ec9bc4a1ec25"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(323), "192.168.1.76", (byte)3, 32.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a52503a1-596a-4371-88c1-c59acba11d8c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(188), "192.168.1.94", (byte)3, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a5d04406-4fed-4d3f-b31e-7e385451f4ea"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7905), "192.168.1.99", (byte)1, 39.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a5d8f0bc-2d1e-4ac2-ba7a-8b2c76c8af9a"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9042), "192.168.1.86", (byte)2, 52.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a6d96f83-5b9e-47b4-8dbd-fb97c84e3aca"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9442), "192.168.1.44", (byte)2, 69.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a711f438-bf17-4379-8454-0acb863d3fc2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7450), "192.168.1.22", (byte)1, 64.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a7219b9b-15b3-454b-b47d-ffea6cf8e5ac"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(785), "192.168.1.15", (byte)3, 14.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a736b3e4-1a48-4d6f-9c05-85b9cceb0707"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7472), "192.168.1.87", (byte)1, 36.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a821b0e1-f2c3-4764-8b21-50d51bf7b7ac"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9012), "192.168.1.92", (byte)2, 32.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a8323693-1cac-4416-abcc-545dc764bca4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8588), "192.168.1.32", (byte)2, 67.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a8a6164e-47ec-4692-93bf-2ff727bbc69a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(477), "192.168.1.17", (byte)3, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a8afaefe-9ded-4e9d-90a2-e2fe40e71583"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9116), "192.168.1.57", (byte)2, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a8ce61e5-9888-49fe-8ede-3d25f8e5dc99"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(735), "192.168.1.18", (byte)3, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a8f36e72-fffa-4e6e-abea-b156c10df185"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8662), "192.168.1.84", (byte)2, 1.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a9ca62bd-9ff4-4dd2-b966-0451856b7340"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(673), "192.168.1.23", (byte)3, 59.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a9e963e8-b247-4371-9ede-6b504a1f60ee"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9919), "192.168.1.91", (byte)3, 98.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("aad08e72-131f-466a-8887-3f90e89a3fd4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8777), "192.168.1.9", (byte)2, 15.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("aae9b594-aa2a-4da2-b407-45dce33b783a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8354), "192.168.1.4", (byte)1, 55.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("aaed2d49-6d06-4985-8764-40ba69a0e1e0"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9903), "192.168.1.87", (byte)3, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("aaf0c9b5-dddf-4a90-a3ab-49d9f1717de1"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8257), "192.168.1.79", (byte)1, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ab48cbad-c11b-4cdb-b4ce-2c6a83cdedf4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9106), "192.168.1.3", (byte)2, 29.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ab62e1b2-464a-4030-9db5-d5e863798913"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(497), "192.168.1.92", (byte)3, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ac04cf54-0ce2-4ff9-85d2-3d5755130bb0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7814), "192.168.1.71", (byte)1, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ac149b27-b1bb-4b52-a324-6a38996a2dc6"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8194), "192.168.1.35", (byte)1, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ac3eb045-2c70-4c88-a265-49f063731db3"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8878), "192.168.1.92", (byte)2, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ac56cd42-c5aa-408e-8118-3783956c9d64"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7526), "192.168.1.6", (byte)1, 12.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ac6a5598-68cf-4c92-9e87-8777db25a1e3"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7331), "192.168.1.83", (byte)1, 10.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("acd7678c-bc1a-4bdc-92d5-98e3a00264c6"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8667), "192.168.1.56", (byte)2, 68.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ace1ed7e-09df-4741-acdc-0ed6d9268f5c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(906), "192.168.1.97", (byte)3, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ad668d68-7987-4a5d-8c6d-2e79f10e69d0"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(617), "192.168.1.33", (byte)3, 24.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ad7e4eab-8c9b-4e89-9674-359a07078c9e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9995), "192.168.1.67", (byte)3, 62.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ad9299f3-db06-42c5-94c7-620f1cfe4aab"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8152), "192.168.1.78", (byte)1, 99.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ad94b1e8-51a6-4409-80e2-e817e16b0f38"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7467), "192.168.1.51", (byte)1, 19.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ade9cbf5-8b97-4671-8aa2-157a0abeb026"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(648), "192.168.1.68", (byte)3, 52.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ae4dd318-a2df-400d-9c3c-88e2e04e4aad"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9346), "192.168.1.34", (byte)2, 36.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("aed3431e-87e1-47ed-a295-2ccbe562e12e"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7252), "192.168.1.61", (byte)1, 47.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("af6f040c-5c13-4cab-b0f7-ae4daedd6353"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(59), "192.168.1.82", (byte)3, 71.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("afb36719-98b7-4c17-9ef3-c6db20e25718"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8013), "192.168.1.9", (byte)1, 17.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("afccc5fb-1f35-49b2-8850-12fb85c4b7de"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7326), "192.168.1.30", (byte)1, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b0b73b54-a5eb-4772-a61c-6580bb4573f8"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9898), "192.168.1.55", (byte)3, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b0ff0c63-9f73-4a08-a313-b2bcf0686caf"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(246), "192.168.1.84", (byte)3, 34.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b15502db-8782-45ff-bd83-004a7768c1e7"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(795), "192.168.1.33", (byte)3, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b1737237-0cfb-42ce-a50d-dc620dfea413"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7463), "192.168.1.5", (byte)1, 21.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b2369431-ceb2-46dc-b3bd-2c7cc31033d0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7383), "192.168.1.8", (byte)1, 38.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b271fcaa-c39d-40c0-856b-da120aba6dfa"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9247), "192.168.1.62", (byte)2, 52.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b30cf24f-1b7d-474c-aa8a-2146abc2272a"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9351), "192.168.1.64", (byte)2, 26.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b370dd36-1554-4113-bf4c-9d36c529f091"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9366), "192.168.1.91", (byte)2, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b3842782-f001-4cf2-9e28-ca886178b1d3"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8440), "192.168.1.32", (byte)1, 48.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b41dd73b-3c52-4e38-b758-0a5a109ec9f1"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8716), "192.168.1.96", (byte)2, 28.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b4b6bff9-5f0c-4c7f-abe6-a410fee6c8a9"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7617), "192.168.1.11", (byte)1, 49.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b67bcd7c-e4bc-46a7-a962-a1bd43775600"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9833), "192.168.1.38", (byte)3, 4.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b68fe243-01eb-4224-ad1d-3de839849f3a"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8687), "192.168.1.93", (byte)2, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b70df1ee-dffd-4186-ae7b-f0f8a8ae313a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(348), "192.168.1.7", (byte)3, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b7b4ae55-098d-47a4-abe1-570fe6d0654f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8705), "192.168.1.20", (byte)2, 77.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b7b6052b-3578-4884-ac74-dd3259c3c755"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(435), "192.168.1.58", (byte)3, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b7e86d71-df77-4fb0-a94d-e24976484b5f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9290), "192.168.1.94", (byte)2, 74.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b7ecfa5d-3bb3-4590-bb71-c6773d87f318"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8619), "192.168.1.46", (byte)2, 56.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b7fb3637-9aaf-46c9-98e8-b675667478a8"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(50), "192.168.1.71", (byte)3, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b8191530-6e34-4f48-8814-370ef98458d9"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9065), "192.168.1.72", (byte)2, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b840a8ca-20e1-4f00-a9c2-0b9fefa7635c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9672), "192.168.1.84", (byte)2, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b8a120d1-352a-45d7-afbc-8d75e725532e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(165), "192.168.1.92", (byte)3, 14.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b8a86b2d-71b7-4e6b-9ffb-133a93a156df"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9947), "192.168.1.89", (byte)3, 0.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b9079c76-e20e-4da9-b36d-08c3b3e69e54"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9279), "192.168.1.69", (byte)2, 84.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b93f0f6e-6bc4-4683-a913-5a2b84beaeee"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(45), "192.168.1.11", (byte)3, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b9a8d076-26e5-42b3-9052-54aec6e47ab2"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8692), "192.168.1.67", (byte)2, 12.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b9cdea64-2879-4bc8-8a3c-454e5aac3cf0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7699), "192.168.1.31", (byte)1, 6.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("ba1d1d65-7f6d-4e1e-ab75-3d0974762e52"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7208), "192.168.1.78", (byte)1, 2.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ba298226-922d-42c9-82c5-34606e8bdbf6"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8474), "192.168.1.47", (byte)2, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ba7a1988-88a1-4b51-8e89-a32fc34ee70c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9711), "192.168.1.18", (byte)3, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ba7f4aac-2dca-4274-8685-75bc262a94d8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7432), "192.168.1.60", (byte)1, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("baec53bb-e861-4186-89d6-c6efd93a2df6"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7887), "192.168.1.10", (byte)1, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("bb498968-563e-45f9-a4da-eb96ff3fd1a2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7502), "192.168.1.3", (byte)1, 63.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("bb907d54-98c8-4f0b-96c8-83ce14117bfe"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9222), "192.168.1.35", (byte)2, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("bbcd3194-deb0-43bb-837c-804c08bcf788"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7791), "192.168.1.20", (byte)1, 14.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("bbf50b71-38b8-4dbb-8472-6e943607b3af"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(602), "192.168.1.21", (byte)3, 63.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bc8c63e5-ce63-4409-b378-08cc9033fed0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7238), "192.168.1.74", (byte)1, 1.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("bd02f914-edbc-4379-98bc-d198155ef399"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9165), "192.168.1.40", (byte)2, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("bda87dde-991a-4e92-af35-29f86ec1f4a0"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(983), "192.168.1.73", (byte)3, 56.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("be8cab06-d283-484e-af2c-8ec3e5902a23"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8978), "192.168.1.67", (byte)2, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("be8e252c-0641-4634-a54b-59c6e71619da"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(386), "192.168.1.38", (byte)3, 47.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("bf20770c-3e48-4fe7-9e0b-f4ae1e26a8ff"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8090), "192.168.1.4", (byte)1, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("bfea2d65-b3be-451c-acb7-6871a37f37c5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9360), "192.168.1.36", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("bfeb5c8f-5dfc-4961-aee2-cf1ed280a706"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9021), "192.168.1.78", (byte)2, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("bff3b2ce-17ad-45f3-9066-a52277f34914"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(901), "192.168.1.17", (byte)3, 7.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bffa22c4-509d-405d-b587-ebe6e415c687"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8271), "192.168.1.46", (byte)1, 4.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c00dbfe2-fde1-434a-886a-df7b59e2d57a"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(992), "192.168.1.87", (byte)3, 55.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c05116a5-7c7e-491b-9052-cb595e160649"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9462), "192.168.1.16", (byte)2, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c0ab279d-122d-4245-ab95-c7cac93789cd"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7939), "192.168.1.83", (byte)1, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c0b2649d-ecf2-475a-91c4-49ddd793fff4"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8739), "192.168.1.40", (byte)2, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c0e4df40-ac73-4282-a880-5b056129663e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9972), "192.168.1.25", (byte)3, 34.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c128521e-5bfd-4421-844a-be2f71a2ea23"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9534), "192.168.1.54", (byte)2, 37.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c12ed0a1-cfe6-4c62-a776-93c1fef3ef48"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9615), "192.168.1.78", (byte)2, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c1a2fe39-bbd6-44c0-993f-a58013dadf4b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(357), "192.168.1.40", (byte)3, 17.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c23f5c30-d5ec-458e-9388-eee22c642531"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9818), "192.168.1.30", (byte)3, 25.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c2c9d12e-8e5d-44b1-bb6a-e7afb1074413"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7256), "192.168.1.1", (byte)1, 20.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c30ac027-a8cb-4c76-87d9-50b9de0ea0d7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9447), "192.168.1.86", (byte)2, 1.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c3302cba-0abf-400d-8db2-f348a94b5589"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(584), "192.168.1.84", (byte)3, 78.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c3436914-cc01-46c4-87c6-f58b45c87bff"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8470), "192.168.1.6", (byte)2, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c37e81d6-4876-48e0-9585-9a59390807e7"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9879), "192.168.1.63", (byte)3, 59.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c388e54c-03cc-475a-a6d3-862f74b03faa"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8782), "192.168.1.43", (byte)2, 32.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("c3dca8bf-00cc-4a66-ab55-956962947221"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7530), "192.168.1.5", (byte)1, 16.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c3f4920e-cd7e-4604-bcc9-e8af9936857d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9193), "192.168.1.56", (byte)2, 35.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c46a03bc-c330-445b-bbe8-e04628fc2965"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7153), "192.168.1.90", (byte)1, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("c50da7b0-40bb-4e21-8084-c44b2b653399"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(68), "192.168.1.21", (byte)3, 99.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c50ebccb-d484-4d0a-9fd0-97a5d6c30f86"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9730), "192.168.1.65", (byte)3, 29.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c50f20d4-cdb0-44ee-9e17-f044c15d89fc"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9785), "192.168.1.26", (byte)3, 33.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c512e9e0-076d-486f-bb63-1c00c5357c0d"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(368), "192.168.1.11", (byte)3, 99.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c5faf8b0-60d6-4e05-8ab2-6ebba51f1ba4"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(439), "192.168.1.37", (byte)3, 11.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c671e595-5ce1-4643-ae10-e7cd335a592a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7411), "192.168.1.26", (byte)1, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c6b37115-7303-465c-98dd-af44e058401c"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7427), "192.168.1.65", (byte)1, 78.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c6c79f70-889c-4644-a0f2-28adb8f1f68f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(491), "192.168.1.90", (byte)3, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c705477e-0f1e-4f35-828c-151a2ac27103"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7849), "192.168.1.72", (byte)1, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c74adeda-f86d-410d-95df-829ac199e065"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9390), "192.168.1.4", (byte)2, 64.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c74cd5d2-5d51-40a4-b77e-31aa20d88cb4"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7901), "192.168.1.40", (byte)1, 89.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c7519c9c-a78a-4e43-a741-71e8c55dc45d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9428), "192.168.1.50", (byte)2, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c778e358-3eff-4ca3-81c1-1061ec9fd96d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7498), "192.168.1.65", (byte)1, 45.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c7aafa48-a2d1-4a2f-b6d6-e9909ad5a184"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(781), "192.168.1.99", (byte)3, 88.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c7d1d4ff-f546-413c-bcb8-499dc06c40d7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8853), "192.168.1.74", (byte)2, 4.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c81941ba-e8ed-4ef6-8744-fc5185ff0acb"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8189), "192.168.1.14", (byte)1, 39.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c8559c17-b4fa-4728-b181-efa81a9380f2"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9308), "192.168.1.68", (byte)2, 24.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c8bd16c0-2a47-487e-b336-2052411d7805"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7796), "192.168.1.6", (byte)1, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c8f093f6-d67d-4241-8030-ba20939f4d81"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(529), "192.168.1.76", (byte)3, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c913690c-2f7c-41c4-a514-f821c69509ac"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(290), "192.168.1.52", (byte)3, 52.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c92873d7-ddc7-4365-8de1-2ab7161f8827"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8397), "192.168.1.47", (byte)1, 60.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c9d47641-5ac5-4221-8976-9a9a95f5d8ab"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7638), "192.168.1.8", (byte)1, 80.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c9eda64f-227d-408a-a2e9-1f6423126aa1"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9342), "192.168.1.91", (byte)2, 58.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ca383b85-2526-4db8-a990-cf7b22de6ad2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7624), "192.168.1.5", (byte)1, 65.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ca7330f4-1be4-4f14-b764-c59634e122d5"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7402), "192.168.1.59", (byte)1, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ca7781ff-a64e-4065-b535-d5d23e9bc8d4"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8445), "192.168.1.27", (byte)1, 46.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("cb92b57d-7963-4f32-9f88-002865436330"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(265), "192.168.1.69", (byte)3, 24.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("cbe702ab-61f9-4cd2-b2ef-dec805b84036"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7729), "192.168.1.41", (byte)1, 31.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("cbe96bc2-68e7-450d-92e7-0cdfa66993df"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7771), "192.168.1.82", (byte)1, 21.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ccf06adc-d2f8-4f0b-afbf-9dbe57ad1279"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(664), "192.168.1.29", (byte)3, 47.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("cd288b05-c83b-4dd3-acd8-02a9870c0052"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(145), "192.168.1.34", (byte)3, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("cd3f90d6-d10f-4513-9294-5d59c273f52a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8124), "192.168.1.85", (byte)1, 13.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ce69c1db-3b62-4d1f-80c4-bbde9ba4d4a3"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7570), "192.168.1.56", (byte)1, 19.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ce8ef336-1d75-4cf1-a191-c818694e7d1c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9236), "192.168.1.29", (byte)2, 26.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cf26f28d-65d5-43a6-a1f2-eb81892a2fe3"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7613), "192.168.1.45", (byte)1, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("cf303b4a-52a2-4e61-b71a-c1f137d7c365"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8910), "192.168.1.79", (byte)2, 34.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d0cfc5ea-8157-4c9c-9cfe-6951bd77b576"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9480), "192.168.1.26", (byte)2, 39.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d0d4d9c1-c6bf-47e5-919d-4d38731b4e5b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8872), "192.168.1.30", (byte)2, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d0fb81ec-f44c-4e22-8432-cabd4bdb2a98"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7762), "192.168.1.31", (byte)1, 60.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d10ab946-5015-4cf3-91dd-65a58936e735"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8953), "192.168.1.99", (byte)2, 83.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d11792bf-39f7-4e9c-99dd-8f9c93893b40"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8657), "192.168.1.25", (byte)2, 41.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d21d17bc-ed8e-449d-a3b7-816d524ed5f4"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(696), "192.168.1.15", (byte)3, 65.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d2324e9d-894d-4fbe-b937-e0329fe4c02b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8314), "192.168.1.21", (byte)1, 94.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d25d55bb-7d22-43b0-a427-42bd18abf3d1"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7738), "192.168.1.56", (byte)1, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d2b769c3-de12-4a71-bfac-f48a316b5c33"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9658), "192.168.1.49", (byte)2, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d2deb25f-3d02-47ca-b065-710254fdd91b"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8997), "192.168.1.51", (byte)2, 60.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d30a3603-3f37-4596-8e63-51feed5fa2a9"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8696), "192.168.1.31", (byte)2, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d33320ea-5989-4ef2-8246-159447cb63ee"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8949), "192.168.1.66", (byte)2, 2.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d357490a-a8f1-4b35-85ae-5898ea9811c5"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(242), "192.168.1.11", (byte)3, 98.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d39b2547-bed3-4e71-a999-22588377eebe"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7810), "192.168.1.40", (byte)1, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d3bf3552-3b07-48e9-937b-44366057530c"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7714), "192.168.1.86", (byte)1, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d3cdb61a-645e-4500-b15c-daab2de6e388"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8358), "192.168.1.7", (byte)1, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d459dc96-a0db-446f-872b-6292b2074f32"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8027), "192.168.1.26", (byte)1, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d4682e9d-9991-4088-874e-122798d39b23"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(876), "192.168.1.44", (byte)3, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d4c0a71b-36c9-4b0e-84f2-4f7f17d52c4f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9685), "192.168.1.36", (byte)2, 21.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d4c24713-234e-40f3-a549-90864bdeab64"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(416), "192.168.1.58", (byte)3, 36.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d52fdb13-5e97-42ce-8b65-9ea931adc699"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9586), "192.168.1.1", (byte)2, 71.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d59e8acb-b190-49f1-be3b-c3cf756f332a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7749), "192.168.1.70", (byte)1, 88.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d5cea469-1a6d-469b-9c13-705e67d1884d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8104), "192.168.1.41", (byte)1, 21.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d5e7037d-54fe-4011-8ac2-48ffff8d9e65"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9539), "192.168.1.84", (byte)2, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d64fdda5-1099-4664-83ed-a00f85f5092d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8483), "192.168.1.23", (byte)2, 39.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d7a292e3-2d02-4377-adbe-886611c2ef7f"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(407), "192.168.1.86", (byte)3, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d7c6e9cb-2d9d-4abd-881e-a97e0f34dd82"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8426), "192.168.1.61", (byte)1, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d973484d-9034-4a15-a71d-9e70a3ec7291"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9385), "192.168.1.9", (byte)2, 88.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d988a6d9-989a-4757-95cf-800ece259bac"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8138), "192.168.1.65", (byte)1, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d9f19266-bdb8-4e1d-9659-b44ff69a1a93"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(174), "192.168.1.13", (byte)3, 9.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("da9a8de9-ea1f-48e4-935b-d8e31006fe1c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9562), "192.168.1.30", (byte)2, 76.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("dbef425d-6241-4a70-9371-554b2b6d2b43"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9720), "192.168.1.66", (byte)3, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("dc25b70a-4b73-43ed-816e-af19571887c7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9633), "192.168.1.64", (byte)2, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("dc7c0142-5ed0-4aa9-9f27-070b30c47a0b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8018), "192.168.1.17", (byte)1, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("dcb432a0-c709-47f4-80f5-7693d22f486d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8536), "192.168.1.21", (byte)2, 86.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("dd6289b0-032e-40db-8f6a-339fe573fe69"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7590), "192.168.1.76", (byte)1, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("dddb9fed-7989-4289-a9dd-9334d0eae2c7"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7742), "192.168.1.92", (byte)1, 65.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("deed2c39-ced9-4238-a501-262d9b8f3346"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8118), "192.168.1.75", (byte)1, 67.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("df3868e5-1a42-4f57-af34-aad86365d349"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(274), "192.168.1.54", (byte)3, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("df474117-f383-447a-9e77-95a6e57d204a"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9371), "192.168.1.68", (byte)2, 41.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dfcc98b4-a524-4fee-aaeb-f87ff72ef66e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(135), "192.168.1.23", (byte)3, 62.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e004c03f-cdf1-4e81-b084-a3bcb1c9120a"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9376), "192.168.1.70", (byte)2, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e00fa286-70ab-442f-8d9d-8d4f7b2406c8"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8988), "192.168.1.71", (byte)2, 99.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e03119d7-c87b-4031-bd1d-03623033e8f1"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(107), "192.168.1.3", (byte)3, 2.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e0711ed0-6ff7-4006-b77e-917790b50651"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(179), "192.168.1.67", (byte)3, 94.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e114ac56-38ef-41b2-b4ff-e4d964e167e9"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9933), "192.168.1.48", (byte)3, 34.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e1d1ce9b-ed08-426b-bf54-0e43442b57df"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9884), "192.168.1.1", (byte)3, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e1e3b9a7-87ba-4c69-aef1-38dbca447744"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8402), "192.168.1.63", (byte)1, 13.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e2321dda-688e-42d7-b769-644e33c34259"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9003), "192.168.1.54", (byte)2, 24.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e236e576-bc8d-4c55-b94a-f1b0b836771e"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9706), "192.168.1.54", (byte)3, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e3eb2175-93e5-4d51-96b4-feef5fe50dc8"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(507), "192.168.1.81", (byte)3, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e4ae72cc-31ae-45a8-891a-fd7f0a975b0d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9423), "192.168.1.15", (byte)2, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e4aefaa8-0370-4bab-adac-2388084fe01a"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7870), "192.168.1.79", (byte)1, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e4c18921-063a-401a-9885-73b62387ea8b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(682), "192.168.1.93", (byte)3, 52.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e5189313-2bbf-45be-bcaa-8e98c6ea6ed1"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(751), "192.168.1.31", (byte)3, 61.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e5561dd6-5276-4639-aeda-5c7af2b6cb50"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(730), "192.168.1.93", (byte)3, 0.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e5ceb9f2-6351-4e60-9dfb-f78abc60a241"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8927), "192.168.1.79", (byte)2, 77.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e67296ad-95c9-46d7-ac67-0c848555f0d0"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(717), "192.168.1.31", (byte)3, 89.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e6f00b68-a16e-4b28-b0d7-d223dd8c3e26"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8203), "192.168.1.70", (byte)1, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e70bee7b-7fa5-42d0-a6c9-2956d40db87d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8883), "192.168.1.33", (byte)2, 77.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e71e631b-45ac-4f94-b5cb-90db9e3345d3"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9333), "192.168.1.66", (byte)2, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e73cfa15-4993-4beb-9288-faa7f363c62c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(790), "192.168.1.33", (byte)3, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e7873f28-3c06-4278-8321-4640ca03afc5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9544), "192.168.1.53", (byte)2, 53.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e794d473-589b-4bb4-bd8f-8f202b1e5fd7"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7633), "192.168.1.10", (byte)1, 48.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e79bddb1-0348-4ba0-8699-d92bc7be66af"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9889), "192.168.1.32", (byte)3, 68.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e7b1f86e-14a3-4352-9c4c-1973e48284d3"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(25), "192.168.1.47", (byte)3, 23.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e7e1f2e3-a74a-4d49-b826-ba54ad584a59"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8171), "192.168.1.46", (byte)1, 99.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e858874a-43a1-429f-976a-7d436d40389b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7733), "192.168.1.35", (byte)1, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e88c4a2c-9826-4b68-83a8-f5f463b10fef"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8406), "192.168.1.7", (byte)1, 16.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e8f6c5e3-5f10-44b5-9435-3ed22be9dde2"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7801), "192.168.1.28", (byte)1, 64.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e9b3e6e7-f6ac-49ad-8922-e1c2ad6630bd"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8786), "192.168.1.2", (byte)2, 66.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e9bc6ba8-48fc-488d-b843-03ba20b44509"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(726), "192.168.1.67", (byte)3, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ea156075-c7c4-4473-8002-135ec204cf7e"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9414), "192.168.1.33", (byte)2, 93.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ea20d188-c3a5-4125-bd88-a557cbb9f6a0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7642), "192.168.1.23", (byte)1, 70.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ea67eb0a-87f7-42a0-b89c-2adddbffc898"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7839), "192.168.1.17", (byte)1, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ea94a480-266e-4083-a8f9-078217f23d7d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9581), "192.168.1.8", (byte)2, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ea9cdb67-4937-4fbf-8c48-3a4f6742d44c"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8310), "192.168.1.44", (byte)1, 57.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ec34c98f-bc4f-4a4c-91d4-c16e503c006d"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8901), "192.168.1.57", (byte)2, 8.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ec7bab94-58f9-4fa3-92ab-b08228ce56b2"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(965), "192.168.1.66", (byte)3, 33.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ec937053-bc06-4184-9f2f-a9c15a6ec007"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8513), "192.168.1.73", (byte)2, 25.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ecee11e5-13c2-4423-abb4-43d5240c9d32"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(1), "192.168.1.47", (byte)3, 92.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ecfed536-e189-45ea-83f9-82dc20b31f7c"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(653), "192.168.1.75", (byte)3, 57.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ed36d1e5-5e1e-47f7-82b0-a9fb960ccfe0"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8802), "192.168.1.53", (byte)2, 86.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("edc99d12-9d90-471e-b7d9-b0a63fbfa93b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7282), "192.168.1.91", (byte)1, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ee3884e0-dfdf-4999-9b99-160c12044fc5"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8862), "192.168.1.17", (byte)2, 5.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ee52155f-e14c-4419-abdd-3b12bb3e9717"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9838), "192.168.1.69", (byte)3, 79.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ee7e40b0-df3c-41c8-babb-f8a0b916833b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7652), "192.168.1.88", (byte)1, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ef695b5c-69d6-43f5-ab44-fd7e246ecd81"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9419), "192.168.1.81", (byte)2, 74.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ef70e807-58c2-45a6-83db-774eb8631b09"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9530), "192.168.1.95", (byte)2, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("efc517ea-ceb4-44e4-a485-8f0f917de5ae"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7753), "192.168.1.50", (byte)1, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f0c96a19-3a0a-416e-842f-ef6acac179d7"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9744), "192.168.1.21", (byte)3, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f1139ad1-761e-4867-9c03-8bb16391bf75"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9410), "192.168.1.64", (byte)2, 42.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f134a817-b5cc-4ce4-bade-6ce52c97729b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(574), "192.168.1.7", (byte)3, 95.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f19223da-b201-4e58-a6a8-d149cb87de38"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7261), "192.168.1.8", (byte)1, 11.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f233b910-e29e-43fd-bd8e-14e49a26c2ae"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9524), "192.168.1.94", (byte)2, 41.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f2ebb542-0ab0-44d3-8a2e-df7a28328bcb"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(79), "192.168.1.43", (byte)3, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f2ed43b5-73dc-4c1a-ab1c-ccdfba5d995b"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(15), "192.168.1.54", (byte)3, 94.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f307d74f-d1b0-4f44-b376-d1d6619f78f6"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9304), "192.168.1.86", (byte)2, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f3290b16-f9d3-408f-ac84-0a4a42218544"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(897), "192.168.1.30", (byte)3, 98.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f3869771-edef-4dec-9668-37b6c701dd8c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9251), "192.168.1.88", (byte)2, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f39163a3-4d2b-4fb2-ac2a-3af8f0963937"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9150), "192.168.1.17", (byte)2, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f3b442f5-52be-40f0-81fa-24c6f2688aeb"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8363), "192.168.1.21", (byte)1, 85.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f3c54ea1-8d92-4d05-a131-f170ecf0b6a7"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(643), "192.168.1.88", (byte)3, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f44b2871-1bed-4704-8156-196252903604"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8319), "192.168.1.43", (byte)1, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f47708e4-1382-49d8-8c11-1dae060448ad"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9337), "192.168.1.96", (byte)2, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f479f2ab-b327-418e-a118-6a803c8f6115"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9701), "192.168.1.89", (byte)3, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f4abfd11-a154-4938-b2c1-e4fd77aa6064"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7369), "192.168.1.65", (byte)1, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f4f4e3c6-81e8-44a7-abc8-a34c3142adf8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8143), "192.168.1.76", (byte)1, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f4f72135-2909-4692-8b53-b130178e81b3"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8344), "192.168.1.18", (byte)1, 65.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("f54bc654-3540-48e8-baff-abf7cab8d9a8"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7388), "192.168.1.38", (byte)1, 6.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f5bda30f-829b-4f63-9a96-19f70c6d2c0c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9136), "192.168.1.51", (byte)2, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f5dbd75d-2a36-47e6-95bb-7bcaba95d0c9"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7185), "192.168.1.39", (byte)1, 75.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f66481d0-a466-4ea7-abd5-35de05c26077"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(657), "192.168.1.72", (byte)3, 94.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f699dd90-b4de-483f-9219-c7c44e774767"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8973), "192.168.1.48", (byte)2, 23.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f6b1414b-b081-4b8d-984d-1e2a1a40c648"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9572), "192.168.1.66", (byte)2, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f6fa6599-caf2-4f0a-9f1d-6c10bd0b7d2b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7949), "192.168.1.5", (byte)1, 43.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f7278789-c214-4f8e-a21c-6f5cc647d8bf"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(960), "192.168.1.19", (byte)3, 5.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f7413ecf-7a09-47d6-90fd-575a8a7411fd"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(593), "192.168.1.34", (byte)3, 77.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f75c96de-fdc5-434f-8ce7-ac8c6116fec8"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8527), "192.168.1.94", (byte)2, 46.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f7c78a4d-54d6-4d19-9560-917259dad6bd"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(463), "192.168.1.53", (byte)3, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f7cd63d1-accc-4866-a9b7-663c404efc27"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9628), "192.168.1.79", (byte)2, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f8369cc3-d424-40f4-a575-b45b630c577c"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9227), "192.168.1.34", (byte)2, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f891e5b1-f760-4f9f-ba2c-7eeefc2ef6bf"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(702), "192.168.1.69", (byte)3, 87.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f899f14b-d903-46d3-a833-6e372be4d991"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7667), "192.168.1.50", (byte)1, 98.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f912058a-4b30-49c2-9c5e-f4fa5e8880f0"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8388), "192.168.1.19", (byte)1, 15.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f9c0ff2d-bddc-4fc8-8124-2c8defff3668"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8992), "192.168.1.67", (byte)2, 36.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fa036ba0-2d2b-4663-90f9-b642418005a7"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8820), "192.168.1.11", (byte)2, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("fa5a87a7-5041-4cdf-b9ee-43f16294d7fe"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(7629), "192.168.1.3", (byte)1, 31.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fb2789dc-eb0d-4aec-b93e-95a97a67539f"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8834), "192.168.1.76", (byte)2, 86.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("fccc7c7c-0eb5-4e32-befb-65bb804c755b"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8086), "192.168.1.25", (byte)1, 77.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("fcf1cd9a-f28f-4d24-b75d-defb1bf2b0dc"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(559), "192.168.1.72", (byte)3, 90.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fdf5cb9b-d181-4439-ba20-3797635ef2d0"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8643), "192.168.1.88", (byte)2, 13.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("fe255aad-5abf-4273-a6ba-a5b77b328fc3"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(169), "192.168.1.71", (byte)3, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("fe34646a-a11b-4fce-ac20-03792c6fdfba"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(236), "192.168.1.70", (byte)3, 40.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("fe8194fa-41fc-4821-b0f3-3f6879d711ec"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(93), "192.168.1.33", (byte)3, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("fee4493e-c39b-4eba-8e73-af799ed6e477"), "Computer2", new DateTime(2024, 2, 19, 23, 44, 55, 334, DateTimeKind.Utc).AddTicks(545), "192.168.1.22", (byte)3, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ff138a32-f10c-41de-acc3-c14dcb87ee90"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9608), "192.168.1.88", (byte)2, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ff174150-7498-463e-8e3b-3a393729e265"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8232), "192.168.1.46", (byte)1, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ff19e8d3-c3c6-4ae4-a676-9aeceb0dc332"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(9090), "192.168.1.20", (byte)2, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ff2cef36-cc32-4fe3-8992-08a955244292"), "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8840), "192.168.1.7", (byte)2, 78.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ff7f241b-ce33-4c28-9d16-2b1cfe69bd2d"), "Computer0", new DateTime(2024, 2, 19, 23, 44, 55, 333, DateTimeKind.Utc).AddTicks(8164), "192.168.1.99", (byte)1, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ParentStudents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("04c96e63-e43c-4129-9d0c-5c42640790a2"), "4-C", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3123), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("057b2dba-da8c-4036-bf75-aaf416513e8e"), "2-B", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3115), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null },
                    { new Guid("0b267daf-f4c5-4871-90c4-87929344b855"), "1-A", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3071), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("407988b1-7a91-460e-b82f-c7ad34786e0f"), "", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3097), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("4d434752-c2eb-4f1a-8fe9-704eb0ef580d"), "3-D", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3089), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("5e4affa7-3251-4c19-9202-b7ac7ffd3501"), "1-A", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3106), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("5f8ed2f6-c54b-4b6c-b824-f0a3a41bac92"), "2-B", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3083), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("9ce3f809-e2c0-48a4-b0b6-1fb4d1505437"), "", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3120), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("a309c292-9f55-4ad3-b4da-a6da8ec76853"), "", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3099), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("a96f7226-0a08-4562-acb4-64d79eafaff5"), "2-B", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3112), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("b5b193a5-13e5-469a-a112-e8474795d2a3"), "1-A", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3080), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null },
                    { new Guid("dd8cf728-72c2-4204-b43b-22e24d9c06f6"), "3-D", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3093), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("eb855c07-cbed-4b1f-92a5-fbee3dbb0ac7"), "4-C", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3126), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("efbe9909-e284-4dec-96f2-bf149eaf1944"), "", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3117), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("f28c01ac-639f-499d-a4bb-e21c568a8e0b"), "2-B", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3086), "192.168.1.1", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null },
                    { new Guid("f9823eca-9eb3-4094-a773-ab4f61c2dd1d"), "1-A", "Computer1", new DateTime(2024, 2, 19, 23, 44, 55, 335, DateTimeKind.Utc).AddTicks(3109), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_SemesterId",
                table: "Achievements",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_StudentId",
                table: "Achievements",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_SubCourseId",
                table: "Attendances",
                column: "SubCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomMainCourses_MainCourseId",
                table: "ClassroomMainCourses",
                column: "MainCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomTeachers_TeacherId",
                table: "ClassroomTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscontinuedStudents_StudentId",
                table: "DiscontinuedStudents",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SubCourseId",
                table: "Grades",
                column: "SubCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_UserId",
                table: "Parents",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ParentStudents_StudentId",
                table: "ParentStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomId",
                table: "Students",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubCourses_MainCourseId",
                table: "SubCourses",
                column: "MainCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_MainCourseId",
                table: "Teachers",
                column: "MainCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSchedules_TeacherId",
                table: "TeacherSchedules",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "ClassroomMainCourses");

            migrationBuilder.DropTable(
                name: "ClassroomTeachers");

            migrationBuilder.DropTable(
                name: "DiscontinuedStudents");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "ParentStudents");

            migrationBuilder.DropTable(
                name: "TeacherSchedules");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SubCourses");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MainCourses");
        }
    }
}
