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
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    TimeSlot = table.Column<byte>(type: "tinyint", nullable: false),
                    Classroom = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Capacity", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Grade", "Section", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(224), "192.168.1.3", "2", 0, null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(223), "192.168.1.2", "1", 1, null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(220), "192.168.1.1", "1", 0, null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(226), "192.168.1.4", "2", 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5344), "192.168.1.1", "Matematik", null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5346), "192.168.1.2", "Türkçe", null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5348), "192.168.1.3", "Biyoloji", null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5350), "192.168.1.4", "Fizik", null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5351), "192.168.1.5", "Kimya", null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5354), "192.168.1.6", "Tarih", null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5355), "192.168.1.7", "Coğrafya", null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5357), "192.168.1.8", "İngilizce", null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5358), "192.168.1.9", "Müzik", null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(5361), "192.168.1.10", "Görsel Sanatlar", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6224), "192.168.1.3", "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6235), "192.168.1.8", "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6228), "192.168.1.5", "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6222), "192.168.1.2", "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6226), "192.168.1.4", "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6237), "192.168.1.9", "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6231), "192.168.1.6", "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6233), "192.168.1.7", "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6240), "192.168.1.10", "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6219), "192.168.1.1", "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6937), "192.168.1.5", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6935), "192.168.1.4", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6931), "192.168.1.2", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6927), "192.168.1.1", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(6933), "192.168.1.3", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
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
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8030), "192.168.1.11", "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", "110-24", null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8012), "192.168.1.6", "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", "105-24", null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(7997), "192.168.1.1", "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", "100-24", null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8014), "192.168.1.7", "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", "106-24", null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8032), "192.168.1.12", "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", "111-24", null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8017), "192.168.1.8", "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", "107-24", null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8027), "192.168.1.10", "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", "109-24", null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8005), "192.168.1.4", "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", "103-24", null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8008), "192.168.1.5", "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", "104-24", null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8000), "192.168.1.2", "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", "101-24", null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8003), "192.168.1.3", "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", "102-24", null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8019), "192.168.1.9", "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", "108-24", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8883), "192.168.1.13", new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8859), "192.168.1.2", new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8888), "192.168.1.16", new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8885), "192.168.1.14", new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8870), "192.168.1.7", new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8861), "192.168.1.3", new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8876), "192.168.1.10", new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8891), "192.168.1.17", new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8895), "192.168.1.19", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8881), "192.168.1.12", new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8874), "192.168.1.9", new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8893), "192.168.1.18", new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8865), "192.168.1.5", new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8863), "192.168.1.4", new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8886), "192.168.1.15", new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8878), "192.168.1.11", new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8869), "192.168.1.6", new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8856), "192.168.1.1", new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8872), "192.168.1.8", new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(8897), "192.168.1.20", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Department", "FirstName", "LastName", "MainCourseId", "Role", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9634), "192.168.1.5", "Fizik", "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9639), "192.168.1.10", "Tarih", "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Öğretmen", null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9642), "192.168.1.11", "Coğrafya", "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9626), "192.168.1.2", "Matematik", "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9631), "192.168.1.4", "Biyoloji", "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9629), "192.168.1.3", "Türkçe", "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9621), "192.168.1.1", "Matematik", "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9647), "192.168.1.13", "Müzik", "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9644), "192.168.1.12", "İngilizce", "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Öğretmen", null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9649), "192.168.1.14", "Görsel Sanatlar", "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Öğretmen", null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(9637), "192.168.1.6", "Kimya", "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("09ccebb5-edc6-4c48-a759-188c844b576c"), "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7861), "192.168.1.83", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("0cecd835-bad6-41c7-8241-f92ef4549566"), "Computer34", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8006), "192.168.1.86", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("0da69d63-bb73-4650-9231-4f7840cba850"), "Computer14", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7911), "192.168.1.58", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("1381d85d-022f-4599-b563-109e9c85d63c"), "Computer27", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7976), "192.168.1.98", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("15a3962b-2e9f-4370-865b-d5d7c1250201"), "Computer29", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7984), "192.168.1.80", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("1e4aba9e-2d70-4630-8b4a-9befa4418307"), "Computer54", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8092), "192.168.1.24", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("2737addc-37d7-4069-a11e-fc96cadc51ef"), "Computer38", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8022), "192.168.1.29", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("321bdebd-5532-491c-abc3-de74c5d0a0da"), "Computer11", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7898), "192.168.1.19", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("369dfde2-b775-4406-88d6-5e428746732a"), "Computer22", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7945), "192.168.1.2", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("370f2a69-d06a-4c91-9ca6-5e16e8bb66a9"), "Computer47", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8059), "192.168.1.55", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("46559cfe-5576-419f-9b4a-62f66c99176e"), "Computer42", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8039), "192.168.1.87", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("46974e81-33a2-43c7-80f6-61704227d635"), "Computer24", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7953), "192.168.1.30", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("4d8e3d4d-ca22-4efb-b63e-898839a1a0a5"), "Computer32", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7996), "192.168.1.53", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("4f011736-18e3-45df-a3e3-6c5193f6934e"), "Computer18", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7929), "192.168.1.76", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("589d593e-d8de-4797-864a-5a6577623638"), "Computer59", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8118), "192.168.1.35", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("59aabbce-5249-4fa8-acd4-8f32e9e87eb8"), "Computer19", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7933), "192.168.1.14", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("5c0b8a58-cf25-426e-aaca-2cd28f40cc51"), "Computer31", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7992), "192.168.1.44", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("5c79713f-4dd1-478e-98ce-f4d90c63b193"), "Computer25", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7968), "192.168.1.9", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("5ee62342-e277-4c65-b1f5-df0a55bf96e4"), "Computer10", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7894), "192.168.1.73", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("60a27d09-8cd7-4eed-9e04-edc444e819de"), "Computer28", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7980), "192.168.1.21", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("63e9b32a-783d-4aab-941f-6dc55bb4e8fb"), "Computer20", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7937), "192.168.1.77", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("67f74cd8-3ff4-4f8d-af42-32a18ecf0aaa"), "Computer58", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8114), "192.168.1.69", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("69b9bd45-2544-4d78-8655-7191e3072172"), "Computer50", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8073), "192.168.1.52", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("6bdce2ff-6f1f-4319-b71b-02f838ed5513"), "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7869), "192.168.1.30", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("6ceba762-1c9c-49d6-875c-e9613f9817eb"), "Computer48", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8063), "192.168.1.38", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("73682a74-dad3-468c-b89e-af42dadcafbf"), "Computer7", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7878), "192.168.1.37", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("758dbdfa-88f8-49af-8e79-683043cd1519"), "Computer46", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8055), "192.168.1.59", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("77e21bc2-0600-4e8e-b3e5-d5af25305580"), "Computer52", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8081), "192.168.1.20", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("78a94b7b-4191-491d-b203-77f150695516"), "Computer53", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8087), "192.168.1.91", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("7b2723c0-6b84-40f0-89b5-19ab28c840dd"), "Computer9", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7889), "192.168.1.8", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("7fcb449a-5666-4fdb-b4a5-b4f969fed11c"), "Computer41", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8035), "192.168.1.34", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("82e6514d-c4d4-4cfc-8e7a-5643ddbbffc0"), "Computer26", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7972), "192.168.1.64", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("8a7dd740-5cbd-4894-a4c3-7cd6a1647564"), "Computer55", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8101), "192.168.1.12", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("8a963d52-a862-49ad-ab80-c50dd3074f52"), "Computer6", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7874), "192.168.1.29", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("95cb4166-bdca-49f9-86e1-9884123ece8f"), "Computer35", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8010), "192.168.1.13", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("9b4328ae-d743-4f2b-987c-d4fbb8a54f6f"), "Computer8", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7882), "192.168.1.16", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("9d5aafa9-39bc-4d7a-bc89-709ddbc94ee6"), "Computer60", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8122), "192.168.1.30", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("a3128826-f302-492a-8a20-099c841816aa"), "Computer51", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8077), "192.168.1.6", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("a9c2661e-408f-4319-91c0-3d5d118eac5e"), "Computer44", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8047), "192.168.1.19", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("aeea7cbd-73cc-4845-be81-de0c8e13cb3e"), "Computer15", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7914), "192.168.1.6", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("b0c66772-07be-4422-b716-a9b0275095e4"), "Computer21", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7941), "192.168.1.67", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("ba811833-cb5c-4d47-99d4-14d28e5bef0e"), "Computer12", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7902), "192.168.1.57", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("bbddbec7-c14d-4723-b9fe-ae6bedcf510a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7857), "192.168.1.11", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("c2750f7f-e6ee-4f11-a505-f174d9e61181"), "Computer56", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8105), "192.168.1.21", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("cb79701d-6d5a-47c0-8d0c-235b7eb075cd"), "Computer37", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8018), "192.168.1.42", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("d7a5116f-b78c-446a-bc8a-a57051bcd664"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7829), "192.168.1.16", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("da1c1d6b-26ab-4773-b3e5-9f74c7b43be6"), "Computer43", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8043), "192.168.1.59", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("ddcf6da5-d0ab-46f9-a14c-a3615e5322a3"), "Computer57", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8111), "192.168.1.16", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("e0567be0-ec5f-4337-a058-bc8a7829de96"), "Computer40", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8030), "192.168.1.62", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("e0fbef81-addf-4457-a823-396576649a89"), "Computer30", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7988), "192.168.1.4", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("e1a46cae-2677-4851-8bad-12fc264dd9b5"), "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7865), "192.168.1.13", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("e1e48cf5-2b8d-45a9-b70f-8259406c416a"), "Computer13", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7907), "192.168.1.44", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("e368fa85-e105-44d6-9722-18472a9e4935"), "Computer39", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8026), "192.168.1.78", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("e3e2d8d1-9fa4-4e53-93a2-8d57bdb491c7"), "Computer36", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8014), "192.168.1.3", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("e78d6dee-0ba7-404d-9424-52b88965b2cc"), "Computer33", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8001), "192.168.1.84", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("eaa56598-b0f6-4da4-a2fe-dc26d1299623"), "Computer49", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8069), "192.168.1.94", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("ed2df726-e900-4326-ba79-de19ca15ca70"), "Computer23", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7949), "192.168.1.26", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("f13ab72c-2bd6-442b-84a5-1227e7626bb1"), "Computer17", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7924), "192.168.1.16", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("f7d519e1-378d-4f53-8ad9-fa4c3eed2435"), "Computer16", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(7919), "192.168.1.59", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("fc45f097-68dc-415c-b9e0-09619e141158"), "Computer45", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(8051), "192.168.1.63", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("014cc395-b520-47d7-9b70-80c0ea61f743"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer7", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9197), "192.168.1.1", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0ec553d0-69e1-48cf-aeb4-3ad60722f5ef"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer23", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9299), "192.168.1.91", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("145a9e1b-0514-4409-a94d-64ac455a8fa6"), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer22", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9291), "192.168.1.95", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("179c3da7-c095-4cfb-8e31-3367b2f3a73c"), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer29", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9338), "192.168.1.96", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1c7dd400-e605-469e-9aff-83ef99dca60c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9147), "192.168.1.10", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2fcc2a86-e212-4cfb-838f-41034aa5e8ea"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer5", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9185), "192.168.1.63", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("332075f7-044e-4647-b338-4e12d8fd4fb7"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer4", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9169), "192.168.1.83", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3c57f3e6-a107-426d-8f77-d296ac1046a4"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer8", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9202), "192.168.1.70", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3fd8fb54-19e7-447f-a88e-ec1149b454a0"), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer20", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9279), "192.168.1.19", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4311db36-8f14-4e07-a896-b946188fcb53"), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer36", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9378), "192.168.1.20", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("43aead2b-2b73-48ba-ae66-a7741159b9c6"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer18", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9268), "192.168.1.14", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4b29751e-49eb-4b92-b0e7-6c783b929b11"), new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer14", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9243), "192.168.1.24", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("4c523900-59ba-4b73-878f-b0366c516d77"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer13", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9239), "192.168.1.8", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4ed3fd88-14b1-477a-9cdb-21ccdbe37b3e"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer25", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9313), "192.168.1.12", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("66a0538e-b766-43c7-bd26-908afc16395c"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer34", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9367), "192.168.1.14", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6783e2c3-7608-454e-87e1-2475d291dc79"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer37", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9382), "192.168.1.17", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7b071552-5a51-450b-aff3-691d6a359ee7"), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer17", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9259), "192.168.1.2", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7f6d0ea9-8046-4f86-949b-18f921eb91fc"), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer19", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9274), "192.168.1.97", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("87e793ca-c95b-454a-ae32-c4d30444036d"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer26", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9321), "192.168.1.32", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("89f2f259-98d2-41be-8149-39b822f38abf"), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer27", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9327), "192.168.1.28", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8c74248a-c3f2-4e5a-99d2-986bec7b62a5"), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer11", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9219), "192.168.1.10", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("94e1bc02-2888-49b6-a3cf-e722766956e7"), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer16", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9253), "192.168.1.89", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("99eebc51-bbbd-4f94-8450-82da079600e6"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9345), "192.168.1.50", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9ad976ab-22e3-4b3f-a2b0-adaaa14901ea"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer15", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9248), "192.168.1.43", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a5b114d7-3338-40d4-b7f8-78e55e488499"), new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer3", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9164), "192.168.1.10", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a95cc31f-1b65-490d-bdf3-3d087691c39b"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9158), "192.168.1.45", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("acd573f0-a5b8-4e70-b42b-5d539e6e50cb"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer9", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9208), "192.168.1.75", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ae3bd3a2-b514-4faa-bd5b-a7b7a1b6c507"), new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer6", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9190), "192.168.1.16", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b2c9fe30-83c4-4bea-991c-4bf04d36ecfc"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer28", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9332), "192.168.1.83", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c5867a32-18f0-4f0d-8b01-66ff3c016f6a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer21", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9285), "192.168.1.66", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c68945d4-70e8-4cca-8136-40337a848db6"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer32", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9356), "192.168.1.19", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("de48e517-1120-46c5-b44e-8315aa76eee9"), new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer35", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9374), "192.168.1.76", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e5363ca1-7a99-4a0c-8826-5bc52538d488"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer12", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9224), "192.168.1.81", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f785d045-9e76-4966-96e4-c04535e2f8a9"), new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer10", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9214), "192.168.1.6", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("fb5efa0d-0f8f-4910-926a-2b7b232883dd"), new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9129), "192.168.1.18", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fc14fe5f-3031-4792-a29b-e5f99a2644f0"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer24", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9305), "192.168.1.31", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("feda4663-cd8d-4e64-8f81-f5695733906c"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer31", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9352), "192.168.1.17", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ff1ab5e9-b0b1-4b61-8086-e5588eb60078"), new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer33", new DateTime(2024, 2, 15, 13, 53, 19, 277, DateTimeKind.Utc).AddTicks(9361), "192.168.1.47", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null }
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
                    { new Guid("81bbb038-3440-47f8-91c9-30055ca851f4"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(1030), "192.168.1.47", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null },
                    { new Guid("e45b99b4-3958-450e-b843-475fcb4281b4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(1045), "192.168.1.50", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("003a49b5-3704-4718-9675-6644663ebd80"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2258), "192.168.1.63", (byte)1, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("00450211-fc77-4633-aebc-46e031622949"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1479), "192.168.1.72", (byte)1, 4.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("009651e4-41ad-4212-bc39-84f499468639"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2965), "192.168.1.15", (byte)2, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("00f9faf6-5735-4473-87ca-405f4e403e3e"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2894), "192.168.1.25", (byte)2, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("012d9b1f-b432-448b-8f3d-f51d91edfe02"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4054), "192.168.1.83", (byte)3, 49.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0194dab1-4e02-4e6d-b26f-0e954293dc26"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1946), "192.168.1.22", (byte)1, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("01f2ad93-c9cd-4d25-adcd-dab9652d793a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2468), "192.168.1.27", (byte)2, 94.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("01fab67e-ccfd-4ea2-9fcf-329810f18d50"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3699), "192.168.1.63", (byte)3, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("020eb8d8-07f2-4d19-bcbe-85c7dedc94f1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4192), "192.168.1.41", (byte)3, 88.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("022a0505-a94c-4196-870a-e57aebac1e94"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1612), "192.168.1.16", (byte)1, 88.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0280bd69-9030-42cf-9f61-00d6721bc204"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4037), "192.168.1.98", (byte)3, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("03b2ab86-033b-493c-aeb6-487ea82193c1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4236), "192.168.1.80", (byte)3, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("03d6df8a-6329-4c2a-bb29-db9cac99830d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3066), "192.168.1.38", (byte)2, 66.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("03f1fbf2-8e3f-43ce-b171-c2c6179bd297"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3156), "192.168.1.29", (byte)2, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("041ce3b0-78d1-4990-be69-9f634c86a0b0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1709), "192.168.1.15", (byte)1, 24.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0422995a-18d2-408d-86d9-c8a8a478de95"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1701), "192.168.1.14", (byte)1, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("04dec44c-2087-4a5b-9877-660f2b563ced"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2840), "192.168.1.56", (byte)2, 85.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("054c97cb-d3f8-4d26-b4fc-dbae411501f8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3481), "192.168.1.5", (byte)3, 99.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("057bd6da-8f11-4e0c-893d-3776e0bac5a3"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2717), "192.168.1.82", (byte)2, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("05ac1b94-2074-4430-a8b7-18c0f83144ee"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1601), "192.168.1.74", (byte)1, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("05e0e6b7-62c4-4eaf-98e8-353ed0b02996"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2721), "192.168.1.4", (byte)2, 10.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("05e90e5a-21aa-4905-b7d9-3b8692b5c52a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2528), "192.168.1.17", (byte)2, 70.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("06b72c52-0e56-4b0c-a981-da3c75f61242"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3844), "192.168.1.52", (byte)3, 41.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("07fbeef6-7e12-413c-b9d6-bc50aeab84c2"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1734), "192.168.1.10", (byte)1, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("083345f1-2da1-4121-92ba-c1daa4498c51"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1604), "192.168.1.95", (byte)1, 97.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("094cc8f0-488d-4579-a128-2f75840fb8b4"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3702), "192.168.1.38", (byte)3, 9.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("09b9a650-c5a2-45ff-92a0-b5d8f04e0273"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4290), "192.168.1.32", (byte)3, 21.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0a6bcc99-5e0a-4929-bdc2-8162abad4a4a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2275), "192.168.1.20", (byte)2, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0aa9a706-3683-4893-8944-00cf8e0314d4"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4250), "192.168.1.56", (byte)3, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0b7788a2-2f4b-4ff6-9885-552bf938a0ec"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3005), "192.168.1.65", (byte)2, 89.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0c33c1b3-ee65-4b7e-8883-0a25611205fd"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2623), "192.168.1.1", (byte)2, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("0d14cc7f-2fda-46ed-bdca-eacc74ee35b9"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2077), "192.168.1.8", (byte)1, 0.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0d90de5b-72d0-4813-96e7-42fa94acb8b1"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1705), "192.168.1.8", (byte)1, 98.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0de07d93-627b-4127-aaee-ddd26976674d"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4261), "192.168.1.73", (byte)3, 53.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0ed83559-d1b2-4aab-856b-b023ecb92dc1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3017), "192.168.1.23", (byte)2, 66.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0edb67d0-5ccc-4722-b94a-40f342a84291"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2741), "192.168.1.38", (byte)2, 64.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0ee998e0-613b-4792-b92b-1f3befe665be"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3526), "192.168.1.25", (byte)3, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0eead828-adcd-4264-96c0-cd4c4e925d52"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3695), "192.168.1.30", (byte)3, 17.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0fbf0b70-3c5f-4a2f-80e9-37cf8acdbf4f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2520), "192.168.1.97", (byte)2, 15.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0ffd6ccd-58d0-466a-ab6b-7ef640b75982"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4257), "192.168.1.48", (byte)3, 59.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("104e6a7d-1187-4ee1-ac98-d4d1b03cada8"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2833), "192.168.1.52", (byte)2, 9.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("108758ce-5ce6-4549-974f-fbb0de3bc3aa"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4401), "192.168.1.5", (byte)3, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("109e26c9-4d8b-4fc2-b8d4-5673ea57c628"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4315), "192.168.1.92", (byte)3, 9.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("113a3954-49cc-4385-97ca-59714244c534"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2055), "192.168.1.44", (byte)1, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("11921cb2-7213-4207-91d8-333bcc665105"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1185), "192.168.1.71", (byte)1, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("119b88c9-a676-4fad-9bca-03c36017cc6d"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3792), "192.168.1.62", (byte)3, 10.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("11d1bd62-7f4b-442d-a82e-d4d579d77c15"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1331), "192.168.1.46", (byte)1, 36.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1213ffe7-4d3d-4c72-8b67-77811e29cb77"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2284), "192.168.1.89", (byte)2, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1290e624-711e-45bb-bc9e-22184dcda8db"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4212), "192.168.1.43", (byte)3, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("130e679d-68af-49a4-b340-0a5fd667b64c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4102), "192.168.1.15", (byte)3, 85.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("13ba1e82-5591-42f1-bd25-853422962b41"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1539), "192.168.1.79", (byte)1, 4.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("13cc8ac9-0c6c-49df-af05-b3b6e2b1aa5e"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3822), "192.168.1.58", (byte)3, 32.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("148b7db1-bf2f-445d-885b-b7b2b9819c83"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1738), "192.168.1.54", (byte)1, 49.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("14a6b08a-7387-4b0c-b442-8d32ff599187"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1616), "192.168.1.34", (byte)1, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("15209c5a-e4af-4979-bc36-b329c986abe1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2861), "192.168.1.48", (byte)2, 15.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("156ec8f8-20ee-4c50-a7b5-927b14f3fe4d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2088), "192.168.1.3", (byte)1, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("160d323a-22b9-44f1-825c-140cdf922c30"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1766), "192.168.1.34", (byte)1, 67.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("162a8c24-145a-4908-a3be-2eea27bbf924"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2648), "192.168.1.97", (byte)2, 62.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("16441522-51ed-4366-b8ef-e89ce45e9c0d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2774), "192.168.1.25", (byte)2, 56.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("164e6ca1-55ee-4dbe-9209-75f9fb6184bd"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4208), "192.168.1.50", (byte)3, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("16c9cfe1-aac9-4342-85a8-a373605364cf"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1924), "192.168.1.31", (byte)1, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("16db96e7-b85a-4b13-be91-85b9e358fdb0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1718), "192.168.1.44", (byte)1, 41.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("16dddc44-922a-4ee6-894d-3b144ef4110a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2984), "192.168.1.87", (byte)2, 94.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("17acc31a-4de6-4c75-86e0-901ad5b911a7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2627), "192.168.1.1", (byte)2, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("17ce71fe-70f8-48d9-9faf-cfa24ab8a025"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2321), "192.168.1.48", (byte)2, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1840913c-8503-4661-aa65-e459ac81dc5b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3095), "192.168.1.78", (byte)2, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("18bc25ea-7023-47f8-84c6-2e563b85abdd"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4397), "192.168.1.56", (byte)3, 74.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("18ed9751-5a60-4b54-a65c-0f13f909fd27"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3448), "192.168.1.68", (byte)3, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("18f383c0-7b9e-4ef8-87ee-2b14c0e7059c"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2114), "192.168.1.21", (byte)1, 66.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("19067378-74d9-4266-99f4-451a768963a5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1758), "192.168.1.61", (byte)1, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1a44b00e-04d4-4ce6-93b1-c706e6540e72"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2096), "192.168.1.86", (byte)1, 15.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1af1f868-3a5c-4d79-a08c-4f87301820f0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2142), "192.168.1.89", (byte)1, 22.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1c35bf60-5720-4a8f-8f81-0981e2c992e3"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4388), "192.168.1.68", (byte)3, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1c3adc28-abdc-4c23-97e4-cc03a7043acb"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2685), "192.168.1.41", (byte)2, 44.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1c66226c-b5f9-4501-b57f-b125537c2309"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2455), "192.168.1.58", (byte)2, 12.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1c993c51-8d12-4b13-bb46-6ac03f88dad0"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2606), "192.168.1.58", (byte)2, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1d74767c-fe1d-441a-b27e-8764783104b2"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3241), "192.168.1.39", (byte)2, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1d83b442-5a67-4081-b536-db21508ccc22"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3685), "192.168.1.34", (byte)3, 16.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1da84eff-4fe7-43c7-bb38-4471a212e950"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2516), "192.168.1.41", (byte)2, 71.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1dc4d53f-562c-4376-932c-19add204c378"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2092), "192.168.1.44", (byte)1, 77.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1e20ec69-c5fc-4a5d-8fc5-3147a8a8d89d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1271), "192.168.1.16", (byte)1, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1e976960-d9e7-4947-b194-1da5f698e5cc"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3945), "192.168.1.73", (byte)3, 9.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1e9804df-0bdb-4747-a704-14b2ee4be4a4"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1454), "192.168.1.22", (byte)1, 17.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1ea23aee-2123-42e9-8f3f-cbe32fa2ff8a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2317), "192.168.1.64", (byte)2, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1f08de81-f731-4d64-9924-384dd71673ac"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1576), "192.168.1.92", (byte)1, 71.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1f4f4233-32f4-48c8-b522-7f909caab170"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2190), "192.168.1.2", (byte)1, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1f88dda9-3cfe-4d4b-96f4-6ce43a811fdd"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3343), "192.168.1.55", (byte)3, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1fafab01-3479-4fd2-926c-13350e03fc3e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2146), "192.168.1.31", (byte)1, 96.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1fb0a0c7-6e85-4f26-b5be-a6ebcc2ced5c"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3148), "192.168.1.16", (byte)2, 19.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("20123e79-2284-4fd4-b47a-ed88a9a18fca"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4244), "192.168.1.28", (byte)3, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("20f9fbaa-f2a3-4873-9ff8-035ef28d554a"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1836), "192.168.1.27", (byte)1, 38.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("21214d9a-21d8-4ecb-ac3b-a13d7cd1eaa3"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1755), "192.168.1.52", (byte)1, 68.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2139dfe1-1853-4af9-a0f5-37374a8168c1"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2198), "192.168.1.84", (byte)1, 92.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("21d659a6-ed54-43cd-8b6f-986add030d1b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2296), "192.168.1.87", (byte)2, 79.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("21ec8365-61d2-4ee6-9bdb-cbdffdf8e8a5"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3616), "192.168.1.27", (byte)3, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("220a2ccb-bf7d-4ff1-917a-eac6e8d95d4a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3237), "192.168.1.48", (byte)2, 91.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("22f11068-f728-4be5-ad05-d1a86ab8adaa"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4405), "192.168.1.34", (byte)3, 75.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("232d6142-9aa4-4825-9c90-f14c97fb67c5"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4351), "192.168.1.57", (byte)3, 39.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("23f528ee-927a-4f41-9db7-10e9d2cb1d53"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4196), "192.168.1.6", (byte)3, 61.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("247ca58c-c781-458d-80af-d46e90091049"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3592), "192.168.1.59", (byte)3, 10.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("249642e1-875e-4547-9291-44c23cf642b7"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1868), "192.168.1.28", (byte)1, 17.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("256fa7fe-0408-4c81-bbb8-2171838c7264"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1920), "192.168.1.38", (byte)1, 93.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("25aea3d8-52e5-44d4-9931-a67256403ee5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3120), "192.168.1.98", (byte)2, 79.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("2614895d-3fcf-4b26-a46d-8b538b3a8e23"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2175), "192.168.1.11", (byte)1, 72.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("262bf92b-956a-4dde-b667-2590af6b95d8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4326), "192.168.1.32", (byte)3, 94.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("26302937-205c-4dfe-8024-2ae140d63dcc"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2307), "192.168.1.26", (byte)2, 70.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("267f01fc-b862-414b-a531-ee5ca4ae4135"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2561), "192.168.1.59", (byte)2, 3.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("26dde4c8-78f9-4af4-bce8-0f5638dc9ebd"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1563), "192.168.1.16", (byte)1, 70.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("26e85189-28c2-465b-a31d-96c1635f771b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1572), "192.168.1.59", (byte)1, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("26f12881-e7cb-49df-ac4b-56f69dff0295"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2436), "192.168.1.21", (byte)2, 14.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("270272ad-b48a-4670-ac94-a0afe68db5c6"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3287), "192.168.1.17", (byte)2, 71.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2745ecf2-59b1-4ac6-b478-b93b0b18c8c7"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1742), "192.168.1.44", (byte)1, 96.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("27fd18de-8cc1-4213-98aa-cabe814a5d59"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2039), "192.168.1.91", (byte)1, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("28aa3f75-41db-4403-bbd3-f9769e972563"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2117), "192.168.1.15", (byte)1, 33.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("28bfd533-2c34-46a3-b9e1-c728535fdc65"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4098), "192.168.1.68", (byte)3, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("290cb8cd-a7bb-4fc0-84f0-68f9787fa3ba"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2652), "192.168.1.23", (byte)2, 16.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("294d7edc-4106-4c61-adc8-bde5cefb19a6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1372), "192.168.1.77", (byte)1, 89.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("296f4e34-17bb-4798-ab82-731d00c1cf0f"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1828), "192.168.1.22", (byte)1, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("29f1eab2-0fdd-4a67-b589-274ec12e7181"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4152), "192.168.1.15", (byte)3, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("2a4e20fe-fb98-4339-ac46-fcbace7a8aee"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1851), "192.168.1.68", (byte)1, 40.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2a5c78a0-464f-47c7-a570-25e7bd8eeef5"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3364), "192.168.1.90", (byte)3, 5.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2a5dbe68-6fce-4ad6-99bd-cfdad22b974e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2043), "192.168.1.26", (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("2abdbd81-fe08-402f-89ca-485d38213280"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1450), "192.168.1.18", (byte)1, 25.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2b62d14f-b3a1-4e42-b291-fac437c8633b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3379), "192.168.1.59", (byte)3, 73.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2c90a55a-5f00-4493-8ff3-5c2f108d1534"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3469), "192.168.1.92", (byte)3, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("2ca4dd2b-29fd-4cd9-9c57-c160eb2cfe03"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2018), "192.168.1.34", (byte)1, 26.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2cf6cd42-0328-4e21-867a-caee35412d11"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1627), "192.168.1.51", (byte)1, 74.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("2d394086-572f-45af-84d2-49808fb62084"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2545), "192.168.1.57", (byte)2, 58.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2dadd84c-3117-4d36-b663-42ad5c501c3c"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2251), "192.168.1.56", (byte)1, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2e6b4558-2b46-49a7-aaa0-60813412d5f6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3840), "192.168.1.53", (byte)3, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2e7e7316-bd99-4ced-8567-feba80fed823"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3768), "192.168.1.95", (byte)3, 52.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2ec6629c-1450-44c8-bee1-6db22c53b7ea"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3323), "192.168.1.60", (byte)2, 69.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2f3d3853-5aa1-42cd-96ba-60b0339015a4"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2067), "192.168.1.81", (byte)1, 89.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2f5557ae-ae52-4134-9cfa-fb3a90b55176"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3245), "192.168.1.90", (byte)2, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("2f9b7df6-944b-4f7b-8178-78aa0638ea80"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2852), "192.168.1.92", (byte)2, 27.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2fb23274-88c0-40d4-9572-85a699736304"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2923), "192.168.1.73", (byte)2, 0.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2fb539f4-54f7-4ecf-8a12-9d24fc88499d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2959), "192.168.1.4", (byte)2, 95.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2fd7910b-0e60-48a5-8ab9-fe7feb460140"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3982), "192.168.1.1", (byte)3, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("3053e551-c3d1-4d7a-a5e6-0a81a3ea1eeb"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1905), "192.168.1.44", (byte)1, 80.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3089a73f-0f05-4432-b26d-7e2f7c643d31"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2869), "192.168.1.58", (byte)2, 12.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3128d652-9003-4e2c-a384-aeb9f69045cb"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2936), "192.168.1.89", (byte)2, 70.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("313f250c-ceb4-4b3b-be1e-b6bd19805d7e"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3001), "192.168.1.52", (byte)2, 68.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("3173ebe2-8638-440a-a45b-04119b283832"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4075), "192.168.1.50", (byte)3, 64.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("319925c5-7498-45f7-a8d1-059a18bafe93"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1799), "192.168.1.37", (byte)1, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("321f2773-2742-4f7d-b42b-5ca822d0f1a8"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2570), "192.168.1.75", (byte)2, 12.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("32e1f77d-9e45-499d-91c3-e4c787f9e2bd"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1791), "192.168.1.99", (byte)1, 42.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("33e53953-7278-4378-a61d-13c2e79910a7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3034), "192.168.1.88", (byte)2, 74.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("35002577-56e6-417a-95ba-048e23df6bb7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2766), "192.168.1.62", (byte)2, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3539a072-7c6d-4417-8d30-48818b7b63e7"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4225), "192.168.1.30", (byte)3, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("353c8936-30d5-4ebe-a168-1e3711d787dd"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2051), "192.168.1.84", (byte)1, 38.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("354cae57-3309-42ed-aad4-984b9af9ecc8"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3208), "192.168.1.5", (byte)2, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("357e0722-512c-4117-af2d-20088f9953c1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3714), "192.168.1.86", (byte)3, 54.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("3587d717-7572-4a55-b8b1-24bbfc019fe6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1282), "192.168.1.81", (byte)1, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("35cfba09-09ed-427d-a21c-a83f0b62e8b9"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4340), "192.168.1.16", (byte)3, 75.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("35ffcada-759e-4f29-b6f3-be73a015169f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4204), "192.168.1.58", (byte)3, 9.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("363685c9-8a51-4f73-bbb2-f3454bd416af"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4030), "192.168.1.76", (byte)3, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3720226b-0057-4ede-bc9d-a19da44bbb71"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2288), "192.168.1.29", (byte)2, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("376c7509-18b9-4297-89ef-43be741dc728"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3640), "192.168.1.50", (byte)3, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("37a48bf7-21f6-44b9-9c20-2652ac31e809"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3283), "192.168.1.29", (byte)2, 94.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("37b5d472-1a58-4c14-a08b-d3d346068cf1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4254), "192.168.1.20", (byte)3, 4.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("37f48cf1-dfb4-4229-bcab-dcdc9245260b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2681), "192.168.1.15", (byte)2, 64.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("384ac73d-e197-49a0-8cc7-3f6cd85c8dae"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2668), "192.168.1.57", (byte)2, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("38b251d3-e62a-40de-b384-f23ddd709a98"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3783), "192.168.1.89", (byte)3, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("38d616ad-591d-4da4-b384-43994cf372ee"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2351), "192.168.1.40", (byte)2, 64.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("38e52972-bfbc-4ab1-b4b2-f211197608a9"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3900), "192.168.1.61", (byte)3, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3a6a1e2b-ce4d-49c1-928d-67b6c4ed3064"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3437), "192.168.1.78", (byte)3, 49.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3ac1a080-6b87-4a3f-bbd6-b462f35c939b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1349), "192.168.1.10", (byte)1, 69.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("3b7480bd-e23d-4892-91ea-995f15e61a0b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3530), "192.168.1.26", (byte)3, 87.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3bc0703b-4d16-47b0-a2ef-8d7ab8d530c4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2951), "192.168.1.3", (byte)2, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3c6c64df-16f6-4363-a856-585ce4be0853"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4018), "192.168.1.39", (byte)3, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3c708f26-775a-44d1-b428-adabd13b7d21"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1591), "192.168.1.65", (byte)1, 4.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3ca006a6-045b-42b7-9361-2ba5f2ca1475"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1953), "192.168.1.6", (byte)1, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3cc48221-8460-467a-8bcf-a3701bc50541"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2292), "192.168.1.60", (byte)2, 73.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3cca4693-844e-4034-abae-06125e79c820"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3229), "192.168.1.75", (byte)2, 95.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3cd93b72-e6f7-4402-97bc-a1cbf2e2f30e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1335), "192.168.1.94", (byte)1, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3d17727b-9cc7-4803-8dee-738cfc4821b6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3507), "192.168.1.47", (byte)3, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3d41c5a2-af0a-42ce-af04-e9011821baac"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1884), "192.168.1.81", (byte)1, 63.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3dfc4b19-e1c7-40eb-af6f-4df01e8be8bc"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1310), "192.168.1.71", (byte)1, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3e0197a5-b928-4a7d-961e-c5f6b435a435"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1438), "192.168.1.11", (byte)1, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3e20c67c-019c-4a1e-9690-e9332e05467a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3588), "192.168.1.89", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3e6c770f-7ee9-4af4-b561-f3dce541cb42"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2639), "192.168.1.88", (byte)2, 48.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3ea7cc6a-f72f-4ef7-9916-a4fbbb9c7947"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4051), "192.168.1.3", (byte)3, 94.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3efdf7c3-8558-4165-ba8f-09e16b95fa20"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2968), "192.168.1.35", (byte)2, 0.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3f38ce37-fc6e-48fe-84d5-ada2e0e4c8fe"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3181), "192.168.1.24", (byte)2, 0.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3f4db312-d011-4215-93cc-5f66e7a13efb"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1248), "192.168.1.43", (byte)1, 76.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3fdc0c11-8cbc-4433-9a18-677a32e889b7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2823), "192.168.1.9", (byte)2, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("40181352-1303-411d-982e-0ede105a8bd3"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2237), "192.168.1.76", (byte)1, 2.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("40ba7f46-7879-481b-9664-0a0966f82a16"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4146), "192.168.1.4", (byte)3, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("40e4eaa3-5c58-4abd-966a-ab4238b791c2"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4015), "192.168.1.45", (byte)3, 22.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("40fa6e28-df6a-4a5d-affe-0a357c3c93e6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3727), "192.168.1.81", (byte)3, 34.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4126537d-dad2-41af-b2b9-3a40d5bd5d8a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3168), "192.168.1.42", (byte)2, 54.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("41885bf8-ffac-4c6f-b7a5-bf85af5b6264"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2770), "192.168.1.17", (byte)2, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("41f78880-b8e5-45af-a8a3-10045e987f99"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1730), "192.168.1.60", (byte)1, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("42460797-d8db-4b8f-b92a-5f3056bea9a1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3884), "192.168.1.9", (byte)3, 22.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("424f9ce7-a2f5-492a-b308-379453981a1a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2533), "192.168.1.78", (byte)2, 37.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("43381106-8e8e-4d97-bf03-7a585f929909"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4131), "192.168.1.60", (byte)3, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("438516ab-568c-41b9-8595-1f74f46f37b2"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3103), "192.168.1.68", (byte)2, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("44384132-a3cb-418c-a5fb-f3fb8115746f"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1467), "192.168.1.39", (byte)1, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("44588914-7a9a-4a82-840f-adcb74c9f54c"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1938), "192.168.1.31", (byte)1, 77.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("44d0619a-df72-48fe-87c2-d307c68f0b2b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2226), "192.168.1.33", (byte)1, 54.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("461549cd-a005-495b-8719-5124ff4ecd4e"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4384), "192.168.1.75", (byte)3, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("46348f84-41cf-40ed-8cf2-f095a0dd22ce"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3859), "192.168.1.74", (byte)3, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("464a0877-f832-49e8-b47a-8eeb2a6bc360"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2399), "192.168.1.54", (byte)2, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4675eb5a-561b-423c-b479-349bdd93f2a9"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4156), "192.168.1.46", (byte)3, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("470ebf42-0648-4562-8b34-ebadda1a9721"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1999), "192.168.1.25", (byte)1, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("47c68bcb-cab9-423c-b15d-5769bc1c98d5"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3942), "192.168.1.74", (byte)3, 77.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("482309c3-d2e9-4a9a-b92f-687026e8ccb9"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2488), "192.168.1.42", (byte)2, 4.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("49bd0cbd-1ca1-4c95-afe0-40fc3525ae01"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1676), "192.168.1.20", (byte)1, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("49e0bb94-5508-4a38-b83c-4255019e76f4"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1368), "192.168.1.27", (byte)1, 79.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("4a6d2335-b1a3-4d24-9dc5-fe84c3e19a92"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3185), "192.168.1.13", (byte)2, 59.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("4adb35f6-2ef1-40b9-a339-65d8a029ed63"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3892), "192.168.1.96", (byte)3, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4c02d6d5-d2b0-4f3a-9862-d8c1f7fc0e9d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1928), "192.168.1.57", (byte)1, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4c5c87ec-a7c1-4e05-b76e-f2593b231d87"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4240), "192.168.1.6", (byte)3, 91.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("4d416cc0-2942-401d-8384-0949b20a5595"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1511), "192.168.1.81", (byte)1, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4d5e210b-93c1-4510-81b0-292479f066e4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2907), "192.168.1.86", (byte)2, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("4db8a360-3768-4cbd-8bc1-507164999bda"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1211), "192.168.1.52", (byte)1, 10.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4dd03d68-26cb-4bf4-a605-6224f5978250"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3452), "192.168.1.21", (byte)3, 30.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("4dd37780-204a-46b6-96f3-b2ea21e06ee4"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2035), "192.168.1.18", (byte)1, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4df39ee5-7aa2-469b-81e5-245351857018"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1982), "192.168.1.67", (byte)1, 72.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4e5a2aa4-49d2-4609-966a-f1d8c577830e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2157), "192.168.1.92", (byte)1, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4f34b4ae-5049-42f2-b69c-df96fdce7d8f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3735), "192.168.1.88", (byte)3, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4fd2970a-b03c-4620-882b-dbf92d77cd92"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3747), "192.168.1.37", (byte)3, 92.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4fd431bf-0d4d-44d2-94ec-f1edea0410ce"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3993), "192.168.1.70", (byte)3, 49.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("506b5ad3-4d5d-4493-adf5-be458dff3caf"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3929), "192.168.1.64", (byte)3, 90.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("50710473-2d05-4518-8ba1-2fdb3339c270"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1815), "192.168.1.77", (byte)1, 65.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("51518ea4-434f-437f-b802-9a101139df27"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2888), "192.168.1.1", (byte)2, 39.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("51abbaf6-46d6-419d-bbe0-0906797321c3"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2424), "192.168.1.61", (byte)2, 72.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("51df52a4-da77-4d7e-9a55-5accd9d654f0"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2796), "192.168.1.43", (byte)2, 27.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5217228c-0920-4653-8607-66e4c9e3b01a"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1762), "192.168.1.24", (byte)1, 9.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("528ab3cb-74f9-4a54-b158-c54c2bc2d1af"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2865), "192.168.1.88", (byte)2, 82.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("52bf865f-e677-40a7-b27e-246b5f21fbf2"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1536), "192.168.1.82", (byte)1, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("531ed3ef-16ae-425d-8e4f-db8246d27f01"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1994), "192.168.1.91", (byte)1, 95.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("536abdbb-38b9-46b7-a395-b2a4bc143a08"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1786), "192.168.1.72", (byte)1, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("53de9e95-791f-41f9-8e1d-1b39430433a8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4188), "192.168.1.3", (byte)3, 54.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5404c2ae-6272-4ed4-83ec-25b710fc2237"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4108), "192.168.1.64", (byte)3, 45.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("544f38c0-8cd8-43f8-a8bb-ff341d81d5e6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1747), "192.168.1.51", (byte)1, 64.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5450c684-c53f-4e46-8f3a-53c88bd6d8b5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2725), "192.168.1.41", (byte)2, 73.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("54f30fc0-f89b-49b0-a8b9-2f6045e94089"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2203), "192.168.1.86", (byte)1, 5.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("556989ae-a155-486f-a616-97a3f69ab747"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3772), "192.168.1.65", (byte)3, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5619743b-746a-4c48-9133-50fc1b61a2d4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2495), "192.168.1.36", (byte)2, 50.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("56ab3d70-15ff-4e1b-8829-2151a816b0d7"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3913), "192.168.1.85", (byte)3, 15.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("56dc8923-8c8b-44e7-a5c2-5665ba8347ad"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1637), "192.168.1.83", (byte)1, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("56f56c6e-5997-4f0f-83b8-4fad77297da4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3160), "192.168.1.10", (byte)2, 2.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("57439d9e-b5b8-40c8-8889-e2cd3380beb2"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3932), "192.168.1.4", (byte)3, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("575992ef-8145-4bab-a909-64212f2fbd0c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4311), "192.168.1.41", (byte)3, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("582080bc-c70c-4491-97b1-55dbfceac388"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3319), "192.168.1.33", (byte)2, 66.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("58224b1f-552d-43ad-ad82-d76bb04cd431"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2407), "192.168.1.79", (byte)2, 10.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("589dc5ca-4410-41fc-a6f5-4d813f166ff8"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1215), "192.168.1.52", (byte)1, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("58a2d4f6-de65-4a6c-90e0-d2a014e36ae3"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3262), "192.168.1.70", (byte)2, 43.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("58ccb4c2-daa4-427c-addc-cf6de4acb8d5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3013), "192.168.1.94", (byte)2, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5942f2e2-f3cf-4ddd-b506-e74314e968a6"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2451), "192.168.1.1", (byte)2, 13.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("598c7766-4426-4d63-b640-d132cab43a22"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1584), "192.168.1.33", (byte)1, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("59aa3381-00b8-4dc1-bfdd-be7756c54021"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3628), "192.168.1.86", (byte)3, 50.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("59c9fe37-b7d5-4a23-a236-2106a5d1cef5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2911), "192.168.1.48", (byte)2, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("59e75e0d-365c-4360-ae3d-995d59960b7a"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1315), "192.168.1.96", (byte)1, 32.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5a57a771-e594-498b-b0cf-d60cfc2f5a53"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2194), "192.168.1.31", (byte)1, 13.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5a608b71-9995-4c83-ba44-96290c6d0d5f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2660), "192.168.1.71", (byte)2, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5ac53500-0999-4a28-a408-f6df22a3d6f6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4303), "192.168.1.63", (byte)3, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5adb9473-fa8c-4d8e-b1dd-119ff46fe5ce"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1267), "192.168.1.92", (byte)1, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5b060157-e6d9-4c6c-80f2-b8db5ea6df8c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3580), "192.168.1.66", (byte)3, 87.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("5b2f8377-4203-49fa-929d-3aade7d7f19d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2014), "192.168.1.47", (byte)1, 87.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5c136e2a-b8e2-4b42-b229-55b06a047931"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3997), "192.168.1.14", (byte)3, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5c1b52ca-cd2a-4276-bd8d-c45faa255431"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3315), "192.168.1.28", (byte)2, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5c612ef1-5859-417f-b336-f0f5ab0e735b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1507), "192.168.1.98", (byte)1, 42.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5cbe8864-38b3-42d9-9888-93389cc4d77d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2763), "192.168.1.86", (byte)2, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5d5d4344-e427-4e03-be41-465397f25a89"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2266), "192.168.1.34", (byte)1, 47.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5d97d4a9-2992-49e3-9667-3236dd707de8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3965), "192.168.1.57", (byte)3, 77.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5dfc5bb0-59fb-4485-bd30-503709cad94c"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2121), "192.168.1.17", (byte)1, 54.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5e04fa1f-8a45-4af3-8683-07dbb96f4199"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2085), "192.168.1.35", (byte)1, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5e7c83f3-e368-4e1a-9a26-e262ceeb2b7d"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3624), "192.168.1.34", (byte)3, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5e9dc0e4-2f77-439c-ad69-2b45f05d672f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2476), "192.168.1.9", (byte)2, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5ec9ce8c-f8e5-4be2-817e-80ed668d4c1b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1824), "192.168.1.29", (byte)1, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5efa2bb1-16a8-4f81-9030-d37481aeb0b1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3025), "192.168.1.8", (byte)2, 40.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5efb378c-81c2-4080-a2b3-af5e3feef011"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1751), "192.168.1.34", (byte)1, 40.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5efbb648-966b-4879-b385-14f67d6a1f1e"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4391), "192.168.1.23", (byte)3, 55.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5f074b6c-e732-44fc-8706-a5af666e1bcb"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2915), "192.168.1.45", (byte)2, 59.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5f482a8d-d6da-4bb3-9f3a-7d499b67c119"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2154), "192.168.1.15", (byte)1, 6.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5f546a97-b7d5-4f48-a799-523f32f1ea03"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3722), "192.168.1.96", (byte)3, 97.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("6008a511-af45-4b4f-a8c7-d4e6e93bf598"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1880), "192.168.1.91", (byte)1, 16.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6159426d-b704-4053-9f53-c0417fd49732"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2313), "192.168.1.15", (byte)2, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("6243984b-1e43-4ae5-924f-fa10a39261d1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4087), "192.168.1.14", (byte)3, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("634de4ed-f994-4e17-b9c3-0365a4cae0d3"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2940), "192.168.1.19", (byte)2, 52.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("63632a01-79d2-423d-abe4-026894bd4f82"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4233), "192.168.1.6", (byte)3, 49.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("63e8c0fa-52a5-4fd5-9f3c-130166c480fe"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1198), "192.168.1.69", (byte)1, 60.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("63fbc205-5512-43f9-b536-31fd93d73f5c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3596), "192.168.1.39", (byte)3, 95.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("64cd2383-8c45-4a77-844a-c8cf77d22f1b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2815), "192.168.1.71", (byte)2, 87.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("652eafeb-b7b7-4940-aaae-f47e59d11124"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3522), "192.168.1.53", (byte)3, 36.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("65826266-5ca4-44f5-a2e6-c457f6e10de8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3419), "192.168.1.10", (byte)3, 37.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("65a087b7-96fe-4b6a-9b2c-a3d414e65e7a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4034), "192.168.1.34", (byte)3, 70.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("65af6412-3265-4567-a2c4-c0d8a207bafe"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4217), "192.168.1.50", (byte)3, 26.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("65b9256b-c6c3-432f-86c9-85ec15534179"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1259), "192.168.1.55", (byte)1, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("66488287-c0a9-4e60-85f5-64c9dc939212"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2508), "192.168.1.18", (byte)2, 83.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("666a1ccb-3943-4576-bdd2-8effbf2710e8"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2031), "192.168.1.32", (byte)1, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6687d7b0-5ab4-42bc-b52e-b5937afb0ba4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2926), "192.168.1.81", (byte)2, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("66c643be-8ff1-46f1-ad18-4b980b5830ca"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3416), "192.168.1.41", (byte)3, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("670e906a-4fb7-4ba9-b411-46608e6d8194"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3331), "192.168.1.23", (byte)2, 35.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("67fa2beb-9929-4c7f-8442-870f6632f0b7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2324), "192.168.1.23", (byte)2, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("691d5bdb-1cf6-4ccc-807e-983c8cd61a65"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3383), "192.168.1.30", (byte)3, 79.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6a480954-d8b8-4ccb-babc-54887343d004"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3057), "192.168.1.20", (byte)2, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6ae536d0-e30f-4a07-bf39-a4474c0a1a32"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3295), "192.168.1.3", (byte)2, 3.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("6b638c9e-6d00-4c8c-9da1-ef8f0937ed02"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2161), "192.168.1.92", (byte)1, 6.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6c5b4cec-ed86-461f-b3c8-9561138ad2c8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4058), "192.168.1.39", (byte)3, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("6cf76028-199e-4871-b404-cd048565d94d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2549), "192.168.1.88", (byte)2, 13.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6d46fb56-08c8-42bc-86e0-cf9b63530b03"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2697), "192.168.1.34", (byte)2, 46.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6e374a66-e319-4327-bffe-18d7488600fc"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1487), "192.168.1.66", (byte)1, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6e8aa93b-8e1c-4957-be2d-0ffdea9e9dd9"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2729), "192.168.1.24", (byte)2, 98.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6f854218-918c-41d2-8286-6b58546ddbe6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3657), "192.168.1.39", (byte)3, 80.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("6f95aaa3-0fe1-4385-9477-f04b854a9056"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1819), "192.168.1.34", (byte)1, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("6f9fdf88-205d-4aef-a3d7-d4cd07e21b95"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2988), "192.168.1.7", (byte)2, 38.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6fdc6b00-489a-4ba8-a8e3-a12824ba5200"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3584), "192.168.1.62", (byte)3, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6fe06fec-c11f-409f-811a-cd188d5241a6"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2411), "192.168.1.24", (byte)2, 56.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7141b810-c376-4845-8213-4ed662d1627f"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1595), "192.168.1.23", (byte)1, 22.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("714ed0dc-43d1-463a-94d0-94b2967384c3"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1697), "192.168.1.84", (byte)1, 80.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("729d0329-1d27-4bb2-af98-c9de3c52b7c5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2303), "192.168.1.97", (byte)2, 93.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("72af190e-8ff2-494a-b802-d3f3eb7e5c85"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3408), "192.168.1.5", (byte)3, 20.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("72cca2fc-31cb-4185-a749-b25f69feaeb6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1844), "192.168.1.42", (byte)1, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("72d7928e-5021-4bf4-b5be-28715876c254"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1857), "192.168.1.59", (byte)1, 87.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("72d8488d-4f47-4465-bd1e-6633fe426bae"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4336), "192.168.1.32", (byte)3, 78.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("731f184b-676c-418c-8e02-608beae07d8e"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2704), "192.168.1.24", (byte)2, 35.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7324deb3-731e-4aaf-aa70-402c5cef5f57"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3563), "192.168.1.14", (byte)3, 4.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("733eaad2-c025-4328-81b3-cfcfd93d3b6b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3387), "192.168.1.38", (byte)3, 23.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("733feada-500f-4fd4-9881-62b0582af496"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4026), "192.168.1.72", (byte)3, 82.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("73977f20-7578-4f92-8386-12d45fcdfb39"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2358), "192.168.1.58", (byte)2, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("73f3d1b3-5e09-4db6-b6e5-3abf17c65059"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1588), "192.168.1.38", (byte)1, 50.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("74c814c8-8517-4838-96ab-101790dca026"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3396), "192.168.1.49", (byte)3, 15.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("74fff5b4-b812-4d58-a39b-765fb01fab2d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2997), "192.168.1.50", (byte)2, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("75540292-ab18-4889-9aad-4ca87571eab6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3806), "192.168.1.64", (byte)3, 91.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("765428ea-a1b4-4146-ac79-9488cf80c8d5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2081), "192.168.1.44", (byte)1, 16.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7674259d-5741-42e9-bf4c-32aeda850120"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2877), "192.168.1.91", (byte)2, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("76981fc4-c2c7-4bc8-a85a-530ea7cca019"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3278), "192.168.1.97", (byte)2, 2.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("76c07179-517a-4743-841b-cd92a40c16ec"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3710), "192.168.1.61", (byte)3, 20.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("77620bc5-ced2-4500-a035-6f6137ee6008"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2280), "192.168.1.79", (byte)2, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7869f035-42cd-43a8-a2f3-ae24ab036124"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2693), "192.168.1.31", (byte)2, 84.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("78ee34c6-be0e-46c5-bdef-26ca7e4f23f5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2898), "192.168.1.50", (byte)2, 91.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("78f40e8b-e9e4-420d-8886-ed26c9c9ef9d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2972), "192.168.1.19", (byte)2, 86.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7950a6a0-ef3c-4554-ae84-620a30ebdaa6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3873), "192.168.1.8", (byte)3, 14.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7966db07-de84-4013-831e-2c6f517e7701"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3030), "192.168.1.4", (byte)2, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("79726c61-28f5-44f3-bbb0-cacec36a25a9"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3571), "192.168.1.49", (byte)3, 21.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7a2d3bfd-b5a9-4d61-9170-9c6814ad1b30"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4116), "192.168.1.95", (byte)3, 99.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7b03ac78-cae7-4e7d-a3ba-11079b0e0d07"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4167), "192.168.1.55", (byte)3, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7cf7d6a2-acaa-4986-a66f-54e05b0b204b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3212), "192.168.1.29", (byte)2, 15.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7d14e50c-b1dd-4b2f-96d5-65fba1b436c4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3084), "192.168.1.18", (byte)2, 16.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7e0123c0-f01c-46d6-a090-86d964130eeb"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3258), "192.168.1.54", (byte)2, 73.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7e1fb758-4aec-483d-8fc8-423019d69118"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2073), "192.168.1.25", (byte)1, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7eb45e01-a444-4bc7-b3d6-ef9898b635eb"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3429), "192.168.1.46", (byte)3, 86.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7fa9f228-e688-4937-b299-5ff0aea45eac"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3152), "192.168.1.33", (byte)2, 20.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8008b672-0563-426f-9511-1eedbc792f5a"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1961), "192.168.1.22", (byte)1, 35.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("800a9a8d-f981-49dd-b167-691c5b721bfb"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2819), "192.168.1.11", (byte)2, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8018b27d-8d51-42ab-861d-2d768d19aedc"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2007), "192.168.1.90", (byte)1, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("805c1700-7db5-4aa2-b9a2-9d720744b3e6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4070), "192.168.1.45", (byte)3, 93.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("80a079a5-be60-4111-8548-99c1ec21d659"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2472), "192.168.1.63", (byte)2, 31.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("80da79e4-33b4-4952-b0e3-a9815db36f00"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1530), "192.168.1.19", (byte)1, 42.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("813ae484-f305-46d6-8304-942ec90241b4"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2047), "192.168.1.18", (byte)1, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("815b26f3-79c1-427e-9a02-73824316d977"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3764), "192.168.1.50", (byte)3, 88.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("81902077-1d85-4555-a93c-b07cb33378b5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2778), "192.168.1.87", (byte)2, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("82502783-65de-46ac-92c4-901ff179031e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2100), "192.168.1.45", (byte)1, 41.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("82c358c5-dddc-488f-9c99-8945e13c5262"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1286), "192.168.1.48", (byte)1, 98.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("82fcbedc-ad3a-474c-ac1a-53b932fb0e45"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4221), "192.168.1.81", (byte)3, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("834d3c81-39b1-45f5-a31e-be181c84177f"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2241), "192.168.1.60", (byte)1, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("83ad7b58-7391-4ac7-acb7-4bc95c5d18d1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3834), "192.168.1.82", (byte)3, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("83c0e192-b83a-4437-919c-1cc35150f2da"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4359), "192.168.1.39", (byte)3, 32.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("84215703-396d-44bb-a320-f7ae0bb71797"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2171), "192.168.1.15", (byte)1, 96.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("84294602-ef8c-48f6-87dc-dc75c4b8e9b2"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3375), "192.168.1.85", (byte)3, 64.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("84ee6f3a-82a0-4c8e-9f75-eae5fe58617b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3112), "192.168.1.44", (byte)2, 10.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8525cc72-0336-424a-883b-9fe4abaa0b70"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1323), "192.168.1.6", (byte)1, 58.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("854b7f1d-ccd7-40d3-ad95-ae4972126028"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2610), "192.168.1.90", (byte)2, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("863738eb-e9e9-491c-a764-e9b57e610c01"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1343), "192.168.1.75", (byte)1, 58.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8696e8b2-ef4d-44fb-82e2-cd7bfd14513d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1471), "192.168.1.94", (byte)1, 76.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("87062678-024d-48a0-a3b2-341d2988ab3b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2234), "192.168.1.98", (byte)1, 55.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("875d28fa-6a2b-4845-981d-feae618fc9bc"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1353), "192.168.1.57", (byte)1, 52.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("87daefc0-5001-457b-87d6-540ba5964fa5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1398), "192.168.1.50", (byte)1, 23.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8809d513-8d01-49a5-92c3-5fa223fc5427"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3360), "192.168.1.88", (byte)3, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("88868e1f-4273-4b48-a5b9-ab9ef6c37fb7"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1306), "192.168.1.82", (byte)1, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("88b4cceb-46b9-48a5-a291-749eab8bbf56"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1459), "192.168.1.75", (byte)1, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("88dcd203-3410-414f-8164-e3025f9dec8a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3462), "192.168.1.73", (byte)3, 60.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("88ed9aaa-a05b-4c6a-b87b-522d51219f70"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1876), "192.168.1.51", (byte)1, 40.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("89feb39f-4500-4b2a-a1c8-567ee4c9037a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2615), "192.168.1.42", (byte)2, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8a03059a-2f5e-4448-86a4-c59ccdf7b79a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2582), "192.168.1.30", (byte)2, 95.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8a3941e3-80f1-4211-9f5d-556890abb6a3"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2106), "192.168.1.15", (byte)1, 93.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("8b489744-f7f9-49b6-8683-3787fa3aedb7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2505), "192.168.1.49", (byte)2, 66.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8b8cc789-b14b-4d68-aba8-decb3de4ed8d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2010), "192.168.1.75", (byte)1, 13.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8ba14f40-5b92-4b0d-a1a2-136e3cc59c38"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1694), "192.168.1.60", (byte)1, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8ba60bc7-e274-4078-92f0-85379214d326"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1402), "192.168.1.35", (byte)1, 75.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8bd6311a-d83c-4884-8164-34259cae30aa"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1255), "192.168.1.44", (byte)1, 95.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8c43f83d-08ac-4483-8477-574fa9ca7bf8"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3076), "192.168.1.56", (byte)2, 71.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("8cb29283-22ac-4975-94e4-1ce99431effe"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2714), "192.168.1.13", (byte)2, 90.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("8cd9baed-2feb-4ceb-baaa-2bd9b03b3ce2"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2786), "192.168.1.94", (byte)2, 19.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8d001e60-15e2-4719-89b4-689854284f77"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1417), "192.168.1.61", (byte)1, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8d0eb98e-5190-427c-bf0e-c17edbc98868"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1657), "192.168.1.64", (byte)1, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8d4d59b2-67ce-4390-b76b-ed5aa79469c8"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3298), "192.168.1.29", (byte)2, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8d939a95-f6cd-4967-9acb-c6d95877709d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3124), "192.168.1.24", (byte)2, 77.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8dacd607-f54c-47a5-a76d-e2ab9e14d916"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1290), "192.168.1.43", (byte)1, 44.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8df79365-470c-40b8-be5f-7698adbe858b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3164), "192.168.1.65", (byte)2, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8e049a96-91f8-48ac-be43-67af92892dbd"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4160), "192.168.1.11", (byte)3, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8e0c8c7f-375b-4d0d-9833-ec0d70acc4a1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3306), "192.168.1.36", (byte)2, 65.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8e4d8c31-4640-4faa-b3cc-4a85fe5a1d54"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2873), "192.168.1.55", (byte)2, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8e521ce3-1ab3-46e9-a34f-8ab3a059d023"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3041), "192.168.1.2", (byte)2, 15.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8e8c9ea8-2aaf-4760-ad2f-a4ea3f1dedbb"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1431), "192.168.1.99", (byte)1, 82.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8ec6478e-276d-4d39-9d02-b0d8687a0013"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3731), "192.168.1.85", (byte)3, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8f07760d-325f-4c47-b364-962a4dcc84e1"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1682), "192.168.1.43", (byte)1, 75.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8fce116a-7b01-4daa-9ec2-c6c53ca1af94"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3547), "192.168.1.23", (byte)3, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("8ff34f0d-5ac9-4f08-bcb4-b8eb33d54cc6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4047), "192.168.1.9", (byte)3, 0.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("91473bed-410d-42a5-bdb9-2fd2fd11938d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2689), "192.168.1.28", (byte)2, 19.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("919fe360-50cc-4456-8aa7-d2b2ef017b01"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1219), "192.168.1.55", (byte)1, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("91e00c4f-11aa-474d-bed8-82effba125f8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3445), "192.168.1.41", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("92ea4971-72c3-43d8-a309-ad6037a1bc9c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3787), "192.168.1.2", (byte)3, 74.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("937a1afc-95eb-47e9-b64e-930fc50b6618"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2947), "192.168.1.2", (byte)2, 93.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("93e83147-e64a-4495-9ab4-fd1df94d9358"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1811), "192.168.1.88", (byte)1, 33.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("940e7a1a-82af-4a30-adc8-7bb424c612af"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1559), "192.168.1.64", (byte)1, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9545acda-0bde-426c-89c5-7e40947d245a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2619), "192.168.1.51", (byte)2, 1.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("95e1ddcf-ab78-4743-8de6-c8d3bac8957b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4164), "192.168.1.17", (byte)3, 57.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("960daf96-2084-424a-b4d8-3433cec7d523"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3888), "192.168.1.89", (byte)3, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("961661ea-3c14-48a4-8534-b9171a5f56d5"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3339), "192.168.1.13", (byte)3, 90.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("96758c6e-a24e-4bca-9c34-7fa95ef15848"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2382), "192.168.1.17", (byte)2, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("9704448a-322f-41ad-bbe6-1ee4f61d35ec"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1515), "192.168.1.41", (byte)1, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("97282443-8ecb-4209-ada2-94914372d9f1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4066), "192.168.1.90", (byte)3, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("97325f05-556f-4c89-9683-371443086633"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1547), "192.168.1.30", (byte)1, 1.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("9742bd88-ebf8-4501-b315-ad93700ff811"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3196), "192.168.1.98", (byte)2, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9789974e-c3a0-498e-86c6-72794cda807c"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1233), "192.168.1.66", (byte)1, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("97a6d3f7-5bbd-4c15-9831-d86a23b9cf37"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2129), "192.168.1.49", (byte)1, 49.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("989d839e-c3aa-4c7c-bb8c-20f1427151d7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2635), "192.168.1.47", (byte)2, 66.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("994bf23e-90e4-4921-a74d-7663bbd28033"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2881), "192.168.1.6", (byte)2, 47.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("995fb7a8-184b-4e34-b6bb-ff537f720ff3"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1294), "192.168.1.28", (byte)1, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9978c489-868f-4b58-b885-989cc4746497"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3551), "192.168.1.30", (byte)3, 50.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("997b2dea-09d7-4be7-98ad-f6678b383b78"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2026), "192.168.1.95", (byte)1, 45.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("99919c6f-3a0d-49d1-9e91-03cd237f6b00"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1229), "192.168.1.19", (byte)1, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("99b6b875-bb2c-4418-91e3-57d5ee64b98e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1427), "192.168.1.76", (byte)1, 91.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9a01bb28-9cdc-40d9-bfbf-5910c02d75b0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1986), "192.168.1.99", (byte)1, 10.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9a5bf9cf-c5af-43b8-a38b-3dea4f7db7a8"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1580), "192.168.1.61", (byte)1, 0.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9a937073-12dc-422a-b38d-5d96cc725a3d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2537), "192.168.1.33", (byte)2, 10.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9b0f5d0b-0112-4eb2-9873-b48d357b6a20"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1380), "192.168.1.75", (byte)1, 80.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9b188c76-0830-4479-8a55-54ce5b97030a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2374), "192.168.1.57", (byte)2, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9b47b328-1dd3-421a-8c4f-38c62d7502ca"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2848), "192.168.1.17", (byte)2, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9b4ba77e-c087-485a-bc76-8dec668ff477"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3392), "192.168.1.65", (byte)3, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9bd9f0ef-44f1-4b28-aa21-4acef3bc1385"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1242), "192.168.1.43", (byte)1, 92.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9bf66362-b510-4bf3-b209-76bed6f27f81"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1327), "192.168.1.76", (byte)1, 57.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9cd047dd-0e05-4189-bff5-245d21970a27"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3957), "192.168.1.22", (byte)3, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9cd8903d-908d-4cc2-8205-69feda609cf3"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3938), "192.168.1.92", (byte)3, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9cf6503f-caf9-45c3-b049-ff57a39a3d74"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1832), "192.168.1.65", (byte)1, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9d8c5e3e-5b0c-4847-a52a-57b7e4038ce7"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3603), "192.168.1.32", (byte)3, 26.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9daf7f01-ce36-4d2d-bd6a-362882cd38c2"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1406), "192.168.1.9", (byte)1, 65.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9e95a158-aa15-4ee4-9376-227c6f9c42b1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3189), "192.168.1.12", (byte)2, 69.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9e9c9a09-af59-4def-8e56-2b6535b74640"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2700), "192.168.1.25", (byte)2, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9f825b40-e924-42a5-b582-0012feeeb43a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4171), "192.168.1.65", (byte)3, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9fc36b9a-185f-404c-9e1a-fda2e437852e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2182), "192.168.1.52", (byte)1, 8.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a0954e5f-b399-42ed-b1d9-199fbbfb9ee5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1435), "192.168.1.79", (byte)1, 83.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a0a1b678-22ef-4e91-855b-9cb9e4e14367"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2491), "192.168.1.25", (byte)2, 89.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a0c04a88-45cb-47bd-8519-54e8805538fa"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2271), "192.168.1.86", (byte)2, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a0ffe7c8-397f-4076-9037-57bd4485f648"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1413), "192.168.1.18", (byte)1, 54.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a16f0c0f-bed3-459d-b6bc-dd2137007e27"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2419), "192.168.1.92", (byte)2, 43.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a185aa06-a615-4faf-b08a-271c643809dc"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1298), "192.168.1.61", (byte)1, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a1aa685d-8e2e-49fa-9554-b09f7b4f1f9c"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1519), "192.168.1.81", (byte)1, 55.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a1f5ca31-8d8d-4801-84a3-73453a8aeffd"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3116), "192.168.1.40", (byte)2, 3.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a2178dec-c912-4b1a-85d0-135e1de44c7a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2676), "192.168.1.49", (byte)2, 99.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a2273a2c-b74d-440e-a714-801bae87a588"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4332), "192.168.1.89", (byte)3, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a33d786e-e5e1-4015-bd47-3c8a479edf85"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2428), "192.168.1.72", (byte)2, 44.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a3532425-5fad-4465-b321-cdbce9011c02"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3706), "192.168.1.40", (byte)3, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a380d958-28dd-4576-936e-42d6d19e3c09"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3266), "192.168.1.4", (byte)2, 12.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a3a19d87-4389-4dc6-877d-2046d2efca36"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1848), "192.168.1.52", (byte)1, 58.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a41f91a9-7798-4b63-a6ea-f1e01f950d73"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2656), "192.168.1.19", (byte)2, 38.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a45bb617-33cd-48f7-84f5-8f4d3f6d6100"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1974), "192.168.1.87", (byte)1, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a4623228-55c4-4dad-89c3-1a3936032bf5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3226), "192.168.1.68", (byte)2, 77.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a499d16e-39a0-4f65-85c5-b4aeab55e39a"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1568), "192.168.1.4", (byte)1, 1.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a4e5c0cc-496c-405e-8f12-221358b8a5c7"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3144), "192.168.1.91", (byte)2, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a4ee43af-6e1b-4281-8c89-9cc52d0e9a71"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3636), "192.168.1.55", (byte)3, 9.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a4faa510-01a9-45c4-91a1-2af077f19b6f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3404), "192.168.1.33", (byte)3, 29.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a5afed7f-d4c4-4820-bae8-93a134b0417a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3274), "192.168.1.54", (byte)2, 25.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a65b8df5-d1ef-4732-a4fa-ed39b59ed715"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1319), "192.168.1.16", (byte)1, 43.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a6debba8-29e4-462d-9a08-dd58e6aa1b70"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3534), "192.168.1.31", (byte)3, 13.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a7db485d-fc79-49d8-afc5-c027b081b1b0"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3291), "192.168.1.44", (byte)2, 46.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a85c5464-99fe-4359-badb-678f5309894d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2737), "192.168.1.41", (byte)2, 34.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a896ef3c-de1a-45e8-855a-c699fbecec2e"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2643), "192.168.1.9", (byte)2, 69.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a8b7ad71-0eb2-40e8-8c2a-b8534f630315"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3863), "192.168.1.25", (byte)3, 34.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a8d7f264-ffb1-4175-a3fb-4e68ebf9f419"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2541), "192.168.1.14", (byte)2, 91.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a9527fc3-7a5f-4c4f-a5c6-e42ea8fe75e4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2463), "192.168.1.93", (byte)2, 55.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a9b60728-c850-4e69-9cd0-e91b1a71c9b6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1714), "192.168.1.25", (byte)1, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("aa1e930c-fa30-4cc0-b6c8-25a8701f7180"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2003), "192.168.1.46", (byte)1, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("aaad2b06-7e9a-4273-94c3-9bfd7ded3004"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3612), "192.168.1.24", (byte)3, 34.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("aabfd47c-f0b6-4583-a5f8-11bc19143e47"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2230), "192.168.1.39", (byte)1, 64.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("aad0b9a1-6e1a-4d5e-8602-fe188b6884bc"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3775), "192.168.1.68", (byte)3, 7.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("abad5f1c-f230-4174-b039-17dfbedabc85"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3335), "192.168.1.27", (byte)2, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("abd84513-6616-48dc-b897-5aa51e74d265"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2955), "192.168.1.51", (byte)2, 13.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("abd88b4c-a4fd-4e91-b6c2-16628e7d142c"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2432), "192.168.1.30", (byte)2, 2.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ac7d15bc-eae8-456f-a2ce-1986c8f8ae4f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4143), "192.168.1.4", (byte)3, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ad0cc76f-65f0-464e-9130-ca47c0501a60"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2585), "192.168.1.94", (byte)2, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ae3d2588-cecd-48e3-a83d-69c34aa6c307"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2299), "192.168.1.78", (byte)2, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("aec6357b-6e4f-40cd-889f-c586c45d1f9b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1394), "192.168.1.19", (byte)1, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("aee627fd-e798-454e-860a-5e82f458865c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3796), "192.168.1.50", (byte)3, 61.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("af6c7bdb-cd4d-4007-a8be-997f8f1acb96"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4139), "192.168.1.67", (byte)3, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("af7bcf86-8acc-457f-a70e-c1459a15eff0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1669), "192.168.1.89", (byte)1, 76.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("afa872e9-24d1-4394-9967-5cf60ac9fe17"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1889), "192.168.1.23", (byte)1, 75.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("afe390bc-b93a-4cb5-b8e3-7395c6f1fdfd"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1897), "192.168.1.31", (byte)1, 23.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b0356b33-c375-4afa-95a4-b89dcbc5f937"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3779), "192.168.1.47", (byte)3, 96.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("b05ac896-a405-412e-943f-8741da6d0635"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4380), "192.168.1.59", (byte)3, 11.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b07ea141-de4d-4710-956f-4635311fa8d6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1942), "192.168.1.21", (byte)1, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b08c61cc-312c-44b2-9bd2-a5e6b96c684d"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3503), "192.168.1.40", (byte)3, 42.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b17d23cc-f591-4db4-97cf-0d69bdbb2d81"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3925), "192.168.1.29", (byte)3, 66.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b20c508c-5465-4ac2-a13d-4ba223805653"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1770), "192.168.1.69", (byte)1, 21.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b20ddcef-1d5f-4ea1-a677-5858f8bbcff1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2733), "192.168.1.44", (byte)2, 39.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b232e564-689e-4487-9f90-5ae794f1395b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3091), "192.168.1.77", (byte)2, 87.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b266fa45-34f6-4010-a018-161408adf6fb"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3810), "192.168.1.80", (byte)3, 5.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b2c6336c-acd2-4c06-b79c-33e23feeda94"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4079), "192.168.1.31", (byte)3, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b2d0eff1-a419-4c50-b826-aea15a2480aa"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3607), "192.168.1.88", (byte)3, 71.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b2d32196-d365-466e-a90f-9386e4decd2d"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3760), "192.168.1.41", (byte)3, 17.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b32dd468-a257-46e8-a8f2-a2fc1dac8c91"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2672), "192.168.1.44", (byte)2, 88.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b425bc7c-959a-4a10-8555-1b56831f3723"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3458), "192.168.1.85", (byte)3, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b44bd249-1446-46be-a10a-52eb8ce7c5c5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1665), "192.168.1.17", (byte)1, 63.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b527b481-ad39-4231-b789-cadb028905b5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1726), "192.168.1.53", (byte)1, 8.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b5674495-f412-443c-912a-7cd4842022c4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3254), "192.168.1.38", (byte)2, 65.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b6b541b5-351d-46c6-8b29-f9d546ab7cb2"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2837), "192.168.1.55", (byte)2, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b741d33e-34f8-417d-8c01-b525635af55f"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1237), "192.168.1.83", (byte)1, 65.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b7fc0f36-99cd-46b6-b1ae-28c4f1b6513c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3660), "192.168.1.80", (byte)3, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b9fc4294-55cb-4b86-b072-af2f5718a0a4"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4011), "192.168.1.91", (byte)3, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ba28488d-1a4a-4a78-ba04-9d97b266bd69"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2844), "192.168.1.65", (byte)2, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ba46166d-588a-44f8-828b-febf645c0e71"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2992), "192.168.1.48", (byte)2, 26.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ba77235e-0a65-45b0-a665-faddc382588e"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3177), "192.168.1.59", (byte)2, 0.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ba9b08a7-8af4-43e3-afec-e3c442d0ae7c"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2403), "192.168.1.91", (byte)2, 90.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("bc19ddd2-0405-4ed5-975a-59f477077daf"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2178), "192.168.1.48", (byte)1, 82.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bc749c80-2115-4489-802c-269895a8e27e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1555), "192.168.1.21", (byte)1, 92.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bcc35a52-1870-4aad-95d7-04e95fb205e1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3372), "192.168.1.65", (byte)3, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("bd6a5817-bd67-453c-9f1a-28cef949ae0d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2790), "192.168.1.7", (byte)2, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("be3529aa-2673-42cd-9394-4e64a3ecb44c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4323), "192.168.1.87", (byte)3, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("be8c5d9e-5502-4d60-b5db-c65cbef17c2b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4319), "192.168.1.49", (byte)3, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("bf4cf93b-9f30-4335-8cd7-9e1d0b4a83ab"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2708), "192.168.1.28", (byte)2, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("bf669301-8db9-4723-bc02-030791af87b0"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3425), "192.168.1.83", (byte)3, 20.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("bf690a67-e7c3-498f-98b4-ae5879edeb8e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1872), "192.168.1.64", (byte)1, 50.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("bf9a4e8b-054b-4a24-9255-3cd079fe7992"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2782), "192.168.1.4", (byte)2, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c003aa88-2a28-4cc8-bc3c-6ce3f74ebabc"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3917), "192.168.1.39", (byte)3, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c0e3199f-8f53-482a-b939-8dcc656a51cb"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2459), "192.168.1.76", (byte)2, 4.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("c1d14226-af92-4634-9dad-62b956c96021"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3062), "192.168.1.52", (byte)2, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c249fcb4-3384-40d0-9817-6999fb44aa08"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2395), "192.168.1.45", (byte)2, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c2928fc5-5e2f-4300-8012-517e90a2eaa6"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2512), "192.168.1.79", (byte)2, 73.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c3208cd6-73ed-4c3d-82d8-a583842328f3"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2150), "192.168.1.51", (byte)1, 26.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c3c53738-f7fa-4c20-a03f-1733ffb46d1d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1339), "192.168.1.49", (byte)1, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c4bdaf2f-5c8b-40ea-aace-e622c5c6eb7c"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1421), "192.168.1.49", (byte)1, 48.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c4cdb804-172f-4203-a27e-21dbb3ed1e2e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1503), "192.168.1.27", (byte)1, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c4ee2792-29b9-44ac-a70b-b50eab593991"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3649), "192.168.1.29", (byte)3, 33.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c5594c59-78b4-456d-a224-d62471e920db"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4347), "192.168.1.86", (byte)3, 76.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c56efa46-d985-4a1f-b31f-0e4ab4cc5c37"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4200), "192.168.1.4", (byte)3, 95.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c58c1e9f-d33a-413b-a487-a35761ca73bc"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4179), "192.168.1.50", (byte)3, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c5b76030-9481-4ff8-8a8e-3f41a2984ca6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1970), "192.168.1.16", (byte)1, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c5fb461b-1733-41cf-86d7-07f8db164dfe"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3441), "192.168.1.50", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c67e3159-4725-4c73-97b3-ea3e5a9dd206"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1865), "192.168.1.33", (byte)1, 21.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c7504fd4-81a9-491a-85d4-5d824fff22e6"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2415), "192.168.1.51", (byte)2, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c7b037d4-630b-44d7-9f71-62e8631fe22b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1633), "192.168.1.88", (byte)1, 35.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c7b10382-451a-440f-a48c-c723433ba5ae"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2165), "192.168.1.75", (byte)1, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c7bb6297-274a-4119-9c8e-154cd78e2f0f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2631), "192.168.1.58", (byte)2, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c83c269e-2ba3-498f-98b8-1709518e2e8e"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4001), "192.168.1.21", (byte)3, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c854d1b2-b525-4f30-8857-b80f48b0a99a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3218), "192.168.1.49", (byte)2, 76.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c86999c4-6ad5-4e8d-9781-3356df6fe1af"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1251), "192.168.1.62", (byte)1, 10.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c881d210-7c9e-4a4d-9c36-e5ea8990ac90"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4344), "192.168.1.28", (byte)3, 21.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c8c3c2ce-6827-4cff-92be-812a52216ebc"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1807), "192.168.1.18", (byte)1, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c93fb81a-5542-4cea-aeeb-b0e6c6dd9412"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2328), "192.168.1.4", (byte)2, 55.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c9a39546-407b-48ac-b891-705e5f071250"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3751), "192.168.1.29", (byte)3, 32.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ca0f6195-e132-41e1-be25-065af3ceaedc"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3108), "192.168.1.61", (byte)2, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ca1d24d6-5910-48ed-8c63-d60e21b9cf6b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1442), "192.168.1.46", (byte)1, 96.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("ca1dd604-b57c-41c2-96bf-a1b2bbae128c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3990), "192.168.1.16", (byte)3, 10.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ca7ba9cb-0276-426a-a567-528182230630"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3689), "192.168.1.83", (byte)3, 73.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("caf07d84-13ee-4b35-a239-5b3536951cbd"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3497), "192.168.1.35", (byte)3, 88.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("caf1a737-3e3e-4a89-9f70-84cda34a87d0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1795), "192.168.1.28", (byte)1, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cb97105a-0dc6-4c07-b0eb-d28452d166bb"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2807), "192.168.1.2", (byte)2, 58.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("cbaf5980-bcde-4286-a69e-3ec0f042dcb5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2254), "192.168.1.9", (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("cbd3a3d9-9f24-4e14-8d7b-c6b0bda8adcf"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1950), "192.168.1.16", (byte)1, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("cc2593f7-e57a-47de-8a52-de338a384caf"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1840), "192.168.1.97", (byte)1, 70.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("cc36c30f-cd35-4d15-8ff2-d6c4fee50706"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2799), "192.168.1.35", (byte)2, 56.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ccfd84c0-fd68-4ee2-95f1-99825b55efa8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4175), "192.168.1.8", (byte)3, 2.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("cea7dc8b-a8eb-4a0d-8400-4304126293fa"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4265), "192.168.1.33", (byte)3, 29.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ceba7337-501f-4f95-a285-53a17e163f3d"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1446), "192.168.1.88", (byte)1, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("cebc41a3-704b-4d35-ade5-976487b3cdad"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1388), "192.168.1.91", (byte)1, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("cf02df10-7e7a-45a7-9bdd-a03449df316a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3400), "192.168.1.32", (byte)3, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("cfdaafcb-fb7f-449a-97bd-2f6b4e182d7f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4365), "192.168.1.21", (byte)3, 64.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d01d6298-6958-47d2-bd3f-4e1cf1140841"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4355), "192.168.1.89", (byte)3, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d06926e0-5ac7-4f8c-9f9a-ef27cb901176"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3128), "192.168.1.81", (byte)2, 66.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d093ebad-ae36-4fcc-8417-a9699aa2d3f6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1302), "192.168.1.60", (byte)1, 92.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d0fe01b9-958d-4c07-95dd-37050ecb7c72"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1990), "192.168.1.22", (byte)1, 36.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d1992245-acda-4eb7-a550-057823c77620"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3867), "192.168.1.2", (byte)3, 87.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d1a2748e-ba4a-4abe-8cef-b02f2f731e0f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2371), "192.168.1.61", (byte)2, 46.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d25f8da1-f230-4a9d-b844-e52eb3ee706f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2829), "192.168.1.12", (byte)2, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d2681c9b-c2d0-4e6d-95bb-ca3f753b5cbf"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1966), "192.168.1.27", (byte)1, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d29be271-bb9a-4c72-ae89-77df6b4a6356"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1483), "192.168.1.85", (byte)1, 81.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d2e15dfa-76e1-40c8-90e4-fa31e0ee4f30"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3087), "192.168.1.84", (byte)2, 52.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d2f4a55a-dbdb-4c14-ab03-01e5a3d14697"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1893), "192.168.1.78", (byte)1, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d304bf9a-87e2-4c85-aaa2-0b3430d2e7d6"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3270), "192.168.1.12", (byte)2, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d3aab174-a86b-4930-ad14-13d2f9932729"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2022), "192.168.1.23", (byte)1, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d43774ff-7dc9-4cec-a735-aea840d736d8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3743), "192.168.1.98", (byte)3, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d4a57614-4659-4f17-bfc5-83eb6be726a3"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1620), "192.168.1.12", (byte)1, 33.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d4b58eb2-36ce-464d-b543-dc22cb1088e6"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2392), "192.168.1.48", (byte)2, 8.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d5515357-59be-4d4d-88d6-40f125275b9b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3555), "192.168.1.80", (byte)3, 37.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d579cc62-6a96-4741-b622-a8eb9a3edd3a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3599), "192.168.1.42", (byte)3, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d5989102-5ae8-478e-8ca5-4374e8a6f339"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2664), "192.168.1.71", (byte)2, 9.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d59e6341-e992-4096-b9d7-5fefb924841b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3575), "192.168.1.10", (byte)3, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d63e1e9e-271d-4841-a50b-81e3732fc077"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4022), "192.168.1.39", (byte)3, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d6867238-e22c-43c8-946a-23b49d8d9d36"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4372), "192.168.1.20", (byte)3, 60.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d720c54e-6b8c-4576-85d0-f1bcfcb92a91"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1624), "192.168.1.29", (byte)1, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d7614d94-09af-4acb-9c6d-af8085e7d418"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1551), "192.168.1.65", (byte)1, 44.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d7edde7c-95f6-47a1-93fc-08df39924bd1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2932), "192.168.1.34", (byte)2, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d7ef9f62-2ca4-4fcf-bbdf-c2c9acdf3979"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3433), "192.168.1.64", (byte)3, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d8004ef6-fada-4092-8db7-ee4cddc608fc"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4083), "192.168.1.10", (byte)3, 71.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d819c5b7-ec08-4a24-9d80-131738f5252e"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1522), "192.168.1.23", (byte)1, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d8695f83-3c02-4ece-81cd-5e8cf6bc6584"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1376), "192.168.1.80", (byte)1, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d94ec4ff-f13f-4cbc-8fca-d5c4579a3aac"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3099), "192.168.1.55", (byte)2, 68.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("da4d19ff-dc60-4b2b-aa37-732f8ac437c1"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4112), "192.168.1.63", (byte)3, 12.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("da787f25-a46e-483d-b203-f6ad3c94bea2"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3466), "192.168.1.14", (byte)3, 7.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("da79f50d-c498-4a55-8366-3d2647f46c4b"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1207), "192.168.1.4", (byte)1, 76.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("da817f72-ac3e-4cc3-bc1f-fe7353c70d9a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2919), "192.168.1.69", (byte)2, 90.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("da9afae5-cd9a-42e0-881d-8a611070a655"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1463), "192.168.1.13", (byte)1, 66.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("daaaa62f-9606-4010-b018-4ef698f9ce62"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3645), "192.168.1.24", (byte)3, 19.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("dab585aa-bdce-42c2-bc2a-0adf14c05ba0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1686), "192.168.1.13", (byte)1, 75.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("dba1b113-94d0-4ddd-8840-0ec16f606a3d"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3755), "192.168.1.85", (byte)3, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("dbe1b11f-30d2-4699-8c40-3d633f57e842"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3620), "192.168.1.74", (byte)3, 75.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("dbecf02e-972f-46f6-b09e-1a382e493f6c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4409), "192.168.1.5", (byte)3, 39.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dc1037ad-6c74-47a9-9139-6dc74c0b0aac"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2222), "192.168.1.22", (byte)1, 99.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("dc6dac85-e21f-4172-804f-607c4c4c5fa6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3653), "192.168.1.85", (byte)3, 96.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("dd40259d-4a55-4dfb-9271-0225aff33abf"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3173), "192.168.1.41", (byte)2, 43.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("de3c9a9a-1bb5-4339-81f8-dd0daaf7a06e"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4286), "192.168.1.61", (byte)3, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("de924406-f3fb-4c21-a01f-a1f36d660106"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1978), "192.168.1.2", (byte)1, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("deb7f712-b7a4-448e-97fe-aa306051e8f1"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3021), "192.168.1.89", (byte)2, 0.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ded9309d-6c3b-44dd-a9f6-a3662c3517f4"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3412), "192.168.1.97", (byte)3, 62.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("defe2306-1dd1-4509-b268-0b5a3db9e06f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3718), "192.168.1.69", (byte)3, 6.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("df360c8c-56b5-475c-bd34-958e94d55429"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1722), "192.168.1.89", (byte)1, 49.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("df43c685-4e27-4451-8f54-0352048cb44f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3310), "192.168.1.89", (byte)2, 90.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e00a2556-12cd-49c0-9604-c331047d87ab"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4185), "192.168.1.51", (byte)3, 69.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e0857db6-5e69-425e-8875-a988b9f39843"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1690), "192.168.1.90", (byte)1, 58.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e16d9f32-69ea-48db-9524-f84e36926ae6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2133), "192.168.1.36", (byte)1, 14.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e2385edf-bf4e-4998-b3ab-f50a27d49eda"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1934), "192.168.1.1", (byte)1, 36.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e263f4cd-1dfc-4930-b495-e74f43549311"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4412), "192.168.1.65", (byte)3, 15.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e29ce005-3324-45d9-b6f5-d7cfe3143ff3"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3921), "192.168.1.75", (byte)3, 41.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e2c82501-f447-46aa-9a4c-4d41869c55cd"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3009), "192.168.1.12", (byte)2, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e2d41788-d47b-4b31-b657-524a1a3594a2"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3961), "192.168.1.11", (byte)3, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e2f25275-baf9-4278-b9bf-ea1e48b884a9"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3135), "192.168.1.69", (byte)2, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e2f326b8-2060-4836-b014-89b9d936ff65"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2976), "192.168.1.18", (byte)2, 22.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e3469e87-7395-41ce-ae16-a4700cc98214"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2186), "192.168.1.87", (byte)1, 65.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e3980e94-b517-46a0-9f32-ad08817453a0"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3905), "192.168.1.68", (byte)3, 50.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e3ea1342-b9f4-4efa-b2fb-482bde5ae0d2"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1861), "192.168.1.92", (byte)1, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e419c251-548e-4865-9cec-ca0b3bbee3db"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2566), "192.168.1.66", (byte)2, 64.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e450e245-394e-4f0f-b1fe-48448cea14d9"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3567), "192.168.1.89", (byte)3, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e4a04e84-c6e9-4b3e-bf43-1b076907b158"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1384), "192.168.1.3", (byte)1, 35.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e4ce5562-de49-4032-a2be-4e0096061eb0"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3852), "192.168.1.59", (byte)3, 81.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e4dfbf2a-f3c4-46de-a5a4-cd36c8f10c0f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2501), "192.168.1.97", (byte)2, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e5027d41-6fab-44a2-bcd9-f74cac8f9a54"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4043), "192.168.1.13", (byte)3, 39.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e51f1a18-9850-4c24-935d-fab4a00a1a72"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4368), "192.168.1.86", (byte)3, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e53ed32c-1b7f-4a87-a6cd-b49f9ba67466"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1673), "192.168.1.45", (byte)1, 7.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e595968e-cd40-490e-b5fb-bf6845e9aadd"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3681), "192.168.1.47", (byte)3, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e605fe9d-a4e7-4bd2-9874-6581151c19d9"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2803), "192.168.1.93", (byte)2, 40.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e66a691f-3b73-41c4-84a6-b5212bb3402a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4294), "192.168.1.27", (byte)3, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e676e8fd-1871-4c2f-8325-dbdc9ea1a013"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1543), "192.168.1.4", (byte)1, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e692fb1b-ab68-463d-8b63-b360076db379"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2811), "192.168.1.79", (byte)2, 5.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e6c9e096-6cc8-4c31-a2fb-4e4b29c44507"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1957), "192.168.1.28", (byte)1, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e794cb14-b5ec-470f-9797-b082e090f487"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2944), "192.168.1.23", (byte)2, 48.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e8013861-7145-4542-aef0-adc79ff28c7c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4095), "192.168.1.18", (byte)3, 99.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e801e2e0-4a40-4b6a-9d20-fdfffa5a6cd0"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3079), "192.168.1.28", (byte)2, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e84089f1-6db3-487d-94aa-20c4f7a8dc20"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2218), "192.168.1.6", (byte)1, 22.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e85706b4-3350-46dd-bed6-7fc6f7283c52"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2367), "192.168.1.44", (byte)2, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e85aa3cd-44e9-4203-80d6-ff4c941b7586"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4416), "192.168.1.38", (byte)3, 52.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e8a78ddf-78e1-455a-9d58-412e3821fd8a"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3909), "192.168.1.7", (byte)3, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e8c7260d-c3df-4928-979f-1cd197fadf12"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1803), "192.168.1.96", (byte)1, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e925c54a-af27-40e4-b4ea-b489b2e3b889"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1276), "192.168.1.68", (byte)1, 40.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e92d6d63-5e1d-4713-bbd2-11629579c1d8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3559), "192.168.1.32", (byte)3, 45.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e9dda61e-b460-4e8b-a0d4-895bea85618b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2856), "192.168.1.95", (byte)2, 49.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ea0c6ea9-694d-4f98-9a15-68d3eac3a70d"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3953), "192.168.1.59", (byte)3, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("ea103ef6-6085-4fb0-af24-a26ddc4a5899"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2336), "192.168.1.9", (byte)2, 10.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ec3c0653-1ebf-4c3f-b3b0-68a2df6d9bfc"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3538), "192.168.1.56", (byte)3, 28.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ecdcafbb-5e02-4428-8a24-8b3a5adbb77a"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2262), "192.168.1.45", (byte)1, 70.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ecfb7586-d02c-4dba-95b1-3f77eafab0f8"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3855), "192.168.1.74", (byte)3, 1.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ed5c2463-0c1d-4f15-a7e5-ede7c1436836"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4229), "192.168.1.4", (byte)3, 79.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("edddafc7-4cf1-48e2-995b-a2bd746a27d6"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1263), "192.168.1.67", (byte)1, 74.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("ee14fb6b-c7ab-4bdb-85d9-0a787761554d"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3131), "192.168.1.84", (byte)2, 44.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ee2c4335-db71-4ae8-9f36-9457e8de289c"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2332), "192.168.1.73", (byte)2, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ef55f9f8-45cd-4ab3-9d58-3ae42576b1a5"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3250), "192.168.1.25", (byte)2, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ef599230-1a58-415f-9deb-10b2eff39b20"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3542), "192.168.1.38", (byte)3, 53.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ef8b5078-e854-4284-81ac-6af6e1d87531"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2524), "192.168.1.7", (byte)2, 93.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("efa00165-cae1-4d05-9e0b-df032d46872f"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2885), "192.168.1.18", (byte)2, 46.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("efb335a0-87cd-4686-87cf-ec28fba752dc"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1475), "192.168.1.62", (byte)1, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("efd8f0a3-c6ec-46a7-986c-15a2a07a4005"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2557), "192.168.1.24", (byte)2, 15.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f0bbef9a-76b2-4fa9-a4a7-2836c9197d64"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3817), "192.168.1.38", (byte)3, 69.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f0eeb350-9415-4a65-b065-0d8b75dae27a"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3221), "192.168.1.71", (byte)2, 99.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f10f23ca-59e4-42ae-a15d-0ecde69a8e9c"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3327), "192.168.1.90", (byte)2, 84.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f11a1d1a-db1c-4fc3-a947-5da323e954cb"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3896), "192.168.1.25", (byte)3, 5.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f1a62140-1646-48df-ae5a-5fbc5d9b8132"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4062), "192.168.1.72", (byte)3, 63.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f1c658db-e807-40bf-85fe-48e27f922a29"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1608), "192.168.1.2", (byte)1, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f2bfc76e-2a30-4ae6-8666-1baf2aba8846"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2378), "192.168.1.41", (byte)2, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f33cee67-0a3b-4f3d-bb89-757942a7175c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3367), "192.168.1.48", (byte)3, 49.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f491239b-8e3c-4afb-a16c-7495135729e0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1901), "192.168.1.30", (byte)1, 6.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f4dbb951-2ba8-48ec-b5f2-1318bd824bb0"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2138), "192.168.1.69", (byte)1, 93.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f503d36a-14b2-46d0-8512-da69c6fb37f4"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2480), "192.168.1.88", (byte)2, 35.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f5b3e230-004b-4fb7-a7b9-788c2762a578"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3477), "192.168.1.99", (byte)3, 61.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f5f014a3-44ca-4c7d-8827-7f98971776ea"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2110), "192.168.1.58", (byte)1, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f6f0b2e7-b86e-46f4-8628-c522b88f0ff2"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4135), "192.168.1.27", (byte)3, 11.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f6f0f059-a16c-4a12-a02d-794191a25f4c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4307), "192.168.1.22", (byte)3, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f7364cff-0f6c-45d2-9622-a273968bd12b"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3070), "192.168.1.25", (byte)2, 49.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f76346ec-39fb-424b-a3b9-fc8e21fe3a40"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2578), "192.168.1.35", (byte)2, 1.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f79579e6-9e6d-44a0-84a2-772a6aa2e182"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3986), "192.168.1.62", (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f7be0f54-5dc9-45b0-8b57-316cd9b03983"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2553), "192.168.1.86", (byte)2, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f7fc37ba-e800-487a-ac8b-52af1539a554"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3302), "192.168.1.91", (byte)2, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f82dced4-757e-4b29-9bd6-482c872736a0"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3141), "192.168.1.62", (byte)2, 6.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f86bb6db-124d-4356-a4a3-f4c1bfd700c6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4005), "192.168.1.14", (byte)3, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f88cdede-b854-492d-a875-47b55b8e646f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3848), "192.168.1.23", (byte)3, 83.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f8d3dd87-ccad-4e5a-8388-47adf8815369"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3949), "192.168.1.47", (byte)3, 24.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f8f3c6d8-e0c1-46a2-b87a-f215671acefe"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3473), "192.168.1.32", (byte)3, 35.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f928f4f9-0998-4c39-9d44-9a1b9e16d8d2"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1661), "192.168.1.15", (byte)1, 21.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f937a533-a75a-47e7-b206-b561bc8d0729"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2484), "192.168.1.72", (byte)2, 8.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("f93f5e73-52b1-4997-bb4c-0de9ec2cf7c7"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3880), "192.168.1.30", (byte)3, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("f964acdc-2805-437e-978d-8c7d2485904b"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3800), "192.168.1.97", (byte)3, 2.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("fa7fb106-6abe-4ffa-bf21-de8464305448"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3038), "192.168.1.97", (byte)2, 80.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("fad2748f-1042-46bd-bdd0-266fab737654"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2363), "192.168.1.16", (byte)2, 25.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("fb8fc4e4-baa4-42a4-ad2b-35bab53e19d2"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3970), "192.168.1.20", (byte)3, 58.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("fbd5bc3b-6265-46ef-a40a-3045ca24dbbe"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2125), "192.168.1.9", (byte)1, 53.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fc24644e-3124-450c-b6ef-b550b9703fa4"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1410), "192.168.1.64", (byte)1, 7.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fc3ac31a-81de-42b2-927d-2fe46e3e45ce"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2386), "192.168.1.52", (byte)2, 58.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fcf46c42-ba75-4417-854a-b97f8352c05e"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3233), "192.168.1.9", (byte)2, 86.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("fd7f07d3-5348-40b0-a036-5bceb29d558c"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4300), "192.168.1.44", (byte)3, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("fd9495c5-6735-4e18-ba1a-6892cb8e4eed"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3632), "192.168.1.83", (byte)3, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("fe0ac4f9-6c91-47c5-a5ed-251ca06e519f"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3739), "192.168.1.69", (byte)3, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fe40b6f3-3dc3-4b66-957a-7e12c1e791f0"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2574), "192.168.1.56", (byte)2, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("fe9d43c2-e53d-4d13-981f-29ed374c36a5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(1526), "192.168.1.21", (byte)1, 97.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("feae89ed-8559-4b5b-bfa7-aafe51f066e8"), "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2980), "192.168.1.7", (byte)2, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("fec6a8c9-3a91-41e6-b283-d5d508c739da"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4091), "192.168.1.37", (byte)3, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fedaf755-1f4c-4ec1-b21b-0ca30e089ef6"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(3877), "192.168.1.16", (byte)3, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ffe5f949-d38b-4f3f-ba55-455d90898961"), "Computer2", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(4376), "192.168.1.90", (byte)3, 53.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("fffc640c-bece-4863-848c-b85279e284e5"), "Computer0", new DateTime(2024, 2, 15, 13, 53, 19, 278, DateTimeKind.Utc).AddTicks(2247), "192.168.1.28", (byte)1, 18.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ParentStudents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1") }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("1434a1e1-acd4-41d0-9816-c785a49fccf6"), "4-C", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(401), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("1466eb1b-f73f-4707-b2f9-b1e50268a76f"), "", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(369), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("1e2c080f-b98a-47a3-b4cf-829b9715daaf"), "", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(372), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("5229d5cd-eb9d-4696-8e03-05094c1d8479"), "1-A", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(351), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null },
                    { new Guid("584a1c43-0f6b-46fa-abad-941dd0697ec2"), "2-B", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(361), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null },
                    { new Guid("707ecc01-854a-4b9a-bb36-158076acac0c"), "", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(396), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("75adb13e-1d6b-49f2-a123-acc5c61c3c16"), "1-A", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(375), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("867fb0b5-cd0a-4afc-9bd4-6d9deddb2e61"), "2-B", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(358), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("87a43dcc-29dc-420a-a7ac-05be52e36ba5"), "", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(399), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("941e265e-7f72-4ec9-82ba-d82c97401f70"), "1-A", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(378), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null },
                    { new Guid("99a02493-1db5-4498-a81e-cd0c90acc971"), "1-A", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(345), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("9d1c1f90-e55b-4e88-82e6-20797562c626"), "3-D", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(367), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("b110e1b4-6927-4c41-a518-bfc0a944de1a"), "3-D", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(363), "192.168.1.1", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("c60d48af-4ed6-4f53-badc-5e094581040f"), "4-C", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(404), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("d4809337-f3bc-4f18-8a3b-76f89d0360d3"), "2-B", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(382), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("e835c42e-ee95-4ac0-b0b5-f801b90e85e7"), "2-B", "Computer1", new DateTime(2024, 2, 15, 13, 53, 19, 279, DateTimeKind.Utc).AddTicks(385), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null }
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
