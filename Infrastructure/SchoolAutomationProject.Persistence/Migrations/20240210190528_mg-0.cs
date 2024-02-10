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
                    Grade = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Section = table.Column<int>(type: "int", nullable: false),
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
                    MainCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MainCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Achievements_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_SubCourses_SubCourseId",
                        column: x => x.SubCourseId,
                        principalTable: "SubCourses",
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
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_SubCourses_SubCourseId",
                        column: x => x.SubCourseId,
                        principalTable: "SubCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Day = table.Column<int>(type: "int", nullable: false),
                    TimeSlot = table.Column<byte>(type: "tinyint", nullable: false),
                    Classroom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSchedules_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1abfbe1e-41be-4440-8dd3-4bf6127d77d3", 0, "87f836d1-a7dd-42d7-8bd7-0e1a35d6492b", "ahmet.yılmaz@example.com", true, false, null, "AHMET.YILMAZ@EXAMPLE.COM", "AHMETYILMAZ", "HashedPassword", "1234567890", true, "82ca47e8-46a5-4672-9ad4-0a0debaef0ab", false, "ahmetyılmaz" },
                    { "2862264a-af6f-447a-a449-c317c736ed48", 0, "0a675a6b-f10a-43be-9ad6-81bc3d1c95b2", "mustafa.şahin@example.com", true, false, null, "MUSTAFA.ŞAHİN@EXAMPLE.COM", "MUSTAFAŞAHİN", "HashedPassword", "1234567890", true, "375518e8-bcbc-4e08-acd1-ec1cd11ec1ab", false, "mustafaşahin" },
                    { "5fc06fe1-18ad-4bf9-8833-85c502b493cc", 0, "a2e748f1-0d79-4c07-b359-5cc970cc74bc", "ayşe.kaya@example.com", true, false, null, "AYŞE.KAYA@EXAMPLE.COM", "AYŞEKAYA", "HashedPassword", "1234567890", true, "c68752eb-05a7-46d6-a474-b532d40c302f", false, "ayşekaya" },
                    { "e042c938-cf05-4ef1-8e3c-bd4efefe1fe0", 0, "d11f341a-2a65-413f-a703-bbd4aad9a4b6", "yusuf.tataroğlu@example.com", true, false, null, "YUSUF.TATAROĞLU@EXAMPLE.COM", "YUSUFTATAROĞLU", "HashedPassword", "1234567890", true, "2dce47e9-2393-4990-a9af-77cb01e0dd03", false, "yusuftataroğlu" }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Capacity", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Grade", "Section", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(8553), "192.168.1.3", "2", 0, null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(8551), "192.168.1.2", "1", 1, null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(8548), "192.168.1.1", "1", 0, null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(8554), "192.168.1.4", "2", 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4175), "192.168.1.1", "Matematik", null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4178), "192.168.1.2", "Türkçe", null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4180), "192.168.1.3", "Biyoloji", null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4181), "192.168.1.4", "Fizik", null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4183), "192.168.1.5", "Kimya", null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4185), "192.168.1.6", "Tarih", null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4187), "192.168.1.7", "Coğrafya", null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4188), "192.168.1.8", "İngilizce", null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4190), "192.168.1.9", "Müzik", null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(4192), "192.168.1.10", "Görsel Sanatlar", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5156), "192.168.1.3", "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5171), "192.168.1.8", "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5162), "192.168.1.5", "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5160), "192.168.1.4", "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5178), "192.168.1.9", "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5167), "192.168.1.6", "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5169), "192.168.1.7", "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5181), "192.168.1.10", "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5149), "192.168.1.1", "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5898), "192.168.1.5", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5896), "192.168.1.4", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5891), "192.168.1.2", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5885), "192.168.1.1", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5893), "192.168.1.3", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd6a6979-cbb1-4c4a-93f0-19a73a3cdcfc", "1abfbe1e-41be-4440-8dd3-4bf6127d77d3" },
                    { "86e143a4-b96a-4821-9dad-28747c241f22", "2862264a-af6f-447a-a449-c317c736ed48" },
                    { "bdac7a93-f4a4-4d94-a5ab-b4e6ccc7643f", "5fc06fe1-18ad-4bf9-8833-85c502b493cc" },
                    { "5836daf9-1a03-4190-872a-4fdc42cf4a50", "e042c938-cf05-4ef1-8e3c-bd4efefe1fe0" }
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
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId", "WorkPhone" },
                values: new object[] { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(5153), "192.168.1.2", "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, "5fc06fe1-18ad-4bf9-8833-85c502b493cc", "5553456789" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassroomId", "ContinuationStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "FirstName", "GPA", "Gender", "GraduatedSchool", "IsPreRegistered", "LastName", "RegistrationNumber", "TotalAbsenceCount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6896), "192.168.1.11", "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", "110-24", null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6877), "192.168.1.6", "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", "105-24", null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6862), "192.168.1.1", "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", "100-24", null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6880), "192.168.1.7", "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", "106-24", null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6899), "192.168.1.12", "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", "111-24", null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6888), "192.168.1.8", "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", "107-24", null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6894), "192.168.1.10", "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", "109-24", null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6871), "192.168.1.4", "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", "103-24", null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6874), "192.168.1.5", "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", "104-24", null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6866), "192.168.1.2", "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", "101-24", null, null, null, null, "2862264a-af6f-447a-a449-c317c736ed48" },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6868), "192.168.1.3", "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", "102-24", null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6891), "192.168.1.9", "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", "108-24", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7611), "192.168.1.13", new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7587), "192.168.1.2", new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7618), "192.168.1.16", new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7613), "192.168.1.14", new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7600), "192.168.1.7", new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7591), "192.168.1.3", new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7605), "192.168.1.10", new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7620), "192.168.1.17", new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7624), "192.168.1.19", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7609), "192.168.1.12", new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7603), "192.168.1.9", new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7622), "192.168.1.18", new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7595), "192.168.1.5", new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7593), "192.168.1.4", new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7615), "192.168.1.15", new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7607), "192.168.1.11", new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7598), "192.168.1.6", new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7583), "192.168.1.1", new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7601), "192.168.1.8", new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(7626), "192.168.1.20", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Department", "FirstName", "LastName", "MainCourseId", "Role", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8313), "192.168.1.5", "Fizik", "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8318), "192.168.1.10", "Tarih", "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Öğretmen", null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8321), "192.168.1.11", "Coğrafya", "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8305), "192.168.1.2", "Matematik", "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8311), "192.168.1.4", "Biyoloji", "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8308), "192.168.1.3", "Türkçe", "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8301), "192.168.1.1", "Matematik", "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, "1abfbe1e-41be-4440-8dd3-4bf6127d77d3" },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8326), "192.168.1.13", "Müzik", "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8323), "192.168.1.12", "İngilizce", "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Öğretmen", null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8328), "192.168.1.14", "Görsel Sanatlar", "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Öğretmen", null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8316), "192.168.1.6", "Kimya", "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("00449ccd-e432-4242-a210-8defab6affa7"), "Computer50", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5713), "192.168.1.60", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("064e3bc3-1cd9-437e-b42b-2d8f452c20a7"), "Computer32", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5636), "192.168.1.68", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("0b510cf5-a6c1-4696-812a-8892a5f7cd23"), "Computer25", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5599), "192.168.1.74", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("0cafe690-c494-41b2-883e-5c3ccce8d243"), "Computer51", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5717), "192.168.1.22", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("0cb32a9a-c05d-43d9-9053-bd582221a22c"), "Computer49", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5707), "192.168.1.32", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("107602b7-9330-49e1-b2f0-2d6899bc4754"), "Computer9", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5529), "192.168.1.4", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("1800e81b-623a-4f2d-8550-fbf16a57b31e"), "Computer38", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5663), "192.168.1.7", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("18dc0edc-2787-41e7-867d-e0f5b67a85d4"), "Computer59", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5750), "192.168.1.3", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("1e6c4a1a-f6e0-4e07-9903-6989449f8a76"), "Computer24", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5595), "192.168.1.90", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("1eeb431c-6da7-429f-b09d-624999adef16"), "Computer6", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5517), "192.168.1.22", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("1f247021-3d49-42a5-93d8-ddefeae88945"), "Computer12", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5544), "192.168.1.62", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("1f6b2c5c-2efb-4ce3-af91-d2c4c919b5fc"), "Computer23", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5591), "192.168.1.87", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("20ec5836-d8f5-486e-a54b-3e77164b29c7"), "Computer30", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5620), "192.168.1.56", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("28176127-37a8-4058-82d7-90683560b291"), "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5508), "192.168.1.60", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("29142bea-5f2e-4efc-809f-01ba6e9289a0"), "Computer54", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5729), "192.168.1.15", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("2b2af546-6e12-406b-8682-19c294ca73c2"), "Computer37", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5659), "192.168.1.74", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("2c4b298f-e289-44a2-bbb3-1dc90f857459"), "Computer8", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5525), "192.168.1.36", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("35c900b0-8b41-4ddc-b1af-07d5df60f472"), "Computer36", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5654), "192.168.1.42", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("36e8ef63-78e8-4ad3-bf09-60128f7227df"), "Computer45", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5692), "192.168.1.26", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("376c2128-6e7c-4d9d-b7e6-870f12a5b0f1"), "Computer40", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5671), "192.168.1.57", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("3d3010c4-896f-4ae5-8909-4f5d3fc21e4d"), "Computer44", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5688), "192.168.1.38", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("42d00907-197e-42a8-aff2-1a06f2570cbd"), "Computer13", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5549), "192.168.1.23", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("55e391ca-f573-440f-94b4-a7c80f2caa6d"), "Computer31", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5632), "192.168.1.81", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("58ded7f8-e2c7-4350-a5f7-39f6642295af"), "Computer53", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5724), "192.168.1.19", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("670c207e-52db-484c-a3cd-559668080365"), "Computer7", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5521), "192.168.1.2", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("6953e860-c080-4a5d-bf55-1e42dc062387"), "Computer47", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5699), "192.168.1.21", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("6f2ec4cf-40ee-4bc0-9327-20af16546d20"), "Computer52", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5721), "192.168.1.17", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("73a62863-b853-4cdb-8d4e-27f1939ac7dc"), "Computer26", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5605), "192.168.1.30", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("76d83da7-7336-4c5c-8b63-90dd2f3a9e89"), "Computer41", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5675), "192.168.1.88", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("7779c388-f89a-4214-9a72-cb2e1e744668"), "Computer19", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5575), "192.168.1.94", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("8067f552-ccac-4d14-8e03-ddedf55c2e3d"), "Computer11", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5540), "192.168.1.79", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("8324d246-bc76-4f3d-9165-b0b33040b612"), "Computer35", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5650), "192.168.1.59", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("832fe3c1-df8d-45b4-a40a-bd683313bdf1"), "Computer57", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5740), "192.168.1.42", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("91a9da9c-c9b2-4039-a563-922ab19a33af"), "Computer48", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5703), "192.168.1.10", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("9274ddb8-540b-4b65-a720-ffccb37db648"), "Computer33", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5640), "192.168.1.50", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("983e4a93-fa7a-40c9-a5cb-b1edaed50d22"), "Computer17", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5564), "192.168.1.66", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("9c81d0f6-5545-435f-9a79-21223777840b"), "Computer22", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5587), "192.168.1.37", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("a25a7aa0-3e2f-4747-b104-c5a9ea2ad236"), "Computer15", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5556), "192.168.1.75", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("a36de876-4694-46e4-8fe6-97c4aea5d2e3"), "Computer14", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5553), "192.168.1.38", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("a49fb2aa-ace2-43b0-93bb-5bb729875240"), "Computer28", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5613), "192.168.1.64", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("a4e3e1bf-0a4e-49d6-873a-5ff2c38a8d92"), "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5504), "192.168.1.64", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("a57d02ee-ed8e-40d8-b73d-db8962db506f"), "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5512), "192.168.1.62", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("ad024e08-473f-4431-aaf7-53c35b0aa977"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5436), "192.168.1.55", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("b2b8ab26-887a-4c26-a727-9bb5820e1d91"), "Computer10", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5536), "192.168.1.32", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("b60f992a-bb29-4ac5-8e70-b093df7c53d6"), "Computer39", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5667), "192.168.1.19", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("b768d716-741b-4b14-8da6-69c16317940a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5499), "192.168.1.30", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("bbeeb81e-395e-484c-80a3-f2f26820623a"), "Computer58", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5746), "192.168.1.38", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("bdf546de-8ca0-46bc-9991-a6f872b6c356"), "Computer56", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5736), "192.168.1.3", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("c184e292-e2ac-4758-bb3a-4a12e8e90e56"), "Computer16", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5560), "192.168.1.21", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("c888e91f-c5dc-4409-9613-d3ad22964034"), "Computer21", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5583), "192.168.1.29", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("cc21dc31-983c-49db-ae52-f2c827735ed2"), "Computer55", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5732), "192.168.1.34", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("ccc6c2b1-b990-4dab-8520-fe39cfa73d35"), "Computer27", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5609), "192.168.1.65", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("ccda2db4-0ef2-4764-8275-77126ce95836"), "Computer34", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5646), "192.168.1.40", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("cf9e9d2c-7bc7-4728-9cf6-9eea11985dd1"), "Computer46", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5695), "192.168.1.86", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("d4236510-8677-45e6-a053-384f9d86f5f9"), "Computer60", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5754), "192.168.1.9", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("e1c6a7ef-b4b5-46ec-8b31-eba89f9e1109"), "Computer43", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5684), "192.168.1.55", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("e7d103fc-f20e-424c-952a-450f86c9ac61"), "Computer29", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5617), "192.168.1.33", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("ed3a7e87-b813-4288-95ce-6279f8d68a95"), "Computer20", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5579), "192.168.1.44", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("f3c10bdb-68ea-4a7d-9a1a-ca08d742858e"), "Computer18", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5571), "192.168.1.88", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("f5efbc43-f49e-4659-99ff-66d86c1cbbbc"), "Computer42", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(5680), "192.168.1.48", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("090900de-a5e1-44c0-86d8-a11beac609f3"), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer16", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7177), "192.168.1.92", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0ead78c3-eaeb-4d49-8093-a9c4f10b1b7d"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer33", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7283), "192.168.1.90", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("18fc6ed1-fafb-4f96-899d-dadd1c5e1cc1"), new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer25", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7224), "192.168.1.98", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1cdae443-07c6-4f75-b575-502ed0f380a2"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer8", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7112), "192.168.1.83", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("208441d2-828e-45bc-9455-6d224b96fdb7"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer4", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7068), "192.168.1.54", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("21b9dbf1-c02a-4c98-868f-fd7ffe445f50"), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer10", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7139), "192.168.1.75", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("2d075698-10bd-41c0-aaff-b4f2e10c1e8f"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7001), "192.168.1.71", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("388d5cc2-8b75-4ca3-bf6a-99202288a12f"), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer18", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7187), "192.168.1.79", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3b3eb422-b6c5-4433-9c38-6180be69061b"), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer24", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7220), "192.168.1.41", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("3b6d7200-24f8-4e06-843d-dffe8dc52b0a"), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer29", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7263), "192.168.1.16", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3d4cb4b1-0310-48d0-bacd-059dbafb2acd"), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer14", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7166), "192.168.1.32", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("42419ef2-48af-4a0b-96e4-a5b647fcd752"), new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer13", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7161), "192.168.1.35", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("42758bd9-d69a-4848-85a1-6fb0325f609b"), new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer5", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7075), "192.168.1.44", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("44680cc6-93fd-4430-a104-ce45a01f07bc"), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer27", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7235), "192.168.1.20", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4b86b9cf-508a-44b8-b006-72d3cdaf22c8"), new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer7", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7105), "192.168.1.46", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4c2ba90b-d58d-43c5-80f9-a1be950eac7c"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer15", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7172), "192.168.1.43", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("54bf0d32-fcd7-4bd6-b426-40a758003529"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7034), "192.168.1.68", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("58af2761-5af8-4b63-8290-92c7a8ab5118"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7023), "192.168.1.14", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6197ca99-b23a-4896-9aad-f9fb51846a2e"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer32", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7277), "192.168.1.93", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("62d11f6a-20cf-44e3-b4bc-ba2c679e2ff1"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer26", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7229), "192.168.1.88", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6373764f-a6ff-4bd7-a394-6528826b2cec"), new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer21", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7205), "192.168.1.40", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("66f67efb-9e77-44b9-b079-ced2f242fa5c"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer31", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7273), "192.168.1.6", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("78424121-ac36-4345-9797-71e738dbe3ad"), new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer22", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7211), "192.168.1.92", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("805c250c-b692-4853-99da-8fe60776f06d"), new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer3", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7061), "192.168.1.67", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8996ec56-77d7-47b3-9eaa-e11a3f8b0b99"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer28", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7240), "192.168.1.35", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a4113546-3035-4418-9b96-48cc0d0c04a4"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer11", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7150), "192.168.1.25", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a58d5c16-a739-465e-86f3-6261e90dfe07"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer17", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7183), "192.168.1.31", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a6b97ad8-93b0-4988-a07c-ffb385122e91"), new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7268), "192.168.1.93", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a90f40b3-2d6a-41e6-87a6-46f4a8fd10a6"), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer19", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7196), "192.168.1.78", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b0bdb46d-bf57-496c-8fe1-6dfab8cb8710"), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer23", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7215), "192.168.1.72", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b20820c1-2733-4a88-8b18-32dcf4b98128"), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer12", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7155), "192.168.1.65", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b36b3562-1a18-4e91-8ffb-ead475898b81"), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer20", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7200), "192.168.1.32", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("da1344f6-6344-4cbd-b5ad-379b6608158f"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer6", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7089), "192.168.1.43", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("edf476b9-1e1f-477f-afde-45d71eb81971"), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer9", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(7131), "192.168.1.84", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null }
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
                    { new Guid("ad8322b0-08a4-484d-932c-6f0f1c8d3a8e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(8996), "192.168.1.79", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null },
                    { new Guid("c2512ad1-b352-4b9c-b873-24e65cc0a4e2"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(9018), "192.168.1.51", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("0006db9a-f8d9-4d40-85f0-90a6bdc4dd33"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1442), "192.168.1.82", (byte)2, 2.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("002556b7-e23b-4479-8331-3c997de87f76"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(578), "192.168.1.53", (byte)1, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0072c50e-f695-445d-a5a2-f45ab6db9105"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1495), "192.168.1.84", (byte)2, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("00ad94e2-2361-46a6-9585-e259571b240e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(889), "192.168.1.17", (byte)2, 23.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("00ae2e1d-795b-485f-a3d2-211199ddac93"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1829), "192.168.1.43", (byte)3, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("00f3dad5-c854-49a5-bc12-18f9e687d95f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1811), "192.168.1.96", (byte)3, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("00fbb83c-be94-40f1-80ca-5ae855298b92"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(782), "192.168.1.25", (byte)2, 78.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("01241925-44e7-4107-a93a-997b84e54555"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2603), "192.168.1.44", (byte)3, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("01448e38-295a-4ac3-a38f-56a6cce3f9f4"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1401), "192.168.1.43", (byte)2, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0158ea90-e38f-45b4-81f6-f00a271060e7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(528), "192.168.1.31", (byte)1, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0164be21-c7a1-416d-91d7-77cd5f25aaf7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(491), "192.168.1.31", (byte)1, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0181fc45-5c68-4719-b6b9-fe6940e2fa0c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(453), "192.168.1.65", (byte)1, 92.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("018d680a-6ae0-4949-86fe-507f0aeb8af4"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1738), "192.168.1.75", (byte)2, 97.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("01dcd101-d795-4a89-aa51-1ae8e014ccde"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(864), "192.168.1.12", (byte)2, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("022dbae9-3fe4-4e62-affa-32a5fe0da5d0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9563), "192.168.1.80", (byte)1, 42.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("025b5538-80f2-4000-8b10-61645f4fea8f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2126), "192.168.1.63", (byte)3, 23.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("029a506c-1751-401f-a7cd-5e36179ce753"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(943), "192.168.1.41", (byte)2, 65.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("03b5dd06-ad02-45ca-be26-1fe4dbeae270"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1509), "192.168.1.40", (byte)2, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0402fd74-82f3-4776-91e5-8f46b5f36fc4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1908), "192.168.1.78", (byte)3, 28.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0404b8dc-fa58-4d55-b1bf-485945d30100"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2047), "192.168.1.38", (byte)3, 47.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("04aec73f-37bc-4b54-9b22-fe96b582bf52"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2493), "192.168.1.48", (byte)3, 32.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("04eb5218-0600-4787-8edd-02d8bd80e17b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2723), "192.168.1.72", (byte)3, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("04f49570-c9a0-484a-9f96-36f3c6e8e095"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2193), "192.168.1.10", (byte)3, 97.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("053140a9-9d57-4797-8bfb-39e603003502"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9693), "192.168.1.12", (byte)1, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("058abe32-37ae-4c9f-9978-66e5aaf7eea9"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1962), "192.168.1.13", (byte)3, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("061b20f2-7f98-495b-a5dd-e2b2d923ece8"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(768), "192.168.1.51", (byte)2, 88.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0645e2b3-8cf3-4c74-8bd8-41ac55c31103"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(901), "192.168.1.42", (byte)2, 62.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0666ce88-f928-4283-b971-8c5b1ff5d2b7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1825), "192.168.1.8", (byte)3, 45.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("067cf173-5e40-44f5-9b27-8a38afb496a2"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(269), "192.168.1.67", (byte)1, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0700c6c9-4860-4394-9a66-e4f6c066aeb9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(973), "192.168.1.68", (byte)2, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("074cfa96-a1cb-497d-b2e3-a9622ccd540a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1668), "192.168.1.76", (byte)2, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0767c02a-6bc9-4088-9d11-924c8d8aabcd"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1562), "192.168.1.97", (byte)2, 16.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0826eccd-9539-4551-b7da-6a57ec795479"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(514), "192.168.1.35", (byte)1, 71.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("08a892eb-828f-42bc-9e59-9a7828aada23"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2130), "192.168.1.64", (byte)3, 9.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0981bac1-8afe-4cf1-90c4-7614e232d358"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(152), "192.168.1.21", (byte)1, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0a15daaa-cb75-4dfb-9704-57a30ec700a3"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(656), "192.168.1.41", (byte)1, 17.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0a690099-8583-47c0-829a-06f8bc974d72"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9904), "192.168.1.9", (byte)1, 66.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0b7adfd7-5295-439f-8311-910060b74df4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2372), "192.168.1.96", (byte)3, 47.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("0c53ffdd-97e3-4591-83b0-719fd11722e0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9681), "192.168.1.56", (byte)1, 98.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0cb47a06-7a7f-4e10-b348-5b8d22bd3056"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1376), "192.168.1.56", (byte)2, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("0cf07559-ac80-4357-a6b5-12afba96756c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9785), "192.168.1.24", (byte)1, 92.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0d0a7fd4-19b4-4802-9deb-a4fde5186b7d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(41), "192.168.1.35", (byte)1, 98.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0d27ce48-1a1d-4427-bc50-214eedf428b0"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2009), "192.168.1.19", (byte)3, 54.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0d56c17d-df49-4232-8c6f-c88017b6fe55"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1071), "192.168.1.3", (byte)2, 84.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0dda876c-dcce-4405-9d7f-d821611aa49f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2033), "192.168.1.6", (byte)3, 71.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0de5c304-2720-4244-84a6-0884a2fa7838"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(383), "192.168.1.93", (byte)1, 18.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0e6747b7-c048-47d2-958c-ef842ca1cb21"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1841), "192.168.1.60", (byte)3, 12.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0e6cb5c0-3a41-4fa7-89da-f2d193eb9a4c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2201), "192.168.1.86", (byte)3, 90.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0ececd4a-e24c-461d-ad48-315ef216c369"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2507), "192.168.1.73", (byte)3, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0f6298cd-2ce6-4cf6-8d14-4136ee8eb47d"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2633), "192.168.1.55", (byte)3, 47.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0f91331e-7770-41a6-a62a-7a81bc5f779c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2254), "192.168.1.65", (byte)3, 32.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0fa11aac-b080-49b4-8000-5c229ecf93f8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9955), "192.168.1.72", (byte)1, 55.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0fc197e0-e7ff-4202-9e83-fd2c5f1f85f8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9835), "192.168.1.53", (byte)1, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0fc73b31-5340-44e8-bd4d-0bdcdde79d50"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2234), "192.168.1.67", (byte)3, 77.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("109aa704-a5e9-4147-be1d-6ab1cac6489e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1941), "192.168.1.65", (byte)3, 77.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("11006228-2438-4c6d-946a-6e3c8000ee7c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(29), "192.168.1.31", (byte)1, 50.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("11a77862-ad2c-49e4-ba67-0beeadc8e5ea"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(232), "192.168.1.54", (byte)1, 61.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("12765ab4-2d7f-4749-b164-4a2aba10a60b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1769), "192.168.1.23", (byte)3, 40.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("1281d566-719b-40eb-8e91-8d4145fa0ef1"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(324), "192.168.1.87", (byte)1, 78.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("12ede7c7-b11b-4317-b55b-be39e1c73710"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2714), "192.168.1.51", (byte)3, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("136bdd67-f55f-492c-b165-951fa06936df"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1685), "192.168.1.30", (byte)2, 82.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("137269be-339e-4f7f-8c14-61b21512820c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2297), "192.168.1.35", (byte)3, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1494ee80-3957-4fdc-932e-e467a494a138"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(105), "192.168.1.69", (byte)1, 32.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("16f01d39-080e-4504-aa49-887dce7339c8"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2343), "192.168.1.62", (byte)3, 81.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("17fad799-93fe-4113-aaea-a5e1fef765bf"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2160), "192.168.1.8", (byte)3, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("182bdd72-6c35-44c6-ae43-996b3e632e1e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1896), "192.168.1.74", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("18c3b1f6-e0d7-4901-904b-0a5a9f856089"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1248), "192.168.1.5", (byte)2, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("18ee9cfe-cb99-44b3-be89-cffc5fce13cf"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(670), "192.168.1.70", (byte)2, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("18f1b555-4a4c-4197-b63c-a935d51a3845"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1218), "192.168.1.79", (byte)2, 45.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("194f69c8-07e3-4e15-a1d9-fba1095d3198"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(562), "192.168.1.90", (byte)1, 69.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1995512a-3c36-4d46-be1a-b868e6364415"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1622), "192.168.1.23", (byte)2, 53.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("199d20ff-2320-4fd9-8cf6-01d6739136c8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(109), "192.168.1.8", (byte)1, 83.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("19ab7f34-fc03-42e4-98c8-3642f77c2bcc"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(114), "192.168.1.71", (byte)1, 49.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("19ac676d-8978-4ed1-ac33-4859cd780877"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(227), "192.168.1.55", (byte)1, 37.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1ad96772-21c6-4127-8a98-c1172498a3e2"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1409), "192.168.1.55", (byte)2, 6.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1b0b86e1-c2e8-4d1f-9c8d-412432e617b0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(222), "192.168.1.61", (byte)1, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("1b55c528-6c46-4e8c-b3c7-d0cd81773f06"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(85), "192.168.1.94", (byte)1, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1b55e6ca-1de6-4718-a69b-a81e53366971"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(59), "192.168.1.84", (byte)1, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1bbed000-93f7-45cf-9fb2-3f1384364856"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1546), "192.168.1.9", (byte)2, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1bc60c99-982a-4041-84fc-e409f00201a0"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1256), "192.168.1.33", (byte)2, 33.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1cc03f00-767f-4a9c-ba29-c0d94d2e1aa9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(764), "192.168.1.14", (byte)2, 44.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1cfa08a3-af0a-400c-bec5-a784d75a3cd4"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(652), "192.168.1.19", (byte)1, 51.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1d262f7c-1465-4daa-8226-c89a4875ef97"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2051), "192.168.1.20", (byte)3, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1e3ad40c-3cf5-4116-9a5b-9b12647714d7"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1277), "192.168.1.64", (byte)2, 53.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1f2880c8-8a96-4a21-81d3-3763c96c06cf"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2), "192.168.1.57", (byte)1, 77.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2095c5d8-ff27-4c0d-9f62-0822939e9aa3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1558), "192.168.1.92", (byte)2, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("20efa841-81d8-4f4e-afb4-586ac95d5709"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9891), "192.168.1.87", (byte)1, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("212bd6cc-d8eb-4495-b4a2-1715f917133e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1272), "192.168.1.77", (byte)2, 34.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("22539725-7c57-4dc0-9e0c-2b486c8068c9"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(51), "192.168.1.56", (byte)1, 86.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("22b4a9b1-ed7f-401b-b7e1-dc2982ec89e3"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9650), "192.168.1.19", (byte)1, 95.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("22d4c38e-4557-42d1-bc69-85de1a502ae9"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2112), "192.168.1.9", (byte)3, 82.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("22f082ae-53a1-4420-a931-f29b30a8c8e4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1837), "192.168.1.5", (byte)3, 6.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("230ce2a2-9315-494f-bc16-c02eca34c872"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(33), "192.168.1.86", (byte)1, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("23717b1d-729a-41e0-a9c3-9c1f26f0b3a5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(495), "192.168.1.75", (byte)1, 9.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2393d4c1-7647-496a-86d4-89da5640472b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9737), "192.168.1.64", (byte)1, 84.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("239b9908-664f-4eaf-8b56-7dbea11e2654"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9831), "192.168.1.66", (byte)1, 21.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("23a6d77d-a67b-42df-8857-0906710b4ad3"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9625), "192.168.1.78", (byte)1, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("23e64ed7-bfcf-4d3f-a71b-eaac7a6a655f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1966), "192.168.1.12", (byte)3, 64.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("23eb34c4-0fd4-44a8-b973-263be05e8640"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2134), "192.168.1.4", (byte)3, 93.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("23fd73ca-85ee-479e-8d7e-6c6a7dfa8d47"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9741), "192.168.1.42", (byte)1, 47.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("2444255b-11d2-435c-b52b-2a402faacdf2"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(354), "192.168.1.98", (byte)1, 72.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("24641f45-3eda-4f67-84c6-008b8aa02ed0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(417), "192.168.1.91", (byte)1, 69.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("24dfeb2e-e1aa-4a5e-ac2e-37944b4da12c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2595), "192.168.1.78", (byte)3, 44.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("253ab5f2-32f7-404d-88bc-888055edd1b4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2798), "192.168.1.75", (byte)3, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("25ab80df-dfee-4078-9442-92ffd0e9af9b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1360), "192.168.1.93", (byte)2, 75.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("25f573de-5359-4b16-92e6-edfc012428e2"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(674), "192.168.1.39", (byte)2, 64.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2635212b-d3dc-4dbc-8c80-21d451ede1cc"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2088), "192.168.1.19", (byte)3, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("26a20dde-9ab2-433b-8cc1-d9582195c99b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2321), "192.168.1.37", (byte)3, 72.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("270b82ed-a10a-403b-9300-3df4dc0d9a67"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2104), "192.168.1.57", (byte)3, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2786c032-5044-40f0-a9ad-0c07084cc0d3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1719), "192.168.1.77", (byte)2, 46.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("27b585e7-8071-4812-b509-3aa0a2aedbe9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(969), "192.168.1.26", (byte)2, 24.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("28381203-7f6a-4f8c-83d5-edfababf9cf0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(143), "192.168.1.33", (byte)1, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("289f4049-e737-4bb4-beb4-7a231099a4e5"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1260), "192.168.1.75", (byte)2, 61.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2940ed5e-a550-42e9-8351-308b36fc764c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1517), "192.168.1.34", (byte)2, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("29ce4f55-dcba-42ff-a49f-25d275ef1927"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1075), "192.168.1.67", (byte)2, 1.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("2a05f66f-8594-4a25-9390-321f9bbb1d27"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1550), "192.168.1.68", (byte)2, 6.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2a155e78-4beb-481a-9524-a10ed2a8a7a9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(786), "192.168.1.52", (byte)2, 42.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2a61812b-8a68-4668-800a-8878ab06818e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1214), "192.168.1.31", (byte)2, 89.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2a7b6787-57e3-4a4c-b560-773dceb9868f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1304), "192.168.1.31", (byte)2, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2adbc131-d84c-47e5-afaa-7d4b39e3678f"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(626), "192.168.1.92", (byte)1, 79.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("2b4871e6-3ea3-4523-b029-d99f9e9b01b6"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2435), "192.168.1.37", (byte)3, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2b5eb192-c73c-4caa-958c-4bb0adfe1a54"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2351), "192.168.1.1", (byte)3, 81.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2bb335b2-dbad-4b3a-a704-1f721a6cca8c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(592), "192.168.1.20", (byte)1, 6.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2c5bd2e5-5f1d-4274-aa3d-c1638a885994"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(362), "192.168.1.13", (byte)1, 68.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2ca04c38-305e-4286-a17b-25027eca0331"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9801), "192.168.1.47", (byte)1, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2cd6c8bf-4130-469a-91fc-82099bb482ae"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1664), "192.168.1.15", (byte)2, 71.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2dcd65c8-228e-4e6b-a980-169db29b506e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(379), "192.168.1.54", (byte)1, 13.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2df65f3e-62c1-45c1-9671-cacb978b25d9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1121), "192.168.1.38", (byte)2, 57.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2edb303e-ce67-4fc0-bf51-82275ec91878"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9540), "192.168.1.48", (byte)1, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2f220dc5-d8f3-4391-8ec4-d6e95e8a0e9e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2413), "192.168.1.9", (byte)3, 69.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2f70177f-45ff-43c7-a767-c1ac8a4f7600"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1222), "192.168.1.37", (byte)2, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2fe9a909-184d-457f-86f4-48e7364ce2e0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9998), "192.168.1.36", (byte)1, 49.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2ff3baef-9c4e-4734-b3ea-f34b2dd45ccc"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9875), "192.168.1.46", (byte)1, 30.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("30321dbf-63ac-4291-b563-fdf6840f8acd"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2625), "192.168.1.23", (byte)3, 19.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("30677678-ea6d-4f60-b5e9-2c1ec493dfec"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1461), "192.168.1.20", (byte)2, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("30a762ff-299d-426e-ba98-bd13a6b0368c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1015), "192.168.1.11", (byte)2, 53.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("310cda5b-268d-4398-b919-1f3c05d61eb5"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(855), "192.168.1.41", (byte)2, 66.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("314b1182-de31-41e2-bee6-3159c40aeae6"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2539), "192.168.1.31", (byte)3, 88.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("31802489-3494-4841-b704-be177ddb2b72"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(37), "192.168.1.55", (byte)1, 81.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3199afdf-f708-4b21-861c-4bbe4008ed10"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(883), "192.168.1.97", (byte)2, 87.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("32026099-fa1c-45d9-95da-2417355fa0f2"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2152), "192.168.1.61", (byte)3, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3233bd0f-6524-40ed-8a57-fd8e6c131969"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9654), "192.168.1.88", (byte)1, 34.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("3283f6e2-7fe7-4b6f-a6c0-626b2e239860"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2267), "192.168.1.93", (byte)3, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("328d7a45-69d8-448b-8ef6-51eae0746ea5"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1863), "192.168.1.96", (byte)3, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3306f333-11d7-4092-b0fe-7a74cb48267f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1230), "192.168.1.11", (byte)2, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("33bad884-fdef-4334-8d08-31a967c5de4e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1268), "192.168.1.28", (byte)2, 40.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("344f7ec7-9ef1-4804-86c0-c6c2e52e524e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1170), "192.168.1.52", (byte)2, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("34532200-bd85-404e-afdc-e97cb673ace7"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1642), "192.168.1.36", (byte)2, 17.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("3475ece2-c5d2-48df-9ec7-9bba5cc1d676"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(716), "192.168.1.87", (byte)2, 13.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3476dd78-18e0-447e-91d1-fc577b4c3cc1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1457), "192.168.1.35", (byte)2, 61.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("348babf0-35c0-491e-a1f9-eca093621362"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1777), "192.168.1.96", (byte)3, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("34fec2a6-a58a-4d11-b17a-08d4fda2bd05"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9755), "192.168.1.80", (byte)1, 13.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("35ab8790-a9d4-492b-bcf4-5389e4ef08bb"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2021), "192.168.1.34", (byte)3, 40.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3676ddac-c8c4-4608-8856-9f2ad9136ae9"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(298), "192.168.1.53", (byte)1, 40.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("368a70b5-b095-45bc-9fd8-3d15dc3160af"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1041), "192.168.1.75", (byte)2, 14.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("372031c7-8f82-4da1-b025-d8cfd84b2a3d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(842), "192.168.1.26", (byte)2, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3723a9b4-e8a5-45b6-88f8-65bb32377525"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2327), "192.168.1.96", (byte)3, 79.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("37dc6f75-1fa6-4ae6-ab50-7455bfaa8f0a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2220), "192.168.1.30", (byte)3, 61.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3825e473-bbc2-406c-92c0-144e773d99ef"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9951), "192.168.1.33", (byte)1, 10.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3849eb00-82a3-4870-8afd-67598ce9b0af"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9897), "192.168.1.18", (byte)1, 93.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("387b0c50-5bb3-4308-9b6e-c2c9adc0859e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9594), "192.168.1.95", (byte)1, 39.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("39aa5def-99a8-4587-8fd8-45f1a7927df6"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(336), "192.168.1.9", (byte)1, 36.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("3a88d284-11bb-410b-b6a9-74947df5b9e4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2180), "192.168.1.24", (byte)3, 96.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("3a9048c7-3636-41ec-adca-89dee5119f37"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1815), "192.168.1.4", (byte)3, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3ae67a78-7807-478a-9ee1-d27b1818be6d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1037), "192.168.1.1", (byte)2, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3b51cbd3-883c-4574-a68b-af29af2a8ea8"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2361), "192.168.1.33", (byte)3, 3.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3b9aad3f-2ab5-4079-bd01-6ae8fdbd96f7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(648), "192.168.1.85", (byte)1, 92.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3c4f1874-18f4-4f03-b610-40203db6d34e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(923), "192.168.1.39", (byte)2, 42.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3c6ca97c-5a63-4f06-8a80-df885bf08b43"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(342), "192.168.1.88", (byte)1, 59.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3d0a33b9-b54e-4977-80e7-b686be590e93"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9901), "192.168.1.31", (byte)1, 95.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3d21a657-7e4f-4f3a-bec9-e83ac9e0fcaa"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(175), "192.168.1.75", (byte)1, 42.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3d3df395-3a99-420d-88e8-c1b3ddf873ec"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(55), "192.168.1.71", (byte)1, 86.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3d527dc5-0843-442e-8ea8-766c05cb6db7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1859), "192.168.1.87", (byte)3, 2.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("3d54d311-b9c0-4b21-96c6-037bbf3d6acb"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(905), "192.168.1.19", (byte)2, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3e507df2-0f65-4ea5-84d6-b592bad3b68f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1870), "192.168.1.43", (byte)3, 38.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("403ec954-b0d9-499a-a65d-899ff3ba85da"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9659), "192.168.1.16", (byte)1, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("404a6b11-76b4-42c2-ba2a-b07783876781"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1608), "192.168.1.24", (byte)2, 4.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("408ba174-04f7-42dd-bbc4-4f442b6ff18c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1580), "192.168.1.40", (byte)2, 50.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("40e5177d-60d8-456c-90df-6f6d4e2955e2"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2803), "192.168.1.61", (byte)3, 61.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("41051d63-88bd-4535-83a4-a4aa9e9cc9c3"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9689), "192.168.1.64", (byte)1, 56.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("41662d46-57c9-4f1c-b1d5-278132b0d2be"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(139), "192.168.1.73", (byte)1, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("417a05eb-7b87-4250-9d9a-8e4ec8305388"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2583), "192.168.1.36", (byte)3, 17.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("41e420b5-ea5e-483e-a68f-ee6f2c9d2606"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2189), "192.168.1.16", (byte)3, 53.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("423cb5f4-1dac-4270-ac9c-77e03deac7b1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1384), "192.168.1.53", (byte)2, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4259b462-ab3a-403d-946b-1444f0cf101b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(100), "192.168.1.53", (byte)1, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("42be3be1-7839-48bb-b818-493d63735d7b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2197), "192.168.1.94", (byte)3, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("42d0ee21-e052-484b-bdd0-bbf8be56dea5"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2543), "192.168.1.38", (byte)3, 29.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("43a07d29-f60b-45c3-ad4e-6e28b46fd01d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1150), "192.168.1.52", (byte)2, 7.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("43b04999-1b30-4c9a-8129-3163acc92d49"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9959), "192.168.1.49", (byte)1, 42.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("44426956-5850-490c-9e1f-e598d7190ecb"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2503), "192.168.1.55", (byte)3, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("44b9b730-d3b1-42f4-b1c8-13a87cce74b4"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(544), "192.168.1.88", (byte)1, 64.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("44dcb7c3-6595-43d7-b6ad-b552e71b5b19"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1924), "192.168.1.68", (byte)3, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("45ac8aaa-1382-46ff-8864-9420100afec0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(375), "192.168.1.37", (byte)1, 13.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("465027ab-bbf4-4d6f-ab2c-69523d94d0c4"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9617), "192.168.1.9", (byte)1, 57.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("46a7350c-1b40-4ae2-a739-22e3b07aef16"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2185), "192.168.1.31", (byte)3, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("46c7c88f-9d70-489f-b1c2-ed35503780aa"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9939), "192.168.1.43", (byte)1, 62.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("46c84bf7-095d-45aa-a1af-6acecbf2e075"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(97), "192.168.1.70", (byte)1, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("46e9bbe3-d927-4b75-b9f9-c0b0de8b47da"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2205), "192.168.1.71", (byte)3, 4.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("472446c1-f481-4504-b68d-3f1f2cfbaaf3"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2515), "192.168.1.97", (byte)3, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("474ecf28-cd6a-4ba4-bbf2-2b2fb8325906"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2017), "192.168.1.91", (byte)3, 77.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("47922ee8-203d-42f9-a83b-48a113c575f3"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1849), "192.168.1.27", (byte)3, 98.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("487059c6-35b7-4dc4-93e6-36a3195ef0c6"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1244), "192.168.1.60", (byte)2, 73.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("487a1ab1-739e-4811-90c7-36e1f7069b60"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2388), "192.168.1.1", (byte)3, 17.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("491cbcda-1766-4bc7-9204-eb2e4d30dea4"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(302), "192.168.1.45", (byte)1, 70.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("49600514-8ea2-4fd3-8fa3-6dd2dcfd1369"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(917), "192.168.1.60", (byte)2, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("498ce6a5-1f01-49a5-a117-f60ee1a03dc5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(183), "192.168.1.34", (byte)1, 58.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("49c188c1-e782-4ae7-a0d2-8324fd9c93cb"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(897), "192.168.1.5", (byte)2, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("49d29ab8-e7d9-4bb1-af21-b3754cbd1e6e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(610), "192.168.1.82", (byte)1, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4a03c575-c02c-4174-9489-78e00c1be560"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2751), "192.168.1.84", (byte)3, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4a882546-d4aa-4083-b9f9-5046d26b23b6"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(548), "192.168.1.82", (byte)1, 95.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4c09c094-d6b5-46c6-8a26-1ed59c4c921e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2347), "192.168.1.6", (byte)3, 0.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4c834ea3-ea3f-4208-b8e9-7fa78b3dff19"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2617), "192.168.1.9", (byte)3, 65.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4cd4ec05-36cf-419c-89d5-60c54a446f88"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2287), "192.168.1.83", (byte)3, 99.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4d47f13d-1c8c-42b6-b19e-22c844af1977"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1423), "192.168.1.99", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4d7e40c9-6b8b-405b-a56a-8e505b5c24d3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1618), "192.168.1.68", (byte)2, 77.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4da11885-a790-46c3-9e28-4ac2b793a065"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(636), "192.168.1.22", (byte)1, 43.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4f1ca870-7995-4323-8c7d-8b3a2fdc788f"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(614), "192.168.1.76", (byte)1, 0.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4f4a366f-7aa8-45e6-a361-b3afcf4b5e86"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(816), "192.168.1.77", (byte)2, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4f6bf348-b84d-47fd-9295-9ea3f269b198"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1033), "192.168.1.35", (byte)2, 93.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4f899829-2478-4c52-b1d8-6845b459e918"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2747), "192.168.1.40", (byte)3, 24.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4f98fb59-0676-4de4-9450-988998e79c20"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9585), "192.168.1.37", (byte)1, 76.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4fdb7e4a-d942-468f-8c0b-ea065712064d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(632), "192.168.1.83", (byte)1, 20.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4fdd94b4-7d37-4791-94db-f83a67a32595"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(951), "192.168.1.31", (byte)2, 42.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5020860e-e182-468d-bff7-f03276421733"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9847), "192.168.1.82", (byte)1, 97.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5091a615-43a3-40ff-a695-c8e740e90531"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1372), "192.168.1.56", (byte)2, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5139dc82-6688-47b1-8964-9c3877721469"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2573), "192.168.1.57", (byte)3, 10.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("52343ad2-2aa3-4793-ad02-771cdf8cfe38"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(558), "192.168.1.80", (byte)1, 89.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("52d7ab6d-e132-42c8-92b7-be0655a39765"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2731), "192.168.1.20", (byte)3, 25.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("530c2c55-d880-4a42-bf0a-9c217241ede4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2459), "192.168.1.50", (byte)3, 89.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("537b6a75-adb0-49cb-b8ec-05bc6b82fe35"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9746), "192.168.1.75", (byte)1, 3.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("54527c82-0bd1-4a25-be4c-5fec58a20cbd"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1521), "192.168.1.75", (byte)2, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("549d486a-856d-4f3c-bf63-2ba5110d7aad"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2666), "192.168.1.33", (byte)3, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("54cd6a1f-ef19-44fd-85a9-da8590b1b0a3"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2380), "192.168.1.62", (byte)3, 90.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5565ebf3-faa5-4380-ac20-4e0208cafd54"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2246), "192.168.1.34", (byte)3, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("55823905-66f4-4934-b3cb-51ded57694a0"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(939), "192.168.1.68", (byte)2, 61.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("55a4779c-887c-47ca-84ad-16530e900f32"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(387), "192.168.1.84", (byte)1, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("55c739bb-17a5-4305-9799-c05db7422333"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9925), "192.168.1.15", (byte)1, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("55ede0ff-5117-4886-84cd-3847c125feef"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9871), "192.168.1.61", (byte)1, 46.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("56348bd8-d714-4af2-89d3-1ddf56585cd7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9590), "192.168.1.54", (byte)1, 95.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("566c52f6-9866-461a-99f7-efb63445751e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2769), "192.168.1.62", (byte)3, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("56f4ca0d-5ad1-453f-8c4e-6feec5737f7d"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2096), "192.168.1.34", (byte)3, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5745d441-2fc4-4a27-911d-b6b6d514f186"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1334), "192.168.1.54", (byte)2, 12.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("58276f13-a4bd-49f9-b910-6b3aec739cbb"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1513), "192.168.1.91", (byte)2, 61.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5960dbcd-e8c3-42e7-b6b2-d7b5538db6c2"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1730), "192.168.1.81", (byte)2, 23.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("597ae0ad-3ba2-49c2-b128-f8cf1bc20b38"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2773), "192.168.1.78", (byte)3, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5983b565-c276-472a-9c1b-abf31cd2b8b6"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(71), "192.168.1.28", (byte)1, 80.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5983db23-fc7b-4eeb-baff-829b705e08fe"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2557), "192.168.1.37", (byte)3, 79.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("59854e9a-a853-4a74-8987-2260bfbd6a8c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(421), "192.168.1.58", (byte)1, 73.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("59975b12-3b5b-4d40-afa4-4a02c8c3becf"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1652), "192.168.1.30", (byte)2, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("59f85360-6a40-4e8a-9d9e-24473e422f94"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2168), "192.168.1.10", (byte)3, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5a21616d-24fb-4275-a2d2-8505a74200be"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2426), "192.168.1.66", (byte)3, 72.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5a377b87-5ddc-4480-88f6-492e9761b32c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(913), "192.168.1.59", (byte)2, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5bf48f24-5b89-42d3-a70b-b6ff4fe85ffc"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1726), "192.168.1.88", (byte)2, 14.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5c604c77-6bf2-42d7-9b55-84c3ed92d945"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(708), "192.168.1.9", (byte)2, 82.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5c90d560-fe00-4cb6-aecc-92e343bc5f71"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(47), "192.168.1.53", (byte)1, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5d2851a7-b437-4231-88fd-64a37426d0d2"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9621), "192.168.1.56", (byte)1, 94.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("5e178e7e-600c-4f36-83f4-3e4db84f30be"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1184), "192.168.1.24", (byte)2, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5e2f25a3-7f79-42c6-83c1-50b926c1b15a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2739), "192.168.1.43", (byte)3, 77.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5e608f4a-62dd-4be0-ad57-e6e61c51ff0b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2511), "192.168.1.36", (byte)3, 45.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5e8ae5ed-529b-47b1-95f3-04ef02ddb24c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1413), "192.168.1.35", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5ead9dad-5a28-4322-9250-91fb85238b74"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1566), "192.168.1.71", (byte)2, 49.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5eea709e-e403-4d5e-9689-a0cccdad4b45"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2637), "192.168.1.51", (byte)3, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5f20245d-f93b-49b6-ab18-c9164409b4ba"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(469), "192.168.1.56", (byte)1, 52.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5faea9d9-1a4d-43f1-97bf-25cd729d96ab"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1204), "192.168.1.15", (byte)2, 71.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5fb36f51-db3d-4788-b8d8-3d53ba4203cf"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2355), "192.168.1.9", (byte)3, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5fe2146c-84c4-4c79-aeab-1a60b991f65a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(760), "192.168.1.82", (byte)2, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("600d52be-c2ed-41fb-809a-72a7c17467c1"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2331), "192.168.1.41", (byte)3, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("602b16f5-cfc4-4919-b929-e562ceb28516"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9629), "192.168.1.55", (byte)1, 74.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("60a03c4a-056f-4045-9903-34240c2b3d13"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1023), "192.168.1.51", (byte)2, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("60bad2ad-d4d2-4b81-a954-68963c89fcde"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1689), "192.168.1.45", (byte)2, 71.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6180a9eb-d2b7-426c-bd50-8becc3b0d0a1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(678), "192.168.1.11", (byte)2, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6207392a-c5e6-4f3b-857c-cf800de8853b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1505), "192.168.1.92", (byte)2, 46.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("62a8880f-a4b4-40d0-b335-819782095a0b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9992), "192.168.1.63", (byte)1, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("62b9cbc2-1ad6-4ce0-a630-1595774c3140"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1238), "192.168.1.65", (byte)2, 82.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("633aa8a8-f5e1-4c8f-984a-b036e6ad01b5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9819), "192.168.1.56", (byte)1, 53.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6393e7c0-579b-44cc-8e2b-d5ef773da9f7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(399), "192.168.1.30", (byte)1, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("6457862c-48f8-4af8-89cb-86ec59906aa5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(206), "192.168.1.78", (byte)1, 43.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("64a81038-a424-4df3-a61b-11ec9759f8ed"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(503), "192.168.1.44", (byte)1, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("64b668e5-c418-457e-a2c6-2ed1a8298568"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1979), "192.168.1.38", (byte)3, 63.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("64f88b73-4f63-49e2-bcec-cb17c3e023cd"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1483), "192.168.1.72", (byte)2, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("65cddca3-627c-444a-bc17-406fc311d249"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(772), "192.168.1.94", (byte)2, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("660d0dcc-806f-4ae5-b3df-de087df1a38b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2795), "192.168.1.30", (byte)3, 73.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("663e92d6-b3e1-4b1f-97e7-40359a233ca7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2025), "192.168.1.70", (byte)3, 10.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("66abd602-0b04-46b2-9158-f32f695ca6e8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9600), "192.168.1.21", (byte)1, 13.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("67789731-b719-484d-a301-f02ba5428fe1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1104), "192.168.1.35", (byte)2, 6.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("67e1238c-fdd2-4def-8ac8-5cd48d7301d6"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2238), "192.168.1.41", (byte)3, 64.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("68a857ae-4a5c-4cc4-afbb-3aa3002e8273"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2146), "192.168.1.84", (byte)3, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("69658e93-05c8-43be-aefd-0757d14db7e9"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(524), "192.168.1.73", (byte)1, 17.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6970f5e7-4eae-402d-8d3c-76ce55966cda"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(391), "192.168.1.80", (byte)1, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("699f30c4-b748-4590-ae67-41b318ba68c7"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1087), "192.168.1.25", (byte)2, 55.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("69d52ea2-a962-4940-8796-f7f0f637bca5"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1749), "192.168.1.3", (byte)2, 17.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6a2ada12-5d91-46b8-8599-023f3bc4e46c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(947), "192.168.1.84", (byte)2, 73.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("6b1762d8-c5bd-4bfc-909c-d735daa96ae2"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(308), "192.168.1.76", (byte)1, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6f45db92-d471-40c6-9b1d-9abf4f79d224"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2392), "192.168.1.42", (byte)3, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("70182fc6-655f-4960-9da2-631e5e4bb6be"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9729), "192.168.1.9", (byte)1, 80.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("702678b4-83d9-49ec-a209-e425f404406e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(582), "192.168.1.25", (byte)1, 36.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("70884caa-b99d-473d-be8d-d9bfc14f161d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(328), "192.168.1.11", (byte)1, 45.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("7101e963-eee6-4f0a-93d3-6b4fc8f9ef5a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9805), "192.168.1.24", (byte)1, 65.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7168e7c7-0931-4a66-b8d1-3546fdbb6758"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2275), "192.168.1.35", (byte)3, 29.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("716a687b-1c63-4ed9-b224-1db1c4cf2671"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2305), "192.168.1.90", (byte)3, 51.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("71fabf4e-f650-4282-9895-5d3d995637bb"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9839), "192.168.1.7", (byte)1, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("728c638e-fabf-4e9f-a781-386832f5a019"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1656), "192.168.1.57", (byte)2, 44.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("72aee347-2bf6-49f7-a6f2-9e6b9fcc06e2"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(927), "192.168.1.62", (byte)2, 92.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("72dc95fa-058d-41ea-94b6-03e0cab8b13a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(860), "192.168.1.12", (byte)2, 47.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("72f3ba9f-4414-45e2-adf0-d0d41f3d81bf"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1781), "192.168.1.55", (byte)3, 18.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("735984bd-b2f2-4443-bed6-66ad81b4339e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2029), "192.168.1.3", (byte)3, 24.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7375fbf3-d420-4ee0-8582-36b76d7001b8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(570), "192.168.1.39", (byte)1, 78.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("73c9903d-f5e4-46a0-ae6d-aba0e835e67f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1491), "192.168.1.94", (byte)2, 25.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("73f4c459-aefd-41b6-94c8-ddc804d1277a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(687), "192.168.1.7", (byte)2, 71.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("744eca86-513b-4840-8f3a-9e836975700c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2706), "192.168.1.36", (byte)3, 41.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("750770b5-19e1-42f6-9e51-0c5a013e7565"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2455), "192.168.1.55", (byte)3, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("752e28a6-2b3a-497b-a823-cff605615907"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2698), "192.168.1.18", (byte)3, 65.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("763e02d2-3ff5-4782-91f3-f1fed10b8049"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(119), "192.168.1.90", (byte)1, 61.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("765b1afc-b50b-46fa-a2c7-45eca23e73a9"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2587), "192.168.1.37", (byte)3, 89.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("77911faa-2ceb-48b4-8c58-85b36d3658b3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1723), "192.168.1.16", (byte)2, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("77c44c6d-445e-4e64-b81f-892d2bc56172"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(67), "192.168.1.61", (byte)1, 10.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("788237ee-d928-47a2-8769-9dcef7c0f27a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2535), "192.168.1.26", (byte)3, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("78914777-3abb-4e78-ac2d-192e5afc26e8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9701), "192.168.1.23", (byte)1, 68.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("78d1ddb7-86a5-4c27-8968-58f00a2f8a8f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1417), "192.168.1.23", (byte)2, 63.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("79012f7c-4cb5-4d8e-9e8f-17040209ab60"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(756), "192.168.1.36", (byte)2, 84.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7933b1ec-cb7a-428b-aa05-ac94d128bd3d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1226), "192.168.1.34", (byte)2, 62.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("796255d1-d0b0-41c3-986b-9586494d0a14"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1576), "192.168.1.65", (byte)2, 31.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("79cacea4-ae0f-4515-89ad-f38d8fc539ee"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1932), "192.168.1.93", (byte)3, 38.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7a330ece-20bd-4463-99f4-d0f0d31c4f6d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(244), "192.168.1.81", (byte)1, 71.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7b5fe6d3-2c9d-43c1-9da4-28e21e281ab4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2301), "192.168.1.61", (byte)3, 27.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7b78c98c-9ef4-4b54-b2ea-79be52500779"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2418), "192.168.1.28", (byte)3, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7b9c3ecc-08c3-42a2-a62e-06195deb4803"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(778), "192.168.1.48", (byte)2, 71.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7bbedc70-bbd0-4744-a094-113dae43aeeb"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2641), "192.168.1.25", (byte)3, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7bdac34d-c5b1-4652-9334-12fbadc048f3"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(540), "192.168.1.83", (byte)1, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7c6c00d5-8052-4f75-a089-75033891b0c1"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2447), "192.168.1.69", (byte)3, 24.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7cebc56a-4565-4ecb-ac1e-d4a0a1944193"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2469), "192.168.1.75", (byte)3, 57.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7d18f5a5-8347-476b-a10d-c7bf286431b5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(507), "192.168.1.66", (byte)1, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("7db40338-2068-4be0-bf9c-c6099523925f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1630), "192.168.1.11", (byte)2, 84.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7e108900-0642-4db1-941c-cd3045cded48"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2702), "192.168.1.76", (byte)3, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7e434071-8834-4e3c-8f13-5a7c3cd7c8c7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(536), "192.168.1.16", (byte)1, 44.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7f1b4b4e-4335-4160-abcd-800f43f6ca14"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(683), "192.168.1.34", (byte)2, 45.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7f431a62-9131-4fae-98fb-c08fd4899485"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2293), "192.168.1.72", (byte)3, 39.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7f544631-3d67-4842-a7cd-5fa04447a53d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1380), "192.168.1.32", (byte)2, 20.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7f70f178-63f6-4353-80f2-01e60af3dcd4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2497), "192.168.1.53", (byte)3, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("7ffda39e-023f-4e8a-b3c4-cde7ef4ddf1a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1648), "192.168.1.80", (byte)2, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("804a0416-5035-4ace-b090-1a36b7ff2425"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(312), "192.168.1.48", (byte)1, 50.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("808533a0-b0c2-43c4-b549-485362eaab5a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(210), "192.168.1.38", (byte)1, 80.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("80e16ed1-f80a-4142-99f8-3cbab8f8d58d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1300), "192.168.1.97", (byte)2, 55.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("81988d92-1bc2-410d-86e8-d150397eee54"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2818), "192.168.1.23", (byte)3, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("81de5ef5-3e79-4ed4-9969-61d013aea5d5"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1542), "192.168.1.28", (byte)2, 25.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("82754335-aa0e-48ba-ad3a-3d2c9e981670"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9685), "192.168.1.93", (byte)1, 68.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8329da76-f2e0-43ee-bbbe-49882f70785b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9920), "192.168.1.93", (byte)1, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("832cdb17-418e-4fff-aa0d-a9560858a1a0"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9779), "192.168.1.12", (byte)1, 78.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("84748ed7-28f1-4ca5-86f9-d03759b08051"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9913), "192.168.1.58", (byte)1, 16.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("84c66990-080f-44a1-92ad-bfe8a028e871"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1525), "192.168.1.28", (byte)2, 29.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("84e123b8-cf8b-417f-96c6-fec1cb709f4e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1765), "192.168.1.87", (byte)3, 79.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("85580187-839e-4fa7-a374-781a63a6c6a7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2785), "192.168.1.34", (byte)3, 89.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("85f3706d-9332-4f6a-b9fc-e5dbfdadb123"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2317), "192.168.1.40", (byte)3, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("85fb64c9-d819-463f-a085-085524990194"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2309), "192.168.1.8", (byte)3, 1.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("86222534-567b-49df-82ba-19d887691298"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1991), "192.168.1.11", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("862cfe4b-5c58-415d-8e8c-e358fc4e807b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1281), "192.168.1.99", (byte)2, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("86389cd7-6d4a-4489-9e16-b7ce41d9ae21"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2777), "192.168.1.88", (byte)3, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("86a338ff-8dc7-4055-b371-9d56c922e17d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1330), "192.168.1.62", (byte)2, 38.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8767ad0f-9ec7-4d22-a6c7-9a9ca2a39839"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9604), "192.168.1.52", (byte)1, 56.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8770545a-5fe0-4b11-bfe2-45d10cd1633e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(893), "192.168.1.84", (byte)2, 70.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("87b76c94-8da9-436d-92dd-630f12193af3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1326), "192.168.1.55", (byte)2, 47.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("87be485d-6077-4189-8c20-98e50528dbcf"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9789), "192.168.1.65", (byte)1, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("887ad70b-d941-4b6d-b16a-73e5991f2203"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1406), "192.168.1.12", (byte)2, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("887f3e69-79ec-481f-b5ea-b8466dd1a663"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(931), "192.168.1.18", (byte)2, 45.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("88a9197d-3584-4ac3-99c9-0478f9c17cec"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(499), "192.168.1.50", (byte)1, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("88c14425-b3a9-4ce8-8e7f-e541e9e94b20"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(461), "192.168.1.37", (byte)1, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("88d22dd3-6ac1-4b7e-8273-7d7c89bac3ef"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(131), "192.168.1.13", (byte)1, 63.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8937379f-cd21-4d1e-89ea-dbf245f63fd3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1638), "192.168.1.86", (byte)2, 50.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("89d1f9f6-ed13-4d0d-b16d-046960e23409"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(346), "192.168.1.30", (byte)1, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8a187a05-4a23-488d-8bdf-d063af9b4c71"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1394), "192.168.1.7", (byte)2, 29.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8b189d3d-ce7a-4466-bdc8-8a42c13dd22d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1322), "192.168.1.82", (byte)2, 2.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8bdbfbfd-444a-4cc6-ac45-78b4d1f1df2a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(724), "192.168.1.85", (byte)2, 27.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8bee4484-01ad-46ef-87c8-48cd5d2daa45"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9793), "192.168.1.10", (byte)1, 84.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8c0bb837-25ab-4db4-8af2-09eb08c1e473"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9810), "192.168.1.72", (byte)1, 23.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8c906252-5c9d-40fc-b34e-43acf771da2c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1188), "192.168.1.89", (byte)2, 72.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8cb5fa55-5c06-48ea-85f5-7591a3fda536"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1886), "192.168.1.34", (byte)3, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8d7670d1-428b-416a-a24f-8cca6116ba14"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(437), "192.168.1.92", (byte)1, 46.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8daa110b-cc50-4de2-be00-d3b3e97967e6"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(712), "192.168.1.57", (byte)2, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8e863d32-0054-4156-9fe0-e7b9dbf871c4"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1346), "192.168.1.47", (byte)2, 38.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8e8ec5d6-8f0c-4ed5-abd9-df333f65ac9b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9697), "192.168.1.3", (byte)1, 60.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8eb4f500-9110-43ca-8233-8b1f755a330e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(240), "192.168.1.61", (byte)1, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8fec09d8-d3d9-4541-b9b9-f7e5bb56f2b9"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(644), "192.168.1.11", (byte)1, 20.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9061adc0-de32-48a8-8a6a-aa03f57787c8"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1701), "192.168.1.77", (byte)2, 75.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("90951182-f701-4521-8dc2-a8f7ede5b9d2"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9767), "192.168.1.36", (byte)1, 28.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("90a8fd8a-9530-4215-b0d6-9c7d63392302"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2430), "192.168.1.90", (byte)3, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("90f02dca-b18b-4d1f-a98c-5835a13d406a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(640), "192.168.1.53", (byte)1, 6.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("91692b4e-b869-4c85-ab96-bb624bf6cd18"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(332), "192.168.1.48", (byte)1, 84.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("92c9f54f-ab55-43d4-ace6-faff61820a2b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9988), "192.168.1.27", (byte)1, 76.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9366f004-f564-4761-b736-04a72a880d17"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2662), "192.168.1.87", (byte)3, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("93ee9857-7b89-43a3-8b61-f1d0ef690712"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2761), "192.168.1.52", (byte)3, 71.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("94584c0e-32e2-4e34-a60f-1524dfe8f1f9"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9964), "192.168.1.69", (byte)1, 99.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9460a8b6-e4fc-4a5d-a37b-a65ddf24d32a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(265), "192.168.1.71", (byte)1, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("94a572b0-d80b-4df4-a53b-47aca2faa5bb"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1660), "192.168.1.36", (byte)2, 49.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("9559d28b-aebe-4847-8b3c-9b325f1683d7"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1312), "192.168.1.95", (byte)2, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("95ab4205-75d8-4762-9109-734b29266133"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(806), "192.168.1.65", (byte)2, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("95ad0734-84c7-4b1b-bb7f-04e5d52fcb6b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2549), "192.168.1.52", (byte)3, 72.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("95d603fe-a125-42b2-9def-a9d17b81e5fa"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1866), "192.168.1.35", (byte)3, 27.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9604ca0c-80a2-44fe-8c28-ab5d2636bcf4"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9947), "192.168.1.75", (byte)1, 90.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("970a55af-76e0-4d8d-b0e1-ef227d4c340b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2727), "192.168.1.31", (byte)3, 55.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("97592731-5261-4d64-8efa-bdddd3bc3c4c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9759), "192.168.1.91", (byte)1, 50.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("98174278-2f2c-4e76-8069-5301e02123d5"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2489), "192.168.1.36", (byte)3, 2.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("987bc259-2c7c-4453-99ad-bad97b0ed7e0"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1079), "192.168.1.20", (byte)2, 84.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("98970432-89a8-42e5-b9c5-6f6e2eaa8b32"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1928), "192.168.1.42", (byte)3, 71.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("990bc6fc-8bd5-4275-a8a2-ec8bf702dff7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2263), "192.168.1.91", (byte)3, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9926971a-6582-446f-a953-41f3118b6f95"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2422), "192.168.1.85", (byte)3, 20.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("993a234a-4b9a-4bbe-9fa0-dc12a08e11a4"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1003), "192.168.1.5", (byte)2, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("99a45c53-0af5-463a-bdbe-5a09835cd1aa"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9567), "192.168.1.49", (byte)1, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("99f6d3f4-4152-4b38-8987-77920827efe7"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(993), "192.168.1.97", (byte)2, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9a4d16a5-6853-46be-a9bf-bca842e0db4f"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9883), "192.168.1.80", (byte)1, 22.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9a7e7469-6f99-4f84-bf76-514086563f9b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(193), "192.168.1.18", (byte)1, 77.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9a9d4af8-05bd-45b4-85a7-8c4569199c4f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1705), "192.168.1.1", (byte)2, 66.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9b17a04c-6c5c-4fc5-b19f-80b1b47923a2"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2481), "192.168.1.90", (byte)3, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9b6327e6-9054-477f-a8a8-7577cb782557"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1154), "192.168.1.8", (byte)2, 96.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9b693923-fb9d-4044-8c3b-02e62a726c53"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(956), "192.168.1.92", (byte)2, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9b7c65f4-3d83-4916-83d5-f1f090db00c6"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9973), "192.168.1.38", (byte)1, 5.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9bb7a4ec-5937-4192-a97e-5a79a2491f3e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2037), "192.168.1.30", (byte)3, 81.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9bf7cffe-b76f-498e-b833-df419d0fa5ee"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(728), "192.168.1.74", (byte)2, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9bfa3750-80f8-42fa-8150-a589181410d9"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2259), "192.168.1.89", (byte)3, 80.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9c047df8-638d-4d1f-b324-93daab0ce047"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(92), "192.168.1.22", (byte)1, 54.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9c294306-2308-4ce3-b6a8-bbf3a323233c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(846), "192.168.1.37", (byte)2, 38.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("9d29e916-38c1-4a1b-a514-0719cbe90070"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1999), "192.168.1.48", (byte)3, 25.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9d612c0a-2f08-4cd4-9d1e-e3434310a8eb"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(566), "192.168.1.30", (byte)1, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("9d9034a7-2af4-40eb-a0a5-1b3a8502bce5"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1342), "192.168.1.29", (byte)2, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9db9957a-9c63-4517-a9c7-f163eaed712e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2410), "192.168.1.27", (byte)3, 74.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9e2d1b6d-bcf1-4e3b-b5b0-eec2f5bd8421"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(278), "192.168.1.39", (byte)1, 8.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9ef67af6-eb6b-4ff0-862b-751cdd566a9e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1432), "192.168.1.19", (byte)2, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9ef8f85b-1c08-4281-9dc0-4e264e0754c0"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1950), "192.168.1.55", (byte)3, 82.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9f1bd748-e361-4f2d-8222-fae5717200e5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9763), "192.168.1.46", (byte)1, 40.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9f8bdc91-3a8c-48e0-a601-a65ecb7b7419"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1709), "192.168.1.13", (byte)2, 20.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a01d34a8-a98a-4864-b0b3-7131b02319ab"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1958), "192.168.1.81", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a0bd10b7-5b2e-4d3f-8075-7282e15e3d84"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(850), "192.168.1.8", (byte)2, 65.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a15197f8-10a9-47a6-b873-0cfc1bfb06bf"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1799), "192.168.1.14", (byte)3, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a15bc202-af03-4553-b2a6-9a0e328bfa5c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9677), "192.168.1.93", (byte)1, 46.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a1790c99-f0f6-480c-b2ba-ccdde07a5a24"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1987), "192.168.1.4", (byte)3, 57.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a1a81cef-0bd2-4954-a274-d951524baa2e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1487), "192.168.1.67", (byte)2, 20.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a1ca549c-a498-4f95-bc79-a61cbed61724"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2210), "192.168.1.63", (byte)3, 95.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a244798b-d7f7-4567-b76a-42e08e6e91f1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(720), "192.168.1.79", (byte)2, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a2b0612b-917d-4d0a-bf95-e2b26377c690"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1129), "192.168.1.97", (byte)2, 81.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a2c1b538-fc47-4044-b22d-d24a24e1826b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1819), "192.168.1.29", (byte)3, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a2e6cb3a-a7ae-49e2-b75b-246581c8b309"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9857), "192.168.1.88", (byte)1, 76.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a31e7eb3-12ea-4cec-8637-c842d317fa1a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1681), "192.168.1.81", (byte)2, 66.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a32a3c84-0f64-4301-a8ac-d2a53aa383c7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(370), "192.168.1.49", (byte)1, 66.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a41e0b5f-38f6-4a41-8b90-2aea03b4b89e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1742), "192.168.1.34", (byte)2, 33.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a44ccb70-69ae-4432-8107-b6e1f83e5184"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1715), "192.168.1.93", (byte)2, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a50bab82-c0fa-499c-be0e-a640eaccb861"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9935), "192.168.1.55", (byte)1, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a55634d5-aad9-4447-b76b-f6feed8f6030"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1356), "192.168.1.63", (byte)2, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a5d6ab79-b5e0-4c4f-b0e8-02c066e33fe9"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1833), "192.168.1.89", (byte)3, 37.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a6a2344e-8df4-421e-b3bf-f6fdca33f252"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(433), "192.168.1.59", (byte)1, 77.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a6d9117f-a502-4814-83a4-1e17f58bdb64"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1791), "192.168.1.59", (byte)3, 99.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a719c885-5927-4839-95d2-6dc0f9e85a17"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1672), "192.168.1.76", (byte)2, 0.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a71c5307-211f-4c8a-9675-bc646b7de863"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1499), "192.168.1.76", (byte)2, 27.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a7a886c8-7b0f-434f-b96f-1fe2e14277b3"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2226), "192.168.1.22", (byte)3, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a7bffdb0-3cb4-4420-ac6d-8750ecc37c8f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(691), "192.168.1.14", (byte)2, 44.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a7ed1f77-be83-4821-b91a-f76868c0bc89"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2084), "192.168.1.6", (byte)3, 18.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a86f4f85-1892-4d91-a643-dd51b0eb820d"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1920), "192.168.1.20", (byte)3, 56.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a8b2298e-ccd9-4af4-8634-0e539d9c70c4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2811), "192.168.1.52", (byte)3, 40.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a8bf5f88-a198-4417-aed3-9a2a23547c9c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1234), "192.168.1.74", (byte)2, 10.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a8df246b-0786-4c18-be40-25f541cf2944"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1210), "192.168.1.98", (byte)2, 80.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a928144b-c57a-4d14-8b7d-ac038c3d3050"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1158), "192.168.1.38", (byte)2, 29.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a935986a-ee70-4d69-8d54-1603d80f1d0a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1803), "192.168.1.26", (byte)3, 45.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a97e7704-96e1-4663-8977-32813fa5ef5f"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(477), "192.168.1.99", (byte)1, 92.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a9a45464-7f9c-4b2b-a342-c8b316312adc"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1634), "192.168.1.34", (byte)2, 98.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("aaa41935-e65e-46db-8fc1-9891a5d32bfb"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9609), "192.168.1.43", (byte)1, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("aabef71b-9121-4cb4-951b-454414d540e4"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(320), "192.168.1.1", (byte)1, 23.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("abc7d0ff-87c4-43d7-a2cd-a646bb9d44fc"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9827), "192.168.1.66", (byte)1, 70.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("acd93b88-3637-4a80-abef-618743871bdd"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1162), "192.168.1.12", (byte)2, 31.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("acfb25bd-e309-45eb-b41f-82e9ceefc9e2"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(261), "192.168.1.94", (byte)1, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ad8d0dc9-860b-4bb0-8208-ba6b8bc42e6f"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9635), "192.168.1.81", (byte)1, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ae25f42f-7852-463f-a046-f40237901648"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2250), "192.168.1.52", (byte)3, 87.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ae7c3117-b005-4f5e-aded-3fa1456aac5b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1446), "192.168.1.98", (byte)2, 93.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("af30fb7e-38e4-4da4-b52f-fd11a0c1195d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(574), "192.168.1.14", (byte)1, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("af4e49c0-8af1-42fb-8b1e-1395e85659b4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1882), "192.168.1.26", (byte)3, 66.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("afb1444d-06c9-4d47-86f4-1f90baabb309"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2396), "192.168.1.42", (byte)3, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("afcb556c-5139-4a7f-be4e-fd2012f3a679"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(88), "192.168.1.61", (byte)1, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b0928456-edf3-4fa7-86cc-0873b526e4db"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9917), "192.168.1.30", (byte)1, 54.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b0b4d12e-f91a-4807-b2c3-674c3653979f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2013), "192.168.1.54", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b1546a9e-12ba-4805-b96e-2c600e5ee10f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2735), "192.168.1.31", (byte)3, 84.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b1c23a15-bc44-48cd-8690-4b078928d30e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(532), "192.168.1.83", (byte)1, 20.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b22407da-0a98-481e-a4c7-5d2ee7b46291"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1795), "192.168.1.62", (byte)3, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b24a7a07-1099-4c85-9c72-8003a2996c1d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1134), "192.168.1.25", (byte)2, 61.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b2ad5c15-2564-450c-85ec-9bafa2cba310"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1529), "192.168.1.34", (byte)2, 49.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b2eb82a8-4a32-4083-872a-8022c5dff854"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2070), "192.168.1.36", (byte)3, 38.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b3324b03-eb73-44e5-bcf1-67796be4678f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2100), "192.168.1.91", (byte)3, 9.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("b433700c-c29f-41ae-89f0-27d4aa123c02"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1285), "192.168.1.88", (byte)2, 71.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b4955694-c120-4559-a91f-ff5d86a18ce0"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(794), "192.168.1.59", (byte)2, 75.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b519783c-b866-4c32-830f-9b907ff59b51"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2402), "192.168.1.24", (byte)3, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b56f0d53-d1c2-4b3e-9a59-97f41a70fa42"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2451), "192.168.1.22", (byte)3, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("b5906c49-7720-4170-8376-58f33b8c14ee"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2814), "192.168.1.20", (byte)3, 89.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b5b8e5e5-0d47-4a00-be25-64a3418c4b1b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1011), "192.168.1.22", (byte)2, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b5fbc913-5f2b-4242-963e-5d920a273a41"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(197), "192.168.1.15", (byte)1, 96.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b6073c57-0698-4477-9bdc-b2cae0deb970"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1588), "192.168.1.88", (byte)2, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b631509a-f40a-4e5b-bfb5-86ffdf65d1df"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1773), "192.168.1.55", (byte)3, 15.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b635c397-14ee-48fa-8637-dc92350e94ff"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1180), "192.168.1.38", (byte)2, 3.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b671e242-d17f-4a4b-af97-cdcbeb06cef2"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1479), "192.168.1.9", (byte)2, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b6bcaa1e-2534-4d4f-8cf2-83d600f4daf1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1475), "192.168.1.2", (byte)2, 40.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b6d06a46-f2f2-49ec-8ca8-948b2dfb70e8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9667), "192.168.1.72", (byte)1, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b6f88edf-518a-4259-b8eb-57e38a1acd03"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(999), "192.168.1.11", (byte)2, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b70d34a4-c6e9-481c-b4f1-de66f82b4967"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9930), "192.168.1.69", (byte)1, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b74e61c6-0a24-4ebd-aaee-9c95c465e859"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1676), "192.168.1.80", (byte)2, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b769fdc8-0bc2-45db-8a0f-91bdf98627e0"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2650), "192.168.1.26", (byte)3, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b8491044-fe21-47f9-9f2c-517c5394d054"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2463), "192.168.1.30", (byte)3, 21.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b8734f83-0adb-4c08-92eb-22bae8bd31d8"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2670), "192.168.1.39", (byte)3, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b8abc892-e9b1-4fea-9d5c-789322e0569f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1007), "192.168.1.82", (byte)2, 20.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b8addae5-5ae7-4c72-afff-e502b87cba85"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(473), "192.168.1.18", (byte)1, 19.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b8bb433a-d3c8-4fb6-90b7-4bc3aa864fe3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1067), "192.168.1.89", (byte)2, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b8c9c4fb-6d58-4e75-a725-03ef1feebbdc"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9977), "192.168.1.29", (byte)1, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b9e65a03-661c-4abe-9be9-b6f677f49198"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9984), "192.168.1.42", (byte)1, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ba016d04-2489-4fbb-995c-17e627710ad6"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(828), "192.168.1.84", (byte)2, 6.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ba05e84f-ab10-406d-b49e-cb70f65ddce7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9843), "192.168.1.60", (byte)1, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ba1d2819-93b9-4411-b215-0bffd47551c1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1196), "192.168.1.19", (byte)2, 99.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("baa75831-59b1-470a-8a99-be1c0cf447b9"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1874), "192.168.1.51", (byte)3, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("bab9962b-89a7-4bf4-9808-1ffefd20d21a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2807), "192.168.1.21", (byte)3, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("bae93c86-edad-483e-8cae-3ddc10614516"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(171), "192.168.1.56", (byte)1, 48.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("bb2e2434-ded3-4bfe-b22e-9e1be96f2044"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2654), "192.168.1.79", (byte)3, 39.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bb84892d-3fca-4cde-9351-5c2c41f12792"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9814), "192.168.1.58", (byte)1, 94.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bc341e89-8fac-43d1-a3d5-ef82923b8b50"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(123), "192.168.1.31", (byte)1, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("bc36e255-07e5-4f15-8ab0-30f1f51e5e9c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2791), "192.168.1.97", (byte)3, 41.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("bcbd0bec-1a28-422b-8dd8-1a7e144cb398"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(666), "192.168.1.71", (byte)1, 32.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bccfbc0f-2094-4fec-86cf-f906d2c4f809"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2156), "192.168.1.95", (byte)3, 95.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("bd3be013-4c63-4775-8735-ee62b152ab10"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2599), "192.168.1.4", (byte)3, 6.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("be821e4d-85e4-4441-9ebf-7399052f1a1d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(6), "192.168.1.8", (byte)1, 19.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("beaf39aa-9ef2-45f6-a0ad-ea91e15eabaf"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(256), "192.168.1.29", (byte)1, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("beb9674f-964c-44f0-8798-b4b9492df2a4"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1192), "192.168.1.12", (byte)2, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("bed54aaf-66b2-4430-af4c-f633a3c6f972"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(413), "192.168.1.68", (byte)1, 67.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("bee9a99a-afa9-4ba8-b820-b20abb7378ed"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1697), "192.168.1.63", (byte)2, 28.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("bf55782f-5134-40f7-9764-1572b58895b8"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1061), "192.168.1.92", (byte)2, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("bff1d1cb-4125-43ee-8388-bc6d0e055ec5"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1584), "192.168.1.75", (byte)2, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("bffd638c-5061-4dee-9057-7bbe98012cc5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(487), "192.168.1.42", (byte)1, 63.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c0397972-879e-4e83-8549-afc9dfcc46cd"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(812), "192.168.1.85", (byte)2, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c08b052f-ca22-485f-94f8-dae6c9eeb370"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1350), "192.168.1.76", (byte)2, 68.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c099ae90-6d2e-4807-935f-59611b8b86d6"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2553), "192.168.1.17", (byte)3, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c12cca29-099d-4748-bab3-4919261928a8"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(520), "192.168.1.27", (byte)1, 58.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c145341f-4acc-4fa3-8a71-925aef917f49"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(148), "192.168.1.85", (byte)1, 10.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c2208002-7b26-4b71-8d64-978b81f1129a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2283), "192.168.1.21", (byte)3, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c22e0acd-b6b7-4caa-9da8-550e92fabe02"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1761), "192.168.1.40", (byte)3, 45.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("c446ba73-4703-49a5-bceb-051206852342"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1053), "192.168.1.75", (byte)2, 16.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c491dca0-1852-4d30-8f03-53fdcafc24b3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1045), "192.168.1.91", (byte)2, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c4e39c15-6610-4472-8281-96bb0c4e4ca5"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(909), "192.168.1.14", (byte)2, 15.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c501aa87-00d0-48e2-8643-25ebfede366e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2271), "192.168.1.35", (byte)3, 95.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c5b285fa-28a4-4c2b-9db0-50eeb909ab9a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1027), "192.168.1.46", (byte)2, 17.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c622ddb1-6f69-48f0-8061-be74990bfe63"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9641), "192.168.1.17", (byte)1, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c67cd02a-8500-4bdd-9936-bfae5f6d185a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9716), "192.168.1.65", (byte)1, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c69ceb3f-3e8c-46fc-a561-57d35a68a5d6"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9663), "192.168.1.42", (byte)1, 20.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c6d13146-64e2-4e9f-8f2f-8e7811541867"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(218), "192.168.1.55", (byte)1, 80.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c6edb459-79cc-4439-bd36-4f6c63b81fc8"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2565), "192.168.1.64", (byte)3, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c70db6f9-369e-4eb5-8e4a-61fc09ed5588"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2043), "192.168.1.67", (byte)3, 47.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c733fcf0-7509-465e-8d94-c0ff256c7a85"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(135), "192.168.1.75", (byte)1, 67.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c7418bde-564c-4047-b115-beaf27f7fdb1"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(252), "192.168.1.14", (byte)1, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c859ff24-8a15-4325-b33a-cc0e28df1023"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2561), "192.168.1.19", (byte)3, 52.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c865114d-9544-424d-b38a-3ccbc6c8478a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(282), "192.168.1.16", (byte)1, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c86ca6b7-0007-4aef-a582-5b71475fef5f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1264), "192.168.1.6", (byte)2, 60.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c87adc8d-741a-42a2-8d89-f47620af75ec"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1614), "192.168.1.34", (byte)2, 12.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c8c96413-86c3-4e11-a057-3aa5e838148a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(409), "192.168.1.29", (byte)1, 88.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c9ca13e8-72da-4595-908f-5d9bf64e0fad"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1364), "192.168.1.79", (byte)2, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c9cad257-e937-4516-9a57-aa80f56b0d07"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2443), "192.168.1.91", (byte)3, 46.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c9d14df0-1c9a-4245-a4bd-862e84204371"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2684), "192.168.1.59", (byte)3, 66.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ca018142-cb75-473a-9745-d728133d3484"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1970), "192.168.1.65", (byte)3, 62.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("cae19878-97ed-46e0-8883-36fa32ded6c6"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(868), "192.168.1.19", (byte)2, 59.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("cb1a3a19-11aa-444e-a39d-0b27274f740f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1091), "192.168.1.93", (byte)2, 8.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("cbba45cb-039d-466a-a3d9-6f67ea805fd4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2591), "192.168.1.82", (byte)3, 88.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cbca7c35-9767-4f20-bc74-a379fc1c72b7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2577), "192.168.1.84", (byte)3, 79.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("cbdc5c43-9830-4efb-b794-535c6ab1e189"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1596), "192.168.1.51", (byte)2, 89.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cccdae18-3988-4d6e-97df-9c48224234ce"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2406), "192.168.1.97", (byte)3, 75.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ccf39532-567d-4c60-a52f-fd1638e2da4d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(481), "192.168.1.25", (byte)1, 7.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("cea7c522-3f90-43cc-8248-fdf4ece7fb5b"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(248), "192.168.1.56", (byte)1, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ceb70757-b2a5-485f-b1ab-ff3b61742244"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1693), "192.168.1.34", (byte)2, 92.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("cee1d969-6a7e-4324-8b41-939bea3a244f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(879), "192.168.1.94", (byte)2, 81.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cf7010fa-5942-4c33-9cda-32c1bbc4a46b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(704), "192.168.1.4", (byte)2, 79.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d080bd23-fb05-4abf-ad72-e6251121dd7e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1975), "192.168.1.18", (byte)3, 98.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d0b005ba-2c87-4d3f-8184-e19d0334c793"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2689), "192.168.1.83", (byte)3, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d18902c7-6566-4cfd-abd4-bf23783d903c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9673), "192.168.1.86", (byte)1, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d2491a39-22af-431a-ad45-194ee3d2ad4e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1465), "192.168.1.10", (byte)2, 62.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d2965db2-4337-42ab-90b9-7a2195b53b24"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2710), "192.168.1.28", (byte)3, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d332c95f-2958-43a3-8157-2dc79b5fd71f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(876), "192.168.1.66", (byte)2, 72.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d3c077e6-0477-41dd-be83-294a5ba3b9b8"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(751), "192.168.1.54", (byte)2, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d3c31f80-d112-46f1-a912-8fa67e548c83"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2122), "192.168.1.32", (byte)3, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d4250786-81e3-4124-9402-1e2fbbf90e6f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(790), "192.168.1.64", (byte)2, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d47519e1-1d7e-4b0c-89a2-6de5c42125df"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(820), "192.168.1.15", (byte)2, 87.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d47c7012-3013-41a0-9cbf-ba70ac002d64"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(429), "192.168.1.18", (byte)1, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d4840150-8570-4eac-aa7e-818e9d8e9361"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(179), "192.168.1.80", (byte)1, 24.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d4af0ee4-a8d3-4425-b4e0-2cb3bca3a727"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(350), "192.168.1.71", (byte)1, 90.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d4f92576-259f-4ba7-a299-3e12643475d9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(977), "192.168.1.84", (byte)2, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d55fd7f0-53c0-4f43-b0da-4b77cb74d38c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9981), "192.168.1.78", (byte)1, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d5b73628-1980-4193-abec-90bfc82c6df5"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2743), "192.168.1.76", (byte)3, 19.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d5c075ea-cf42-45a2-9d2f-c30bcbdc9ee3"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9823), "192.168.1.28", (byte)1, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d5c694b6-99a2-4f28-af76-16aac0c20a68"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2485), "192.168.1.62", (byte)3, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d5f4bdfe-7823-4fe6-8fa6-fc7202678826"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(425), "192.168.1.14", (byte)1, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d60e3f15-55e5-4f9d-9cbd-81eb3f92b1ea"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1954), "192.168.1.27", (byte)3, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d63b9748-747c-4482-bd3a-66b15754b40d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(214), "192.168.1.72", (byte)1, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d6d7a7ff-5ee0-4728-a883-ad7c9cb677e7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2644), "192.168.1.28", (byte)3, 82.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d724bcd1-badd-4c35-b80c-ab2de7cb0e32"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(961), "192.168.1.52", (byte)2, 20.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d7d57eb6-6839-432e-9711-59f712c0513f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2335), "192.168.1.85", (byte)3, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d7fc714d-ac7a-4f18-9a29-8b33f80eca6e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9968), "192.168.1.6", (byte)1, 3.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d83bcc2b-fc34-433c-8fd4-6dbafcbf0da6"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1200), "192.168.1.82", (byte)2, 54.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d85181fb-89ff-403e-a626-65fa68bd1f30"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2172), "192.168.1.51", (byte)3, 25.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d9521111-8cd8-45f8-aa22-7fe176d4ac4e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1807), "192.168.1.4", (byte)3, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d95a52db-3c48-4818-8575-22833c9fcb21"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2629), "192.168.1.85", (byte)3, 10.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d98fe82e-c634-48af-a396-21d9e197447c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2658), "192.168.1.68", (byte)3, 66.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d99dfe62-351f-456a-901a-f03d20d0d641"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9943), "192.168.1.96", (byte)1, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("da02f244-ddd0-4ff2-bb8d-2d6edbd7ec18"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1398), "192.168.1.42", (byte)2, 27.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("da38bc81-3ae4-425d-8461-c0f49834d615"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(366), "192.168.1.90", (byte)1, 85.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("da3b85af-79bc-4be7-b67b-de7bc6c400ff"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9707), "192.168.1.8", (byte)1, 3.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("da48a57f-ab2e-4285-ba1a-57605dfa4780"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2078), "192.168.1.26", (byte)3, 79.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("dac8d291-9722-4e36-a400-7115c6d12d48"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9908), "192.168.1.19", (byte)1, 76.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("db218ffc-7c1a-4a59-914e-1b0a944a6b5d"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2313), "192.168.1.62", (byte)3, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("db5c60fd-648e-424c-86dd-897de2e5a0e4"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2242), "192.168.1.45", (byte)3, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("dbb38350-c731-486c-a162-cf3d885fe579"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2781), "192.168.1.48", (byte)3, 96.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("dc68b2a1-03f1-4980-9f40-c238e38918de"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2108), "192.168.1.21", (byte)3, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dc7114b3-739c-464c-ad07-0bf02513657a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(358), "192.168.1.36", (byte)1, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("dcbd1970-1bb4-4a36-968d-22be74690169"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(395), "192.168.1.93", (byte)1, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("de1e6a23-3f9f-442c-9d56-3563f678fa7b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1389), "192.168.1.15", (byte)2, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("de9a3d0a-28e7-4cd5-9702-cfd8cc148258"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9573), "192.168.1.2", (byte)1, 8.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("def5e839-4375-4fef-bb0a-75c3f0eb1713"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(660), "192.168.1.10", (byte)1, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("df125f78-9f7b-46eb-bb2b-e4acde051732"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2611), "192.168.1.57", (byte)3, 13.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("dfefce0b-a62e-4793-9c32-9e123bfde8af"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(236), "192.168.1.90", (byte)1, 40.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e06dab3d-1a94-41ab-a3a0-76841c5e6bd1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1368), "192.168.1.2", (byte)2, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e07a298b-5141-4ca2-a00c-cf300e4fe5c1"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1853), "192.168.1.38", (byte)3, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e0906741-916a-47af-809b-b614cb06eb67"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1166), "192.168.1.68", (byte)2, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e0949174-59df-4d08-b934-7435582e5a53"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2439), "192.168.1.6", (byte)3, 57.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e0edb0e5-db64-4533-acaa-b7f3676045be"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(465), "192.168.1.14", (byte)1, 43.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e16a454f-b499-4510-b3dc-1d410aaf8a88"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1252), "192.168.1.63", (byte)2, 56.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e1f20c17-ea25-4f0d-8fe7-fdfc859f12a0"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2118), "192.168.1.11", (byte)3, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e28897b4-90af-4f57-9581-cf409673fa2e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1538), "192.168.1.34", (byte)2, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e29a9ae4-8506-4827-9468-a8c25e72749a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2621), "192.168.1.60", (byte)3, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e2a8a483-99b4-4f9f-9ed9-df502d70d6fb"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1946), "192.168.1.70", (byte)3, 4.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e2c3c07c-c68f-4b0d-ba01-e6a8c6b6dc09"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(700), "192.168.1.41", (byte)2, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e31cb615-7f18-4f61-9a1f-7a4d6eefc45a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(588), "192.168.1.7", (byte)1, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e34706cb-9570-48bd-84fa-dfc78f679fd9"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9887), "192.168.1.60", (byte)1, 32.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e35a95b5-1184-424e-8941-8040ea99e9aa"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(457), "192.168.1.69", (byte)1, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e393c228-02e5-4a8b-a2cf-fb4118998ab9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(695), "192.168.1.17", (byte)2, 20.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e497881d-5b04-43b3-a909-53a6a87ff37b"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1427), "192.168.1.54", (byte)2, 17.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e4b81e5a-2c04-4806-9d87-3f27fbf08a2a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1019), "192.168.1.81", (byte)2, 31.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e50e7542-11df-42d8-98c5-522525457b43"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(75), "192.168.1.40", (byte)1, 11.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e5678d54-21aa-456e-9a01-9bcc8ce42968"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2607), "192.168.1.61", (byte)3, 58.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e578ad36-680a-49ed-91e0-3532beed2722"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(798), "192.168.1.96", (byte)2, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e5895825-9948-4af6-b9ca-872ec398cd45"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(802), "192.168.1.7", (byte)2, 6.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e5d4ab2c-9768-4584-871a-34ee6471bfc3"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9711), "192.168.1.23", (byte)1, 40.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e5f8f31f-7cf6-40c1-9ff5-be40d626358a"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(554), "192.168.1.45", (byte)1, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e6636a4d-c6fb-4504-8c39-4622c1ce51bc"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1308), "192.168.1.65", (byte)2, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e6d9147f-93f8-4ab3-852e-9d1d24ab64ff"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1995), "192.168.1.51", (byte)3, 30.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e6db1221-576a-4e15-9578-5f1b2c8484bf"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(965), "192.168.1.72", (byte)2, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e898d6f0-8e57-4049-9bb4-c85095a69faa"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1892), "192.168.1.9", (byte)3, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e8d07c6a-32f3-49e6-9798-5d5f0e2d0819"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1554), "192.168.1.69", (byte)2, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e966b1c4-8309-4942-a544-f48d12e34f1a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1100), "192.168.1.91", (byte)2, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e99194b1-4e27-416a-9772-c0ce13240c34"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2056), "192.168.1.51", (byte)3, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e9b3f81a-a54e-403b-bb91-89c868badc0f"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1108), "192.168.1.75", (byte)2, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e9bf24b9-acbe-4c6f-ae35-42915dce170d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(22), "192.168.1.56", (byte)1, 97.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ea35c127-acc7-4262-ab0a-fc7663946893"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9775), "192.168.1.60", (byte)1, 52.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ea8f56f6-e671-46e8-b04b-505e036ed32b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2757), "192.168.1.76", (byte)3, 25.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("eb33cbe1-8cd5-4992-a2a6-114e0e5ff65d"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2473), "192.168.1.97", (byte)3, 93.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("eb9926ab-f21e-4801-9234-fc506af5f107"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1117), "192.168.1.78", (byte)2, 64.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ecd880c3-6d34-4d20-b759-864d95ce756e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(63), "192.168.1.60", (byte)1, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ececf02b-518f-4529-87e7-c7f35b16b4e1"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1146), "192.168.1.5", (byte)2, 73.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ecff3d76-4cf3-44bf-9a26-7550164a5085"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(935), "192.168.1.4", (byte)2, 51.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ed2b8996-ede0-4bf1-97bf-234bf4c2f0db"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(80), "192.168.1.17", (byte)1, 15.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ed980460-ebfd-4ce3-b1fc-c6e95eb50324"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(734), "192.168.1.34", (byte)2, 21.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("edf02d21-29de-4d9a-b8dc-eff05373e47d"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2279), "192.168.1.74", (byte)3, 67.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ee061ed9-fca0-4ef8-8924-5b8c0b22961b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2339), "192.168.1.5", (byte)3, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ee3af6d9-fd66-414e-9d7a-ce0ed79a2420"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1626), "192.168.1.94", (byte)2, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ee44ef0d-1425-47da-9947-a8f37dcd594e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(273), "192.168.1.40", (byte)1, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("ee470f6b-c83c-4d7e-95ed-9a7c452a0e57"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1049), "192.168.1.6", (byte)2, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ee841125-ef81-4253-96ec-c0a129b53b4b"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2832), "192.168.1.90", (byte)3, 25.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("eec03285-ab29-4b6b-adc4-b98e8225005a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2765), "192.168.1.81", (byte)3, 75.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f012f60a-d6f5-4867-a438-4045b27e62b7"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2176), "192.168.1.63", (byte)3, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f04e8f54-b9fb-4378-865e-b1505baf3e0a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1983), "192.168.1.27", (byte)3, 36.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f0932d77-6549-4546-9b05-d03e53f2e1a5"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9853), "192.168.1.53", (byte)1, 28.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f0b3fe4f-87ab-4141-9d4d-5112726a8c34"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(201), "192.168.1.79", (byte)1, 77.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f12631f6-dbee-4c96-82b2-f1dcb0fab63d"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2718), "192.168.1.88", (byte)3, 57.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f24947c9-de84-40a7-8fe9-a6720831017c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1533), "192.168.1.38", (byte)2, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f274b659-b187-4eae-a2f4-871f52338dd1"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2531), "192.168.1.53", (byte)3, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f2becbb8-ffde-4f7e-9ef2-f4fe5105cb2e"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1592), "192.168.1.43", (byte)2, 89.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f2d73e13-7cda-404c-8b86-654e374d3f5c"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9613), "192.168.1.20", (byte)1, 18.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f31b6343-6ece-49c0-a442-9606aa54d583"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(511), "192.168.1.58", (byte)1, 81.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f336bc50-2643-46d6-a82a-13ba7122c376"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1338), "192.168.1.21", (byte)2, 12.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f34e3b02-4c02-4f6d-9b2b-6f9851279f53"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2569), "192.168.1.87", (byte)3, 82.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f39cf26b-935e-4345-bc26-74110699f1b2"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9733), "192.168.1.30", (byte)1, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f3f356b0-1a4f-43ff-a885-15c5d502a57d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(188), "192.168.1.93", (byte)1, 19.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f436fe12-3f09-4c3d-b022-4b3df2cf27e6"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2477), "192.168.1.92", (byte)3, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f4506082-6d65-42ae-85a4-4e34a32ae79f"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2003), "192.168.1.33", (byte)3, 59.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f473ddcc-8ca3-4de1-b028-c1d9cc55c9f6"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(606), "192.168.1.29", (byte)1, 70.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f49af908-b2d4-46a5-b867-09edc552de9d"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(167), "192.168.1.83", (byte)1, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f4d8ff3e-7238-4113-8f76-fd326d8877c0"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2142), "192.168.1.80", (byte)3, 1.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f4e3e218-b543-4afd-8fb3-7ec7f4116e5e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1936), "192.168.1.52", (byte)3, 7.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f4fa6d4f-c84c-4fd6-94e6-32a7c5b2418a"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1095), "192.168.1.81", (byte)2, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f5071d7c-e366-4aa0-a214-9ac2a6b8e85a"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2138), "192.168.1.16", (byte)3, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f616ad12-92cc-469a-bae1-b6dc51a196a3"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1112), "192.168.1.6", (byte)2, 27.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f61d6543-6940-439b-ba09-65aecf919fb9"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1572), "192.168.1.20", (byte)2, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f6247759-9555-4889-bd39-42d330316723"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2693), "192.168.1.1", (byte)3, 39.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f668abcb-84de-4a8a-9e48-39434a82af61"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9797), "192.168.1.3", (byte)1, 30.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f6763524-ce89-4ae0-a295-a42f55d044f3"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1785), "192.168.1.28", (byte)3, 63.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("f6afa397-d680-4e88-bc70-765956d8ef52"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1471), "192.168.1.68", (byte)2, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f6bb6ac3-add8-4038-8f68-a7e24938997e"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9771), "192.168.1.9", (byte)1, 47.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f7bf1536-9462-4cdb-a809-2848a363b473"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(618), "192.168.1.79", (byte)1, 32.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f7bf9b34-5671-4dbc-b89d-8451f88655ce"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1083), "192.168.1.57", (byte)2, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f7f9758a-6f50-495e-bf41-d4db8db1b143"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(981), "192.168.1.63", (byte)2, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f855d100-1dca-47bb-97a3-0acae23805b7"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9751), "192.168.1.67", (byte)1, 43.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f8d8b077-3e8d-421c-a605-52ae3d6cacf6"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2092), "192.168.1.39", (byte)3, 52.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f8f6c0cd-d549-49c5-9714-2b5aced36a70"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1845), "192.168.1.50", (byte)3, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f8fed197-a0cf-4ae6-8027-8e897bbfeea4"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(403), "192.168.1.29", (byte)1, 49.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f990c552-ca46-4ed4-ab19-43dcbc808b8f"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(622), "192.168.1.21", (byte)1, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f9e6a514-144b-4f42-8786-185fb5de8130"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9879), "192.168.1.28", (byte)1, 57.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fa192f6b-23cc-4b6f-a6b7-f6a4b88d3d0e"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2060), "192.168.1.8", (byte)3, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fa62428b-101f-46c0-a499-397f78f2ef0c"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(824), "192.168.1.42", (byte)2, 17.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("fa79869d-1237-4502-914f-98f273cfe59c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2074), "192.168.1.55", (byte)3, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("faf9231b-e436-4cea-95db-d74f626218bf"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(316), "192.168.1.17", (byte)1, 39.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fb01a347-c78c-4c8d-9bc2-bf5a297b11d0"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1878), "192.168.1.93", (byte)3, 41.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("fb06ce90-2b68-42de-ac53-502978b95909"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(738), "192.168.1.6", (byte)2, 71.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("fbbd98ef-0293-47ba-8774-95b353bf859c"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2680), "192.168.1.36", (byte)3, 82.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fbd50b50-2de7-4ad7-99d0-b26a4b10e6e4"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1316), "192.168.1.91", (byte)2, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fc00ae0b-a156-40aa-8824-a3b4304b7625"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2376), "192.168.1.29", (byte)3, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fc454a8c-17f7-45a2-bd97-18730ca06b0d"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1057), "192.168.1.33", (byte)2, 49.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fc901b97-36da-4497-9a1f-1d59830ddade"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1734), "192.168.1.11", (byte)2, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("fd9015c1-4f32-4878-bfad-95285df377e0"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1125), "192.168.1.56", (byte)2, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fe37f401-be78-4f68-ac11-26b35188d262"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(872), "192.168.1.95", (byte)2, 81.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("fe42f5a4-e0b4-4afe-aae4-8256af4970cd"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 318, DateTimeKind.Utc).AddTicks(9646), "192.168.1.66", (byte)1, 29.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fed60c1a-f886-4a30-af8d-2c669fccde28"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2164), "192.168.1.73", (byte)3, 24.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("fefcc384-ae22-4d82-a0f8-f98834697706"), "Computer0", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(127), "192.168.1.82", (byte)1, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ffb75175-0926-44d2-bd49-d37d63de47a5"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2230), "192.168.1.6", (byte)3, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ffcb1953-158b-4155-b787-51915dc54670"), "Computer1", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(1176), "192.168.1.2", (byte)2, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ffe627d7-8276-435b-a024-7b9e136626c3"), "Computer2", new DateTime(2024, 2, 10, 19, 5, 28, 319, DateTimeKind.Utc).AddTicks(2384), "192.168.1.39", (byte)3, 51.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ParentStudents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") }
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
