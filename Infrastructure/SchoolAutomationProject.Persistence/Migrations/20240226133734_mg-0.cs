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
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
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
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(750), "192.168.1.3", "10-A", null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(748), "192.168.1.2", "9-B", null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(744), "192.168.1.1", "9-A", null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(752), "192.168.1.4", "10-B", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6892), "192.168.1.1", "Matematik", null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6896), "192.168.1.2", "Türkçe", null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6897), "192.168.1.3", "Biyoloji", null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6899), "192.168.1.4", "Fizik", null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6900), "192.168.1.5", "Kimya", null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6903), "192.168.1.6", "Tarih", null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6905), "192.168.1.7", "Coğrafya", null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6907), "192.168.1.8", "İngilizce", null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6908), "192.168.1.9", "Müzik", null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(6910), "192.168.1.10", "Görsel Sanatlar", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8190), "192.168.1.3", "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8211), "192.168.1.8", "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8198), "192.168.1.5", "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8187), "192.168.1.2", "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8195), "192.168.1.4", "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8213), "192.168.1.9", "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8204), "192.168.1.6", "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8209), "192.168.1.7", "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8216), "192.168.1.10", "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(8171), "192.168.1.1", "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(9140), "192.168.1.5", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(9138), "192.168.1.4", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(9132), "192.168.1.2", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(9125), "192.168.1.1", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(9134), "192.168.1.3", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
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
                columns: new[] { "Id", "ClassroomId", "ContinuationStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "FirstName", "GPA", "Gender", "GraduatedSchool", "IsPreRegistered", "LastName", "ParentId", "RegistrationNumber", "TotalAbsenceCount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3275), "192.168.1.11", "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", null, "110-24", null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3223), "192.168.1.6", "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", null, "105-24", null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3170), "192.168.1.1", "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", null, "100-24", null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3228), "192.168.1.7", "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", null, "106-24", null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3280), "192.168.1.12", "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", null, "111-24", null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3236), "192.168.1.8", "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", null, "107-24", null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3268), "192.168.1.10", "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", null, "109-24", null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3207), "192.168.1.4", "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", null, "103-24", null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3215), "192.168.1.5", "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", null, "104-24", null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3186), "192.168.1.2", "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", null, "101-24", null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3197), "192.168.1.3", "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", null, "102-24", null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(3241), "192.168.1.9", "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", null, "108-24", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5769), "192.168.1.13", new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5719), "192.168.1.2", new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5778), "192.168.1.16", new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5772), "192.168.1.14", new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5742), "192.168.1.7", new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5723), "192.168.1.3", new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5754), "192.168.1.10", new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5780), "192.168.1.17", new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5788), "192.168.1.19", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5762), "192.168.1.12", new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5750), "192.168.1.9", new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5785), "192.168.1.18", new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5732), "192.168.1.5", new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5729), "192.168.1.4", new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5775), "192.168.1.15", new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5758), "192.168.1.11", new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5736), "192.168.1.6", new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5706), "192.168.1.1", new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5745), "192.168.1.8", new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(5791), "192.168.1.20", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "FirstName", "LastName", "MainCourseId", "Title", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7292), "192.168.1.5", "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7302), "192.168.1.10", "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Uzman Öğretmen", null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7305), "192.168.1.11", "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7282), "192.168.1.2", "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7289), "192.168.1.4", "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7285), "192.168.1.3", "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7275), "192.168.1.1", "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7312), "192.168.1.13", "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7307), "192.168.1.12", "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Başöğretmen", null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7316), "192.168.1.14", "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Uzman Öğretmen", null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(7299), "192.168.1.6", "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("0027bd62-7d6d-41d7-9ecb-7a53d7432928"), "Computer24", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6776), "192.168.1.5", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("01e1fdd5-fded-47d2-bdfd-605d075f3601"), "Computer58", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6931), "192.168.1.24", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("0364152d-0700-4afe-817b-e3e617cdf506"), "Computer38", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6835), "192.168.1.27", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("1418b79b-fb01-475d-989d-8f8ca425a82f"), "Computer9", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6694), "192.168.1.4", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("1c800066-f3d2-4a8b-aa9a-6b203ebb684e"), "Computer53", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6910), "192.168.1.37", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("1eee4ee0-90e4-4e1e-a11a-4dcf0b2cb013"), "Computer55", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6919), "192.168.1.60", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("2007332e-ce09-43d0-a581-a1cbf213c185"), "Computer14", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6716), "192.168.1.47", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("2036d35d-0f8a-428d-bc16-dbdc5a5b253b"), "Computer59", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6935), "192.168.1.63", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("23d3a619-4d76-4fd0-9258-dfe6f41a0989"), "Computer18", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6750), "192.168.1.1", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("23f4d4c1-1d51-4d04-927d-644979c42892"), "Computer11", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6703), "192.168.1.97", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("2b18d545-75df-4f30-b151-fa2bfbbafef0"), "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6667), "192.168.1.18", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("2fffe089-2b68-468a-b0a9-99bda84b7d4e"), "Computer39", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6840), "192.168.1.20", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("317b1ddb-758a-45a3-b784-8ab4d3319725"), "Computer27", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6788), "192.168.1.5", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("3945f2df-46fc-415a-9e25-7ab51229895a"), "Computer21", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6762), "192.168.1.72", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("3b897175-3c65-4df5-8594-567d2f288e39"), "Computer49", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6894), "192.168.1.54", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("44447247-8179-4652-9c5e-f31a2e6a7c4a"), "Computer16", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6741), "192.168.1.54", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("44eb1602-bb2a-4cf8-b700-9bf37f2452d0"), "Computer56", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6923), "192.168.1.5", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("47a143b3-2ac5-42dc-a7e1-c29b62920c80"), "Computer7", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6686), "192.168.1.83", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("495da5a2-03cb-418f-b909-7cc57cb45292"), "Computer57", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6927), "192.168.1.85", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("4a4e26bd-df44-4011-881e-26aa24b96583"), "Computer43", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6868), "192.168.1.55", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("4e84bf6d-73a1-436f-8bc1-70ed55e10385"), "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6675), "192.168.1.95", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("4f180ecc-070f-40e9-8370-f58912646552"), "Computer40", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6844), "192.168.1.85", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("545fabc8-0f1c-42c8-90ef-2c266cc2a820"), "Computer13", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6711), "192.168.1.47", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("54df809b-407c-43fd-9741-ac94c78b6042"), "Computer31", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6806), "192.168.1.91", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("5b6457de-1b7e-4d52-900a-4d82696bc5d4"), "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6671), "192.168.1.94", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("5fed062c-e252-489d-99fb-6b27da2ca400"), "Computer36", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6826), "192.168.1.40", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("6175427f-95a1-4f9a-83fc-9af49d3c2934"), "Computer47", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6885), "192.168.1.61", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("62efffae-fab9-45f6-be13-5f7b52612026"), "Computer26", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6784), "192.168.1.16", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("66feda0c-384e-43c1-9cc7-bb33e4747efa"), "Computer60", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6939), "192.168.1.59", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("6749301e-5664-41f3-a00f-59c9c114c04d"), "Computer54", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6913), "192.168.1.15", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("6be39c92-d3c4-40da-b724-5221757c6fb7"), "Computer10", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6699), "192.168.1.94", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("71ca9c73-c71f-4382-a8e7-5674f9ff995f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6662), "192.168.1.86", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("7216e850-6f80-4737-8815-ea904ee69c7c"), "Computer35", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6822), "192.168.1.46", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("7ede0e68-d54a-4959-b1e1-6ca73eeaf49c"), "Computer41", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6848), "192.168.1.72", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("82301881-8589-4309-b698-fb931b27825c"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6603), "192.168.1.86", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("86d7e9f4-dc08-45c1-8d6b-a4fd11c8b908"), "Computer19", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6754), "192.168.1.89", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("8874a6f3-4980-44c9-b6b2-c432ddcab8c0"), "Computer25", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6780), "192.168.1.62", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("8ce56cff-d025-49ce-964d-1451c8acaf0f"), "Computer45", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6876), "192.168.1.19", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("9bab569c-c214-4f93-87ce-0971e6c36d3b"), "Computer6", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6679), "192.168.1.55", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("9cfd8255-f56b-4cdd-926a-37a07c6e3606"), "Computer15", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6737), "192.168.1.17", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("9fc0cf95-9fd7-4967-af5e-8667fb81e3de"), "Computer51", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6901), "192.168.1.49", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("a10b1304-9eae-463d-b107-2336d886b908"), "Computer32", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6810), "192.168.1.25", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("a2401610-7209-485b-86a9-ad88121a8cc4"), "Computer37", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6831), "192.168.1.6", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("ac512d14-35e6-4b3f-8d16-6e223040e9b6"), "Computer48", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6889), "192.168.1.92", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("b46b08d8-4c10-41fc-acab-f14fd0a502ce"), "Computer34", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6819), "192.168.1.49", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("b8f0f992-51e2-420f-9450-03bcd3f3b5d4"), "Computer30", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6800), "192.168.1.47", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("ba231c60-cc0a-48c7-95f5-f2041df326c8"), "Computer52", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6906), "192.168.1.38", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("ba4ef0d4-7f99-47d2-9662-e25e3632eab8"), "Computer28", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6792), "192.168.1.21", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("bc127570-ea2c-4511-996b-8af384f8c965"), "Computer29", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6796), "192.168.1.66", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("da53e9a3-d6e1-4503-b0cb-195700f0e0c7"), "Computer33", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6814), "192.168.1.84", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("da80cb82-ca54-41e3-9c03-2dd5dff52013"), "Computer50", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6897), "192.168.1.54", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("da98555f-58a9-4a59-a227-b394b77967e8"), "Computer42", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6852), "192.168.1.16", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("e1829e0c-019f-4cfa-99d4-8bf23b723e88"), "Computer17", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6745), "192.168.1.93", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("eb4bccdc-04df-4ffc-b89a-72c0e2931627"), "Computer23", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6772), "192.168.1.6", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("ee1ab8a9-634a-4b68-b184-c04e988ca602"), "Computer44", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6872), "192.168.1.37", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("f35d99d5-f182-4c2e-af6d-a7ea5287c049"), "Computer22", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6766), "192.168.1.72", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("f44aaa79-c3b4-4cfc-90cd-fe7c93cbd6f4"), "Computer12", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6707), "192.168.1.3", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("f48e7db1-b98f-4bbc-9274-71497f4ac62d"), "Computer46", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6880), "192.168.1.34", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("f74ea4b2-7aa7-414e-a768-1eb33b8e159f"), "Computer8", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6690), "192.168.1.23", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("fa72ba66-b159-490b-ac5f-cb959d27a724"), "Computer20", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(6758), "192.168.1.62", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("00b08a7b-5665-447e-9903-fdffdac8861c"), new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer38", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9664), "192.168.1.8", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0637f28f-219a-4c99-9485-e2c62b7c5e90"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer20", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9557), "192.168.1.14", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("080bcd37-ea8e-4ef7-8177-f56de049b5df"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer13", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9520), "192.168.1.66", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0c619460-ac98-493f-bd6c-370c13322d9f"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer26", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9588), "192.168.1.33", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0cd77ae2-cfa6-4427-93a1-85e99e6261c7"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer10", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9503), "192.168.1.75", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1a7be210-1732-4f80-ab41-97de1e35254c"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer22", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9568), "192.168.1.70", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1d522cd9-eed3-4def-8de6-b0dc26e58052"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer23", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9573), "192.168.1.86", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3307de8f-81b3-4a86-a625-c0cd7befdd20"), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer18", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9546), "192.168.1.73", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("45a7edae-7176-4141-8211-9da32df3fdc5"), new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer3", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9455), "192.168.1.97", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("532a5882-5b5d-4182-8e88-85914cd1a6de"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer16", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9536), "192.168.1.96", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("573a15f4-6c08-4c04-9f86-fe39d33f1d1a"), new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer6", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9480), "192.168.1.79", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("57e4af4c-4b81-47b4-b2ed-0f28d184d148"), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer5", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9468), "192.168.1.89", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5bbc1ba6-da09-4804-a501-29458c75c769"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer29", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9605), "192.168.1.25", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5ca110d7-f478-4fc4-93da-e900ffcbfba8"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer9", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9497), "192.168.1.75", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("63a3efb3-30e1-463a-8079-b061ac81ea26"), new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer15", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9529), "192.168.1.67", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("67930c49-343f-4f0e-ae92-65ea3b7566de"), new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer11", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9508), "192.168.1.6", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("70e62a99-4c09-48bc-a60b-5023315e5cac"), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer21", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9564), "192.168.1.48", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7aed4851-138b-402c-b383-92448fb03f05"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer27", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9594), "192.168.1.93", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8564d256-7254-495f-9084-f187c10d7cb2"), new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer33", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9630), "192.168.1.5", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("91bfd09f-588e-464d-9854-ff96fde0666b"), new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer37", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9660), "192.168.1.98", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9478bd4c-6808-4f26-afea-fbf8c46fed17"), new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9422), "192.168.1.60", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9877ef03-df5a-4fcb-b7fd-4e30a2ef1a16"), new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer8", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9492), "192.168.1.7", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a0bf99c5-62f8-42c1-8b02-6587acccc568"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer36", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9654), "192.168.1.26", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("af1bc7cf-cb26-413a-8166-e79f0b21b0e1"), new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer34", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9644), "192.168.1.93", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("af43a8b7-e654-450b-ac1d-be7f33378e62"), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer14", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9525), "192.168.1.52", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b0017fcc-8028-480a-a0a4-3c5e0251ef3d"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9444), "192.168.1.88", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c125ce1b-5dae-4b58-b8b7-94045d5deb79"), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9449), "192.168.1.74", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c3f1a32f-1ee5-4389-b9e2-45f4fe95d797"), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer25", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9583), "192.168.1.89", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("cbf49fe1-7c7d-471d-9c6d-51815a03a0e5"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer30", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9611), "192.168.1.12", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("cd6ca259-8e14-4206-89b3-5346bd231db9"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer4", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9462), "192.168.1.50", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d108b22e-07d6-426a-8804-5981b62545da"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer31", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9617), "192.168.1.25", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("dafb67b8-1d98-4b9d-9d4f-f6f24e963658"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer28", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9600), "192.168.1.32", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("db18cf69-eba5-4e39-8bce-35990ecadb61"), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer19", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9553), "192.168.1.84", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dc97b1f0-a669-49c5-80d3-590e909e021c"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer17", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9541), "192.168.1.43", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e9ab21ff-7e80-484c-b726-8d67c3071e14"), new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer24", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9579), "192.168.1.30", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("eca3e294-fa1b-4a17-9651-aeba8c70ff79"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer32", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9624), "192.168.1.50", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ed1adf67-74af-4337-b91e-bc27b89b3f30"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer7", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9485), "192.168.1.73", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f6a606e2-7e5c-469c-a9bf-0106ab2e39bc"), new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer12", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9513), "192.168.1.98", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f822205f-dd34-429e-a2be-6daf4acf2915"), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer35", new DateTime(2024, 2, 26, 13, 37, 34, 353, DateTimeKind.Utc).AddTicks(9648), "192.168.1.87", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null }
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
                    { new Guid("52501396-229e-4c95-ad42-60248d377d84"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 356, DateTimeKind.Utc).AddTicks(1900), "192.168.1.80", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null },
                    { new Guid("704b9506-79ee-4f93-bfbd-e146db161fa4"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 356, DateTimeKind.Utc).AddTicks(1828), "192.168.1.18", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("00163d1f-2d1f-4b0d-a533-9071f1ddb76c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2532), "192.168.1.80", (byte)1, 23.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("006f4cac-0469-45fb-a2ec-240a3f2eabc4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5084), "192.168.1.39", (byte)3, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("00c223c9-651a-4233-8ed1-8555b5c7227b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5217), "192.168.1.28", (byte)3, 36.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("01199ee7-6c98-4643-aa9a-fd5d581bee63"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5028), "192.168.1.78", (byte)3, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("013c435e-47bb-4614-85b7-068fb4969a16"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2970), "192.168.1.17", (byte)2, 56.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("018095cf-7654-4514-b37c-9b2a07fe6437"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4914), "192.168.1.56", (byte)3, 6.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0186a17f-3457-4745-a0b4-3bd664cb3415"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4861), "192.168.1.33", (byte)3, 2.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("02054fd8-5fa1-4392-a37f-cf30bf92c580"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2766), "192.168.1.35", (byte)1, 73.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0265b254-7871-4b67-ac8b-434ca0f6b2dd"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3233), "192.168.1.90", (byte)2, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("03f4555d-1c05-46dc-b1d3-683941f18071"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3316), "192.168.1.44", (byte)2, 3.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0454994d-062d-4065-94ba-7e3a1e74364f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2957), "192.168.1.61", (byte)1, 74.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("04a58bd1-8637-4d48-b9fd-77a310693c9a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3881), "192.168.1.18", (byte)2, 90.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("04be318b-04de-4978-a030-c85b25160365"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2974), "192.168.1.1", (byte)2, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("04c69fdc-09c8-49b8-a62b-11c5662b964d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3438), "192.168.1.90", (byte)2, 51.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("04d8c2b6-8c1a-4d3d-950d-85eeec6b386c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2785), "192.168.1.79", (byte)1, 14.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("05c6cad4-75d4-4bcc-9afe-914a5094b137"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3049), "192.168.1.68", (byte)2, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("06403c19-ed75-4570-85c4-401e7dbfe8be"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2183), "192.168.1.2", (byte)1, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0676e1a5-972f-4e1f-a9c7-d6719fe86df6"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2835), "192.168.1.17", (byte)1, 11.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0788f870-2623-4f0e-8ed7-c1e2766d0bf3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3972), "192.168.1.41", (byte)2, 62.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0875dfe7-f1ce-415e-9f84-18bcddd606c1"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3690), "192.168.1.16", (byte)2, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("08aa8da3-8783-40ee-8bd4-9805f0c10882"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2401), "192.168.1.94", (byte)1, 56.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("08c19a2c-8b97-4071-b297-72f6120b9668"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3999), "192.168.1.38", (byte)2, 15.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("08de6395-413c-48de-baa7-bcfaa2c86d56"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3215), "192.168.1.75", (byte)2, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("08e5a9da-2390-4a22-ba7b-59334ab352d9"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1932), "192.168.1.85", (byte)1, 77.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("09028b14-ac9a-4ab3-b658-bf02bc64f6d0"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2986), "192.168.1.57", (byte)2, 97.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("09b5ba44-a0e3-40aa-bf92-044b41ac8c0b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3303), "192.168.1.27", (byte)2, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("09dd7391-e399-408d-8118-8ae1890e7f27"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2815), "192.168.1.7", (byte)1, 15.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0a191403-b98b-452c-876a-df6fba560f25"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3740), "192.168.1.35", (byte)2, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0b23c8ba-24ba-44be-be53-963c69b5970e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4030), "192.168.1.7", (byte)2, 21.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0c08aafb-8e97-4101-ab14-d1521ef8d001"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2260), "192.168.1.26", (byte)1, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0c280448-aacc-4170-801c-d17ff5772475"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2605), "192.168.1.71", (byte)1, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0c57109b-6703-404f-a9e9-42c95bbbb53a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2961), "192.168.1.66", (byte)2, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0d6e39b6-9860-4b84-bc6b-0a9fddf0522c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4607), "192.168.1.48", (byte)3, 68.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0dbc12e4-0d70-4bb0-82a3-179b8d4f080b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4926), "192.168.1.83", (byte)3, 51.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0e2abd32-0f35-471d-b1a4-0b9775d1c3a3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4078), "192.168.1.3", (byte)2, 8.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0e8248d8-de2b-4cd3-9632-79a5277cd7a2"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3660), "192.168.1.64", (byte)2, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0e9a1f35-36af-4b3a-864c-7b3fa91eafc6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2966), "192.168.1.46", (byte)2, 23.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0ee09b02-6e3b-4edb-8d23-3a79a66531e3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3934), "192.168.1.99", (byte)2, 33.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0ef793dc-c359-41e3-b581-e66467f82ef7"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2090), "192.168.1.5", (byte)1, 72.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("0f0967c3-b037-4443-be85-cc3a4ba0179d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3796), "192.168.1.89", (byte)2, 15.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("0f87ba1f-1228-481d-951c-dc872a16de63"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3043), "192.168.1.22", (byte)2, 75.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("110c449a-38da-4748-912e-9f9c3e130b9d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3938), "192.168.1.41", (byte)2, 57.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("116f05f7-8b44-4327-9455-32e64a96737d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2042), "192.168.1.9", (byte)1, 51.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("117975bd-dfd9-4e96-9183-ac391cd6782d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3698), "192.168.1.7", (byte)2, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1193100b-24b5-4f04-9e6b-4784d6b70e94"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3903), "192.168.1.36", (byte)2, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("119cd4ac-a305-46cc-a67d-5bf31aa5171c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4261), "192.168.1.11", (byte)3, 12.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("11edda2b-b373-4214-843a-9bc891eeb20d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4546), "192.168.1.67", (byte)3, 60.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("12bd60d3-cc2f-4148-b4cf-8da1803cc304"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4572), "192.168.1.76", (byte)3, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1313b37e-b79b-4a6b-8a04-fe00b1c9b8eb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4404), "192.168.1.89", (byte)3, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1448adcf-d16c-431e-9f73-c5bbcfc73353"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4418), "192.168.1.1", (byte)3, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("14fbc00d-0fd8-4f93-a06a-7dd963d26a5d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3678), "192.168.1.45", (byte)2, 16.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("15345559-2a68-44a9-9dac-b03228c968a6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3754), "192.168.1.96", (byte)2, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("15416850-0462-4688-b8fc-dd0343deea73"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5139), "192.168.1.30", (byte)3, 45.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1556b622-adbf-448c-978d-a2d92d2de2bb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4338), "192.168.1.64", (byte)3, 95.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("15b106ef-e661-401e-a9a7-e06b24d6def6"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5195), "192.168.1.7", (byte)3, 33.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("15d0a161-dbd9-4a39-85b5-67c04962ac19"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4725), "192.168.1.12", (byte)3, 61.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("15e2da4e-a992-4167-84af-129383af4c40"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4853), "192.168.1.10", (byte)3, 43.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("16a4c3ca-73e5-463b-a6a6-b79ad518051f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4344), "192.168.1.51", (byte)3, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("17129753-3c82-4ef9-882b-d6558ff3981d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4703), "192.168.1.29", (byte)3, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("172908a8-3e13-49d6-89e0-394057399ebb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4348), "192.168.1.9", (byte)3, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("174a8d18-ee6a-4be2-b95c-241c5526d37e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1878), "192.168.1.28", (byte)1, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1777a4b8-50e5-4d1d-8a01-3fff92a7e19c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2476), "192.168.1.8", (byte)1, 25.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("17ea830d-59b5-4a9f-bc9d-78b811aab204"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3958), "192.168.1.83", (byte)2, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("184ec0b2-b649-432c-a5da-a6cc5f24ea5c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4311), "192.168.1.2", (byte)3, 95.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("18642f10-6cbd-411b-aaf3-6889a2252ade"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2503), "192.168.1.77", (byte)1, 1.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1865c420-8b02-483a-890f-b2e921202ca3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4210), "192.168.1.36", (byte)3, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("195e3939-5ae0-4bfc-aeb8-5506748aaa76"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2698), "192.168.1.86", (byte)1, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1996b0ce-3be5-42f6-9b97-285450649ec6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3774), "192.168.1.60", (byte)2, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("19e2a24d-3fc6-4147-ab9b-7cbc30462183"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2888), "192.168.1.28", (byte)1, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("19fc10d5-2e4f-4767-8a32-f8f3253661f9"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3920), "192.168.1.49", (byte)2, 58.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1a0383ba-90a2-4121-9030-56546d188832"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3269), "192.168.1.77", (byte)2, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1a085254-0211-4bdd-b1a9-86bd8132520d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3823), "192.168.1.43", (byte)2, 95.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1a1a3a94-a464-4a29-9436-5f07c020dd14"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2080), "192.168.1.4", (byte)1, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1ad9a2ce-84e3-4964-a003-4af972c395e3"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2446), "192.168.1.89", (byte)1, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1ae76415-7bda-4fed-99f3-3dcfedc25833"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4943), "192.168.1.62", (byte)3, 95.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1b3414e7-e643-44a7-9cad-df881bfa30b1"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2234), "192.168.1.49", (byte)1, 5.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1b58236f-58e2-4ec7-8be4-968c237de871"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2003), "192.168.1.29", (byte)1, 16.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1b986cca-f220-41d2-993f-9b5cc7451023"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2213), "192.168.1.71", (byte)1, 42.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1beaa974-f3fd-41d1-bc31-8e7a9f5231ad"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5221), "192.168.1.68", (byte)3, 42.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1c5abae9-bf59-4b77-8240-2381c98901b0"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3203), "192.168.1.72", (byte)2, 31.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1cfc0282-5af0-4b83-9444-7af765e64d4e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4249), "192.168.1.33", (byte)3, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1d3300a5-41c6-48c0-ac17-e5ab27e995cf"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2144), "192.168.1.39", (byte)1, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1d526f91-3c5d-4097-8d1a-381aba2a491d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2230), "192.168.1.76", (byte)1, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1d8cfd52-a00e-410f-bcdf-a58ed3675d2e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4052), "192.168.1.12", (byte)2, 96.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1db90e23-c319-4df1-a8c5-434636663f0b"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1989), "192.168.1.12", (byte)1, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1dd61e2b-219c-4676-a352-e130496c1f32"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1882), "192.168.1.98", (byte)1, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1deb7ffe-5056-412c-87c8-05fb401b3291"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3164), "192.168.1.76", (byte)2, 11.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("1df52b93-4871-43f5-ba92-5b35b49da02c"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3560), "192.168.1.39", (byte)2, 49.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1dfaba61-5f8e-4ac2-815c-7fa092f7042e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2409), "192.168.1.55", (byte)1, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1e12560c-4152-490a-b379-6cba9cce7bed"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5092), "192.168.1.59", (byte)3, 93.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1ed627ca-bd46-472e-ab37-78eb43e75bef"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5156), "192.168.1.50", (byte)3, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1f6c75e6-d285-418d-a70c-5944dce62c72"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2052), "192.168.1.85", (byte)1, 8.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("1fb7ef95-4ccf-4c1a-8103-3b688275fd16"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4892), "192.168.1.29", (byte)3, 10.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("1fd3e98b-14ee-4863-b741-7bebbe075cf3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4550), "192.168.1.53", (byte)3, 49.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1fe250c0-fef6-4989-b803-7e0ab9121775"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4756), "192.168.1.49", (byte)3, 62.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("20600874-7574-4cc2-b0e0-e61c83c7b4e9"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1850), "192.168.1.52", (byte)1, 68.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("212bd347-7ad3-468a-a80d-7a9483fcb8c3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4461), "192.168.1.57", (byte)3, 92.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2281c5f1-9017-4a15-af55-8f54bc4a340c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2472), "192.168.1.97", (byte)1, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2292d13b-58a7-4783-865a-65ab2aba28a2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2497), "192.168.1.39", (byte)1, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2335ca01-14a4-4944-bdcb-4f86f89e6c21"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4240), "192.168.1.85", (byte)3, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("23481427-b7fc-4fa5-9a09-e0ddf3ce7416"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3578), "192.168.1.68", (byte)2, 66.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("23810a9e-a49b-43c2-bbf0-9592885c1257"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4495), "192.168.1.30", (byte)3, 32.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("23a2f2be-9368-45d9-b218-d4fc7291b0a1"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3293), "192.168.1.94", (byte)2, 96.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("23b5d3b5-aeb4-447d-b87d-2eaa4ae9825a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3003), "192.168.1.51", (byte)2, 11.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("23c4bc6b-a410-4d93-89f6-9fe911f93a5b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3417), "192.168.1.90", (byte)2, 16.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("23f5275a-ff15-4487-a2a8-dc8ac79eb670"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3160), "192.168.1.35", (byte)2, 54.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("243f2f7e-7988-4f51-bfcb-da6120c5eada"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4760), "192.168.1.37", (byte)3, 57.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("24c160f5-5fd6-41f3-8362-fd57c4757a17"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2865), "192.168.1.4", (byte)1, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("25cddf98-01c6-4186-a703-9eb26e3d415e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3211), "192.168.1.70", (byte)2, 38.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("25d2a8c5-06c7-495b-b86d-3d01fed07a1f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2038), "192.168.1.13", (byte)1, 48.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("27213692-7499-4358-997e-b6a7e8b19d56"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3089), "192.168.1.8", (byte)2, 52.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("273d1818-7cdd-46cf-b054-4b6ff8bd4207"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4414), "192.168.1.80", (byte)3, 49.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("27b18902-fb65-4ac8-bdb3-77a5cdc1efec"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4373), "192.168.1.51", (byte)3, 28.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("27c82b46-f64f-4226-b0fb-9175f6a4d3b3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4167), "192.168.1.98", (byte)3, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("27f999ce-0776-4287-9d42-44a955b704d0"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3107), "192.168.1.50", (byte)2, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("285ab823-ac21-424d-8048-29e756e89dc3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3625), "192.168.1.75", (byte)2, 33.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("287e5b9b-b98f-42d3-bed5-f9c5c8cbacf2"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4734), "192.168.1.82", (byte)3, 89.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("28ba7dee-0543-4e9e-8d09-ba09c113ed89"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3446), "192.168.1.29", (byte)2, 52.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("28c5aa86-9aac-440c-86bb-174efc4fb78f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2126), "192.168.1.91", (byte)1, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("291a9970-16d8-41c4-86d1-1938f38c0e01"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2566), "192.168.1.59", (byte)1, 97.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("294e1125-0eec-40ce-95f8-91bc1edc0ae2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2947), "192.168.1.6", (byte)1, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("2951a1e6-a084-435a-8153-0799d914c9e3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3225), "192.168.1.17", (byte)2, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("29dfd55e-7605-43ab-859d-c9f0eea1468f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2165), "192.168.1.41", (byte)1, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("2a8138da-80ec-4de9-a606-cb72e4957b1d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4998), "192.168.1.67", (byte)3, 5.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2acf0146-50b4-4066-8535-f2ee5b7bc1c3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4151), "192.168.1.48", (byte)3, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2b23e38d-1d8d-492b-a5b1-61d0ff4e6d94"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1861), "192.168.1.77", (byte)1, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2b598887-562d-4488-838b-50ef1cc38a86"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3176), "192.168.1.77", (byte)2, 90.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2b98b3ef-ad90-4e79-9519-07d417d22a3c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2112), "192.168.1.47", (byte)1, 95.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2bd4d46b-bfa4-4ef2-83e9-0c9e8966f22d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2801), "192.168.1.53", (byte)1, 52.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2be6cb22-3bda-427e-8352-98d242829820"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3778), "192.168.1.58", (byte)2, 23.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2bff0ad3-d683-452f-ae48-7a9727eb2cf8"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3508), "192.168.1.98", (byte)2, 18.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2c0860b7-6938-4dcd-99c6-6747db72349f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2108), "192.168.1.25", (byte)1, 31.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2c3901d5-0ed5-4960-bed4-131ccabe992e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3617), "192.168.1.75", (byte)2, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2d53932e-aeb4-416f-9ebc-4987cc976efe"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3877), "192.168.1.53", (byte)2, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2d704c53-0576-4f23-8be0-f95bc392907b"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2205), "192.168.1.33", (byte)1, 2.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2e33680e-29dc-4eb8-b8a5-f2862b14f29b"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2068), "192.168.1.91", (byte)1, 22.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2e384a1f-6c82-450d-b7c2-4bb1444dd149"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2017), "192.168.1.72", (byte)1, 24.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2f2aa44c-a007-4b54-ad7e-be64dbd9f6b8"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3643), "192.168.1.5", (byte)2, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2f32c598-3b98-4afe-82ca-0aa7f9719212"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4764), "192.168.1.29", (byte)3, 13.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2f4d8a6c-ef8f-4787-bb35-0340c0436692"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3600), "192.168.1.47", (byte)2, 88.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("30825e72-5a9c-4a82-bce0-5037549f259a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2332), "192.168.1.72", (byte)1, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("30cf05d7-7a6d-4709-9684-d24b30d6a31d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3473), "192.168.1.99", (byte)2, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("31651398-4fd5-4584-af29-7faefc7ca209"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5238), "192.168.1.15", (byte)3, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("31af182f-dc86-4762-84ba-bf7d684045e8"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4664), "192.168.1.56", (byte)3, 71.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("31c75aac-2b65-4fe1-a818-d82cca83abe0"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3762), "192.168.1.89", (byte)2, 44.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3262162e-b819-446c-aa05-3c2486a143de"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2072), "192.168.1.33", (byte)1, 1.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("32a73301-62c5-4974-a7b5-1710480f3bf8"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3033), "192.168.1.45", (byte)2, 76.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("33707a92-576e-41ba-b3ca-50bef14123cc"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3800), "192.168.1.14", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("337a6de3-5938-4a1f-8ea1-43d0683b303d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3873), "192.168.1.21", (byte)2, 21.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("3402a6b6-5d74-4ff9-a051-d29adc4457ff"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3719), "192.168.1.38", (byte)2, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("341bbab6-adea-4f47-bdc8-2ae7c0153bea"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1957), "192.168.1.61", (byte)1, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("34aa9e7b-c5b9-4ee7-a218-19e81d78ceca"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5097), "192.168.1.47", (byte)3, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3513117d-a773-4899-b78b-87dd73898f70"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4357), "192.168.1.44", (byte)3, 73.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3531a5de-4c46-479f-ba03-40f80a1c2838"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3924), "192.168.1.48", (byte)2, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("356e64ab-bcb3-42db-bebb-05a960af92db"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1905), "192.168.1.18", (byte)1, 59.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("358c00b1-178f-4ed4-8596-81cb36780853"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4228), "192.168.1.59", (byte)3, 59.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("35c3a508-4d5f-49aa-b16d-94c7c9e15478"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3481), "192.168.1.51", (byte)2, 62.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3691218c-4178-4506-b352-1acce6113991"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3422), "192.168.1.30", (byte)2, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("36c3c8d5-604a-4f27-a7a0-f50fb8285974"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3061), "192.168.1.32", (byte)2, 58.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("376d1bbb-b589-453c-9bf0-276be6bef757"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3007), "192.168.1.29", (byte)2, 99.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("37d25fd6-e8a0-47ef-bb0a-a3d94a2c13d0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4922), "192.168.1.20", (byte)3, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("38353fe3-837b-486f-83bc-8354a34af0dc"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2609), "192.168.1.22", (byte)1, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("385c1b1b-7eb5-4214-b8af-8bf23478ae66"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2104), "192.168.1.40", (byte)1, 36.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("38632ca3-ed83-4d84-96b8-62de01587bd2"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3912), "192.168.1.10", (byte)2, 72.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("386ad1fa-1cad-4e51-83dc-ac45e141cf49"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4640), "192.168.1.47", (byte)3, 53.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("38aead14-1dce-4c7e-a996-274345b27f47"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3784), "192.168.1.38", (byte)2, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("38f902dc-9783-4e00-a8ea-b33413cb4e85"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1800), "192.168.1.31", (byte)1, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("397d8ba2-17e6-4e81-a045-a09667a3cfea"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3736), "192.168.1.40", (byte)2, 39.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("39d01375-ba12-4aa3-bdf9-9f472a89011b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5049), "192.168.1.98", (byte)3, 93.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("39efaf83-c9de-4e59-9072-6261f34b1faf"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4961), "192.168.1.10", (byte)3, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3b2a57ef-d789-44eb-a843-60de47971bb7"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4087), "192.168.1.92", (byte)3, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3b474945-f238-47a1-9c25-3c2769c62f62"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2371), "192.168.1.79", (byte)1, 88.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3b91421b-91e0-4903-9d12-962cf2ca44a2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1922), "192.168.1.25", (byte)1, 76.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3ba0cf3e-482a-4a57-a784-f22742692cbc"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3285), "192.168.1.48", (byte)2, 30.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3bc70ffa-9893-4e3c-89b6-b7f2c75152df"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4849), "192.168.1.54", (byte)3, 60.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3bcf7e92-585b-49fd-906c-8c0f6992fa65"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4533), "192.168.1.97", (byte)3, 55.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3bd598df-8058-44a3-8e3d-effdf9495cc6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3328), "192.168.1.26", (byte)2, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3bf73a0b-8d52-45b1-81a2-553c66d2c313"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4171), "192.168.1.68", (byte)3, 84.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("3c452059-17d2-4ea9-a348-dd9cb4a78eff"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2613), "192.168.1.33", (byte)1, 86.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3ca21452-adb0-49fa-979f-a8dc3cb885c0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4616), "192.168.1.65", (byte)3, 53.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3cd38010-435c-4faf-b09d-3b6226226355"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4280), "192.168.1.62", (byte)3, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3ce70511-f0cd-4c1f-9dcf-9a2d3848c296"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4060), "192.168.1.36", (byte)2, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3cf1527f-b08b-4640-af43-eae6e0f1b074"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3190), "192.168.1.42", (byte)2, 64.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3d51e7ad-54e3-4ab0-ab0c-1a0fa4917cf3"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2161), "192.168.1.79", (byte)1, 82.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("3d65500d-9332-46d3-88f5-987ed1584963"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2209), "192.168.1.77", (byte)1, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3e3ff9e9-d812-4ef9-8e8b-481228593a14"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3255), "192.168.1.85", (byte)2, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3ea653c0-8142-417e-be3c-fc8661024116"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3025), "192.168.1.99", (byte)2, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3f1cb263-f234-4760-85b2-d4fbabbeff47"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4223), "192.168.1.67", (byte)3, 7.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3fa3f45f-0294-4068-b62a-4fc0e0720849"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3075), "192.168.1.6", (byte)2, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("3fd2a4ef-1262-4ebe-84e9-0bffa2942343"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4117), "192.168.1.17", (byte)3, 67.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4008d67b-55e6-45de-b9d9-4d6da85649b0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4214), "192.168.1.26", (byte)3, 43.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("4043c0df-4093-4881-83bc-6aa50062f4d3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3516), "192.168.1.59", (byte)2, 73.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("405f8714-3324-4dbf-bc17-fad6495dda41"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1845), "192.168.1.25", (byte)1, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("40ec9e52-b52a-4318-b175-a32ff532d41f"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3029), "192.168.1.58", (byte)2, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("41369c8c-91b8-4bcf-956e-e92f5cd0b3f9"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4589), "192.168.1.15", (byte)3, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("414ec62e-6c2f-4742-856a-5f553811e725"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4515), "192.168.1.10", (byte)3, 82.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("417c1be1-ca6c-434c-99cb-d85a37b4d2e6"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4965), "192.168.1.49", (byte)3, 73.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("421346c2-4ddd-43eb-af62-22b2078dd715"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3146), "192.168.1.22", (byte)2, 40.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("42908782-e3f3-41d6-b8bb-23122be3a408"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2248), "192.168.1.76", (byte)1, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("4362f9af-78ba-44ce-92bb-f5026d5a5359"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1909), "192.168.1.61", (byte)1, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4398bb58-52b9-495d-89dc-5e88ab32e6c6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3526), "192.168.1.68", (byte)2, 42.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("43c9acdb-d1ff-4740-b452-ff292e357cca"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2900), "192.168.1.37", (byte)1, 60.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4411e7ce-ade6-4847-bfc1-0424fb1b5cd7"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2122), "192.168.1.81", (byte)1, 29.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4422d263-1906-4ca8-beba-33ffe07e9530"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5010), "192.168.1.29", (byte)3, 70.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("447ba26c-9ba3-482a-9e4c-fcd25ed9b337"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1927), "192.168.1.20", (byte)1, 72.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("44afa188-2a17-415e-b06e-9f0ecc18d3b0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2939), "192.168.1.92", (byte)1, 40.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("450f8481-5584-4102-a11f-6e5815785db8"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2454), "192.168.1.40", (byte)1, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("456b9ec3-9edf-4b43-bb99-8b3489a02c05"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3613), "192.168.1.87", (byte)2, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4575d751-893d-4889-84b3-08143d78ecef"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2656), "192.168.1.61", (byte)1, 41.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("45b624f6-7ff6-40ad-837a-ef96cda266a4"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3156), "192.168.1.98", (byte)2, 21.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("47059df4-4cea-479a-9199-ba0ad319ebbb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4361), "192.168.1.26", (byte)3, 35.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4754ea8d-ef8b-48e8-a82b-f85650f5290e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4056), "192.168.1.46", (byte)2, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4799ed0e-def3-4bb9-a830-e74cf8656e3e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3069), "192.168.1.72", (byte)2, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("47a54b1b-0286-484e-8e05-b29bdcaf2daf"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3586), "192.168.1.64", (byte)2, 87.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("480cf1e0-9b10-46c7-8dbe-7001bfde4556"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3307), "192.168.1.85", (byte)2, 20.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("48622d21-1e09-4809-b0c4-94bc4b650df7"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4142), "192.168.1.17", (byte)3, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("486beccf-8f23-4053-85a4-10b04466d03f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2116), "192.168.1.74", (byte)1, 85.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("486ff975-a180-463d-b883-ecd53e18f47b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4044), "192.168.1.74", (byte)2, 4.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("49700745-026d-4b91-9db9-615c3fa704b4"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2978), "192.168.1.68", (byte)2, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("497138c6-1b7e-41b5-95c4-af37bd91b415"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5234), "192.168.1.70", (byte)3, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4976486c-9a58-4285-a736-042aedecf729"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5045), "192.168.1.22", (byte)3, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("498a007a-4c6c-4162-8e33-5695159a717b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4330), "192.168.1.99", (byte)3, 45.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("49af15b6-af8b-4d01-baf6-ff4edde93aa8"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2226), "192.168.1.16", (byte)1, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("49da6a44-c47b-4312-828e-4683f6ab0d30"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3954), "192.168.1.5", (byte)2, 8.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("4a3cfd2c-5e7c-48a1-b165-012232dbf2a0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4426), "192.168.1.26", (byte)3, 96.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4a4cbb1f-fef8-4a19-999a-eeef6d25a627"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3021), "192.168.1.70", (byte)2, 74.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4a96060f-83f8-4fa5-ab8b-5a43ae6863d1"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4564), "192.168.1.37", (byte)3, 7.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4b1170ce-9ea6-4ffd-935d-1613ec7e0ebd"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3499), "192.168.1.77", (byte)2, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4b946a15-e689-4723-8224-6e935ea7479a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2170), "192.168.1.72", (byte)1, 94.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4bf897c2-c2be-4ee6-a696-c4b44574cd96"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4147), "192.168.1.45", (byte)3, 71.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4cc50389-038c-478e-aa07-320ad9688853"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2845), "192.168.1.74", (byte)1, 96.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4cde1f60-ee82-4cb1-aa1f-84c997b010a4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4525), "192.168.1.90", (byte)3, 48.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4cf90c07-414b-4c61-adfb-689d07992b5a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2823), "192.168.1.43", (byte)1, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("4d009000-4974-4042-8dd7-c1d39b9e370d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4883), "192.168.1.21", (byte)3, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("4d6ff56a-a198-44f4-b17d-1cd023e8a3e3"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2758), "192.168.1.34", (byte)1, 11.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4fb05c81-3eff-44d2-8fd9-448ee02cec9e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2666), "192.168.1.77", (byte)1, 35.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5031c301-0235-4609-8c8c-32a6d0f2f968"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5053), "192.168.1.27", (byte)3, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("50b74bc0-8d33-49ed-9944-00adda6e0bd0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2631), "192.168.1.52", (byte)1, 35.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("518ca554-daac-45f5-9ede-0dfa8c2afbe0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2095), "192.168.1.95", (byte)1, 55.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5198975b-79a9-4aae-ad10-460d37a455b7"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3237), "192.168.1.26", (byte)2, 24.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("51a93a6c-2715-418b-bfa4-45b8b4a99c75"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3744), "192.168.1.74", (byte)2, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("51c89b8a-13f6-4df4-8270-637142094439"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4630), "192.168.1.49", (byte)3, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("51fe988a-0f9c-4171-a686-c4aa165d2742"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3412), "192.168.1.43", (byte)2, 11.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("528d47e4-9c30-4b83-8c20-960561ed9b12"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3819), "192.168.1.93", (byte)2, 30.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("52d0d638-0038-495c-924e-b07dff4553ab"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4730), "192.168.1.64", (byte)3, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("535ec2da-2cb0-4ff1-8e78-8c92a0eb9323"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2648), "192.168.1.7", (byte)1, 29.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("538af310-a095-4871-84df-89b707481393"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2362), "192.168.1.58", (byte)1, 73.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("54b63cff-816d-4871-98fd-f19ca35cd3da"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2025), "192.168.1.58", (byte)1, 85.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("54c01640-068b-408c-85d3-c92beab6594e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3434), "192.168.1.36", (byte)2, 29.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5530badd-4eb4-4969-a9cd-b855898a832e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2797), "192.168.1.41", (byte)1, 33.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("555e0c64-b3f8-4d74-8d0e-f6943056d880"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3916), "192.168.1.69", (byte)2, 0.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5574ad2d-d9f3-40eb-aaec-d6a2ce21b59f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4107), "192.168.1.19", (byte)3, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("55d12d99-1391-4555-9609-a6e38041405a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2686), "192.168.1.75", (byte)1, 50.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("55dfbc0d-9c96-46cf-9dcc-8acd56d52a4b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3635), "192.168.1.88", (byte)2, 97.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("562fb116-77bd-4684-98ad-75f0a8acaeab"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3491), "192.168.1.50", (byte)2, 77.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("56500d40-9fab-4271-b64a-8f361f674696"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1914), "192.168.1.14", (byte)1, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("56aaf914-d315-43e9-987c-fde1694456e0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2586), "192.168.1.44", (byte)1, 6.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("57a8888b-f4ea-477d-a147-269958784e82"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4644), "192.168.1.68", (byte)3, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("57b084e4-3e3f-4578-92ae-78de7c3b4054"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2511), "192.168.1.99", (byte)1, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("57c48629-52d2-4aa6-85fa-ad79521c84dc"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4656), "192.168.1.55", (byte)3, 13.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("58713dde-a6e1-4b8f-8384-759ee1f7815d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2690), "192.168.1.49", (byte)1, 29.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("58b22d03-088c-43b0-8973-7cd5bcde6e9d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2493), "192.168.1.70", (byte)1, 51.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("59254918-27c8-4941-9a91-1af4cb128e99"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3976), "192.168.1.66", (byte)2, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5939c71a-c59a-4856-99a5-2fa41ea633ba"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2617), "192.168.1.31", (byte)1, 21.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5962436f-8dd1-4819-99d7-11c343d85e8e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2344), "192.168.1.16", (byte)1, 29.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5a224907-eca0-48be-9369-a043eb4a76bd"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2762), "192.168.1.32", (byte)1, 10.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5aa0e308-00f2-4627-bbca-6366c16e09e6"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2264), "192.168.1.43", (byte)1, 87.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5bb477e5-8acd-456a-b430-ca9f89ecbbdc"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4296), "192.168.1.19", (byte)3, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5c182e10-70a7-487f-a2e3-0115f044a165"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4576), "192.168.1.14", (byte)3, 54.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5c4c9912-a144-4a7f-b4d5-951b3f09eb99"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5213), "192.168.1.79", (byte)3, 97.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("5cb9c91e-9f68-4ef1-838d-0abdaf92a31d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3839), "192.168.1.57", (byte)2, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5ce65f39-8dfa-4bef-a517-3fcd0422fa08"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2354), "192.168.1.67", (byte)1, 32.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5cf9be96-2534-4153-a1b7-6292f8cee4bd"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2998), "192.168.1.14", (byte)2, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5d0667d2-aeaf-4e3a-89a6-efe9506ca4e2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2582), "192.168.1.67", (byte)1, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5d2bae9e-88b1-4b1e-bb9b-04cbe301cfca"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2528), "192.168.1.76", (byte)1, 74.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5eaa777d-876b-4a20-a12b-315ca3b0f6c3"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2297), "192.168.1.32", (byte)1, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5f0ae2b7-88b1-404c-ad5a-ded484562c17"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2592), "192.168.1.49", (byte)1, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5f9539d4-25ff-42e8-9e98-f7f1f39976bc"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4476), "192.168.1.70", (byte)3, 51.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5fc9dfb2-c45a-4343-8bf8-86fc27ba7086"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3125), "192.168.1.65", (byte)2, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("603d26f1-2a9b-4d25-b225-a1b2769efe28"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3142), "192.168.1.13", (byte)2, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("605f2ed0-b4ff-4c03-80ac-45b6ffdfafa7"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2882), "192.168.1.54", (byte)1, 5.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("607154b9-d9f6-45e8-820f-51639b014e37"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4379), "192.168.1.31", (byte)3, 21.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("6151f1cc-33b1-41d4-8b23-f936ac6a1167"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4326), "192.168.1.59", (byte)3, 53.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("617d3eb1-d097-4ea4-8be1-ce797bb1baef"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2703), "192.168.1.84", (byte)1, 19.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("6245ef82-f993-4167-88a5-8acdd5132ff1"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1999), "192.168.1.3", (byte)1, 71.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("62d8b423-44ab-4475-af64-badab8f2f746"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2468), "192.168.1.26", (byte)1, 76.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("62e54a9e-6463-4514-a420-89fbd725de16"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4988), "192.168.1.98", (byte)3, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6302fc9d-4a5a-46c1-b4e2-9335a2601004"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2597), "192.168.1.58", (byte)1, 33.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("63b3cdb3-4e72-42d5-a399-be70b97d669f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4408), "192.168.1.85", (byte)3, 10.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("63d2477e-8a75-4153-87b3-a6dae6cf1292"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2570), "192.168.1.54", (byte)1, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6402c47f-06c8-48b2-bd94-281164cb2220"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3477), "192.168.1.57", (byte)2, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("64399295-b550-433d-bc90-6b85f0c8cdbd"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2076), "192.168.1.26", (byte)1, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("64e3fa30-9cbf-4fba-ba36-06e64cc91602"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3065), "192.168.1.84", (byte)2, 79.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("654b6ae6-70d2-44d8-8468-3cc7ee4964b6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3359), "192.168.1.84", (byte)2, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("655ca7ac-1df9-403b-91c6-a64ff99cec52"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3609), "192.168.1.44", (byte)2, 63.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("656b15a1-b706-413b-bed3-8df09e40f149"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3950), "192.168.1.88", (byte)2, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("65f537d2-5f25-4093-bb2f-a3ffb314a107"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3199), "192.168.1.72", (byte)2, 18.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("66089672-0566-4f28-8fb7-d11ebf6ac833"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3604), "192.168.1.95", (byte)2, 51.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("66583f8d-4bda-4b70-917c-f44ce39da6bc"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1953), "192.168.1.51", (byte)1, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("66882a53-2473-4bdf-aa00-506b47b70466"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2780), "192.168.1.87", (byte)1, 43.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6798efd0-91f5-47b4-aeac-16d41f0cb4ce"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3138), "192.168.1.21", (byte)2, 42.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("679dd703-3317-4e40-8273-abe443d2d485"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4503), "192.168.1.89", (byte)3, 35.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("68135a89-ecfa-4e28-8494-53b24743ea57"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4687), "192.168.1.34", (byte)3, 25.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("6875f523-a433-49c8-98c4-c3050a2098ff"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3758), "192.168.1.96", (byte)2, 84.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("6892398f-949f-490a-9ba7-809b3c85ad01"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3503), "192.168.1.34", (byte)2, 86.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("68b16a6a-9198-42bb-8b97-9e00234cea41"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3117), "192.168.1.33", (byte)2, 65.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("69848ffc-1ee4-4c73-93ee-d777c20261e0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2662), "192.168.1.92", (byte)1, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("69ad8c6f-5c4e-4fe6-be02-6e1345e426b4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4129), "192.168.1.29", (byte)3, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6a1b185e-43bb-4e21-90ef-5cbb12ca7bf6"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1865), "192.168.1.91", (byte)1, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6b08ee7f-7047-47e3-95fb-ad14a9a40a7d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2670), "192.168.1.84", (byte)1, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("6b660e25-6dfb-4b6c-9148-f3a38fa0ffb3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4485), "192.168.1.66", (byte)3, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6c2b96f6-00e8-4650-9a8a-fa46ee0e7e14"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3853), "192.168.1.60", (byte)2, 48.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6c9a8c0e-646d-458d-adc4-0f5e6724484a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3408), "192.168.1.50", (byte)2, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("6cca569c-70fb-4011-99d7-f843b4feb01c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5148), "192.168.1.26", (byte)3, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("6cffa262-b31c-4a7b-9de8-a2d21a3d2d9c"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3946), "192.168.1.49", (byte)2, 6.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6d0e7b6c-1ea5-4cf9-9825-14eb051077e1"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4957), "192.168.1.74", (byte)3, 55.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("6d163a5d-6500-4dc4-8c43-642e3e52236a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2064), "192.168.1.19", (byte)1, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("6d2d8b2f-8bba-4690-8ae1-8f0a49f36400"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3250), "192.168.1.83", (byte)2, 77.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6e355d69-fe3f-4854-ba79-403502f97c2a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1827), "192.168.1.99", (byte)1, 48.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("6e3f593e-5127-4663-b61c-b647eb693081"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2046), "192.168.1.53", (byte)1, 3.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6f3dc3a0-a97f-41e0-b488-fab4b5cfd35a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4752), "192.168.1.57", (byte)3, 84.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6f782a2d-b6df-4779-ba08-8bc77adc1862"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2754), "192.168.1.1", (byte)1, 13.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6ffe5da1-60a5-4830-a0dc-3f86e00e9984"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4699), "192.168.1.61", (byte)3, 19.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("701a7087-f3ba-4f3a-b4b8-82c585bafd57"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4918), "192.168.1.77", (byte)3, 17.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("70485798-093c-4b26-8c0c-406387934f5c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4511), "192.168.1.73", (byte)3, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("70e141b8-5fad-41a4-95ac-1303ca825c8c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4857), "192.168.1.29", (byte)3, 57.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7246e1fb-9640-4dd2-9c62-02d248ba7b70"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2951), "192.168.1.26", (byte)1, 82.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("72708fa1-da53-4aac-baca-6a606b4598e0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2324), "192.168.1.59", (byte)1, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("72cdbcc5-0f92-4698-a7dc-9303f96d0642"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4202), "192.168.1.52", (byte)3, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("72e2af4e-64d8-4f28-b5c4-182d6c734d38"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5057), "192.168.1.50", (byte)3, 54.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("737fa616-9b41-4827-b350-93b40d561a6d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2827), "192.168.1.97", (byte)1, 85.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("73906a4d-7d18-4a82-80ed-4a42440805c2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2578), "192.168.1.24", (byte)1, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("740880ec-61a3-475a-add7-983ae6b8456d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3320), "192.168.1.40", (byte)2, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("74b026ec-da56-4bcb-9b34-7248214b8153"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2222), "192.168.1.10", (byte)1, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("74c8892c-6d1d-4711-9d03-08b1f97d10b4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4974), "192.168.1.72", (byte)3, 40.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("75955695-78ef-4dac-bc21-b4a2be0c0e21"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4302), "192.168.1.2", (byte)3, 75.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("76c216ea-de59-48a6-96c9-3c8ca9259f0a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2328), "192.168.1.87", (byte)1, 61.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("772f1b3c-71f6-4651-8798-2099992add6b"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2285), "192.168.1.70", (byte)1, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("776bd0ca-a10d-4d17-9fb4-bf05d49070e0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2336), "192.168.1.92", (byte)1, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("77776cae-5084-45d3-8741-b12f34b95372"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3452), "192.168.1.88", (byte)2, 2.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("77df44b5-1871-4c4d-8e50-d4edcc1c205e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2916), "192.168.1.12", (byte)1, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("77e81bc5-8909-425d-9064-66673fa80ee1"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3538), "192.168.1.97", (byte)2, 6.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("780f8b0a-ff2a-4187-9181-b1bf869f4f85"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2240), "192.168.1.1", (byte)1, 64.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("784ab7d0-dde7-43da-ba1c-7b2eed8e4522"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2289), "192.168.1.46", (byte)1, 87.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7861bc49-bb99-4a90-b9a6-5abe94671932"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4682), "192.168.1.34", (byte)3, 64.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("78ccd9d4-d278-47a6-8d68-4521689a4f39"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2643), "192.168.1.70", (byte)1, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("78e91cef-f74a-4e5d-a9d3-572c48357d55"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2458), "192.168.1.40", (byte)1, 11.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("78f0e0e3-f234-4a6b-bba6-9d8b866b527a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3456), "192.168.1.51", (byte)2, 18.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("790d0cc8-fc8c-4b66-9ca3-598e1973e8ce"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3381), "192.168.1.19", (byte)2, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("791600e6-e770-4c9f-bf05-6302a6a1a0fb"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2874), "192.168.1.20", (byte)1, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("792f9021-3213-4891-a344-02f401c479e2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2904), "192.168.1.41", (byte)1, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("793a9cf9-b27a-4cf6-a6c5-f44851e0961b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3674), "192.168.1.37", (byte)2, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("79a9b7b4-9616-47bd-bcd8-816c5eefd388"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3121), "192.168.1.74", (byte)2, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7a06fff4-6695-44b7-ac14-7af402cf6fda"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2021), "192.168.1.7", (byte)1, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7a13452f-fe18-43e5-a974-dc0b407c93f1"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4179), "192.168.1.39", (byte)3, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7a3b86fa-aa50-44e6-ba77-107bacf35136"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2652), "192.168.1.40", (byte)1, 65.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7af3b289-ad8d-4959-a0dc-11fc4c638668"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3770), "192.168.1.35", (byte)2, 27.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7b62b38e-feff-4e30-864f-2fad3a09b8aa"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3715), "192.168.1.66", (byte)2, 69.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7bfa6cf3-49d3-4987-972a-ff298ede6169"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4292), "192.168.1.47", (byte)3, 36.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7c3e3855-6efe-492b-9385-6209a252ac67"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3864), "192.168.1.72", (byte)2, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7c3f0134-140e-4a36-a6af-243a400f699a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3980), "192.168.1.97", (byte)2, 1.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7cb888df-eebb-4ec2-85d5-c528235fa33c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2029), "192.168.1.32", (byte)1, 55.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7d1c77ee-f916-46a4-9574-3ad22b7d9a83"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2943), "192.168.1.22", (byte)1, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7d96ce90-ae13-4637-8480-c3398493d5b2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2148), "192.168.1.1", (byte)1, 91.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("7e1b6bb9-8873-4d87-81d1-041aca9dd609"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4113), "192.168.1.66", (byte)3, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7e8fa0ec-315f-40bf-bc0c-a36dc49285c5"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3574), "192.168.1.88", (byte)2, 27.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7e9b6f8a-55b8-4957-b41f-0d320c2b1ced"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3889), "192.168.1.49", (byte)2, 3.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7eb9c6c0-4cc1-4860-821f-b492103d5e77"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2358), "192.168.1.8", (byte)1, 33.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7ef5d1f5-0ecd-4c48-9966-152956fd0e5a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3079), "192.168.1.81", (byte)2, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("7efd3591-e157-4646-ae0a-fb087ea44447"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3570), "192.168.1.11", (byte)2, 50.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7f7e08a7-9807-49f2-9b67-74a6ec2d05f5"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3629), "192.168.1.72", (byte)2, 70.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7fb265db-103b-433b-bd43-cff4ead76502"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4091), "192.168.1.38", (byte)3, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7ffa37e4-4104-4922-8e77-fc1f9c4585a7"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2489), "192.168.1.63", (byte)1, 23.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("806b6762-5d7d-4cd5-aa3f-0c952c513526"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4695), "192.168.1.77", (byte)3, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("80a08713-4d20-42c0-8c1b-aab150dde174"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4022), "192.168.1.12", (byte)2, 64.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("80ab4651-e675-4d00-87de-3ae12ab06447"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5160), "192.168.1.87", (byte)3, 81.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("816f2e4e-c23f-4fe2-966a-702fbc213d68"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3168), "192.168.1.8", (byte)2, 65.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("81bbf42d-a212-4cd7-ac68-2b4cac9eb96f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4541), "192.168.1.45", (byte)3, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("81c6fd73-2a2a-4ca5-ab2b-17443f76ff1c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2252), "192.168.1.79", (byte)1, 69.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("81cbdf46-de7f-4f19-8284-cba04fc820ae"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3289), "192.168.1.79", (byte)2, 77.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("82022cbb-49c5-4236-95d6-77994a773e09"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2519), "192.168.1.70", (byte)1, 82.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8227d272-69c6-4d4c-8905-5fafbe4385a7"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4457), "192.168.1.46", (byte)3, 19.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("82496731-8d99-41b8-9da8-953977fea07a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2060), "192.168.1.51", (byte)1, 69.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("824fae63-b179-4c2b-b336-36343a779581"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5209), "192.168.1.59", (byte)3, 33.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("82800b3c-6ed8-44e0-abe2-020ce3832eb0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4125), "192.168.1.8", (byte)3, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("82cd65e5-603a-43c1-8766-09bf0344f21f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4083), "192.168.1.27", (byte)3, 62.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("83c690ce-752e-4bf8-8d50-380460dd7fe0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2537), "192.168.1.14", (byte)1, 89.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("83ed41a1-9574-44b8-ae01-ab9199f3ad1c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5106), "192.168.1.23", (byte)3, 57.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("84150ff0-7592-4021-8fb2-9e8b9355b005"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3788), "192.168.1.7", (byte)2, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("848ce1b7-d384-4a75-b31c-fbe3438306b0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2789), "192.168.1.29", (byte)1, 54.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("858ea902-6d17-4bc1-bb10-69a49ace628a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3221), "192.168.1.41", (byte)2, 86.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("85d5030d-8109-464e-b487-e0cc26c0237e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4245), "192.168.1.35", (byte)3, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("86bb9171-308e-4697-bbaf-7c30e47395fd"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4257), "192.168.1.90", (byte)3, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("86d4471b-73fd-4e23-ae6c-63c4e8068030"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4678), "192.168.1.48", (byte)3, 68.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("871e156b-69af-4411-9211-88a30f33ab4a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4648), "192.168.1.86", (byte)3, 29.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("87530fa1-64b9-4fdd-b72e-9c1b18431406"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4430), "192.168.1.9", (byte)3, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8760b5df-6f18-4516-810a-00eee174e66c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4306), "192.168.1.47", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("883d6893-54e2-4fa7-9d73-9f518f018a0e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5183), "192.168.1.90", (byte)3, 8.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("886cb9e4-dd09-420e-bbd5-0eb74646a2c6"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5143), "192.168.1.65", (byte)3, 14.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("89337626-5364-42ec-9122-ab111c123df2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2310), "192.168.1.64", (byte)1, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8a0590f8-6379-4660-aca0-754a7b5d52cf"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3648), "192.168.1.47", (byte)2, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8a21ef0c-c648-4569-8fb4-ec43a1dc5e66"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4103), "192.168.1.39", (byte)3, 95.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8a49180d-c548-44ee-90a4-34c893bef405"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4048), "192.168.1.78", (byte)2, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8ae8a8bb-ece2-4418-adfb-70f432afdbfa"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4395), "192.168.1.42", (byte)3, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8b36b0a1-7538-4658-80b1-aed14477a45a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4969), "192.168.1.38", (byte)3, 43.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8b8302b0-5a02-4429-831d-02e78767a81b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4652), "192.168.1.11", (byte)3, 81.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("8bdffbbc-e87c-4f39-b39e-d7c0bfa681cb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4121), "192.168.1.28", (byte)3, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8be565f2-aaca-48a0-96bd-e2fe65a7c69a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5187), "192.168.1.80", (byte)3, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8c4ed687-75ec-4a75-bdce-990f7edc92b7"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4400), "192.168.1.61", (byte)3, 19.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8c8d96b9-006b-40b2-b492-15d5ab3140f3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3805), "192.168.1.72", (byte)2, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8c9c9e1f-b908-4705-babc-202fa28655c0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5071), "192.168.1.27", (byte)3, 22.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8d232337-4918-4945-a60a-38704f54f84f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5164), "192.168.1.87", (byte)3, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8dd2a392-795c-41a3-abe3-c453f03acee6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3827), "192.168.1.37", (byte)2, 9.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8e178729-094a-4e62-8b2b-8881777f8fa8"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2896), "192.168.1.93", (byte)1, 77.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8e444f59-aa5c-42d0-b9ff-b90d5cd4156f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4748), "192.168.1.72", (byte)3, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8e50e887-d077-45a2-8d0a-294f7ecd06e4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4674), "192.168.1.34", (byte)3, 84.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8f29e49c-79ba-4835-a35d-6b9fbd73d145"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3385), "192.168.1.60", (byte)2, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8f3efbe8-470b-4800-b657-042cf6b807e9"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2811), "192.168.1.78", (byte)1, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8fd3da28-1d02-4fa9-a899-f87d42f22d99"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2256), "192.168.1.25", (byte)1, 33.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8ff1a9d8-f293-46c0-b42e-9ebd5f9a83fd"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2156), "192.168.1.46", (byte)1, 82.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("90a38d5e-9593-44e0-b0cf-d45d46c8e5f0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4744), "192.168.1.12", (byte)3, 10.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("911d4eb2-8572-41d7-9ea9-584dc723bea3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5067), "192.168.1.65", (byte)3, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("917551a6-a9c3-42a2-a3fb-010902038eab"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4691), "192.168.1.5", (byte)3, 95.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("91f4df8a-a62d-4a99-be2b-599bf51b46d7"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4529), "192.168.1.47", (byte)3, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("92986194-e28d-4f51-86ac-a267f2fd7bd2"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3885), "192.168.1.74", (byte)2, 2.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("92a1a61d-8bc5-44e7-a066-321b37025fc3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4481), "192.168.1.58", (byte)3, 96.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("92a28e0f-dd6e-40e6-b212-2d3a97863298"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3544), "192.168.1.54", (byte)2, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("92c734cc-dfc8-40f3-a47f-30e7a0377125"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2982), "192.168.1.42", (byte)2, 57.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("93909c46-405c-49a8-ab97-a4da54ff2139"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3229), "192.168.1.87", (byte)2, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("941aafa3-fc8f-4622-9cdb-42310a4ac952"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3350), "192.168.1.78", (byte)2, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9421128f-fd70-499d-888f-108e5b3a7a39"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1870), "192.168.1.82", (byte)1, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("946f14c4-5904-4269-935a-760d802fe6be"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2793), "192.168.1.57", (byte)1, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("94eef361-79b3-4df7-ba37-358782f44bae"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3207), "192.168.1.53", (byte)2, 14.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9504593d-0050-43de-b413-45113c4b290d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4369), "192.168.1.91", (byte)3, 27.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("956c587c-901a-4f09-a22e-8caef255df19"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3311), "192.168.1.4", (byte)2, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("96676cf7-f1d7-400b-8473-7b550b9582cf"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3908), "192.168.1.99", (byte)2, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("96e5649e-f0cb-4191-9703-05c60acd6549"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2397), "192.168.1.39", (byte)1, 17.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("96feed41-2dd7-4766-acbb-237b85fcc700"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4387), "192.168.1.33", (byte)3, 81.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("971c18e6-e865-4a9f-b509-b782ef6ca2ec"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3273), "192.168.1.43", (byte)2, 71.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("97b47826-13aa-4499-b8ba-c929d77a7046"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3369), "192.168.1.45", (byte)2, 46.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("97bff283-daeb-4d0e-b5f3-5838008320b5"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4198), "192.168.1.33", (byte)3, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9806c3f1-f4c6-430a-8c82-1738f864c053"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2340), "192.168.1.72", (byte)1, 35.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("984d649e-e932-4d99-9e16-71aa8f5e5dc4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4272), "192.168.1.33", (byte)3, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("987b6fbf-fd94-47a6-85fa-a4b3716549f7"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2348), "192.168.1.27", (byte)1, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("98dd3cf7-19db-4755-a13d-7d08dfb32fbb"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1937), "192.168.1.1", (byte)1, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("98de26fe-d484-4481-bd7e-e24eb98fe652"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4175), "192.168.1.78", (byte)3, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("98de590b-9449-43a9-99ef-0bc82460cffe"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4189), "192.168.1.24", (byte)3, 87.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("992ac17f-6dc7-43c3-b939-b9705fdb97bd"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3469), "192.168.1.22", (byte)2, 15.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("999515a0-41a1-46b8-aa2d-f9cbfe9863ab"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4834), "192.168.1.63", (byte)3, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("99c40af7-814b-4256-a12f-5a38e1bb2ea2"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4218), "192.168.1.98", (byte)3, 3.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("99c8b9fa-1bac-48c8-be4c-f372181a3e3d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3338), "192.168.1.20", (byte)2, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9a62179a-08a3-467d-999a-9ccba725519a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5018), "192.168.1.3", (byte)3, 7.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9ae94c73-cf3e-440b-a544-1256bad3764b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3259), "192.168.1.91", (byte)2, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9af873c9-df83-4b01-b5d5-32a24735dd0a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4156), "192.168.1.82", (byte)3, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("9b621402-c692-4295-905e-fbfe287e1c35"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3694), "192.168.1.37", (byte)2, 58.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("9ca7b489-6f13-4d72-9a9f-be2946453a3f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4099), "192.168.1.54", (byte)3, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("9d1e8af4-349f-487d-aa7c-6555b1045cb2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2306), "192.168.1.54", (byte)1, 11.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9d62a231-d9b9-465e-bd98-03d26a15611b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5114), "192.168.1.65", (byte)3, 55.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9dd22748-1fd0-446e-b357-d33f7328fe44"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5079), "192.168.1.2", (byte)3, 58.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9e13bdb2-7897-4b92-8de0-014a54bca395"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2736), "192.168.1.84", (byte)1, 70.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9f309f79-d286-408d-a52d-1b34209cb21e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4879), "192.168.1.7", (byte)3, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9f58d595-3b03-4033-afa9-68bb919f78f0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2056), "192.168.1.99", (byte)1, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9fb6e6fc-89c8-4ce2-8284-20c67e8b1d2f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2524), "192.168.1.88", (byte)1, 90.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a0c02b76-09ca-44a2-8689-793682f4f79a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3039), "192.168.1.49", (byte)2, 33.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a126f1a7-1abe-43d5-8e07-cc49a4e2b5ca"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3813), "192.168.1.43", (byte)2, 27.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a129e27f-6d74-4d46-a7b2-fb9ece43666a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2776), "192.168.1.1", (byte)1, 79.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a14320be-ecc9-4a91-a7d8-b1ca05c4a439"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1874), "192.168.1.53", (byte)1, 70.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a151abe6-b4ac-4a4d-8d38-e7fd4f2714b1"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2195), "192.168.1.93", (byte)1, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a1776569-304e-4ab2-b162-efcbdbc85647"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3487), "192.168.1.97", (byte)2, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a1cf1c50-f2f7-4301-a5e9-14fb78f422d5"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4003), "192.168.1.28", (byte)2, 48.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a20d3637-2e43-441f-8ea3-00248e61cd47"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2750), "192.168.1.72", (byte)1, 73.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a234671c-d808-480f-8f17-337a013adccc"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3548), "192.168.1.50", (byte)2, 84.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a3099c96-3b85-444f-b856-cb906b276ecd"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4668), "192.168.1.55", (byte)3, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a37b7917-c78d-434e-90e3-466554d74576"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2727), "192.168.1.82", (byte)1, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a3bc0e37-72cf-46fc-b56b-5eb5a9cd2f86"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4581), "192.168.1.65", (byte)3, 53.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a3e8fd1e-6cc3-4dac-b47c-528090c17351"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2152), "192.168.1.34", (byte)1, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a43f7eed-f655-435f-bdfb-142840c2cb4f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5230), "192.168.1.24", (byte)3, 96.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a456421d-2907-49d7-b0c4-1d1589bb5d19"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2413), "192.168.1.32", (byte)1, 3.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a4b59fe2-c008-47f0-8225-7dd026f8b0cb"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4034), "192.168.1.11", (byte)2, 41.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a4c42134-ab61-421a-997f-97572c7106ff"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3843), "192.168.1.46", (byte)2, 65.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a529675e-22dd-4e6b-b9d5-40d170773358"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2366), "192.168.1.10", (byte)1, 69.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a562ad0a-f744-405b-8c79-938c2e19553b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3495), "192.168.1.73", (byte)2, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a59415e5-6702-4ee2-9c0d-4347c27ac6f2"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5126), "192.168.1.78", (byte)3, 55.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a59543b0-5f0f-406e-ab94-9d465ae6996e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4095), "192.168.1.30", (byte)3, 23.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a61fde77-8d04-452f-8ce5-e4aadcf41c84"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4253), "192.168.1.75", (byte)3, 49.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a712202f-4e96-4d2c-b627-18af2f8134c8"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3590), "192.168.1.5", (byte)2, 73.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a8da3329-fda9-4aa3-9630-1c6c980cf4a4"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2379), "192.168.1.82", (byte)1, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a8e71d80-5c5e-4c81-9b6f-a8ca5082116e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5063), "192.168.1.25", (byte)3, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a9a78e50-f294-4f83-b0ee-e771a1c9278d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3582), "192.168.1.32", (byte)2, 50.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a9af4495-b701-4adc-8d57-ac215de0e0a4"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2770), "192.168.1.74", (byte)1, 46.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a9e9fe14-c3d8-427c-8dc0-8b5ad6b8142a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4015), "192.168.1.32", (byte)2, 20.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a9f1c1c3-9473-437d-9a8e-29c251076439"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3194), "192.168.1.91", (byte)2, 61.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("aa30074c-a4f6-4445-acf1-48af695bf954"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4267), "192.168.1.66", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("aa35d7fb-d73a-4339-b78e-4ec322809e0e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2301), "192.168.1.80", (byte)1, 93.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("aa794ff5-fd10-4a38-983a-78203fc908da"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4334), "192.168.1.41", (byte)3, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("aa9e9a1b-7164-453e-a17b-642e6bd4a572"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3377), "192.168.1.75", (byte)2, 61.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ab234aaf-24f6-4546-8ea0-31ae29d3b2f0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4930), "192.168.1.60", (byte)3, 32.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("abedfbb6-0762-466a-8444-82648eb9a296"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3180), "192.168.1.12", (byte)2, 72.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("abf30c78-5d37-4a3f-affd-307baa5e1cdf"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3652), "192.168.1.78", (byte)2, 38.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ad92895e-a6f2-45ea-89c6-5cb9937815e4"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1896), "192.168.1.16", (byte)1, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("adcd27fe-bf0e-4f51-917f-413757127b16"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2187), "192.168.1.46", (byte)1, 50.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("aeb565bc-0802-44c5-8901-d366d752fd3f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4611), "192.168.1.36", (byte)3, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("aebf20c0-d91d-4dc4-baee-e2f097624990"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2320), "192.168.1.45", (byte)1, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("aeca0966-dbf6-47bc-8107-64f06c1d1936"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4935), "192.168.1.91", (byte)3, 11.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("af5b8911-0e9a-42f2-a7c1-49c591959828"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4839), "192.168.1.37", (byte)3, 93.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("af73d276-6ebd-497a-83cc-08d83cd32439"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1967), "192.168.1.46", (byte)1, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("af8bf5e9-bda7-45a8-b4f4-1f7357a8d806"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2179), "192.168.1.31", (byte)1, 68.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b017b3d7-0732-44ec-9c2a-c7615f8c6ad5"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1918), "192.168.1.97", (byte)1, 89.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b08988fc-6c40-4a0f-adec-b2658bf0124d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2442), "192.168.1.25", (byte)1, 26.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b0b1ad23-008d-4683-bd37-26fab1ad8aed"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5203), "192.168.1.29", (byte)3, 70.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b1738ad9-5bd0-41cb-ba43-1524dfaf702d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3809), "192.168.1.60", (byte)2, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("b181c716-16e1-49d1-807d-371a2f4607ef"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4288), "192.168.1.14", (byte)3, 17.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b200f065-a385-413b-9914-b0e21b66d842"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2912), "192.168.1.9", (byte)1, 47.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b221ea17-6997-44f8-b432-4c484786ab19"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3831), "192.168.1.11", (byte)2, 70.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b25b4119-2eee-47e4-8bc7-41b5358a22a7"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5169), "192.168.1.66", (byte)3, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b25c891c-d550-4e95-ac9a-d275a435976c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5102), "192.168.1.92", (byte)3, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b26d547e-018d-411e-b88c-1e9773b85059"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3342), "192.168.1.56", (byte)2, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("b282ae77-6556-43cf-b999-9cb358c26164"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2389), "192.168.1.95", (byte)1, 62.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b311b618-db81-40d2-b681-5b0a66524a1e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4904), "192.168.1.31", (byte)3, 12.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b32c893c-402a-4a9a-b1dd-b257230439a4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4599), "192.168.1.65", (byte)3, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b3429f6b-2b40-4ff9-8d5a-580bc8169025"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4064), "192.168.1.86", (byte)2, 84.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b4074309-46ac-4f60-9419-9814812a7f4a"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2992), "192.168.1.86", (byte)2, 67.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b4341e79-b3f1-47c4-b432-3a777ae3cd15"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3299), "192.168.1.20", (byte)2, 31.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b486c23b-d3dc-4446-8ffa-321db38933c2"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4568), "192.168.1.27", (byte)3, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b551c943-6e42-42b6-8f87-e56170abe100"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4353), "192.168.1.20", (byte)3, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b5f8ad63-4ea9-4e08-b076-5c2c2e6c8862"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2926), "192.168.1.8", (byte)1, 42.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b69e975a-8c2e-4c79-bbaa-3f32d60f0649"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3664), "192.168.1.20", (byte)2, 17.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b6b52d87-421e-4973-a871-743ea17ccedb"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2840), "192.168.1.59", (byte)1, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b71c5736-a100-495f-a9dd-27d9cf19c2dd"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2099), "192.168.1.2", (byte)1, 21.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b7a35762-afa6-4a5d-a31f-16b1e2e85d77"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4585), "192.168.1.96", (byte)3, 97.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b7eb8af6-2c16-43c8-b61c-3dbb928ca66a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1945), "192.168.1.85", (byte)1, 84.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b863ee67-6c32-4017-93c4-1f4d1187119d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4133), "192.168.1.67", (byte)3, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b8e41e06-5600-4613-8913-c02f2ccad82b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4284), "192.168.1.53", (byte)3, 94.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b953815b-6181-4cfa-a659-ca3cc914eae4"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4953), "192.168.1.39", (byte)3, 69.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b9720e12-e470-4fa3-8758-314aad8e45d9"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2481), "192.168.1.11", (byte)1, 17.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b9766960-4dad-41e6-b7df-8e492232e435"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2418), "192.168.1.45", (byte)1, 99.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b9e667c2-7aeb-451b-aa58-8940e7d9967e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2450), "192.168.1.69", (byte)1, 20.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("baf22646-8a91-422b-a0cf-0c44f7fbfd2c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2485), "192.168.1.67", (byte)1, 65.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bb6d45d2-b0ce-45f0-b141-46ad0da98755"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5244), "192.168.1.82", (byte)3, 94.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bbc54f5a-6a20-466c-80d0-b26b1d1aaba2"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2462), "192.168.1.80", (byte)1, 15.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bc80fc92-48a5-4ffb-9eee-c596f6943764"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2011), "192.168.1.48", (byte)1, 1.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("bcf0d535-ab40-438f-81f3-b56fc633b9c6"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2930), "192.168.1.75", (byte)1, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("bcf1ff4c-ac0f-4ade-9c92-83aabf77cd38"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4499), "192.168.1.50", (byte)3, 61.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("bd2a9e10-ed04-4c20-97d3-3c9d84ab34ef"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2922), "192.168.1.89", (byte)1, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("bd3a0142-3a80-4e30-a038-9f90436e9802"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4068), "192.168.1.18", (byte)2, 33.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("bdfc5226-8d98-4fd3-8a94-6ca69b388e23"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3281), "192.168.1.12", (byte)2, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("bdff0288-8d68-4dff-bf86-212f87fa3565"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2034), "192.168.1.73", (byte)1, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("be69e047-9936-4e59-947e-575b5ecd9060"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2678), "192.168.1.59", (byte)1, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bf61f8bf-c814-488e-a370-bdded25eaa50"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2314), "192.168.1.92", (byte)1, 5.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("bf730a00-9a72-4a0b-81b3-ab3d9d61be30"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4603), "192.168.1.75", (byte)3, 80.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("bf7567a0-a4fb-4ed9-8a29-8f80aa9ac522"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1994), "192.168.1.8", (byte)1, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bf8965b0-b3b8-4e7e-bcce-3c958f262db0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2175), "192.168.1.28", (byte)1, 82.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c02e6732-3957-4622-8921-055e3673e9a7"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2191), "192.168.1.57", (byte)1, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c0720323-592e-44a7-8f9f-ad2dea4a1671"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4184), "192.168.1.23", (byte)3, 78.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c08d2f05-1c9f-44a4-9acd-74c32aeb45ae"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3847), "192.168.1.1", (byte)2, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c0e0f310-3336-42df-803f-66279fba0437"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4315), "192.168.1.35", (byte)3, 27.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c105448b-0931-47f1-9d52-59f8e16e7855"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5152), "192.168.1.79", (byte)3, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c16a9ecc-0e32-4438-9a11-a2eadd32f838"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5014), "192.168.1.49", (byte)3, 89.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c18b7bdd-ebe8-42d6-ac94-17bb572ee312"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3111), "192.168.1.79", (byte)2, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c1919c2e-d488-4681-bac8-59bc420ec3cc"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4465), "192.168.1.75", (byte)3, 50.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c1a9270c-b47f-4e6e-b5f5-11ac2c3e31cc"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1819), "192.168.1.90", (byte)1, 20.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c2201391-da02-4006-8334-78469e2871dc"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3732), "192.168.1.17", (byte)2, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c23f2aeb-0b0a-47ba-8377-654995400058"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3103), "192.168.1.52", (byte)2, 98.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c23fb568-7164-4baf-8823-3b2416871fc3"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2719), "192.168.1.51", (byte)1, 69.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c2832009-5497-4cdb-8b40-b852db577b10"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3277), "192.168.1.50", (byte)2, 55.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c3c0047a-6017-4286-95f6-db5fd095c17a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2574), "192.168.1.21", (byte)1, 80.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c55104d3-9249-42f3-bc4b-fddc7d445aa0"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3172), "192.168.1.80", (byte)2, 38.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c556d943-e5a6-4b95-aff4-1fdef8b19247"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3895), "192.168.1.45", (byte)2, 45.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c5652c2b-ed47-452a-8c0f-6bcd355b3888"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3522), "192.168.1.82", (byte)2, 92.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c579796b-82b4-42c4-8907-35cab1bc8aec"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4138), "192.168.1.53", (byte)3, 48.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c5ca5b8d-eadf-4a1c-b400-bb4c82f5cd10"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3530), "192.168.1.22", (byte)2, 39.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c5d8311c-b37f-45cb-8d3d-b42b2cd7b5bd"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3750), "192.168.1.14", (byte)2, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c60cde95-dbf4-4352-a54f-2faf4714d4d5"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5199), "192.168.1.69", (byte)3, 75.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c6e229c2-af09-4172-ad4a-6342e5ec84ba"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1823), "192.168.1.94", (byte)1, 11.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c6fb62d6-73f1-4e1a-b46b-8e2e9f55be79"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4438), "192.168.1.40", (byte)3, 49.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c7843cc0-bd1e-43f4-a1fd-5f1b949e49b8"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2849), "192.168.1.10", (byte)1, 72.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c7a159ea-59a2-4a5e-8e6c-ac179f4779db"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3670), "192.168.1.15", (byte)2, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c7c02a68-2b5c-4746-bb32-4dcc18cd3796"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3792), "192.168.1.62", (byte)2, 2.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c7c4d0af-a738-4a4a-9cec-78e80e3e53db"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2682), "192.168.1.90", (byte)1, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("c85df647-19ae-4dc7-b0f6-d7641693c98d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2244), "192.168.1.40", (byte)1, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c868ee69-db9a-430c-9b96-c0f8feacb56d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4537), "192.168.1.75", (byte)3, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c8f22595-59e6-4646-9690-b09a64a97a6d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3465), "192.168.1.84", (byte)2, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c96285df-db3e-412a-84d8-1875ce39f095"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2908), "192.168.1.1", (byte)1, 66.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c97e13cb-9ae5-482d-8861-607525bf2246"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3989), "192.168.1.13", (byte)2, 84.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c99cd5a1-e435-4753-b761-789305b1771f"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3728), "192.168.1.71", (byte)2, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ca33f167-8d2e-46a0-b40a-5021c4ee376a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2507), "192.168.1.14", (byte)1, 19.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ca786aab-1da3-476d-9a44-ee003599f69b"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4738), "192.168.1.27", (byte)3, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ca7c4249-0c5c-4d15-b2c7-3dbfa76c13f5"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4206), "192.168.1.81", (byte)3, 89.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("cafc3db1-f1a1-4771-9557-0531d5f3af68"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5226), "192.168.1.69", (byte)3, 46.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("cb10ea35-2126-4a95-8081-8fa8e5001d91"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3534), "192.168.1.4", (byte)2, 55.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("cb331eee-b517-4429-9463-c84b74777bbb"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2878), "192.168.1.4", (byte)1, 28.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("cba4dd39-bbe0-4662-b5d1-b35706a79d61"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5023), "192.168.1.2", (byte)3, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("cbb97a71-9f8e-4f37-ae93-1b9076385769"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3057), "192.168.1.55", (byte)2, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("cbccb873-3c25-450b-9b83-67e500da4826"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4276), "192.168.1.11", (byte)3, 80.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("cbfe1eca-f240-4e56-aa98-7d31642692a2"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3639), "192.168.1.78", (byte)2, 25.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ccc37f74-6cc9-4c1a-bf7b-6495bad68ee2"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3461), "192.168.1.3", (byte)2, 92.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cd490948-b0df-4f0d-983d-af842c8e2ebb"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3993), "192.168.1.21", (byte)2, 13.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("cde3ed51-b31b-4501-8d17-50ecab83d90b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3373), "192.168.1.43", (byte)2, 91.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("cdfed625-5920-45dd-9ab1-3eee00d263be"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2515), "192.168.1.30", (byte)1, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ce12318f-c2e9-4e6c-b996-ed379c62489f"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3134), "192.168.1.50", (byte)2, 93.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ce6ce978-4a64-4f08-a8f4-3636af47dfb8"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2218), "192.168.1.8", (byte)1, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ceca53a5-8d7c-4620-a97c-24051c9cc1ff"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2393), "192.168.1.2", (byte)1, 95.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("cee524e5-5b53-45fb-8db1-220f9c6892d5"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2731), "192.168.1.25", (byte)1, 82.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("cf1580e3-b0fb-4ff5-b046-5e9ee0d3753a"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2405), "192.168.1.66", (byte)1, 42.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("cf2ca8a6-693c-45ce-acc0-a95206622699"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3084), "192.168.1.71", (byte)2, 10.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cf7c88a6-72f8-479e-b13e-afc8f6a300c6"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5041), "192.168.1.17", (byte)3, 85.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("cf92e916-79be-4d25-93c4-a860c934783e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3985), "192.168.1.68", (byte)2, 8.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("cff36bc4-45c9-4806-a415-dcecaa1c54cb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4448), "192.168.1.7", (byte)3, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d0a591c5-f0e9-47da-8b8c-192e5cc0b9c1"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5037), "192.168.1.41", (byte)3, 19.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d0aa8a76-c26a-4368-b9b0-561355b5bd1c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5118), "192.168.1.62", (byte)3, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d0cc4ec8-a497-4ccf-8760-8e1b2c441086"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1961), "192.168.1.26", (byte)1, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d1bb8e71-2bb9-4e27-a753-a5dd5adf4922"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2674), "192.168.1.41", (byte)1, 26.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d1c29ada-12d0-46cf-9de0-c9b892c6277e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4072), "192.168.1.70", (byte)2, 85.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d240a4b1-c49f-4f74-b3bd-dd96ca31b7f1"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1971), "192.168.1.69", (byte)1, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d24a2596-d1d9-44ac-b1f8-a079cc9ef121"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4594), "192.168.1.77", (byte)3, 74.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d2edb18b-7a5e-4462-af37-e0d966e8b23c"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3430), "192.168.1.7", (byte)2, 79.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d333b803-480d-4388-b6f3-ac997d04b6d1"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3186), "192.168.1.25", (byte)2, 14.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d3435386-22fe-40eb-9ee9-83bf57fcd0a5"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2635), "192.168.1.51", (byte)1, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d39df626-9cd4-4b5e-a8eb-ab6ad265df6c"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3346), "192.168.1.21", (byte)2, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d444eeae-2719-40c8-afc6-020e0c0c2d66"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3682), "192.168.1.72", (byte)2, 63.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d45a6c3b-9b2c-4898-a8c7-fd5fe410330a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4845), "192.168.1.38", (byte)3, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d53d90e4-b5cc-41ff-ad9a-2694ac919362"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2892), "192.168.1.20", (byte)1, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d60a6c1b-6098-48c2-b04f-bc78ac5aad25"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1949), "192.168.1.70", (byte)1, 14.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d62a3ced-09f4-4ae2-9225-05103805460c"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3766), "192.168.1.58", (byte)2, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d668c275-71a5-489d-a75e-c82bc92b137d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2627), "192.168.1.52", (byte)1, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d6f460d0-2254-454f-bd2a-da9ab846bae9"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4507), "192.168.1.60", (byte)3, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d70cd5f6-789b-403a-8ad4-8062900b3604"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3566), "192.168.1.36", (byte)2, 58.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d777c992-88ae-4d9e-bdac-1b30c5fa46d4"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3334), "192.168.1.4", (byte)2, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d7949348-8c52-487c-ad6d-645a1e18594c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2831), "192.168.1.97", (byte)1, 52.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d8209434-8281-46e3-b30e-4e9743f84b00"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5191), "192.168.1.62", (byte)3, 54.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d91b8d1f-93a1-49e7-b1b3-48004f0a4e24"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3389), "192.168.1.57", (byte)2, 69.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d92f042e-0d6a-457b-8921-efc1ad404739"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2383), "192.168.1.36", (byte)1, 70.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d9471775-1a5f-4f79-bfb3-5a0b5590cf80"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5174), "192.168.1.91", (byte)3, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d9f1718a-fff1-4b97-9cf1-f5af7a860af5"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1886), "192.168.1.93", (byte)1, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("da2a2fa1-5095-4b08-9932-00efb6ab7576"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2293), "192.168.1.29", (byte)1, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("da2e17f5-92b4-44ea-9d0c-05889ccc716c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2819), "192.168.1.54", (byte)1, 46.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("da5170f6-dcd8-4c53-9004-c44c024830eb"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3129), "192.168.1.39", (byte)2, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("da6cae45-bab9-44c4-b985-2518f51070e5"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3942), "192.168.1.45", (byte)2, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("da6dd12b-22c2-4f23-b634-463d0f540c38"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3621), "192.168.1.28", (byte)2, 47.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("db066942-5e4d-4fe2-bdfd-5315a62f07e1"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3968), "192.168.1.83", (byte)2, 82.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("db3b855e-944a-482b-83b1-8e7eba95a5ca"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3053), "192.168.1.60", (byte)2, 87.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("db717af9-7ff4-4777-84b9-60bcf41f96fb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4869), "192.168.1.56", (byte)3, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("db949d8c-e708-444c-abb4-e2e855f46f96"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4896), "192.168.1.44", (byte)3, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("dc3b13e4-b74b-44cc-ba48-fe5e23c02af3"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4442), "192.168.1.85", (byte)3, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("dd208574-758c-4ca5-b589-b3fdf2fd54b9"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2601), "192.168.1.20", (byte)1, 74.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("de0ca99f-f357-4603-9142-20bc01513483"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2869), "192.168.1.1", (byte)1, 28.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("de338f76-a785-491b-bb22-533288d0d983"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4519), "192.168.1.84", (byte)3, 96.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("df0c9edb-69f9-4f7b-b4d0-a67d9e9ebbb0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2436), "192.168.1.89", (byte)1, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e0f8a682-0f82-4346-bdce-5893bd101894"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4873), "192.168.1.99", (byte)3, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e140b994-7927-4718-b3c9-0224189278b0"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4900), "192.168.1.40", (byte)3, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e1449967-3fd9-4685-b6e3-0a0c75369f7e"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2562), "192.168.1.44", (byte)1, 32.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e176b9b2-34db-459f-9fea-32883918ba70"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4554), "192.168.1.52", (byte)3, 71.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e1948ead-8e03-41e6-b853-511a0292aa1c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4490), "192.168.1.4", (byte)3, 0.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e1eeb4f3-6165-449c-a8fb-1c3429471584"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5075), "192.168.1.43", (byte)3, 33.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e2221b2b-d80e-4fb2-b25f-34e744d7060f"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4453), "192.168.1.38", (byte)3, 30.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e27aa447-fc76-4d01-8def-7251c5755677"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5032), "192.168.1.67", (byte)3, 40.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e2ade270-bb3b-4c25-8ad3-5e304a239220"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2746), "192.168.1.46", (byte)1, 49.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e37157e9-44c9-4e7d-a370-453877d7ee2d"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3686), "192.168.1.16", (byte)2, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e40e478b-22d5-4194-8c25-d0740a421444"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5088), "192.168.1.21", (byte)3, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e428789a-0169-47f4-89ce-aa2c2b61f6fe"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4949), "192.168.1.97", (byte)3, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e4779c60-e4a8-4faa-be23-3e2a2e671b2e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4193), "192.168.1.13", (byte)3, 10.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e4a6edba-0b2c-4cf6-b77a-cf35e7831aa5"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4908), "192.168.1.44", (byte)3, 63.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e4e5bb2e-e974-4d41-af1c-219a1d1b0a9b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3835), "192.168.1.87", (byte)2, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e54c0e88-e07f-4e5b-8650-36b4c212411f"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3099), "192.168.1.79", (byte)2, 36.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e5918e2f-9b0b-402a-8eb2-cf707b78498f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1891), "192.168.1.37", (byte)1, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e59b7301-d6c9-4d2e-9fed-6b9ecc9f25d2"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4713), "192.168.1.80", (byte)3, 34.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e6318cd6-debf-44be-a5d0-e9dace9d1ed0"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1900), "192.168.1.84", (byte)1, 7.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e65c1a12-d87e-4505-86a8-c0342eae1abf"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4717), "192.168.1.53", (byte)3, 42.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e6fe38d8-f427-40b6-9885-80663dca0835"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3964), "192.168.1.11", (byte)2, 69.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e83f32e0-1154-40c3-86f6-e2962a6c84a3"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2935), "192.168.1.46", (byte)1, 8.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e8b9c1fe-a286-4c9a-bacd-58c1f3cacff3"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3595), "192.168.1.87", (byte)2, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e8f8bcd2-3f96-47e7-9cd5-8bd011ee6153"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4365), "192.168.1.89", (byte)3, 9.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e936bd3e-ef06-4094-92da-e07db16b4eff"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3426), "192.168.1.30", (byte)2, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e9d92ab0-8694-47ca-a577-84fa17de8478"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1855), "192.168.1.88", (byte)1, 0.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ea4f0982-860f-49f9-9794-2e360048ebe2"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3869), "192.168.1.58", (byte)2, 56.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("eb100d8a-1940-4c40-b7e8-ec6c98af6f01"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3899), "192.168.1.15", (byte)2, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("eb315241-d7b8-4402-9e5a-9f06ed78d2e5"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4709), "192.168.1.80", (byte)3, 39.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("eb3e2bd2-1d16-4b9b-8555-2cbeebcc2ddd"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2639), "192.168.1.60", (byte)1, 29.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ec25dc6c-1d88-4154-a373-4b1e8d6f2253"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2854), "192.168.1.46", (byte)1, 89.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("eca6cbe6-dad7-4c45-923a-064b966a8d40"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3656), "192.168.1.15", (byte)2, 4.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ed76ddd2-90dc-42d8-8c25-2661046da772"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5006), "192.168.1.43", (byte)3, 72.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ed787368-22cf-4aca-bce0-c54b0c9d665d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2086), "192.168.1.73", (byte)1, 69.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("edd66e9c-52a3-4cf3-97a2-c81737bbab94"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5178), "192.168.1.17", (byte)3, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("edd705c7-c043-45b3-9d8a-f5d2f0d279e9"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3152), "192.168.1.31", (byte)2, 85.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ee448c0f-4dd2-4524-bbaf-ffef8a8c1807"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2375), "192.168.1.93", (byte)1, 92.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("f04a13d6-02b6-4f8b-8191-72b73983d221"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4383), "192.168.1.94", (byte)3, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f1672a9a-1b8e-4102-9f0c-20d2427a9ba1"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2741), "192.168.1.88", (byte)1, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f1c60de1-fe7c-4bb2-9226-3b444d295514"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4634), "192.168.1.76", (byte)3, 59.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f2915b6a-59e0-44c7-b350-696ff5425af6"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5002), "192.168.1.73", (byte)3, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f2ad1de0-0f23-4a00-b0e8-ccddb797e47b"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4038), "192.168.1.76", (byte)2, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f2f72e1b-2959-4fc9-baf5-ba6228346302"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4560), "192.168.1.28", (byte)3, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f3099b12-126a-4bd5-abad-18ea34d3c2c2"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4026), "192.168.1.47", (byte)2, 18.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f41d8f33-fd5f-439f-b89b-6318282f0e2d"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4660), "192.168.1.57", (byte)3, 78.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f4301b49-1ff3-4739-bb65-6419a48ca982"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5110), "192.168.1.37", (byte)3, 37.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f491b9ad-d452-4dc8-8434-f351272005ce"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3723), "192.168.1.76", (byte)2, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f4aed478-37cc-4510-8ede-2bc2cb7a4c5d"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2199), "192.168.1.5", (byte)1, 5.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f4cdec82-8709-4965-aeef-a37ee06dec12"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3265), "192.168.1.94", (byte)2, 13.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f53431a6-e013-4f5f-86b7-dcad9ad9d703"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4994), "192.168.1.47", (byte)3, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f606ec07-a590-4080-a9d7-4f787b3b2628"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2269), "192.168.1.57", (byte)1, 90.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f690801c-e78b-454e-8c13-0a2019ff62aa"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4434), "192.168.1.10", (byte)3, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("f799a790-d0f3-4e6e-8e4d-3f9d8f7ff83c"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4422), "192.168.1.5", (byte)3, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f79d944c-08ff-4f78-bfbd-6db7157e0b5e"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3512), "192.168.1.13", (byte)2, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f7d819e6-fdf9-4f04-89b3-4d9950a4bd1e"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4865), "192.168.1.71", (byte)3, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("f84cd963-23f4-419d-a2eb-3c6549a09186"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2715), "192.168.1.54", (byte)1, 89.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f8d3cb12-8016-4142-ac94-d1497a6ef5b6"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3324), "192.168.1.30", (byte)2, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f8f3d4e9-1576-4107-b247-566c0b75090a"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4721), "192.168.1.26", (byte)3, 90.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f907f4b0-01ac-4b74-b201-b71269b6551c"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2805), "192.168.1.82", (byte)1, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("f98378c5-cccf-4aa1-a0d8-b1f04c600d43"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4391), "192.168.1.97", (byte)3, 23.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fac7e65b-d674-4504-acac-6383069e50a8"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3930), "192.168.1.66", (byte)2, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fb96e703-177d-41d4-b28f-7734750a3d61"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3363), "192.168.1.53", (byte)2, 93.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fbe7caec-42bf-4c5e-86b4-d85566a73095"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(5122), "192.168.1.21", (byte)3, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("fd00911c-96c1-4df8-a674-4a2c9b500ab3"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(1941), "192.168.1.26", (byte)1, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fd55bd35-ca3f-4a71-8026-25e2dcb911eb"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4888), "192.168.1.2", (byte)3, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fd59ed40-238e-4fcf-ba23-56cb0f44eff7"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2621), "192.168.1.2", (byte)1, 43.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fd5d3bee-ae9d-4357-92f7-48ae51392ae5"), "Computer2", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(4939), "192.168.1.1", (byte)3, 26.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("fd635e19-7a64-4bdc-baa2-8618be483811"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2723), "192.168.1.9", (byte)1, 50.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fdc1c583-24f9-4c27-9ba3-17bda76709f7"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3442), "192.168.1.9", (byte)2, 24.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fdea379f-af76-4acf-baf0-ed9082fe0e6f"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2432), "192.168.1.10", (byte)1, 79.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fecd97d4-7cbd-4831-95aa-acfd0725cefe"), "Computer0", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(2007), "192.168.1.72", (byte)1, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ff60a1a3-5f20-4edf-b89f-f255f182e202"), "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 354, DateTimeKind.Utc).AddTicks(3354), "192.168.1.80", (byte)2, 91.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("17f859cb-71b1-46d7-81e3-7f0ba67bbf4d"), "1-A", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8646), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null },
                    { new Guid("19963e3a-e174-4692-8528-344321cb7f58"), "4-C", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8715), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("1abe0d61-ed19-4094-86c6-e304a136aeba"), "4-C", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8712), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("55c02af9-53fa-497b-abc4-af27f7a4c72a"), "1-A", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8637), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("5a3f9302-0688-44d0-94e8-f65f456e9d10"), "", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8682), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("68b55558-730b-4eee-8844-93ad3d6393e0"), "2-B", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8661), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("7c002d7e-de85-4e8a-b181-8c9ad697e486"), "", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8678), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("7eb1bee3-ebe8-426a-97b0-4fe3951a5e4e"), "1-A", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8690), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("9c65f82c-7cbf-4e17-9892-86bc42bec2f9"), "3-D", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8674), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("b94e0b65-11c9-486d-ab5d-11c93e62928e"), "3-D", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8669), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("bb219a04-c4e6-4f1e-b036-8bfaa3ff9cd7"), "2-B", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8698), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("bc89f8a2-8dbd-456b-a9e1-e864992bd0fc"), "2-B", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8665), "192.168.1.1", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null },
                    { new Guid("db9838b0-0edd-4b95-965c-2d6dd0dacd45"), "", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8705), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("e5e33d5d-2b26-4ab2-a000-7d9e68d0457d"), "", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8708), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("ed0654ce-3ffb-479c-8173-84069a770d48"), "1-A", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8695), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null },
                    { new Guid("f58463e8-d307-4b8f-a16a-daf96887aa70"), "2-B", "Computer1", new DateTime(2024, 2, 26, 13, 37, 34, 355, DateTimeKind.Utc).AddTicks(8702), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null }
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
                name: "IX_Students_ClassroomId",
                table: "Students",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

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
                name: "TeacherSchedules");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SubCourses");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "MainCourses");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
