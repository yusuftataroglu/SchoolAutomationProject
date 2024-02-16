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
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(6794), "192.168.1.3", "10-A", null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(6793), "192.168.1.2", "9-B", null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(6790), "192.168.1.1", "9-A", null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(6796), "192.168.1.4", "10-B", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1965), "192.168.1.1", "Matematik", null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1967), "192.168.1.2", "Türkçe", null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1969), "192.168.1.3", "Biyoloji", null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1970), "192.168.1.4", "Fizik", null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1972), "192.168.1.5", "Kimya", null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1975), "192.168.1.6", "Tarih", null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1976), "192.168.1.7", "Coğrafya", null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1978), "192.168.1.8", "İngilizce", null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1979), "192.168.1.9", "Müzik", null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1982), "192.168.1.10", "Görsel Sanatlar", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3010), "192.168.1.3", "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3022), "192.168.1.8", "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3014), "192.168.1.5", "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3008), "192.168.1.2", "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3012), "192.168.1.4", "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3023), "192.168.1.9", "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3018), "192.168.1.6", "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3020), "192.168.1.7", "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3026), "192.168.1.10", "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(2999), "192.168.1.1", "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3800), "192.168.1.5", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3798), "192.168.1.4", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3794), "192.168.1.2", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3790), "192.168.1.1", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3796), "192.168.1.3", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
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
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4804), "192.168.1.11", "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", "110-24", null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4790), "192.168.1.6", "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", "105-24", null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4775), "192.168.1.1", "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", "100-24", null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4792), "192.168.1.7", "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", "106-24", null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4806), "192.168.1.12", "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", "111-24", null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4795), "192.168.1.8", "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", "107-24", null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4801), "192.168.1.10", "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", "109-24", null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4784), "192.168.1.4", "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", "103-24", null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4787), "192.168.1.5", "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", "104-24", null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4778), "192.168.1.2", "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", "101-24", null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4781), "192.168.1.3", "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", "102-24", null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(4798), "192.168.1.9", "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", "108-24", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5635), "192.168.1.13", new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5611), "192.168.1.2", new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5642), "192.168.1.16", new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5638), "192.168.1.14", new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5623), "192.168.1.7", new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5613), "192.168.1.3", new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5629), "192.168.1.10", new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5644), "192.168.1.17", new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5649), "192.168.1.19", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5633), "192.168.1.12", new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5627), "192.168.1.9", new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5646), "192.168.1.18", new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5617), "192.168.1.5", new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5616), "192.168.1.4", new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5639), "192.168.1.15", new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5631), "192.168.1.11", new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5620), "192.168.1.6", new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5608), "192.168.1.1", new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5625), "192.168.1.8", new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(5651), "192.168.1.20", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "FirstName", "LastName", "MainCourseId", "Title", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6456), "192.168.1.5", "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6462), "192.168.1.10", "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Uzman Öğretmen", null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6464), "192.168.1.11", "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6448), "192.168.1.2", "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6454), "192.168.1.4", "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6452), "192.168.1.3", "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6443), "192.168.1.1", "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6470), "192.168.1.13", "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6467), "192.168.1.12", "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Başöğretmen", null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6472), "192.168.1.14", "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Uzman Öğretmen", null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(6460), "192.168.1.6", "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("0372143e-383d-42a7-abdc-d501f9fe43b3"), "Computer58", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4868), "192.168.1.18", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("0ada9607-8cf3-49dc-9cb2-89391ded1403"), "Computer60", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4876), "192.168.1.60", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("154fcb7b-85f6-437d-af46-da0ee82720fd"), "Computer40", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4785), "192.168.1.4", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("15d5910b-3e59-4331-936f-7533923657ea"), "Computer44", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4800), "192.168.1.68", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("161b76ec-079b-4f9d-954d-6858b24a7828"), "Computer15", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4673), "192.168.1.90", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("1c6ba9d2-1604-4107-adef-586e50b9328b"), "Computer13", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4662), "192.168.1.87", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("1f9af2ba-b8b3-406c-b081-80e31a14f833"), "Computer36", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4767), "192.168.1.76", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("2d8a545b-5303-49d0-b58d-f6f9b8bfbece"), "Computer19", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4695), "192.168.1.43", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("33441d0e-7db5-4dbb-b71d-8466c5943757"), "Computer34", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4759), "192.168.1.4", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("401524b0-1064-4985-b08d-bfb40ba966f3"), "Computer18", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4691), "192.168.1.92", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("40f827be-a5c8-4109-b223-fd9af2fdc48d"), "Computer43", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4797), "192.168.1.75", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("41d03e0d-0a18-48d8-ad96-e492d7defcd3"), "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4618), "192.168.1.46", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("4d6a5539-3f7d-4d34-b6bf-b118a7d5c916"), "Computer46", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4811), "192.168.1.87", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("4ffc0d62-8df8-4674-8612-652c8a47c5bb"), "Computer11", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4653), "192.168.1.25", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("5a5916df-6932-4433-bb80-46a4eceae0f6"), "Computer41", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4788), "192.168.1.34", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("61773fd6-5c85-461c-b057-01c4ae2fc3d1"), "Computer26", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4725), "192.168.1.38", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("65e3ac85-7142-4e53-9794-827620c3df0a"), "Computer9", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4645), "192.168.1.58", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("68247dbf-549f-4019-bb1f-a3329b5513cb"), "Computer50", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4834), "192.168.1.46", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("691fdcad-6408-43df-9d0c-d78140e66fcd"), "Computer45", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4805), "192.168.1.52", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("6a0da5aa-b9b3-46a4-9d48-25ef82e3abab"), "Computer33", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4754), "192.168.1.41", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("6b121f7d-de5e-40d6-ae50-26a0c78e2746"), "Computer24", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4717), "192.168.1.27", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("6cc8e0d1-ed5a-46fd-b621-681adf89d9c4"), "Computer30", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4742), "192.168.1.98", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("6d53e0aa-b903-40da-b792-e5e44a603c5a"), "Computer57", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4864), "192.168.1.57", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("6d647a45-870f-4455-bbdb-9081fbe9bf49"), "Computer47", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4815), "192.168.1.92", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("707bc523-59b5-4d3e-9ade-81ad066a7131"), "Computer20", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4699), "192.168.1.42", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("7cff7a4f-c35f-49e6-927a-ee9095b63ccb"), "Computer23", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4713), "192.168.1.45", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("7fe8f1b3-2795-48c8-83d6-1ecc1ad5c74e"), "Computer49", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4830), "192.168.1.54", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("81969769-c0f5-40dc-ba2f-0b2717b30164"), "Computer35", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4763), "192.168.1.39", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("8514ed25-ce3d-44fb-a8ae-c58cedb609e9"), "Computer29", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4736), "192.168.1.24", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("8bdb511e-e878-435b-b81e-940e91f5446a"), "Computer7", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4637), "192.168.1.56", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("8eb57426-33de-4807-a6b6-f5347d532503"), "Computer48", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4826), "192.168.1.8", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("91fc2c8b-378a-4d94-9b0d-15c70d037bfc"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4605), "192.168.1.76", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("93593d8e-6296-4ace-b241-0e485da48179"), "Computer54", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4852), "192.168.1.13", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("93e12280-c5ed-41ad-a0bc-e715d6219e4a"), "Computer53", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4846), "192.168.1.3", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("97cf5f9a-d2f1-45ba-b304-b9f410222e09"), "Computer42", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4793), "192.168.1.29", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("9f46cecb-7523-4255-b02c-14cfd5ef2460"), "Computer37", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4771), "192.168.1.47", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("9ff055d3-9254-4cf2-9151-f2a40889feab"), "Computer12", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4657), "192.168.1.8", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("a14d2360-69ae-4243-9297-3fbeb689c1a3"), "Computer28", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4733), "192.168.1.31", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("a8cc6f47-a7cf-40a9-9bd0-7baa9f1ded14"), "Computer59", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4872), "192.168.1.6", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("a934f14e-988a-48ad-aae6-3b26adac6e16"), "Computer14", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4669), "192.168.1.14", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("ac42a6b0-d360-403c-9aa6-005ba0fde83e"), "Computer52", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4842), "192.168.1.3", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("af5edab3-b550-4036-9367-7da88c1c3437"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4574), "192.168.1.7", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("b3912cdf-f9dd-443e-a188-a8d52f3ae906"), "Computer25", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4721), "192.168.1.95", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("b3ed1c55-144b-457a-b7d4-55fff8b88dcf"), "Computer31", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4746), "192.168.1.99", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("b92c67d3-9428-4da6-83d6-8723fd06c889"), "Computer10", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4649), "192.168.1.24", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("c60518f1-488f-4815-b43a-6fa161b94e84"), "Computer51", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4838), "192.168.1.96", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("c6cfc68a-cb6a-47b0-a3d9-4dae02fc8771"), "Computer56", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4860), "192.168.1.63", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("c761bf58-895c-400c-b208-53a4326201aa"), "Computer8", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4641), "192.168.1.75", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("c7b29b00-bcb2-486b-b632-b5444ed830e0"), "Computer39", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4781), "192.168.1.94", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("c9c7c6fa-756e-4627-a14d-9fd162580105"), "Computer6", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4633), "192.168.1.23", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("c9c7e836-9b78-4532-b71c-b2680cfddcb5"), "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4609), "192.168.1.22", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("cc160f3a-6396-4ef3-8150-636bbde8a597"), "Computer38", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4777), "192.168.1.12", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("ce6ff3c4-b851-4024-813d-ad61a128eeb2"), "Computer55", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4856), "192.168.1.40", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("d33f3777-b4b0-44eb-a9d5-95dd268eaa9d"), "Computer32", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4750), "192.168.1.99", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("d731535b-d8f7-4e8e-a724-4d14bd289eb9"), "Computer17", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4681), "192.168.1.74", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("d9878881-187b-47bf-810c-980a1581170b"), "Computer21", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4703), "192.168.1.14", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("e213cbd3-f843-4f92-b1df-2f6fa456585c"), "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4614), "192.168.1.43", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("e7c50e63-5b57-47b9-9fa8-55fd1ed77692"), "Computer16", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4677), "192.168.1.75", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("ec868554-f2d8-420a-a926-2b870716ad7b"), "Computer27", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4729), "192.168.1.61", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("f9cfd241-07f9-4e66-bb19-e68b7bfc1005"), "Computer22", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(4709), "192.168.1.60", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("16bbc5c1-ba61-4bb0-81f4-5f5b3e181d91"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5818), "192.168.1.31", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("36e7e1e3-80ff-498c-9237-335287c6cd35"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer15", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5905), "192.168.1.21", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4690add9-de11-43b1-9c3a-91ff30f890c0"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer17", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5915), "192.168.1.1", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("476c368d-4de2-4384-9dd4-7f84d7e0726a"), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer3", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5823), "192.168.1.22", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("47ae3ec6-4f8b-46ee-9986-42e13dd86030"), new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer16", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5910), "192.168.1.4", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4c0d37ea-72fa-47db-b25c-88a0465ab16e"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer14", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5899), "192.168.1.80", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4db04576-527c-4ad5-83df-04dbdd977b46"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer4", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5830), "192.168.1.47", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("559ddb19-f620-4a57-b7a5-c0d0f0f0f89e"), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer25", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5957), "192.168.1.87", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("56716a3c-2ca8-4057-9111-95df61f2e944"), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer18", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5922), "192.168.1.1", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("653b3bac-1d24-43d4-a16c-b68096370fb4"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer21", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5935), "192.168.1.75", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("79a7013b-2ee1-4e99-a22b-39e9be40d23d"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer19", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5926), "192.168.1.75", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7f63cbee-c60e-4c15-b18e-bd9f02e15803"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer7", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5852), "192.168.1.62", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8bf8ba2d-c071-436a-abe6-7d2b16d7a8d4"), new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer22", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5940), "192.168.1.36", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("90f8fbf2-f6a4-48f0-b8ef-3f63bca1ec74"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer5", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5835), "192.168.1.89", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("96b8bcb4-4ca0-42dc-a8ad-42fdcc93081c"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer29", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5981), "192.168.1.74", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("977c04ae-412c-45f6-9f47-b5493524c1f9"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer8", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5857), "192.168.1.82", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a17b2faf-3ca5-4db1-9abb-4e7bbe19c86e"), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer32", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5998), "192.168.1.41", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a560c505-aeb8-439f-ba72-81e72adba487"), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer31", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5992), "192.168.1.71", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("aaece8e6-19da-49f3-a84d-f23852d3a22a"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer28", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5973), "192.168.1.89", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ada42f67-a979-419f-89f5-bddc8a82f03c"), new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer6", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5842), "192.168.1.63", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b0bb6349-e4d6-4a83-9239-be810a800627"), new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer23", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5947), "192.168.1.77", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ba75bbe5-8a68-42f2-b90e-6bb97d4c2774"), new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer13", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5894), "192.168.1.69", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("bfad2ad3-385e-4ace-bdc1-e76457938f1c"), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer11", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5874), "192.168.1.76", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c3ef1917-bea1-449c-b0da-0bdd0d00cb7a"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer26", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5963), "192.168.1.71", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cdcac4b0-1a16-4261-ba05-6498a5fdcb4e"), new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5986), "192.168.1.29", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d6608507-b0db-4625-94f4-f6ef6a9edab6"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer9", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5863), "192.168.1.4", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d726bf5c-6f1b-4b3b-a2b2-c846f207cee2"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5802), "192.168.1.46", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e06d6479-4bd8-450f-a02d-f0879d7b90cc"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer27", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5967), "192.168.1.55", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e12b8050-e238-47bb-9d43-2fd2b57f71f2"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5813), "192.168.1.95", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e71d930b-ab6f-47c3-aa4a-a5fb93b2005d"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer24", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5951), "192.168.1.47", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("eec78c8b-283d-4383-83c8-49a5c2eae0a3"), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer20", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5931), "192.168.1.49", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f24ff93b-cc77-42d8-83ef-9d2d7966fb66"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer10", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5868), "192.168.1.89", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f46fa385-dec1-44ed-8d17-8f394943b654"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer12", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(5878), "192.168.1.24", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("fda0e543-0401-4f92-a1b7-2a50eecf605d"), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer33", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(6005), "192.168.1.17", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null }
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
                    { new Guid("765d7859-15c1-47dd-b06a-0e0fc302ae5c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(8084), "192.168.1.49", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null },
                    { new Guid("c33e2728-233f-4030-bbce-b6cd6b8d1696"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(8064), "192.168.1.83", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("003456a8-653b-4459-aee2-0dfbb48b9a4c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9232), "192.168.1.80", (byte)2, 17.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("00ec7918-5b02-4050-b3a4-6c1c2dd1014b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9487), "192.168.1.46", (byte)2, 72.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("016efedd-6726-4725-88bd-40da6edf6dd4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8061), "192.168.1.72", (byte)1, 81.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0179eb88-0a42-4ce4-8e8c-6e5a7cb1dc43"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8957), "192.168.1.99", (byte)2, 89.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("01f99e1e-cb0b-49e1-8eb2-64ce43036b33"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9024), "192.168.1.13", (byte)2, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("0218c2fd-a811-4a23-b268-0381c1567699"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8917), "192.168.1.17", (byte)2, 67.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("02ce3292-4a6d-4f36-81c7-ceb6e9f02e7b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9824), "192.168.1.28", (byte)2, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("034a0270-cae0-439d-888b-e1cce9dbf154"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(411), "192.168.1.2", (byte)3, 65.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("03c02321-2414-4b55-9fb2-775112a0d273"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1018), "192.168.1.41", (byte)3, 40.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("047c659d-0f78-413f-a643-83cc0e8272af"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8099), "192.168.1.64", (byte)1, 10.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("04948e7b-fe31-4321-a83c-7e088c0722d8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8215), "192.168.1.56", (byte)1, 62.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("04df89c4-f341-4ed1-b7a4-2bf9026cc9f4"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(466), "192.168.1.58", (byte)3, 24.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("051989a0-d777-4159-9e41-b6e339ff79ea"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9574), "192.168.1.45", (byte)2, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("053f574c-4e9c-44a1-90ed-b0e9eaf5e9b6"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(728), "192.168.1.24", (byte)3, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0544f04e-a177-4a91-b3c6-40df75df8d37"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(121), "192.168.1.61", (byte)3, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("05d585f8-b851-45d3-89d6-aba68b82beaf"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(989), "192.168.1.49", (byte)3, 19.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("05dd43b4-1138-4fba-a175-ca477c0a833b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8377), "192.168.1.96", (byte)1, 80.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("06dadfdd-ae7b-40f8-bf4b-d8e625ef30e3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(36), "192.168.1.10", (byte)3, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("06e4c612-97e2-48cc-b49b-5cda350b7889"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8913), "192.168.1.23", (byte)2, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("075a5c80-74a9-4568-bc1b-fe8ea9b3bd44"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9820), "192.168.1.22", (byte)2, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("079a7282-553b-44d6-ad4b-bb9713111e75"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9524), "192.168.1.36", (byte)2, 48.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0842ef4f-942a-466f-a8c8-4c6a504584f9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9727), "192.168.1.80", (byte)2, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0a449d8f-940e-4e7a-8228-29c6c19c1890"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7732), "192.168.1.31", (byte)1, 59.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0ab7e498-d4cf-4d3b-a0b4-343b7109572e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8066), "192.168.1.71", (byte)1, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("0b60de05-e33e-46cd-9931-2ede9785a788"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9869), "192.168.1.7", (byte)2, 60.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0bf40d75-1d77-414d-bc8e-e6a601b4d423"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(721), "192.168.1.42", (byte)3, 73.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0c0aa198-0710-4f66-a011-66b797498414"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(683), "192.168.1.69", (byte)3, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0cac1ddb-cd84-4234-8f7d-16bc923ac742"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(154), "192.168.1.18", (byte)3, 31.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("0d4099e3-c661-45e0-b06f-b27baed549ff"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(795), "192.168.1.70", (byte)3, 55.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0ea34080-60e0-4f75-a340-52a7322672b1"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9662), "192.168.1.60", (byte)2, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0f1ba268-e708-42ce-a15e-d3d05a6376fd"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9057), "192.168.1.85", (byte)2, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0f427968-69aa-4f90-ae48-a328ac0f85aa"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(873), "192.168.1.47", (byte)3, 25.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("109168f8-f44c-4718-a5d8-7dbf6aa419b9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8965), "192.168.1.10", (byte)2, 10.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1180c2ff-7ddc-46f9-a2f0-0e34a2b00a3c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9271), "192.168.1.40", (byte)2, 24.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("118a2c10-9f70-4d0d-8020-1325921eeff5"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8005), "192.168.1.46", (byte)1, 50.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("11aea2d0-4263-4458-8cc6-bdd03d1b1dfa"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8895), "192.168.1.23", (byte)2, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("11bbd196-0d07-4a68-a961-7ba1a1baf66b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(899), "192.168.1.93", (byte)3, 21.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("125f4008-0e15-4b54-a0bb-b8b51f927cca"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9457), "192.168.1.6", (byte)2, 45.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("12752f2b-370e-4a26-9e3c-5af88a625a41"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8430), "192.168.1.72", (byte)1, 71.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("129249a1-bd4e-4e68-894d-08bd375d47d7"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7817), "192.168.1.80", (byte)1, 57.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("12fd2324-a220-4046-8a9e-432c74b3524b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8373), "192.168.1.24", (byte)1, 76.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("13566636-1f81-4318-bd7e-ad828908615d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9761), "192.168.1.92", (byte)2, 76.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("135b5273-4d01-4c64-90da-704cb510bbaf"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(83), "192.168.1.50", (byte)3, 79.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1466a5ad-9d57-4d11-9277-9041400fe8e0"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(69), "192.168.1.24", (byte)3, 70.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("14aea2f3-30eb-4bb6-852b-cb9319fcd706"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8111), "192.168.1.7", (byte)1, 90.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1535487f-5e24-483e-b960-4369d4ea51b9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7968), "192.168.1.63", (byte)1, 57.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("162f244e-3365-4f57-b1b2-b4890d965ced"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8741), "192.168.1.74", (byte)1, 20.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("167c119f-6346-4ef4-878f-5e90aeac5341"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9586), "192.168.1.21", (byte)2, 65.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("16c705fb-cd71-4c2b-aa5d-6b714ef1e016"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8505), "192.168.1.39", (byte)1, 2.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("16c8a7bd-e3b8-493c-a7cf-746ea002b5c3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(400), "192.168.1.24", (byte)3, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("16f8c953-675c-430f-a8cb-a8650a8bc588"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(32), "192.168.1.64", (byte)3, 7.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("170abc1a-083e-4038-a579-12ee3ebcb60d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(928), "192.168.1.67", (byte)3, 82.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1740ed90-b35c-4d2e-a255-b4f6be91bf55"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9741), "192.168.1.58", (byte)2, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("177a3985-6ef2-4527-bc93-d077bdd5a8dd"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9275), "192.168.1.76", (byte)2, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("185f96f2-dc12-4c20-92de-b2bf275f405a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9637), "192.168.1.66", (byte)2, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("18c2a3b8-7fdc-44e5-848a-05cd98638f04"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8978), "192.168.1.91", (byte)2, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("18cfd79b-f8df-49fd-a827-ba1d3323eb48"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8961), "192.168.1.48", (byte)2, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("18d2be19-3239-47a6-97ea-84d9dd7c77d6"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9224), "192.168.1.10", (byte)2, 33.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("195f1e87-612d-47b7-8147-ff4af01cebca"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8357), "192.168.1.11", (byte)1, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1a069f0a-7dae-47d7-8989-1bc510a99aae"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9914), "192.168.1.82", (byte)2, 68.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1a3b9b95-0e4c-4ded-8094-871954a3ede5"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8808), "192.168.1.84", (byte)1, 40.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1a468721-959d-4988-9cbb-e255601bd63c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9006), "192.168.1.3", (byte)2, 49.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1a49a954-3540-4808-9339-188fe86529e9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9117), "192.168.1.70", (byte)2, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1a9b9023-6dee-4bbc-8d6e-f944327a05da"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8708), "192.168.1.36", (byte)1, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1ac3bfb9-e09a-431e-a08d-0e2f6fcaaed1"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(674), "192.168.1.38", (byte)3, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1aff7375-2f3b-4e68-98bd-49e4ce3232ac"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7851), "192.168.1.69", (byte)1, 66.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1ba00b59-6d9e-455b-80cd-5617ec115cbe"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9803), "192.168.1.18", (byte)2, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1bb4b930-159a-44b1-8ff7-0db732c0121b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8822), "192.168.1.87", (byte)1, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1c46eb26-437f-476b-a71d-59516a13fb2e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9453), "192.168.1.29", (byte)2, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1c557b31-5002-418d-8ed2-3f53ca78589d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9624), "192.168.1.85", (byte)2, 82.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1cde3fc8-c1d4-4a18-97f1-d3d0ed018e6c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9812), "192.168.1.49", (byte)2, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1decedc4-b9e3-4861-8125-fcceba939bae"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9446), "192.168.1.27", (byte)2, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1e2e926f-2c9a-4c24-8fe6-5e7ab6c7148d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(971), "192.168.1.90", (byte)3, 67.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1e322ea0-f630-4948-8cd5-92bf4e305341"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9061), "192.168.1.4", (byte)2, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("1ea24d33-efcc-4081-89a0-fdd5042aaf75"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9371), "192.168.1.66", (byte)2, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1f4f2161-3448-4498-b7c1-19a93ea09834"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8642), "192.168.1.27", (byte)1, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1f73ba48-0f4d-4a92-bfd2-8d5fdd3a8bdb"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8501), "192.168.1.88", (byte)1, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1fa2cfdb-4bbf-4347-afe6-e609a909de0b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9113), "192.168.1.26", (byte)2, 83.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1fb504f1-6e85-4f64-b53f-41683145eee3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(425), "192.168.1.49", (byte)3, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("20d2537c-cf9d-480e-983f-e7cb49bdcc59"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8872), "192.168.1.28", (byte)2, 25.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2110c626-d91e-4afd-8d34-b3840077d179"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(877), "192.168.1.74", (byte)3, 40.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("211cdef2-21b4-4b2d-b446-7feed912441a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(616), "192.168.1.10", (byte)3, 97.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("216b350b-b5f9-4e3b-a21c-50422ad40826"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8927), "192.168.1.77", (byte)2, 60.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("21eb572a-6ec9-46cd-84ce-1a4497e69d42"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9479), "192.168.1.14", (byte)2, 3.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2280e2ee-7bd7-4430-be9a-8eddee66a59a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9769), "192.168.1.42", (byte)2, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("22970950-9688-4db5-8c9e-05e7d5051943"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9384), "192.168.1.94", (byte)2, 7.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("229d6456-1fd9-427d-afc8-be2e8a19de0e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9890), "192.168.1.20", (byte)2, 77.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("22b3765c-1599-4daf-9566-f8893ae9fd10"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9719), "192.168.1.61", (byte)2, 30.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("23a6e72a-3527-4c48-baa7-9b491fe0d2db"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8779), "192.168.1.39", (byte)1, 90.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("23de8c4e-c6b7-4fa2-86aa-7899840fe5a8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8521), "192.168.1.73", (byte)1, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("255922fd-d29a-4290-9781-9a3631f6df3d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(881), "192.168.1.24", (byte)3, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("25d7c583-36cd-4d7d-9480-7acca1c19cad"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8454), "192.168.1.26", (byte)1, 45.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("25d9e015-6565-4d1c-b5b8-2d50ee51639d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9151), "192.168.1.63", (byte)2, 34.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("27770b59-69aa-411e-9923-6a14fc81f9c7"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(624), "192.168.1.29", (byte)3, 1.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("277773b9-1425-4125-ab39-c2c348c4defb"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8558), "192.168.1.11", (byte)1, 63.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("27bfb866-0e08-4e57-9eb4-d9aae3af7644"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9257), "192.168.1.14", (byte)2, 51.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("27f72428-5865-4e55-a8fd-56a34854e024"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9629), "192.168.1.2", (byte)2, 69.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("282d692e-2e9d-4a4e-bef0-7ee51d08c0ca"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8944), "192.168.1.75", (byte)2, 43.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("294681ae-4df0-4862-8f06-fec51aa979e4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8704), "192.168.1.20", (byte)1, 63.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("29528dff-a641-40a0-8d91-f1849856aa55"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9424), "192.168.1.92", (byte)2, 36.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("29e9ac3b-7cf1-49c2-99f6-af5f8bd6dd24"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(417), "192.168.1.38", (byte)3, 52.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2a38d11c-e28f-4928-9b0d-9c307654416a"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8459), "192.168.1.25", (byte)1, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2acafb53-856a-4e52-ae0c-a515dedf1cdf"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9939), "192.168.1.22", (byte)2, 68.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2acd318e-bcbd-40f2-bc74-628011dc145f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7989), "192.168.1.2", (byte)1, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2afaf7bd-8740-4bf1-bf1a-75db4913130b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(450), "192.168.1.55", (byte)3, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2b15b695-19d1-41cf-a0a4-ce13a82ae603"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9948), "192.168.1.56", (byte)3, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2b95545d-87de-4c00-8ac8-12a88246042a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9503), "192.168.1.96", (byte)2, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2ba9c064-6d5a-40cd-be3e-dad3fadc4c4c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9304), "192.168.1.90", (byte)2, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2bcea681-e2d1-4b39-9014-61e5677737bd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8775), "192.168.1.53", (byte)1, 17.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2bf8ebc0-4062-45f5-bd73-659d6c3db9d4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8392), "192.168.1.79", (byte)1, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2c100e8a-d62a-4001-a10d-201997702058"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7728), "192.168.1.11", (byte)1, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2c3e1127-8564-47cb-a4a9-f1e5eff6f733"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9842), "192.168.1.95", (byte)2, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2c566117-281f-40ea-86bd-513e8e119df0"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9161), "192.168.1.55", (byte)2, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2de0d01b-3d33-49ef-a942-a84a4600dcbe"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(537), "192.168.1.53", (byte)3, 83.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2e27e9b3-8c5c-4fe1-ad9f-b4e19a0085bd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8140), "192.168.1.61", (byte)1, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2e39b51c-9e8c-4999-9bc0-41d41b3a821c"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(458), "192.168.1.35", (byte)3, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("2e5cfe23-a835-4dd6-9a19-b54784efbe51"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(488), "192.168.1.63", (byte)3, 58.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2e866c8b-1852-498a-bd89-8b3ca4fb92e6"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(910), "192.168.1.4", (byte)3, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2e8c1864-6ed0-456a-b8a5-4a1bef5dadf0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8487), "192.168.1.58", (byte)1, 81.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2e9d4b9b-7c1a-4d45-aa2d-5959b6db9b92"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8119), "192.168.1.90", (byte)1, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2ebacbaa-7619-4e90-ab49-a575fdf1363d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(799), "192.168.1.71", (byte)3, 68.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2ec4799c-1040-495e-b760-6c29a6d46b09"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8599), "192.168.1.5", (byte)1, 17.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2fd99d89-79e7-4182-bb3e-733a24e6ed1a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8921), "192.168.1.94", (byte)2, 44.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("309555a4-ee90-45ed-9136-6f7c0f5388e5"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7956), "192.168.1.65", (byte)1, 87.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("31089c0d-6141-488a-a417-56bdbe3ea918"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8194), "192.168.1.41", (byte)1, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("31be5fb0-a852-4d02-93ea-9f95c1231d4f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(166), "192.168.1.82", (byte)3, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("321f41b0-f200-4676-b1cc-85bd919db902"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7710), "192.168.1.91", (byte)1, 61.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("323ba2d1-8c2b-4b70-80ce-9cd21d380a39"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8638), "192.168.1.16", (byte)1, 28.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("32737e81-dca5-403c-8775-0d7c5541a340"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(133), "192.168.1.55", (byte)3, 78.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("32d5f435-1f88-4f0e-b3d6-9f6beb743f21"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8107), "192.168.1.41", (byte)1, 60.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("33af82ea-9fa6-4608-a8f5-8dcecac0b6cf"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8718), "192.168.1.20", (byte)1, 1.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("33ba9e92-efd3-4ee5-b7c6-2b497b86946a"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8123), "192.168.1.56", (byte)1, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("343e3c9d-9ba7-4647-9036-3549a55fb450"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(809), "192.168.1.91", (byte)3, 13.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("34f0c995-0dea-4b95-b5a8-8f013680cdb1"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8554), "192.168.1.4", (byte)1, 73.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("35aab65c-4c90-494f-a964-6a05263960d8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8426), "192.168.1.13", (byte)1, 62.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("365eda71-e7bf-49fd-ad0f-0a5bbe4ba11e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(914), "192.168.1.42", (byte)3, 23.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3691f739-790f-4805-be74-852e2677222e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9032), "192.168.1.85", (byte)2, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("36fb6e7a-5944-430f-ba31-5a0c86399eba"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9432), "192.168.1.24", (byte)2, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("37101d88-a06a-4452-adc4-66644c1f71a7"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8089), "192.168.1.28", (byte)1, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("37186b68-8862-426d-aad4-ba633f79726d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9832), "192.168.1.21", (byte)2, 29.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("37f3ecfa-9e11-430f-a534-407a47ab892b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9045), "192.168.1.54", (byte)2, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("384b95dd-52bf-4253-9ba1-276e1c63ee33"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(549), "192.168.1.24", (byte)3, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3879e7c6-9cec-49d6-80a0-3e336c73247f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9808), "192.168.1.56", (byte)2, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("38dc62bf-9783-4ed1-858f-bbacde4a0657"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7867), "192.168.1.64", (byte)1, 20.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("39583d9b-0dd9-4296-9d2b-137283af02dc"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(600), "192.168.1.81", (byte)3, 87.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("396ba8f1-31e2-4c64-93e4-ceaabf99227a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(956), "192.168.1.90", (byte)3, 42.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3a06e021-7f71-4e7e-9295-d5ac7d6a7fba"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(145), "192.168.1.96", (byte)3, 89.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3a497e15-e9f2-43a6-8ea4-fb3254e36bf0"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9582), "192.168.1.52", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3b0bddc9-9fed-4712-804f-690517c49adc"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1022), "192.168.1.37", (byte)3, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3b279801-5eeb-4f2b-8fbf-36d1b78a9b05"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(604), "192.168.1.26", (byte)3, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3b916b9e-80ce-42ef-8115-ef4b75023e2b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9495), "192.168.1.37", (byte)2, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("3bd446cb-5c32-4bc6-8f8f-5efed741d1b5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9765), "192.168.1.81", (byte)2, 71.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3c152c9b-4ca3-4c07-b25a-f95ba4c0c8db"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9324), "192.168.1.46", (byte)2, 64.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3d3f970b-4500-4afa-a10f-998bb370bab6"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9300), "192.168.1.10", (byte)2, 3.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("3d41e0b7-971f-46e6-8864-e1637801dccc"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(193), "192.168.1.49", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3de17b3c-3685-4f86-bc2d-6b179d31dfbb"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8771), "192.168.1.21", (byte)1, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3e0c4345-cc8d-46c7-91d5-b9b3ce28c5fd"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(645), "192.168.1.97", (byte)3, 50.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3e137fa6-2111-493d-8065-17325475ef4f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9109), "192.168.1.7", (byte)2, 18.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3e3e9c13-cfdf-49af-a28d-7d81b27c82a3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(515), "192.168.1.29", (byte)3, 63.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("3ecaec57-29c4-4bed-8ffd-6717427066e3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(215), "192.168.1.17", (byte)3, 30.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3f043741-975d-4b03-8575-e04fa4efe99a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9053), "192.168.1.2", (byte)2, 84.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3fb89a1a-19f6-421c-87ff-537fffa4e431"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7804), "192.168.1.24", (byte)1, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("405b8698-537c-4545-8098-fd64b178f4e9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9653), "192.168.1.31", (byte)2, 10.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("40640f14-e5db-46b5-a35f-5590d399dc5c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9918), "192.168.1.70", (byte)2, 21.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("409e0230-d31a-4bc1-9439-d59e9a4d462b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(240), "192.168.1.24", (byte)3, 77.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("410b6ee6-e2df-47c2-bc75-b53dc8307caf"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(608), "192.168.1.57", (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("41927d3f-cd55-4b76-8e32-dedba59e470f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8550), "192.168.1.74", (byte)1, 40.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("41a46af9-5f6f-4e1e-8119-078d8740f7bb"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9469), "192.168.1.13", (byte)2, 5.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("41b74e75-0e11-48b7-9958-762f601ed604"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8400), "192.168.1.66", (byte)1, 6.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("41fa3270-559d-41e7-8da5-a6ce80c6ef6f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7847), "192.168.1.86", (byte)1, 45.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("4245c1ab-c0c3-41e9-9bae-acb1cca80d3f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8289), "192.168.1.19", (byte)1, 90.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("42643963-8966-42d8-b249-af25706b25f1"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(227), "192.168.1.9", (byte)3, 75.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4286c1ee-e14c-4f3b-bc09-c324c6e22e20"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8093), "192.168.1.4", (byte)1, 46.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("42a80064-25a4-42ea-8a15-56712350b09d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(977), "192.168.1.83", (byte)3, 91.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("42ae1aef-6c10-4027-89ad-900b09cceda3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(429), "192.168.1.15", (byte)3, 87.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("42e798d9-2229-46d9-beb7-6e0210dfaf95"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7744), "192.168.1.53", (byte)1, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4308ae6d-39e4-43c5-8945-99d8f5f5ddfa"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7985), "192.168.1.95", (byte)1, 16.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("43c4a9b5-238d-4b62-865f-d6930eb7c149"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8998), "192.168.1.29", (byte)2, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4447d529-4abf-4044-bb7b-69f7aa76e188"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9131), "192.168.1.45", (byte)2, 13.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("44a28d86-d67f-4f0e-9491-5aaf7489a04c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9028), "192.168.1.48", (byte)2, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("452edd95-f00c-41b4-8240-98f543b3bca8"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1036), "192.168.1.74", (byte)3, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4592d06b-7030-4d8d-bd6b-6fa0ae42ce6b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8166), "192.168.1.4", (byte)1, 80.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("463f2977-b4cf-4c9e-b471-8c524f0e99b1"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9532), "192.168.1.97", (byte)2, 94.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("466136ac-dd4b-46e6-a5d6-8dd75ec189bc"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8621), "192.168.1.34", (byte)1, 65.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("469e9780-828a-4150-9120-c48e6afd8735"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9678), "192.168.1.55", (byte)2, 28.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("46cbda9c-4bc1-436b-b027-5281f305d22b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9015), "192.168.1.27", (byte)2, 68.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("46cbfb73-f191-4768-9cd0-85ee91296768"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8858), "192.168.1.45", (byte)2, 54.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("46db16c0-ae6f-4053-832a-b8154261ba66"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9169), "192.168.1.14", (byte)2, 2.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("476d80ea-9915-4ba7-a740-e1e4839e4fad"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1014), "192.168.1.10", (byte)3, 67.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("4817cb14-5431-4806-af48-3ae6c21b3a27"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8737), "192.168.1.46", (byte)1, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("4861068f-6fde-4f36-8482-ba96e4bf1370"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8755), "192.168.1.81", (byte)1, 9.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("4862e9e6-66b1-4cd4-9fb6-545e15a96095"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9210), "192.168.1.24", (byte)2, 76.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("486508ff-7b85-4a89-95d1-7544eb7fb1ad"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8293), "192.168.1.4", (byte)1, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4925f359-ba01-4c12-a923-4370581ae0c1"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9291), "192.168.1.75", (byte)2, 98.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4936350b-aa36-4066-b498-c8c30085c26c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9465), "192.168.1.61", (byte)2, 11.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("49569471-9e0b-450c-95ae-2674bc8750b2"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(493), "192.168.1.82", (byte)3, 85.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("49eae55a-393f-4338-9151-eb39c3d51eec"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8986), "192.168.1.47", (byte)2, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("4a09a2e5-def7-4ccd-9bb9-73c5d17dea3a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9312), "192.168.1.3", (byte)2, 51.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4a46868d-3589-4b3e-a5dc-8b6e98b72b41"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8633), "192.168.1.89", (byte)1, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4abdcaa1-32b1-4606-978f-e134c3881e9e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9735), "192.168.1.87", (byte)2, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4ad78f48-5261-4224-84de-c1fc87ca07f4"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9670), "192.168.1.20", (byte)2, 77.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4aef51a5-6a67-4d2a-963a-fca77712903a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9139), "192.168.1.57", (byte)2, 57.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4b6e3ef3-50fb-45c5-b03f-61f295c3038b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(553), "192.168.1.87", (byte)3, 99.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4bf1bf35-eb9c-45ff-984f-d10894ce5105"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8650), "192.168.1.52", (byte)1, 11.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4ca4f76a-86ac-4548-8ccc-841773e5c974"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7736), "192.168.1.25", (byte)1, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4cae637a-7864-462b-81ae-b0c0178b2a3e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9173), "192.168.1.34", (byte)2, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4d848011-7e8f-4b57-9135-9ac3462bc016"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8796), "192.168.1.58", (byte)1, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("4daeb407-38a7-4be0-9e3f-dd60663bdc0e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8024), "192.168.1.80", (byte)1, 75.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4e3ccdb3-4773-44a0-9673-2905ddb41f6b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(533), "192.168.1.18", (byte)3, 34.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4e6389eb-2637-4c1e-8b90-bdbd65d95f3e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7825), "192.168.1.91", (byte)1, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4eb9a06a-451e-4df0-bdc1-1b91f71a7196"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(754), "192.168.1.70", (byte)3, 64.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4ef18e63-c561-4a93-b01d-9a13db6c9992"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7843), "192.168.1.25", (byte)1, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4efaffbf-a8b1-425d-8b9f-91657a685dfc"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8994), "192.168.1.66", (byte)2, 99.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4f341a27-43d5-4c13-8afe-715b4c2efcc1"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8662), "192.168.1.85", (byte)1, 23.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4f844205-a31e-496b-8f88-df8cb976fb49"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9674), "192.168.1.33", (byte)2, 12.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4fca9ed8-63ad-45bf-97cf-5ed000997a84"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9607), "192.168.1.88", (byte)2, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5092c264-cedd-40bc-8218-ea4e18338e39"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9877), "192.168.1.2", (byte)2, 57.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("50ac2c9f-a109-4260-93c3-02a63e390c5c"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(311), "192.168.1.58", (byte)3, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("50e6f9e0-aac5-4979-98a3-b0938415d343"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9342), "192.168.1.71", (byte)2, 85.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("518b4a2a-e71f-4007-9626-33cb0e8f0cfd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8186), "192.168.1.83", (byte)1, 25.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("51ad1ad9-d26a-46ac-a0d5-282dd88f8612"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7798), "192.168.1.88", (byte)1, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("51e4baca-fd15-4677-9296-1cb0de2825ca"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9412), "192.168.1.9", (byte)2, 60.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("52b46b90-a4a3-473f-b8a1-66a69fbc9257"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8617), "192.168.1.53", (byte)1, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("52e696fb-311f-4ab0-8014-10e159ea54c7"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(115), "192.168.1.52", (byte)3, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5360cc38-aac7-49fa-92ea-f4e3c9e04d9f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8745), "192.168.1.61", (byte)1, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("548338bc-fe4e-4a01-8a1d-578bcdf45b4f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8450), "192.168.1.49", (byte)1, 21.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("54c3804f-7c48-4282-8d8e-ae465c6eecaf"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7858), "192.168.1.3", (byte)1, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("5599ec21-c01f-4e09-b2dc-e01e3b278f08"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9499), "192.168.1.24", (byte)2, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("55cc3f56-b8ba-46e4-baa3-5cb9f8fd27c9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9691), "192.168.1.68", (byte)2, 11.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("55f68898-dc25-4d10-8315-fab31c0ca23f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8880), "192.168.1.43", (byte)2, 82.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5654d11c-d703-482f-8a00-d1b71db25579"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(87), "192.168.1.66", (byte)3, 61.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("56790b1e-23fa-47d5-8af4-04f9f04a7bea"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(223), "192.168.1.46", (byte)3, 26.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("56e232ee-d731-4b8e-b2ea-562de76e26c1"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9667), "192.168.1.41", (byte)2, 9.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5711c709-9ede-4737-b39e-aa0ea95cf362"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8876), "192.168.1.40", (byte)2, 59.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5758152d-3f5e-4222-926e-0fa9699d0dcc"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(527), "192.168.1.45", (byte)3, 9.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("575e135c-314b-4d91-9eaf-9b44f23ea559"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7979), "192.168.1.95", (byte)1, 28.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("57dc212c-dad9-4b5a-a184-41ad59d4273e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7699), "192.168.1.76", (byte)1, 1.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("585809be-9cbf-45fb-840c-85bb5161aa5c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8136), "192.168.1.38", (byte)1, 36.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("589238c6-7e7e-4639-ac68-7c2aefcfd0f4"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(404), "192.168.1.56", (byte)3, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("592d5d41-3627-49eb-91fe-3eb61a23c093"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9135), "192.168.1.84", (byte)2, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5aaddd27-7386-48e5-a950-d888bba00fa4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8442), "192.168.1.83", (byte)1, 60.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5b1fedcc-33ca-48aa-b13d-7124a576c3d0"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(462), "192.168.1.86", (byte)3, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("5bbf4d47-40be-4751-bfcf-34be2aa8b62a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9375), "192.168.1.37", (byte)2, 5.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5c0458bd-9299-4e8b-9bb5-e3a26ca66b10"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8014), "192.168.1.47", (byte)1, 55.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5c1d4001-796c-4db4-b78b-cf5abae2a182"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7907), "192.168.1.73", (byte)1, 99.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5cdd6bc0-f3c1-4406-9cdd-8dfbe696ceac"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(628), "192.168.1.52", (byte)3, 58.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5d8558be-90a0-4be7-92c8-23f8fb4bf918"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(707), "192.168.1.91", (byte)3, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5df997c2-9d13-4a55-9240-0683f4d71632"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8144), "192.168.1.99", (byte)1, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5e41e8de-c19e-4b44-a6d2-46a6d3899b18"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(141), "192.168.1.32", (byte)3, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5e6b98dd-e6e4-4802-9523-55e0a9755e27"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(774), "192.168.1.84", (byte)3, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5e87d3c0-54c7-4d23-9b2f-8f063374b9d9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8103), "192.168.1.32", (byte)1, 83.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5ee352e8-b221-4e04-aa7b-675bc49a2dc4"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9894), "192.168.1.44", (byte)2, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5f862d54-b798-4c0b-956c-3c7c43ea00f0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8170), "192.168.1.30", (byte)1, 75.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6007a519-45c3-4ae5-9a5e-9c9785f7e68a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9040), "192.168.1.75", (byte)2, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6077bd07-dffa-4056-b842-23b79cbce53d"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8818), "192.168.1.87", (byte)1, 93.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("608fb398-973d-491e-9b97-2e4492586a71"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8953), "192.168.1.74", (byte)2, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("612a7090-9904-4092-8fa3-84c0a40892ae"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9536), "192.168.1.43", (byte)2, 45.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("613bc329-6a2f-4a7f-a8ba-de000a0a3b82"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8319), "192.168.1.19", (byte)1, 88.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("614c0999-9054-414e-8966-431c831346fb"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(519), "192.168.1.48", (byte)3, 36.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6152c2d5-70ed-49db-ac8c-0bd8c861b57c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9928), "192.168.1.35", (byte)2, 5.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("61fe335a-8178-4c2c-a06d-8a1cfdd2a01f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(783), "192.168.1.6", (byte)3, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("62002a18-7eea-4de2-8802-d84bc5f45a01"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7952), "192.168.1.72", (byte)1, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6207bca5-cec8-45f4-97b1-06533ebe948c"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(232), "192.168.1.7", (byte)3, 34.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6225c016-4923-4672-bfee-59f6ee3e2560"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(211), "192.168.1.63", (byte)3, 13.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6240ec1b-980a-4319-8131-a130421db4a5"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8571), "192.168.1.72", (byte)1, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6294b408-b860-4763-bd38-79e927a69024"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9753), "192.168.1.14", (byte)2, 85.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("63001306-ea9f-4229-bf36-b40b36e9be84"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8347), "192.168.1.12", (byte)1, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("630ee388-3c4a-432c-b85b-a15809750e03"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8949), "192.168.1.94", (byte)2, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("633761a4-3c51-4b3b-98c0-48a0534b0720"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7714), "192.168.1.75", (byte)1, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("634ca0eb-0e26-4137-9c94-7900a4d99eba"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(65), "192.168.1.18", (byte)3, 65.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("640f7fa9-8810-477d-a3ae-3810ba3b0158"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(149), "192.168.1.15", (byte)3, 16.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("64376af5-1a70-4d2a-a2ec-5f9fe8c0f8d3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(744), "192.168.1.8", (byte)3, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("64495a12-c4cf-46d0-b254-28f50daff1fa"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8278), "192.168.1.92", (byte)1, 15.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("64bc7695-84e4-4888-bde6-0f8ff6610b38"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(433), "192.168.1.14", (byte)3, 34.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("64fed0f5-0fbe-4bc9-837c-91ae76ac0a2e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8001), "192.168.1.45", (byte)1, 53.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("650add41-cfa0-49d1-9b96-dc31a7098cc3"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9715), "192.168.1.32", (byte)2, 73.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("650c5e41-79b9-4302-8678-132fbaa29409"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8576), "192.168.1.51", (byte)1, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6526c279-e1bb-4e2b-b09c-48558778c603"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8759), "192.168.1.50", (byte)1, 3.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("65d66e28-1fb8-49d4-a26f-fdaf28e92529"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8493), "192.168.1.48", (byte)1, 3.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("660c9f88-ea2c-4e92-a9ae-c7d9938d1b9a"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8381), "192.168.1.95", (byte)1, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("660e9b77-95fe-439d-9dbb-899271f363da"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9633), "192.168.1.44", (byte)2, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("66a52db5-b84f-418d-b616-4910466bed86"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(778), "192.168.1.93", (byte)3, 44.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("66b1c04e-916c-45e1-b48c-bf86f4a733d8"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9697), "192.168.1.80", (byte)2, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("66f85c3a-65ec-4798-bc99-0791e2e7c69b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9286), "192.168.1.78", (byte)2, 5.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("68c1a87c-6e75-4894-b12c-831919459aef"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(45), "192.168.1.56", (byte)3, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("68ccaac4-b050-4267-803b-fbd0fe47ee4e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9073), "192.168.1.46", (byte)2, 3.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("692f3439-831c-4b6b-912e-c1f8b33c2653"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8868), "192.168.1.76", (byte)2, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("6a1a3ee3-477f-47c5-bcfc-6a2442613eb0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8020), "192.168.1.71", (byte)1, 68.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6aac1810-5757-4c8a-b2df-82837c47c797"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(470), "192.168.1.64", (byte)3, 40.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6c0640ca-106a-4eaf-903f-68dd82e235c4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8591), "192.168.1.88", (byte)1, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("6ca1e66e-3cc9-4878-9c8c-657dbba0aa29"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8044), "192.168.1.46", (byte)1, 39.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("6cc0bc05-6832-4607-8dbf-5f177e4d00e1"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8513), "192.168.1.79", (byte)1, 49.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6d438e6b-b89b-42a9-8da2-0d2aea02d296"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9711), "192.168.1.36", (byte)2, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6db7719a-047e-4ae4-93d4-6e4b8d354d17"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(948), "192.168.1.26", (byte)3, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6ddc99af-a832-4b03-8824-b31009abded4"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(28), "192.168.1.90", (byte)3, 11.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6e47e108-fd0b-4002-9602-981306f7e899"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9952), "192.168.1.13", (byte)3, 50.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6f9acade-d1cc-4d4b-a609-439edc3b403b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8361), "192.168.1.7", (byte)1, 81.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("6f9e5995-b688-4c28-ad53-19a99f2ef6b9"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1026), "192.168.1.87", (byte)3, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7175e82b-24c1-450b-9129-1ebc1283eab7"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8767), "192.168.1.24", (byte)1, 66.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("71a6e6d9-acd9-4149-91a7-93fde4f6e295"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8040), "192.168.1.31", (byte)1, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("721c7c45-57f2-493f-a6f1-bcca4a23cc8e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(865), "192.168.1.8", (byte)3, 73.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("72d53ca5-d188-4616-91dd-43599cad8f39"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9557), "192.168.1.77", (byte)2, 16.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("73080e08-0422-49f4-896f-c52defa88c8b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9507), "192.168.1.97", (byte)2, 15.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("737934fe-7d37-403a-98ac-640ca81a9acc"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9093), "192.168.1.49", (byte)2, 65.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("738db8ce-088f-466e-a67c-8d91cf42d5e5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9604), "192.168.1.96", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("74369b7c-c45d-4fc6-a95e-9484c52bd40b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9512), "192.168.1.46", (byte)2, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("74a6e191-2c7c-4da6-a72d-d6a1b17713f7"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(437), "192.168.1.72", (byte)3, 49.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("74d51980-87dc-4c12-a6d4-3756d79aa586"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8725), "192.168.1.4", (byte)1, 95.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("74dfe31e-7aa6-4bfb-b3e5-95ad01f4d00a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8990), "192.168.1.10", (byte)2, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("74ff3611-3e50-480a-9a60-4e6646944763"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(641), "192.168.1.72", (byte)3, 89.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7544c1f5-0489-4884-90ed-7fec42a80f20"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8036), "192.168.1.11", (byte)1, 66.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("754e6614-33e8-4d73-9ee1-388584f88197"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7779), "192.168.1.87", (byte)1, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("76bdf3b3-def8-400c-8a04-50daf0421b2a"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7877), "192.168.1.61", (byte)1, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("76dffd7a-9b09-459f-b81d-2d6c30b569b3"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8784), "192.168.1.46", (byte)1, 46.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("773d6c8b-32a5-4691-a240-3c1c235c261c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9097), "192.168.1.40", (byte)2, 70.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("77daf80b-f0f8-4886-ad0e-d9e57f85e2d7"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8323), "192.168.1.41", (byte)1, 5.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("78428376-c6a1-49ff-b2b9-cac7c989d70d"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8048), "192.168.1.37", (byte)1, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7878116b-b0f8-4d93-a410-ed2e6b7a46ad"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8804), "192.168.1.39", (byte)1, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("78862d34-cff2-43bf-aa07-6a1d613b4676"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9279), "192.168.1.4", (byte)2, 3.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("78f0bf08-6743-4e6b-a0b7-1bfcc4220591"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(574), "192.168.1.32", (byte)3, 53.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("79bd66f0-854d-4dbd-9575-19b3bb1bcf4c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8546), "192.168.1.53", (byte)1, 39.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("79f660e2-8a84-413b-b273-d7a035445307"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8729), "192.168.1.45", (byte)1, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7a118f42-8aae-42d4-95b0-c7b6bafbbd24"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9985), "192.168.1.30", (byte)3, 3.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7a4cc390-eead-4bbe-ad8e-94444ee3cb76"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7993), "192.168.1.20", (byte)1, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7a809f30-ce52-4264-b89f-2850d2b52b5b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9995), "192.168.1.40", (byte)3, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7a861aae-3a35-4c6d-9656-dc6898070392"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7829), "192.168.1.87", (byte)1, 45.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7a928d55-dfe8-4837-bfc1-04842e768876"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8909), "192.168.1.99", (byte)2, 37.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7ab25247-e3ff-42f1-a432-fd0a3600390d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9657), "192.168.1.69", (byte)2, 38.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7b142bae-49d5-4902-bf7e-a0e62ad8b264"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8203), "192.168.1.35", (byte)1, 15.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7b1a5b79-a56d-4f0e-ab8b-912af134e75a"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7771), "192.168.1.22", (byte)1, 98.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7b906099-84dc-4187-bd42-269d5c1c9846"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9799), "192.168.1.72", (byte)2, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7bfb93d3-daa4-41ee-a28c-cd1af7f72f0a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(396), "192.168.1.35", (byte)3, 36.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7c30c53f-7b5a-47d0-acdd-9cd2c43c7946"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(869), "192.168.1.53", (byte)3, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7c4396c2-6f95-4e3a-9fcc-36d227071c97"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(649), "192.168.1.25", (byte)3, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7c971811-b6bd-4d2e-8df3-97ae8b52f186"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(278), "192.168.1.6", (byte)3, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7c9af693-3f94-4b08-bb2b-6155c1a43f5d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9283), "192.168.1.27", (byte)2, 38.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("7d04bbcc-0080-4f7c-bd16-b9b8ea1e26b1"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9906), "192.168.1.33", (byte)2, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7da2b394-0fbe-4081-94a5-2397a5a32d12"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(383), "192.168.1.76", (byte)3, 42.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7dad2d3a-549e-46dd-8337-834f819181fd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8132), "192.168.1.34", (byte)1, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7db149ab-2087-4985-a173-89ed9a971c60"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8438), "192.168.1.87", (byte)1, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7ebaadc7-aa2b-4096-99cc-fced8d2e8640"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8152), "192.168.1.93", (byte)1, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7eeeab48-d077-4d41-ac48-ef812bea69e8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7893), "192.168.1.66", (byte)1, 24.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7f893b86-7ed5-4711-9c9c-3e825798ce75"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8733), "192.168.1.45", (byte)1, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("80c4914b-ca0b-4228-9b2d-a0d24554b80e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(303), "192.168.1.96", (byte)3, 19.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("8127b297-feaf-405a-bd84-db489e061e47"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9350), "192.168.1.66", (byte)2, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("813cb966-2630-43ef-bf32-aa9038e44a58"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9143), "192.168.1.23", (byte)2, 91.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("81880243-cc8f-43ba-aa2c-8fa3cd23d8b3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(981), "192.168.1.71", (byte)3, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("822cd597-19bc-4c31-b3f5-1946e4003fc0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8286), "192.168.1.88", (byte)1, 69.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("824f4757-4111-47e4-80e1-291134cba7f7"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8812), "192.168.1.60", (byte)1, 16.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("82f0fc7f-8891-4530-8ba3-5accee1e43a8"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9931), "192.168.1.54", (byte)2, 17.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("82f546c0-4044-4163-ac33-677d432c3d00"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(137), "192.168.1.98", (byte)3, 52.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8360101a-75fd-4b8c-b47d-794bc09e20fb"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9354), "192.168.1.14", (byte)2, 41.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("83dc1e2e-1945-479b-a3fc-24297dd69904"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9402), "192.168.1.40", (byte)2, 11.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("83fb65b8-f972-45ba-85bd-7c4724a98b8a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(740), "192.168.1.53", (byte)3, 73.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("844c389d-bf62-4cea-9a0a-71c83e493fb9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7881), "192.168.1.95", (byte)1, 17.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("84cc7ac2-e0e3-4f47-8cdd-004b22fe9c56"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(174), "192.168.1.90", (byte)3, 42.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("856a0ee8-db24-4904-9bb4-2be9e854a116"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9957), "192.168.1.50", (byte)3, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8570bf54-c2c9-458e-b119-75e217e32be3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(997), "192.168.1.64", (byte)3, 81.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("85d0324a-0eb0-4270-9bec-038c264be7be"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(179), "192.168.1.29", (byte)3, 57.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("86136032-3eb6-49bb-a4d9-9041f1c043cf"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8646), "192.168.1.97", (byte)1, 13.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("86432fb6-d5a4-433e-8e16-c74c59820d0c"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(266), "192.168.1.83", (byte)3, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("865aab15-bd6d-469e-aa43-6602b9bb8d5b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(944), "192.168.1.8", (byte)3, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("86692e58-3eec-40eb-98e3-83b62840937a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(323), "192.168.1.95", (byte)3, 10.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("867ae07f-cb97-4879-9c0e-61f7151cf437"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8792), "192.168.1.42", (byte)1, 47.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("867da06e-11d5-4b23-a55c-08902cd1ff92"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9245), "192.168.1.53", (byte)2, 34.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("869fe1e8-6967-4ff3-a068-8965e11f0c66"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(294), "192.168.1.60", (byte)3, 99.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8746fd05-b765-40ef-aa94-5e70a3aa4365"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8605), "192.168.1.59", (byte)1, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8775a4d2-aa8c-4e18-8272-650a51da4a8b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7910), "192.168.1.5", (byte)1, 91.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("87a1a060-df7e-41b5-b932-c597bdbc2c50"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(511), "192.168.1.62", (byte)3, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("87bcf687-e768-44b3-a5bf-d0e28d72cf07"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(290), "192.168.1.83", (byte)3, 55.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("87eed9b1-3e96-45f9-9802-f397a0ead62f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(670), "192.168.1.37", (byte)3, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("880081fe-ef3c-442b-afcd-1cfca3c7f06b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8211), "192.168.1.1", (byte)1, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8832b2ca-1410-4089-b07c-6bf04f74ef11"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(922), "192.168.1.33", (byte)3, 0.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8837e70c-eec3-4ed3-95d7-581ad533b979"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7915), "192.168.1.78", (byte)1, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("88be78f1-7166-4c2e-9aa4-2b6dfb25910e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(804), "192.168.1.10", (byte)3, 55.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("88cde404-ad41-449a-a80b-34b3253d7ed7"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(207), "192.168.1.49", (byte)3, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("88e64028-8462-43a7-8291-e2b0c8eb82ce"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9787), "192.168.1.82", (byte)2, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("896ce3c1-1c33-4e76-9b48-dc507a2223a9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9101), "192.168.1.3", (byte)2, 58.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("89c294a7-a84c-4128-b47a-13d6ca9c9657"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9791), "192.168.1.56", (byte)2, 14.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8a9c757f-7267-4e70-853a-e0704d65feb0"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(315), "192.168.1.28", (byte)3, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8aa0bd0d-dad5-4311-afad-a65caccd3511"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(827), "192.168.1.67", (byte)3, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8bb895a0-c11e-4e62-9dae-c2c87e4b1052"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(691), "192.168.1.13", (byte)3, 64.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8bfc066d-6f1c-4d7e-a1ca-d96273d026fd"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(703), "192.168.1.33", (byte)3, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8c1411d6-6e7c-4fc3-a9f7-cdddba5b65a8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8420), "192.168.1.28", (byte)1, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8c449e09-1828-42a0-b727-57e840c5fefe"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8148), "192.168.1.26", (byte)1, 29.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8cd951ca-329e-449c-8981-2c79e8fbc23f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8483), "192.168.1.42", (byte)1, 50.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8cda19de-fa34-4997-9ed1-f80dab15f10a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(590), "192.168.1.8", (byte)3, 88.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8d11d1d4-15f9-451d-be7c-01a0fd0f3c97"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9253), "192.168.1.30", (byte)2, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8d443faa-9041-4787-b475-c3b727bba398"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8534), "192.168.1.61", (byte)1, 88.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8d50d57f-bbd4-438a-bbf2-4845d38f38fc"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8888), "192.168.1.94", (byte)2, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8dbcd0d9-bc3f-4c3b-bb90-87eaf93d34f7"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(855), "192.168.1.72", (byte)3, 43.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8df354f7-a803-431f-b537-b1499d2b801e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(421), "192.168.1.28", (byte)3, 95.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8e75a61b-2ae2-49bf-999e-eaf2759b3e8f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9165), "192.168.1.49", (byte)2, 78.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8ed27616-38b0-431a-a4f5-82229c9e0502"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9615), "192.168.1.69", (byte)2, 4.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8ee229c4-32ad-4771-a2e6-a3882d52652e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8497), "192.168.1.94", (byte)1, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8f0975e6-1f86-4614-9747-b5e2badc1cfd"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(454), "192.168.1.30", (byte)3, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8f540336-2e86-450c-a325-7e328343a832"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8085), "192.168.1.49", (byte)1, 22.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("903df9f0-0c70-4c84-828a-c7ce5946e407"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(695), "192.168.1.82", (byte)3, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("905b40dc-627e-4e73-9503-308802fa3825"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(366), "192.168.1.8", (byte)3, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("908d9d9c-08f4-4ba8-8308-1be6b3ada64a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9828), "192.168.1.72", (byte)2, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("90943873-a58f-4f90-a008-6776afeccfcd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7775), "192.168.1.60", (byte)1, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("90e21829-fc59-4341-a7f7-1dff383d5b66"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9757), "192.168.1.4", (byte)2, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9119f1e7-7844-4c05-933e-8319b394c216"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9483), "192.168.1.12", (byte)2, 51.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("912d3f28-a8b7-4bef-8e46-481ab04546e5"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7766), "192.168.1.70", (byte)1, 57.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("914771ac-768b-484e-9d14-799aa3f0ff39"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8331), "192.168.1.38", (byte)1, 96.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9176366e-d305-4740-ba78-ce9b24948004"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7723), "192.168.1.30", (byte)1, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("91e5ca17-217e-46f2-a59b-e1a82b23c51a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(903), "192.168.1.84", (byte)3, 12.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("92122edd-4de8-4315-9c3e-795c409f6507"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8396), "192.168.1.44", (byte)1, 63.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("926fc221-102c-445d-a233-0fb1150a0268"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9019), "192.168.1.5", (byte)2, 20.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("937672a3-eae5-42a7-a3a5-0ab066a0c8ed"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(851), "192.168.1.41", (byte)3, 18.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("93f9ef39-0856-4044-9b18-701e5a97cb2a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(791), "192.168.1.64", (byte)3, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("945082d1-a240-47a5-b264-3ccf9def13b2"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7932), "192.168.1.8", (byte)1, 91.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("948744ad-7279-4d3b-92aa-e0ed539ccdda"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9473), "192.168.1.34", (byte)2, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("95f29702-bba5-47f0-83df-191842b41557"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(906), "192.168.1.10", (byte)3, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9686c421-33b2-406b-8062-93a0d2a12566"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(75), "192.168.1.96", (byte)3, 70.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("96b13864-8676-4196-b31e-66baa66ca375"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8434), "192.168.1.86", (byte)1, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("96dca618-a1c4-4086-b3b2-0ccb5c410f58"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8369), "192.168.1.33", (byte)1, 33.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("96e5d637-92b9-48f8-9567-8a4314e24707"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(961), "192.168.1.80", (byte)3, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("96ec91d6-66fb-4a02-b7e0-cbd243386905"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9338), "192.168.1.9", (byte)2, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("972910ea-6829-41c4-8e2a-27aeeb33d507"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9228), "192.168.1.39", (byte)2, 46.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("9747eb34-00c1-4da3-8236-e6f7456c6a0a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(374), "192.168.1.20", (byte)3, 41.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9801702c-6d89-453a-b40d-7a6e8d3a6f27"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9002), "192.168.1.76", (byte)2, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("984e690a-4b4a-4802-b9f0-5e456af78d66"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(256), "192.168.1.4", (byte)3, 97.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9858dea9-d1a2-4f1c-b498-325ee7930fb8"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(711), "192.168.1.24", (byte)3, 35.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("990511ad-f40e-462c-9c4b-4a33c9979e8e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7839), "192.168.1.15", (byte)1, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("999bc6f8-7569-4ee1-93b8-38eed72b5013"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9346), "192.168.1.45", (byte)2, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("99a44d89-6d04-44fa-9109-9867dc6d7d3f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8629), "192.168.1.78", (byte)1, 58.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9a2c92e5-f839-48f8-bf61-c72ce5247765"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8683), "192.168.1.9", (byte)1, 79.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9a57b26d-cb5c-45df-9740-c564e0c847fe"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9157), "192.168.1.97", (byte)2, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9a9a8820-7b9a-49d3-8022-73d45d5c16c3"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9745), "192.168.1.31", (byte)2, 99.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9a9cea43-cee0-4e49-b36d-32d173bf1c72"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1039), "192.168.1.92", (byte)3, 22.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9b86dabd-7612-4aa6-82a1-0d05ee07506b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9641), "192.168.1.80", (byte)2, 51.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9bfcbc71-76b5-4e48-950f-7002b9c1cd85"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9596), "192.168.1.10", (byte)2, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9c5450d7-3424-423c-984c-1164bff54bd5"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(766), "192.168.1.41", (byte)3, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9c691da3-610b-402b-95f7-de76356c7519"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7863), "192.168.1.53", (byte)1, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9ca0e44f-a77d-4876-bfcb-19a62b0a8662"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9334), "192.168.1.36", (byte)2, 62.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9ce18866-0fe5-4744-ae02-b2122aeb92fd"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(270), "192.168.1.59", (byte)3, 85.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9d5a927d-f2da-4f34-89e3-8b8c5a945450"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9123), "192.168.1.4", (byte)2, 73.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9d7593a4-d088-4f51-99a4-4a2f7b9c9ade"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(847), "192.168.1.21", (byte)3, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9d82e67a-7337-421b-8a26-e6198fa6fb42"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9645), "192.168.1.36", (byte)2, 42.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9dbc6138-e268-440b-8499-c25156e81cfc"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9898), "192.168.1.40", (byte)2, 53.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9df77397-e95b-4a05-bd7f-64b94fb599dd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8700), "192.168.1.10", (byte)1, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9e96a5fa-f254-4f04-90d6-a4df0a968738"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7946), "192.168.1.41", (byte)1, 12.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9f002a64-aec3-4e50-9621-289aef38412f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9420), "192.168.1.76", (byte)2, 51.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9f21b316-ee41-4aa0-997b-68488282e5ce"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(407), "192.168.1.93", (byte)3, 4.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("9f437fd9-96fe-433a-a599-2f206bf6b44c"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(523), "192.168.1.6", (byte)3, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9f4fe58f-1859-46c6-81c5-b9396a2e9ce1"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(53), "192.168.1.34", (byte)3, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9f89715c-ec71-44c9-a510-327faa18a481"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8282), "192.168.1.61", (byte)1, 31.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9fa4f203-e1c5-4c5e-b002-bea7901c46f5"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8199), "192.168.1.24", (byte)1, 22.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9fdf6acb-6a6b-4a92-9de0-7b2962729c54"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1030), "192.168.1.64", (byte)3, 87.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a03a638b-62bf-4183-bc2b-29fd5203c2d5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9214), "192.168.1.87", (byte)2, 35.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a2489320-5575-4360-b27c-7960e22c9df9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9206), "192.168.1.54", (byte)2, 81.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a24fc666-1e26-47e5-82a9-752c5aca0f6f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(993), "192.168.1.19", (byte)3, 74.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a2b81d1a-7a97-40b0-8d5b-87ed8d108b19"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9440), "192.168.1.10", (byte)2, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a2bfa557-907f-4856-b6df-2e63dabf5551"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9965), "192.168.1.47", (byte)3, 49.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a333ad4d-0e44-4fd1-8d28-ed6abad1ecff"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8939), "192.168.1.56", (byte)2, 2.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a4072d7e-42cd-40e7-a11b-24d7b9b9320a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9731), "192.168.1.37", (byte)2, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a4ea6fc0-e927-45dc-ab4a-8d6f07fe219d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(158), "192.168.1.44", (byte)3, 0.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a4fc4917-1030-45c7-86c8-4b2798574028"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8127), "192.168.1.88", (byte)1, 99.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a55327a6-a7fa-4590-be75-70c1b8114729"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(3), "192.168.1.60", (byte)3, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a574408f-3d20-4120-bb04-2bc4e32f92bc"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9202), "192.168.1.62", (byte)2, 38.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a5f212ef-dbbc-46f6-b7a1-5fd33996873c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7809), "192.168.1.68", (byte)1, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a64edee6-2427-44ea-94e7-7e47b6dd15e8"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9885), "192.168.1.39", (byte)2, 20.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a6901d3c-78f1-4e1e-8501-15dc50664e7e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9816), "192.168.1.79", (byte)2, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a6fcca35-4768-46fa-9e51-e153eed4d947"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9194), "192.168.1.8", (byte)2, 13.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a71be130-6dcd-4eee-89ec-5498509f49c5"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7873), "192.168.1.87", (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a75115cb-564a-4684-a880-2278c5c2469d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9749), "192.168.1.10", (byte)2, 7.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a75e5008-ef5a-499b-bf5d-b1212a88e2c0"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9611), "192.168.1.83", (byte)2, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a7b47b2f-e7c8-4cea-b421-df70487ed6e1"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9779), "192.168.1.32", (byte)2, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a813824e-f5f9-4075-8bc7-07adfd7b40b6"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9308), "192.168.1.67", (byte)2, 99.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a844dad4-94d9-4c7e-94ae-7004bee333b4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8416), "192.168.1.6", (byte)1, 69.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a86b9b6a-b522-43d8-9471-b68d3bd065a9"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(545), "192.168.1.62", (byte)3, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a8d98e61-4d0a-4cb6-8afb-b4bebbe1c963"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8412), "192.168.1.96", (byte)1, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a923c0fd-13b1-4393-9247-cc8b8fc5d408"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9873), "192.168.1.33", (byte)2, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a9d4efdb-4667-43a7-9a9e-a7afef7cafdb"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9011), "192.168.1.72", (byte)2, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a9d5ce25-1a59-4644-b2a5-209f5ed052ec"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9846), "192.168.1.43", (byte)2, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("aa6ecc98-9f08-4ae6-9ce4-614985b06148"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8272), "192.168.1.78", (byte)1, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("aa715bc2-823b-45a2-9558-bf5c9cb595cd"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(354), "192.168.1.80", (byte)3, 98.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("aa765927-5df9-49ac-adc3-23cc827b0e91"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9528), "192.168.1.86", (byte)2, 26.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("aa7ce79a-35f7-42a4-925a-f7d741b53469"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9295), "192.168.1.7", (byte)2, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("abc22121-4aba-47ce-9514-f9372a89b2ba"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9358), "192.168.1.91", (byte)2, 33.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ac0ddde4-34ca-444d-932b-91508438f211"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8471), "192.168.1.23", (byte)1, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("aca91750-c3b0-4796-ac79-a807d30892d6"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(889), "192.168.1.24", (byte)3, 6.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("acae6257-d44c-4b65-b108-13d34f61b28f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(111), "192.168.1.18", (byte)3, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("acfadb89-8b84-4270-9f2b-4e1b4072828f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(125), "192.168.1.30", (byte)3, 47.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ad3b23ef-dc67-41aa-9de7-4055e731ac9a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9910), "192.168.1.92", (byte)2, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ad6343cc-ade7-4da0-97f1-733c4132f87e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8208), "192.168.1.61", (byte)1, 69.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("adb91c23-4a9f-4413-a095-b2989b5edebe"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(79), "192.168.1.56", (byte)3, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("adcd7043-6424-4acd-9b59-80358150c13a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9981), "192.168.1.58", (byte)3, 85.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("add69dfa-d2f3-41fd-ac87-04405a7fa67b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7960), "192.168.1.14", (byte)1, 75.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ae2fef85-bd32-4523-8d83-62a2ba374ba9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8800), "192.168.1.76", (byte)1, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("af002e74-351a-44fd-8745-86f72effda94"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(724), "192.168.1.90", (byte)3, 38.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("af1f407d-16f8-426f-962f-1184fa864de3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(441), "192.168.1.98", (byte)3, 74.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("af291706-df3e-447d-b3f1-3856c636a654"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(985), "192.168.1.29", (byte)3, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("af85eee6-921b-4118-acca-49426c784781"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7740), "192.168.1.23", (byte)1, 11.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b036a553-b139-47ef-97ae-1e55de36f281"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8613), "192.168.1.44", (byte)1, 39.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b053243a-0ab1-48ed-941c-8d8ec387956c"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8838), "192.168.1.58", (byte)2, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b0807879-9eea-436d-bf7b-d2dfe6401f09"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9977), "192.168.1.87", (byte)3, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b0c50c86-68a4-4ecf-884f-99e661d3da71"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9516), "192.168.1.45", (byte)2, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b1150fa3-69a3-4bc3-ba81-dfa181ec8bec"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(170), "192.168.1.12", (byte)3, 50.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b1b86bba-4fa7-491b-9f7d-a77601d3bac9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8833), "192.168.1.71", (byte)1, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b228a5e1-0cb7-444d-8b6d-3fe39e643542"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(307), "192.168.1.23", (byte)3, 98.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b26a5474-dcb0-4559-88ae-d3361c18507f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9362), "192.168.1.42", (byte)2, 53.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b2ef1132-4941-4cd7-add3-c66a7ba2de3f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(582), "192.168.1.74", (byte)3, 19.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("b33eb2a1-1b4e-406b-ace4-605134dbfc49"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(932), "192.168.1.63", (byte)3, 84.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b412326f-fff7-4e63-806c-855ee2de5b80"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(299), "192.168.1.65", (byte)3, 96.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("b4233b12-8eca-480b-b36d-e77614246353"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7897), "192.168.1.72", (byte)1, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("b4908c29-0203-4f31-a4ad-6db42d2671c5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9795), "192.168.1.33", (byte)2, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b4bdcd69-f23b-4701-830d-82d1d8adb6ae"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(936), "192.168.1.58", (byte)3, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b513f626-35d7-4e86-b5ca-773fcc849fce"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8788), "192.168.1.96", (byte)1, 70.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b60f173d-31f8-4277-98e1-581de015b440"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9520), "192.168.1.32", (byte)2, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b7b31ade-5f56-41aa-82f4-eec1c29eb734"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(895), "192.168.1.84", (byte)3, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b7b33d70-b4f8-499d-a2d3-a71b1c8d41da"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9850), "192.168.1.3", (byte)2, 73.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("b809d28b-e3da-49df-a450-7424a5a162aa"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(199), "192.168.1.71", (byte)3, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b8749cd6-03a7-4102-a364-a450de668538"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8182), "192.168.1.93", (byte)1, 69.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b8d15d2d-cb46-4849-83d1-4762685571a9"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9036), "192.168.1.14", (byte)2, 48.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("b8ef66d0-bff8-4238-baa1-d6349be5f5a1"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9065), "192.168.1.94", (byte)2, 98.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ba54d9c7-e478-40a4-93e8-b864b40abe35"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(578), "192.168.1.24", (byte)3, 65.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("ba6c27e1-df8c-4bad-9c56-1a3d97bb8dfb"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(557), "192.168.1.30", (byte)3, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ba73a245-52f7-4a66-8278-cb8041aca112"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9961), "192.168.1.27", (byte)3, 93.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("bac3b473-a6fb-47e1-ab04-3c94a11d3372"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(620), "192.168.1.32", (byte)3, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("bb133667-92a8-4c3b-a01c-1e309da041a6"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8072), "192.168.1.7", (byte)1, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bb5f5d07-5466-47a9-9f23-d042ab6170c9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8057), "192.168.1.60", (byte)1, 47.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("bbb29816-c16b-4110-8f7c-f4ca33eb8e77"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(286), "192.168.1.98", (byte)3, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("bd5e5ee8-0df9-463a-b556-a2797f1e4ce9"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(822), "192.168.1.88", (byte)3, 30.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("bd8e5860-db92-4a49-86f7-b9d0216caff4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7964), "192.168.1.78", (byte)1, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bd908c40-c69d-4322-8214-5c2f95256d3c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7885), "192.168.1.61", (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("bdeea99c-3611-4f3d-8ddc-e56d830baff5"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(637), "192.168.1.79", (byte)3, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("be2149b0-42a9-47cf-a791-017c3fecd65a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(445), "192.168.1.77", (byte)3, 81.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("bf0c966f-277a-4f31-b0b5-b875094bbc26"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(370), "192.168.1.48", (byte)3, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("bf79e262-94c1-4ac2-9064-e95bbc4dc22c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8327), "192.168.1.33", (byte)1, 60.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("bfbeb98d-f67f-4e45-9134-c1378d656d41"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(252), "192.168.1.18", (byte)3, 92.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c0346d2f-aa7a-4259-841f-5eb68025296e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(260), "192.168.1.71", (byte)3, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c05e4255-92ce-4564-912d-9ade5cdbdd8a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9590), "192.168.1.14", (byte)2, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c2627eaa-da6f-45ee-8f87-16fc627f342c"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9991), "192.168.1.46", (byte)3, 87.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c2ef28f1-0b2a-4ebd-8e1b-0718491c5ae7"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(918), "192.168.1.35", (byte)3, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c31fbd99-6b23-4fd9-9efe-6f9a42bd0e93"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9783), "192.168.1.3", (byte)2, 17.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c32d0bc1-0056-4d27-a186-e85a07dfd098"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9619), "192.168.1.59", (byte)2, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c35aa6b0-0133-402b-9c44-02a201867328"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9999), "192.168.1.96", (byte)3, 40.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c49bd515-8952-44fb-a982-6eb736d591ab"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8446), "192.168.1.63", (byte)1, 22.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c4b649f8-1aff-4914-8644-c2ded8ab267d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1006), "192.168.1.76", (byte)3, 35.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c4c10c53-d5ca-456d-b731-e98864311aec"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7749), "192.168.1.9", (byte)1, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c4e99c99-fd58-417b-8438-59da06aa8dcf"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9328), "192.168.1.83", (byte)2, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c513aa0a-185b-4ddc-a716-1f5c2f746abf"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8763), "192.168.1.31", (byte)1, 35.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c52ecc1a-b404-4ff6-bcef-7a3a2c0fbd4d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(940), "192.168.1.65", (byte)3, 66.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c55e7cb0-8349-4432-bc97-b761cb5bf911"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9570), "192.168.1.48", (byte)2, 25.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c58e904c-50e7-4578-8aff-5716243339c5"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9944), "192.168.1.11", (byte)3, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("c5b48519-55de-428f-b000-983e14e186ec"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9600), "192.168.1.36", (byte)2, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c629f252-ca03-46f4-a087-844e1b2ab22d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9649), "192.168.1.64", (byte)2, 21.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c64318ab-9773-4d93-9cb5-888bcb29e4a8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8463), "192.168.1.11", (byte)1, 97.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c6df6679-2e9b-4eb0-b5f5-3992d4ae410f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9682), "192.168.1.25", (byte)2, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c73c399a-a4cd-4bba-8fd7-d340cbbdf027"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8722), "192.168.1.42", (byte)1, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c78ec689-f471-4079-aa98-9c45a16d554d"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7922), "192.168.1.29", (byte)1, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c7ba2d5c-ef51-448a-968f-7e6b4ff1c8e1"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(219), "192.168.1.14", (byte)3, 65.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c872818c-78b7-4c04-99b3-964c42787c4a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9935), "192.168.1.52", (byte)2, 28.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c8f6cb65-4e74-4875-a51b-a1589f1404a9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7972), "192.168.1.82", (byte)1, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c90d0b11-6011-4eca-8481-9827eba14e2b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8609), "192.168.1.4", (byte)1, 18.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c92fbeff-9e9b-4ffc-a859-10085d36b75d"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7813), "192.168.1.6", (byte)1, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c98eaeb8-dfa2-4b36-9d0c-8a03985679e2"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(387), "192.168.1.15", (byte)3, 11.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c99febc2-0e6d-48bd-a2ba-b4f15dd8005a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(484), "192.168.1.10", (byte)3, 74.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c9a9294b-f6bf-4ca7-9997-407b811ca447"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(570), "192.168.1.3", (byte)3, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ca3c2b4b-67f4-4425-90f6-7445d740f0e3"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8595), "192.168.1.72", (byte)1, 45.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cab94464-3f37-417d-82ce-368e34aafca5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8969), "192.168.1.87", (byte)2, 19.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cac6374e-3e7a-4576-bbde-b85a9d65b2fb"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9181), "192.168.1.44", (byte)2, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("cb56d94a-1928-45ba-b8ef-469b4d6a1bf7"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9881), "192.168.1.49", (byte)2, 87.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cbad808c-a9e4-4206-b447-6c7cff4149b7"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(282), "192.168.1.81", (byte)3, 58.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cbdf994d-6eae-4cf6-bb42-fa34bb95985f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8156), "192.168.1.93", (byte)1, 66.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("cc38830f-26c6-4cc5-a7f7-de40ef9bef35"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7833), "192.168.1.77", (byte)1, 13.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("cc4a652d-f276-464c-91fc-e282d0e18ad4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8588), "192.168.1.21", (byte)1, 68.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ccb4e306-21ba-4006-a420-97803fb6fde5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9723), "192.168.1.99", (byte)2, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cd449b55-5e7d-4a8d-897d-fc0516fe31b8"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(274), "192.168.1.22", (byte)3, 86.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("cd44c116-fc69-4a50-9f1d-e827f0bb8d78"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(612), "192.168.1.19", (byte)3, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("cd939f69-5700-4c8e-93e2-a8e9681be27f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9562), "192.168.1.42", (byte)2, 86.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("cdc2db12-e619-4f13-8798-42b3aea2c4fa"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(248), "192.168.1.1", (byte)3, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ce2eb6ad-7ea2-4b8e-ac92-8457a14ba23b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(699), "192.168.1.16", (byte)3, 87.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("cefb4bbd-dee0-4e8f-9716-800d348cbae6"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(566), "192.168.1.81", (byte)3, 1.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cf3aedc9-6420-4860-9566-58bda204324b"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9190), "192.168.1.17", (byte)2, 85.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("cf4b66fb-22e1-4277-a07a-26b4565a3491"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9049), "192.168.1.59", (byte)2, 96.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d0bde298-3abd-4af7-9947-6696e4ef6c35"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(678), "192.168.1.20", (byte)3, 23.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d0e451b6-1996-4834-b4e7-532cbdf605a6"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9969), "192.168.1.79", (byte)3, 2.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d0fb87a0-0b17-420a-9608-a6fe3b2557fd"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(831), "192.168.1.87", (byte)3, 17.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d12d59c4-fa02-47ae-a647-72d5f2cda643"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8302), "192.168.1.82", (byte)1, 12.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d1cce15e-daa1-409c-adac-08cc0d4bf69a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9924), "192.168.1.31", (byte)2, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d205e4f3-68da-4e75-a6b2-ebda87ee04b0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8115), "192.168.1.85", (byte)1, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d221ccc9-aaac-41f0-9d3d-6d0a47ee77a4"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9261), "192.168.1.53", (byte)2, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d28292f8-8044-4080-8e7f-9462f648b63a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9185), "192.168.1.12", (byte)2, 64.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d29424f2-f459-4be2-8afb-f10d57e2037f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9902), "192.168.1.1", (byte)2, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d40828f8-04a0-4806-a798-8b99474fbb41"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8160), "192.168.1.22", (byte)1, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d456a919-3081-45ee-8465-6f2d87477f6c"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(362), "192.168.1.22", (byte)3, 49.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d4e83fb8-41d1-42b0-8871-39f7295cd3bf"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8467), "192.168.1.4", (byte)1, 50.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d4f8bd0a-23d2-4865-979d-79fa295185b1"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(327), "192.168.1.74", (byte)3, 74.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d5091b33-2755-42d3-be68-037586713cc8"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(49), "192.168.1.52", (byte)3, 25.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d50be128-2d4e-427b-85cc-325a7d60c7b5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9105), "192.168.1.49", (byte)2, 69.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d52c8763-9b67-464f-8a89-7161660e973d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(758), "192.168.1.40", (byte)3, 2.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d68d591e-160c-49e5-8e42-97beae0c30d4"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(717), "192.168.1.1", (byte)3, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d6986684-390c-4ae5-94c9-6553b72f4062"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8527), "192.168.1.60", (byte)1, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d6c19f32-5b96-44a2-9010-08e936fa7d65"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9367), "192.168.1.24", (byte)2, 19.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d709243b-bf0a-4dd8-94cc-87e75e803a9c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8654), "192.168.1.72", (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d7eae8e2-2113-4b9e-b371-041712cb030e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8028), "192.168.1.49", (byte)1, 33.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d7f14bfe-38ff-4089-b2b7-41e1f227e7ff"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(687), "192.168.1.77", (byte)3, 43.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d7f3e455-4f26-496f-92ef-0b71d8697273"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(392), "192.168.1.73", (byte)3, 23.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d80ada0d-e48d-4157-92cd-e35eda1eaf1d"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8509), "192.168.1.90", (byte)1, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d9058b40-35d4-4788-b5d6-c1c1e065e87e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8223), "192.168.1.8", (byte)1, 95.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d9341747-ad92-4193-ab32-5705c4404015"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9578), "192.168.1.81", (byte)2, 60.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d9da1bdb-7e93-4b79-b7f7-da3732ff461d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8905), "192.168.1.36", (byte)2, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d9eafaf6-b077-4744-b29b-e61373a26b57"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1010), "192.168.1.31", (byte)3, 11.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("da4d2a20-1620-407e-b31c-f91711736d8b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(237), "192.168.1.91", (byte)3, 24.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("dab0075e-f182-409d-8b28-1b34baa0797a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(586), "192.168.1.53", (byte)3, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("dadbc792-9f33-4654-aeda-3b61f6ca71f3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(770), "192.168.1.24", (byte)3, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("db03ecdd-875f-447b-9e19-e7e945a4a5de"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9249), "192.168.1.32", (byte)2, 78.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("db15dcf5-52e3-40fd-8dda-f0c9d49474e9"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8475), "192.168.1.14", (byte)1, 80.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("db463a1f-efc6-4c3f-9dcf-dea125c3e66c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8658), "192.168.1.76", (byte)1, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("db719ea4-38f8-49a4-bdfb-8671b64d933e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9218), "192.168.1.89", (byte)2, 40.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("dbbe0aa5-c934-4999-8e4b-e99fb09131fa"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1002), "192.168.1.86", (byte)3, 47.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("dc2356e5-f2d2-4f27-b999-a79c5d8aceef"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9436), "192.168.1.95", (byte)2, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("dc4f4b01-b66e-44c6-b759-e7104edf143e"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8892), "192.168.1.90", (byte)2, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("dc770121-3829-43f5-8901-dcdf4a0488c2"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8219), "192.168.1.40", (byte)1, 20.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("dccac85e-272c-45b0-baab-5c448ee4e3e2"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(732), "192.168.1.38", (byte)3, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("dd470798-d0e9-40e0-8c39-cb3bffb97cc0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8672), "192.168.1.38", (byte)1, 24.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ddddbc44-06dc-47ec-80dd-660a84874688"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9491), "192.168.1.72", (byte)2, 10.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("dde5de26-2193-47be-b8b0-959f25b63671"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9461), "192.168.1.85", (byte)2, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("de4efe40-a2fd-46dd-93aa-3cf5f415e947"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1051), "192.168.1.21", (byte)3, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("de5f92dd-92f0-41a1-9ca2-f69c8795c51e"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8580), "192.168.1.41", (byte)1, 7.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("de60c1e4-701a-45d8-8bfb-ccd7b98064b3"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9320), "192.168.1.59", (byte)2, 30.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("df28dfab-340b-43aa-a466-dd5076de57c0"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(787), "192.168.1.41", (byte)3, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("df68cf2e-e03e-4e9b-ba13-762913b2cff5"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(478), "192.168.1.67", (byte)3, 11.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("dfdafb31-5f2a-43ae-abad-b633173d364b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7855), "192.168.1.47", (byte)1, 46.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("dfde41f8-af23-4599-8486-c790526b98a8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7753), "192.168.1.61", (byte)1, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e070a748-6cda-48d5-bf59-b5a8503c716a"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8032), "192.168.1.76", (byte)1, 46.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e0b3744b-9bde-455d-80e7-2eb07d792646"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8884), "192.168.1.31", (byte)2, 29.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e1abbfb6-b8a4-458e-ac31-6514c3700d4f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7821), "192.168.1.23", (byte)1, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e250463a-de66-4d13-8a3e-79172c1cbda2"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1043), "192.168.1.60", (byte)3, 93.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e2716db7-d811-44ae-8033-a30a28c59b43"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8010), "192.168.1.28", (byte)1, 80.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e2cd2c3e-5caa-4a6a-b003-61ad2b3ebc71"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7975), "192.168.1.45", (byte)1, 58.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e2f8face-90f0-47b8-ab67-bd69ef1fa86f"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8562), "192.168.1.1", (byte)1, 51.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e339c798-a04e-4acc-b1f2-2cd5fae7dbd4"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7918), "192.168.1.79", (byte)1, 47.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e3fd1019-047b-45a9-81c9-cde19249c529"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(474), "192.168.1.20", (byte)3, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e4eff19d-eb43-4375-96f7-469af27d490a"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8178), "192.168.1.80", (byte)1, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e52a8ffd-b17f-4fa9-b8ab-c144d7d01de3"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9973), "192.168.1.49", (byte)3, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e55c91a6-208b-4428-a64a-8c64e9abb8d2"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8408), "192.168.1.3", (byte)1, 64.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e5629a76-958f-42fe-9e01-d920b1232ab0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8479), "192.168.1.15", (byte)1, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e5cd92aa-22cd-46fa-99c1-c238e7c66acc"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9836), "192.168.1.20", (byte)2, 59.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e5dadbb0-8609-45da-9442-752da3052960"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8982), "192.168.1.3", (byte)2, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e6345ba6-acac-4a3e-a3d4-8940994aee5d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(41), "192.168.1.92", (byte)3, 7.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e6a05aac-cddb-4e7c-a4f5-d30628899d1a"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(762), "192.168.1.5", (byte)3, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e6e6d40a-d5a3-4c4f-a50f-8119c253035d"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8901), "192.168.1.38", (byte)2, 89.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e718fefc-528d-4136-9e65-b67b19a3467b"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(861), "192.168.1.12", (byte)3, 7.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e7c299a2-11b0-4786-967b-29e9553e9754"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(203), "192.168.1.61", (byte)3, 40.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e852631e-d35d-423e-a6e5-3a1c1769d338"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9380), "192.168.1.77", (byte)2, 47.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e8c497c8-8516-4df3-8c29-59fd49858696"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9566), "192.168.1.14", (byte)2, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e8da5d2e-6609-4581-9f53-cac02487b3dd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8676), "192.168.1.18", (byte)1, 45.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e8e7a4eb-1311-438c-9911-b49c6344bb20"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(952), "192.168.1.55", (byte)3, 14.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e8f5c187-234f-479f-bed6-6a46a8364b27"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9069), "192.168.1.7", (byte)2, 28.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e9d80c96-9ae5-4fce-8ad6-eb5b6f74dc1d"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(835), "192.168.1.93", (byte)3, 94.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ea1b940c-17d4-438a-8588-e4bad41e06af"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9450), "192.168.1.82", (byte)2, 3.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ea314cac-31a6-4c64-a066-488dde831248"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8353), "192.168.1.60", (byte)1, 80.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ea3733e8-d359-487b-a427-a60f19dcd97f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9316), "192.168.1.72", (byte)2, 34.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ea639ee5-9440-41cf-b499-a5712de5c7b1"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(61), "192.168.1.87", (byte)3, 92.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("eabf99d4-5488-4e6f-ba04-70646363f2ae"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9079), "192.168.1.31", (byte)2, 22.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("eac31464-716d-4540-8fc7-f9ac2ded505f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(333), "192.168.1.73", (byte)3, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("eb84c645-3393-465d-a22a-877b7da8d984"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9177), "192.168.1.48", (byte)2, 92.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ec71e1fa-670e-4b3a-a167-403f12b82d24"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8298), "192.168.1.70", (byte)1, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ecd320a7-2814-497e-b275-cb11b4c1daa2"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(633), "192.168.1.26", (byte)3, 79.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ed61b022-216a-4956-9498-189fc03e3305"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(1047), "192.168.1.21", (byte)3, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ee07c7e9-bfc5-4ff3-a3c7-213d39a40cbb"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(541), "192.168.1.47", (byte)3, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ee3d18a5-9136-42cb-9cee-fbd734819e8f"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(378), "192.168.1.19", (byte)3, 12.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ee682dba-f078-4d0a-807f-26df727f8f49"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8666), "192.168.1.37", (byte)1, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ef61a1ed-4a22-41d5-a813-70bfa0d923ec"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8343), "192.168.1.55", (byte)1, 36.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("efe5bed4-e8de-426b-baf7-d68ec2071d3e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7), "192.168.1.5", (byte)3, 75.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f0199c4f-05fd-4022-8e75-627f62a9fce0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8404), "192.168.1.23", (byte)1, 37.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f0379f9b-48bc-4322-816d-319ffdab6094"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9266), "192.168.1.93", (byte)2, 4.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f044f7f9-7810-467e-84ad-dd6cac713970"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(90), "192.168.1.42", (byte)3, 67.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f0c9fc3e-1298-4d7f-b37c-c86ba78af5e5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9416), "192.168.1.96", (byte)2, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f154d6f6-87eb-44a3-b9b2-ebffb8e611ff"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(561), "192.168.1.52", (byte)3, 85.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f15ad328-bbfc-4ebc-85b9-2085cd31f55b"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7889), "192.168.1.19", (byte)1, 23.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f1bba778-a5b9-42e5-84e9-9fc144733fad"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8315), "192.168.1.39", (byte)1, 58.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f1f670ad-4446-47b1-9932-6db534165fbb"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8625), "192.168.1.74", (byte)1, 31.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f237565e-fcb5-45bb-9187-8aad742f2d99"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9407), "192.168.1.92", (byte)2, 76.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f250ca09-de06-4577-a979-2e9288e21670"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(750), "192.168.1.61", (byte)3, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f2673708-9e09-47dc-9c8c-33ceb8a686b1"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(57), "192.168.1.26", (byte)3, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f28397bd-2ac2-46ad-93f3-e0a26ca4911c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8830), "192.168.1.76", (byte)1, 61.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f2a31603-64f5-40ae-8c09-837b3324c005"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8751), "192.168.1.44", (byte)1, 25.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f2d78662-1c4d-44c5-9607-10692a10a05f"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9127), "192.168.1.43", (byte)2, 13.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f4029118-5887-4e22-86f2-645082eb935c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8311), "192.168.1.98", (byte)1, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f4313d86-3257-4fa7-880f-edb16b0b1195"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8190), "192.168.1.9", (byte)1, 85.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f473d9bf-a2be-478d-8e99-ba7cdfbdadcc"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9398), "192.168.1.87", (byte)2, 69.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f490e2fd-48b8-482c-a79e-9cc5c703de70"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(319), "192.168.1.92", (byte)3, 74.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f49c66b0-469d-4e9a-81b0-6a647256b2c4"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(594), "192.168.1.55", (byte)3, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f53f019b-0229-40b2-8071-f207824f4de8"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8365), "192.168.1.96", (byte)1, 68.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f5887c42-e6bc-401f-b08f-1789b563ade2"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9147), "192.168.1.6", (byte)2, 66.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f607e0b1-1327-448c-8933-4686ca2f3c43"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8862), "192.168.1.19", (byte)2, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f672d0f2-47cb-4be1-aab7-30d613bbda89"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(244), "192.168.1.22", (byte)3, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f6cb7942-ca26-4ca0-86c9-bd853646f78e"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(885), "192.168.1.22", (byte)3, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f8d7f183-ce12-4760-b35c-7e02ff428704"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7927), "192.168.1.66", (byte)1, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f8e3df83-b0d1-46fe-9b44-8231cceed9ff"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7783), "192.168.1.73", (byte)1, 43.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fa0e883b-d7eb-41f9-9d6c-97e970fefdf0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8826), "192.168.1.82", (byte)1, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fa46e10b-494b-43b0-b647-17c84cdb33b6"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(736), "192.168.1.30", (byte)3, 71.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("fa84e467-33d8-49b1-96d4-ad284f5ec146"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(162), "192.168.1.26", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fba9dec2-fa58-4f5b-9727-912da39540cc"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7901), "192.168.1.40", (byte)1, 97.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fbc42ff4-a3e3-41d2-9ce5-48685ea5eae7"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9428), "192.168.1.59", (byte)2, 21.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fbd3b674-7efd-4832-afda-f41a7f50cc96"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(129), "192.168.1.85", (byte)3, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fc206549-28fb-4a25-b281-9079c42ad619"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9775), "192.168.1.32", (byte)2, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("fc35ec2b-1eee-41f1-bd5b-ea73fb7720af"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(94), "192.168.1.76", (byte)3, 19.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("fc74ff1f-e3b8-4cb0-ae04-c5d9fd93fc24"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8566), "192.168.1.48", (byte)1, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("fc837491-0910-4bbc-a5ea-f7e7402420ed"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(839), "192.168.1.25", (byte)3, 64.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("fc841461-dab1-4b36-bbe4-28aaa7d97c06"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7762), "192.168.1.17", (byte)1, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("fcda8bbe-e063-4825-8e18-18ec97378a25"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9198), "192.168.1.55", (byte)2, 34.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fd33839a-eebc-4b45-842d-ca60bdc5c0bd"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8712), "192.168.1.56", (byte)1, 17.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("fd85cb45-e3cc-49b7-9f84-f53d2a351b33"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(843), "192.168.1.83", (byte)3, 31.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("fd8b99fa-0618-49cd-97b7-4818efd0ef06"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8584), "192.168.1.31", (byte)1, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fdab2530-ff84-4cde-8d1f-d724611a4399"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7759), "192.168.1.48", (byte)1, 95.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("fdcc991c-33f2-430a-95e8-0eb88f9cba38"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8174), "192.168.1.29", (byte)1, 95.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fe0635c7-1b1d-4a03-8ea6-c9e2d0e2c374"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(7997), "192.168.1.61", (byte)1, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fe57e3ed-dbc5-4aba-9268-35823f6ce2f0"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8517), "192.168.1.14", (byte)1, 40.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("fed47ecf-e63e-477d-85a1-002a438610a5"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8972), "192.168.1.41", (byte)2, 38.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fedbb34a-ee19-43e0-b560-29741847d697"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8306), "192.168.1.45", (byte)1, 36.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ff1e9532-1ab2-4569-95e4-2bda86603933"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8679), "192.168.1.40", (byte)1, 15.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ff497a4c-5d07-4fd8-a2be-abf9cdf84ef6"), "Computer2", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(358), "192.168.1.32", (byte)3, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ffda9e45-9657-4731-b0e4-7ebe7941be3a"), "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(9686), "192.168.1.30", (byte)2, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ffe6f41a-81a7-46e6-b0eb-0942b40e514c"), "Computer0", new DateTime(2024, 2, 16, 14, 58, 0, 632, DateTimeKind.Utc).AddTicks(8053), "192.168.1.57", (byte)1, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ParentStudents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("0fb0bddd-f174-4483-b761-b4261691163d"), "2-B", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7305), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("25468e07-c32d-43ac-82ca-8d3a710de590"), "1-A", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7268), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("2c06a530-4a95-4e2c-b87a-1bf30a49c767"), "", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7319), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("2dd394d4-60dd-4ee7-9f99-491f7943a821"), "1-A", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7299), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null },
                    { new Guid("3403cda3-57ab-4646-8f29-5d1c9254a4a1"), "4-C", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7325), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("442fd8ab-6271-44af-90ac-941a5ff4009d"), "3-D", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7291), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null },
                    { new Guid("47810bd0-562e-4c32-b586-aba76f0eb4d6"), "", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7296), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null },
                    { new Guid("ae71d934-bba5-461c-97d0-5f12e4d2fe3f"), "", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7311), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("ae8f8aac-a706-4b3e-97a6-7b7da88746ab"), "3-D", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7287), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null },
                    { new Guid("bc6c8a22-69c3-4908-ab36-23a3687fd68f"), "2-B", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7309), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null },
                    { new Guid("be25d384-8590-4682-95bd-4ba7d0bd8d91"), "2-B", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7284), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null },
                    { new Guid("c3602b33-c786-4669-8a0b-de546c56a547"), "", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7294), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("d1982110-ca50-48a8-b54e-226f4fe0af75"), "2-B", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7277), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null },
                    { new Guid("d7393082-ea85-4ed8-bac1-8717c8659da2"), "4-C", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7322), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null },
                    { new Guid("e64a6751-e039-412b-958c-90bd8bdc57bd"), "1-A", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7274), "192.168.1.1", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null },
                    { new Guid("e78b6ce5-f4e3-47dc-981c-1049e3f161bc"), "1-A", "Computer1", new DateTime(2024, 2, 16, 14, 58, 0, 633, DateTimeKind.Utc).AddTicks(7302), "192.168.1.1", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null }
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
