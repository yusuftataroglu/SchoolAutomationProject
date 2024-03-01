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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                columns: new[] { "Id", "Capacity", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(4783), "192.168.1.3", null, "10-A", null, null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(4782), "192.168.1.2", null, "9-B", null, null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(4780), "192.168.1.1", null, "9-A", null, null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(4785), "192.168.1.4", null, "10-B", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(683), "192.168.1.1", null, "Matematik", null, null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(687), "192.168.1.2", null, "Türkçe", null, null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(689), "192.168.1.3", null, "Biyoloji", null, null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(690), "192.168.1.4", null, "Fizik", null, null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(692), "192.168.1.5", null, "Kimya", null, null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(694), "192.168.1.6", null, "Tarih", null, null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(696), "192.168.1.7", null, "Coğrafya", null, null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(697), "192.168.1.8", null, "İngilizce", null, null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(698), "192.168.1.9", null, "Müzik", null, null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(701), "192.168.1.10", null, "Görsel Sanatlar", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1672), "192.168.1.3", null, "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1685), "192.168.1.8", null, "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1677), "192.168.1.5", null, "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1669), "192.168.1.2", null, "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1675), "192.168.1.4", null, "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1687), "192.168.1.9", null, "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1681), "192.168.1.6", null, "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1683), "192.168.1.7", null, "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1690), "192.168.1.10", null, "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(1665), "192.168.1.1", null, "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(2490), "192.168.1.5", null, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(2487), "192.168.1.4", null, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(2484), "192.168.1.2", null, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(2481), "192.168.1.1", null, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(2486), "192.168.1.3", null, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null }
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
                columns: new[] { "Id", "ClassroomId", "ContinuationStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "FirstName", "GPA", "Gender", "GraduatedSchool", "IsPreRegistered", "LastName", "ParentId", "RegistrationNumber", "TotalAbsenceCount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3580), "192.168.1.11", null, "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", null, "110-24", null, null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3560), "192.168.1.6", null, "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", null, "105-24", null, null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3542), "192.168.1.1", null, "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", null, "100-24", null, null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3563), "192.168.1.7", null, "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", null, "106-24", null, null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3582), "192.168.1.12", null, "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", null, "111-24", null, null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3567), "192.168.1.8", null, "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", null, "107-24", null, null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3577), "192.168.1.10", null, "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", null, "109-24", null, null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3553), "192.168.1.4", null, "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", null, "103-24", null, null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3557), "192.168.1.5", null, "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", null, "104-24", null, null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3547), "192.168.1.2", null, "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", null, "101-24", null, null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3550), "192.168.1.3", null, "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", null, "102-24", null, null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(3573), "192.168.1.9", null, "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", null, "108-24", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4499), "192.168.1.13", null, new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4470), "192.168.1.2", null, new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4506), "192.168.1.16", null, new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4501), "192.168.1.14", null, new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4483), "192.168.1.7", null, new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4473), "192.168.1.3", null, new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4492), "192.168.1.10", null, new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4508), "192.168.1.17", null, new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4513), "192.168.1.19", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4497), "192.168.1.12", null, new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4489), "192.168.1.9", null, new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4511), "192.168.1.18", null, new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4477), "192.168.1.5", null, new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4475), "192.168.1.4", null, new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4504), "192.168.1.15", null, new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4495), "192.168.1.11", null, new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4480), "192.168.1.6", null, new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4465), "192.168.1.1", null, new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4487), "192.168.1.8", null, new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(4515), "192.168.1.20", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "FirstName", "LastName", "MainCourseId", "Title", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5246), "192.168.1.5", null, "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5254), "192.168.1.10", null, "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5256), "192.168.1.11", null, "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5232), "192.168.1.2", null, "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5236), "192.168.1.4", null, "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5234), "192.168.1.3", null, "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5227), "192.168.1.1", null, "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5261), "192.168.1.13", null, "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5258), "192.168.1.12", null, "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Başöğretmen", null, null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5263), "192.168.1.14", null, "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5250), "192.168.1.6", null, "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("010313b7-8f9c-4021-869f-c5646ff7616b"), "Computer20", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2709), "192.168.1.87", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null, null },
                    { new Guid("01386b21-023d-4478-af57-4ee25b986dce"), "Computer53", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2863), "192.168.1.17", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null, null },
                    { new Guid("03d627bf-5c96-4a43-8c89-c4ec87ffe72a"), "Computer58", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2889), "192.168.1.24", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("099a7ff4-272f-4524-84e9-d91a8f5c9f22"), "Computer44", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2822), "192.168.1.13", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null, null },
                    { new Guid("12cfbec1-91cd-42e0-8880-f2687552490d"), "Computer29", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2750), "192.168.1.71", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null, null },
                    { new Guid("1410b794-2f24-49f0-87d2-0fca794621cb"), "Computer41", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2810), "192.168.1.75", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null, null },
                    { new Guid("16ec0dfa-b51e-4da1-8ff6-0f035eb66ddc"), "Computer37", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2794), "192.168.1.22", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null, null },
                    { new Guid("18986194-4e5a-401a-a451-fc4dd43f53f1"), "Computer40", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2806), "192.168.1.38", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("1df5c419-67a4-4819-a0ca-068e2c8549ec"), "Computer35", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2784), "192.168.1.74", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null, null },
                    { new Guid("222fa022-9e43-4d47-86d1-ec3c7ed31ac3"), "Computer24", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2728), "192.168.1.74", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null, null },
                    { new Guid("28be6724-8ad9-4b50-87a1-1467e1a0240e"), "Computer56", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2875), "192.168.1.47", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null, null },
                    { new Guid("299e4e9e-d614-4e43-a7c1-7254ea74e323"), "Computer59", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2893), "192.168.1.79", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("2bb6acac-86cc-4238-be5f-a5ac0f57ddf8"), "Computer46", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2832), "192.168.1.61", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null, null },
                    { new Guid("2d3a521d-018b-49d9-92ab-01c3bde75cc8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2612), "192.168.1.42", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("45d01c2c-5fc1-4544-939f-155f871dcd11"), "Computer14", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2685), "192.168.1.60", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("478c5c49-92a9-45d5-a4c9-90e04850f89f"), "Computer13", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2680), "192.168.1.41", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null, null },
                    { new Guid("4fe18ecf-682d-4c65-85d5-b103c35c6c76"), "Computer11", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2669), "192.168.1.32", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null, null },
                    { new Guid("5300e15c-0bd8-44bb-9426-44ff7796fcb8"), "Computer26", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2736), "192.168.1.58", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null, null },
                    { new Guid("53faf4ff-aca5-473f-978d-f4f2184c2a2a"), "Computer55", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2871), "192.168.1.50", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("5b8277dc-e6c7-4f70-96f8-50cc61e56903"), "Computer30", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2762), "192.168.1.42", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null, null },
                    { new Guid("5fae1263-21b3-4df8-9c89-05a1971984a9"), "Computer25", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2732), "192.168.1.12", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null, null },
                    { new Guid("61f762e7-c7fb-4552-9472-572b0021a5bf"), "Computer8", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2656), "192.168.1.14", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null, null },
                    { new Guid("621b164e-ec3c-4d94-83d8-138a22501e84"), "Computer34", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2780), "192.168.1.91", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("68b7a7d4-27f5-4276-8e1d-8b313dedc6fb"), "Computer18", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2701), "192.168.1.3", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null, null },
                    { new Guid("6a8ab0bf-0d6d-4f2b-a347-c8bb46cf4211"), "Computer45", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2828), "192.168.1.75", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null, null },
                    { new Guid("756cbb74-ff3e-4f38-99a1-75ff8691da61"), "Computer39", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2802), "192.168.1.41", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null, null },
                    { new Guid("7f326bb0-a058-42a9-8422-3d36cc977275"), "Computer21", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2715), "192.168.1.22", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null },
                    { new Guid("7fa68bfc-08f6-4267-a371-f91122a9704c"), "Computer50", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2849), "192.168.1.5", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("83544632-ede2-4de3-a1ad-3ab57a742505"), "Computer12", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2673), "192.168.1.66", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("863aa004-232d-4ada-8cfa-091f000062d5"), "Computer27", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2740), "192.168.1.52", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null, null },
                    { new Guid("8c5fd766-25de-4c13-bc9e-151d37395d25"), "Computer31", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2767), "192.168.1.48", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("8f06d667-abe9-4ab0-8c3d-cabcf5124ef7"), "Computer7", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2652), "192.168.1.17", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("916f33aa-f4cf-48a5-a42a-ffbf7fdd4bc3"), "Computer51", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2853), "192.168.1.97", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("9711a259-9f0f-4f74-8b59-b5459a06edf0"), "Computer9", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2660), "192.168.1.45", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null, null },
                    { new Guid("9d0f3bd7-e411-4859-913a-92cbc73a4801"), "Computer43", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2818), "192.168.1.50", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("a053f065-e55b-4d91-9f2f-91b9c83c61e0"), "Computer48", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2840), "192.168.1.76", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null, null },
                    { new Guid("a2efb9ff-2d96-4596-825e-3fde57394516"), "Computer17", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2697), "192.168.1.41", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null, null },
                    { new Guid("a7f097a1-aa42-4efc-b502-2a659ecc6cae"), "Computer49", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2845), "192.168.1.48", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null, null },
                    { new Guid("adfac8c9-2ba8-454d-ad60-77260395b9cf"), "Computer42", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2814), "192.168.1.4", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null, null },
                    { new Guid("aefab0da-4fc6-4629-bf8e-8b927f3ac568"), "Computer54", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2867), "192.168.1.64", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null, null },
                    { new Guid("b23ff0fd-ee20-4fa6-9045-5d811d9a4e73"), "Computer47", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2836), "192.168.1.96", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null, null },
                    { new Guid("b68c9431-cb52-4ff2-9bc7-94273addf17e"), "Computer32", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2771), "192.168.1.64", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null, null },
                    { new Guid("b824fd86-2588-4ef7-9eda-623ac0c45b88"), "Computer38", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2798), "192.168.1.56", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null, null },
                    { new Guid("bc270fc0-22c7-4d4f-bdff-61f259b7426e"), "Computer60", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2897), "192.168.1.11", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("bee34c6b-4859-4849-98b7-af7d16f612c4"), "Computer19", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2705), "192.168.1.73", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("c05ef970-2e53-4131-927a-52cd2c7d6561"), "Computer33", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2775), "192.168.1.57", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null, null },
                    { new Guid("c2857fac-17df-47da-af19-e261af715d60"), "Computer6", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2648), "192.168.1.72", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null, null },
                    { new Guid("c2de6598-7bf5-42e7-990a-a58c729b6012"), "Computer36", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2788), "192.168.1.67", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null, null },
                    { new Guid("c6c80743-be3d-4701-9dfc-5af7cc833ec8"), "Computer52", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2857), "192.168.1.91", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null, null },
                    { new Guid("de0b5b1e-6aef-4be9-935e-8bf4bc33bc85"), "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2620), "192.168.1.29", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null, null },
                    { new Guid("e485789c-6985-4690-9ac4-bce939a5e4ab"), "Computer15", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2689), "192.168.1.64", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null, null },
                    { new Guid("e71dd03f-48a3-4e2f-aed2-8f2d90505be8"), "Computer10", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2665), "192.168.1.28", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null, null },
                    { new Guid("e9f6ef63-12bd-439a-8319-f6faa567d2d2"), "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2616), "192.168.1.70", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null, null },
                    { new Guid("eb885065-849b-4d45-86c2-c529ae9e266d"), "Computer23", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2724), "192.168.1.63", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null, null },
                    { new Guid("ed6bab61-4afe-4b83-a7b6-974f6eacebea"), "Computer16", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2693), "192.168.1.11", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("f2d4e3c1-5822-4580-ba93-c0732d95fe18"), "Computer28", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2744), "192.168.1.66", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("f739dbd0-0792-4c14-adac-bdd860b347f3"), "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2642), "192.168.1.75", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null, null },
                    { new Guid("fca87f4d-889a-4be7-b538-abb467888125"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2567), "192.168.1.67", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("ff08bd9c-0ee8-4a56-8d87-c5832b7e3b55"), "Computer22", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2720), "192.168.1.66", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null, null },
                    { new Guid("fff4246f-bac8-49f4-915a-2f6763a87121"), "Computer57", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(2879), "192.168.1.94", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("08348459-80cf-4127-b12e-d852a3f27581"), new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3779), "192.168.1.98", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("0f96c8ec-1112-4f8c-a501-97ba6ba0114c"), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer17", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3882), "192.168.1.38", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("14e30421-ba10-4dbf-8d49-265e0501dff5"), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer12", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3854), "192.168.1.95", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("1c2807a1-7c17-483f-b066-fe35c0a62975"), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer25", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3936), "192.168.1.89", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("23cc1b19-d325-471f-adf0-742cb0f783dd"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer6", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3824), "192.168.1.72", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("34e0c023-0858-4de6-a2c0-a1cd62f6696d"), new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer3", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3806), "192.168.1.16", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("358ca1c1-1ec3-417c-b817-e93ac0700977"), new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer5", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3818), "192.168.1.80", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("3cd5a26b-58d7-451d-afe6-31ae90372db3"), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer8", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3833), "192.168.1.34", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("44106d43-4ef0-4cff-a983-edf2f110a3d4"), new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer31", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3972), "192.168.1.53", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("572843ba-d585-49e0-a700-899a454314cf"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer36", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(4000), "192.168.1.19", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("5925c4f1-e932-4cf2-b58a-e503eb6c93dc"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer13", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3859), "192.168.1.13", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("5e516bc5-d187-4a74-b42d-5a3379e6cfb6"), new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer37", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(4005), "192.168.1.32", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("624a70ab-1096-42f9-86d7-4404b7264b9d"), new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer29", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3961), "192.168.1.76", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("7055b4c7-1305-4360-b379-a3686fa6d2c2"), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3798), "192.168.1.45", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("7e9e7475-c717-4a78-80b3-f6bc599d824e"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer26", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3943), "192.168.1.74", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("822fcf68-9463-4e01-8e70-55fab46f42cb"), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer16", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3877), "192.168.1.97", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("88836235-7d2f-43a0-8069-2c7724fc2aac"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer14", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3865), "192.168.1.34", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("892c9b59-ceab-4c13-88dc-b61da53a2c98"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer9", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3840), "192.168.1.37", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("9050c5b5-33e8-4e9e-a8a8-7c5df34e5ac6"), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer21", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3911), "192.168.1.14", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("926f9b99-4793-47e8-8e44-e9b91244fd50"), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer34", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3988), "192.168.1.70", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("983b0879-0c04-4dae-a663-581bda0f2ac3"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer19", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3900), "192.168.1.58", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("9a73649c-b4a7-4e18-a736-b926c2c63b38"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3967), "192.168.1.22", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("a82af6cc-4f4d-402b-b2d5-f71d319dc1f3"), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer22", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3920), "192.168.1.95", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("a902afc6-bd53-45a7-ab67-407d8e167e40"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer33", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3982), "192.168.1.58", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("a922bae6-a82e-4268-8e19-400471c7ecdd"), new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer7", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3829), "192.168.1.92", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("b12590ed-09cf-4adc-8938-5a40835528a5"), new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer18", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3894), "192.168.1.9", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("b5fa896d-86ac-4b3e-a19a-e968f271d36b"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer23", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3925), "192.168.1.77", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("b8b7ed88-f4c7-46f8-a2d1-c450e7bdd6e9"), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer15", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3871), "192.168.1.30", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("bd41e685-683f-4369-b043-32991fbc0942"), new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer27", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3949), "192.168.1.27", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("cf9e143c-08fb-4a0e-b67f-716ddba8e929"), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer32", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3977), "192.168.1.41", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("d1878132-bfb3-404a-993e-3c30f2050874"), new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer35", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3993), "192.168.1.8", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("d853eacb-124d-4ae1-9e1c-c79a9bfa574e"), new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer11", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3849), "192.168.1.34", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("e4bc0cf8-d6e4-4ac4-acbf-0d2f24c41bad"), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer10", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3845), "192.168.1.57", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("e8acd24b-666a-4a95-aacf-257c2f0fab77"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer28", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3955), "192.168.1.19", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("e9168e25-dd8a-45b6-ac02-359116c0915f"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3791), "192.168.1.61", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("edd86e9a-5245-4524-b5f3-fc3f83f0b76a"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer24", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3931), "192.168.1.46", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("eef7f10f-6dda-45c4-9e54-0da2cb404481"), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer20", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3905), "192.168.1.26", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("f4c7df0a-3e72-4561-a864-9f0926243599"), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer4", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(3811), "192.168.1.3", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null }
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
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "StudentId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("859b02a8-2a87-4d35-ab0f-cadcf9171094"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(7918), "192.168.1.40", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null, null },
                    { new Guid("fbd7bb0f-b1cb-4eb1-907b-c54eb0a7e6c2"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(7879), "192.168.1.30", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("0020fe6e-5587-44a3-be8b-1d56180dac5c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6071), "192.168.1.4", null, (byte)1, 51.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("0051da7f-da05-4409-9561-a18f27787768"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6783), "192.168.1.44", null, (byte)1, 35.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("00afd08a-de80-4cea-a836-c809cf0bc31a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8982), "192.168.1.99", null, (byte)3, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("0108ff33-cbef-4702-ac03-85f5c9fa5894"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7156), "192.168.1.59", null, (byte)2, 6.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("013fcbbc-c8be-4540-a813-3ce920f8890c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6913), "192.168.1.19", null, (byte)1, 50.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("01b5d030-7cbb-4ac8-b912-64043f21b397"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7907), "192.168.1.15", null, (byte)2, 45.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("022babc9-81e0-4489-9a42-dd1740a1a4c5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9318), "192.168.1.42", null, (byte)3, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("024c590a-a19b-4389-ab7f-6e14bc9da4a2"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8811), "192.168.1.23", null, (byte)3, 30.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("02b0ca25-179c-410a-8ade-4c6d8d375b18"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6603), "192.168.1.35", null, (byte)1, 86.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("02f83add-3a28-4ec3-a7ae-28fca5b13676"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7772), "192.168.1.48", null, (byte)2, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("02f989f9-b6fd-431e-84d8-c51c4af81dba"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8471), "192.168.1.61", null, (byte)3, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("0324b531-be8d-4014-bb3f-2996865015dd"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8172), "192.168.1.75", null, (byte)2, 39.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("032de0b7-7d20-483a-b4d2-923c67b018d8"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7368), "192.168.1.69", null, (byte)2, 19.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("03cbb78c-7acd-44a2-b8d2-f76614be9578"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8712), "192.168.1.23", null, (byte)3, 64.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("04368bca-b238-4a01-8621-1f0757370c58"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9158), "192.168.1.41", null, (byte)3, 70.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("04c94d9d-be29-48f0-9e49-01a57bfecd74"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5873), "192.168.1.72", null, (byte)1, 40.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("051a69ab-df51-4c51-b95c-73d4e05a06a5"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7147), "192.168.1.7", null, (byte)1, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("05315d1e-2849-4a2c-8f10-665e487cc2c4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7431), "192.168.1.27", null, (byte)2, 86.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("05f873b7-c0d8-4a81-8143-c394cf22adf5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8502), "192.168.1.49", null, (byte)3, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("061d3083-3ee4-4309-8c5d-6b48922d446e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7001), "192.168.1.76", null, (byte)1, 12.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("075fab3e-2e4c-42ec-b6fc-ccb626b7c5bd"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7288), "192.168.1.39", null, (byte)2, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("0779689b-a64d-4427-9106-1f15afa5fe11"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7638), "192.168.1.89", null, (byte)2, 68.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("07c909be-5063-4126-9653-033003107585"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7501), "192.168.1.11", null, (byte)2, 93.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("082cbf04-7bc0-443c-a37a-aee6ff5b4862"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9050), "192.168.1.44", null, (byte)3, 4.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("086f8a4a-eb80-4ce2-b7b7-6297f763384b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5965), "192.168.1.35", null, (byte)1, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("09011786-8abb-4910-bcb3-84cec33e03a2"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6679), "192.168.1.32", null, (byte)1, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("0a999272-5ae5-4375-bdb5-615983821d8e"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8354), "192.168.1.30", null, (byte)3, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("0a9b3b9c-bbdf-47df-8bb6-f399cc9aac59"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5721), "192.168.1.96", null, (byte)1, 55.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("0b0c4b52-f0ed-468f-aa7c-81fdbd4baf81"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8046), "192.168.1.44", null, (byte)2, 55.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("0b92f4bd-82a2-4acb-a373-5c83340ed80b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5705), "192.168.1.94", null, (byte)1, 40.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("0b9d69b0-fb6d-49a0-918b-c4cf49c1534f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8319), "192.168.1.94", null, (byte)3, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("0c736c82-dd6d-4f5c-b8fe-6d9236b6e09b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9265), "192.168.1.9", null, (byte)3, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("0c8ba2dd-963f-453e-bf66-76b98c9ffc64"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6551), "192.168.1.66", null, (byte)1, 25.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("0cc40cdd-86a4-4a21-bd6f-113716ba1af7"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9123), "192.168.1.99", null, (byte)3, 17.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("0d346127-0ed2-4e9f-a9e6-7b922a56157b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8772), "192.168.1.34", null, (byte)3, 46.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("0d98a27c-9fda-47b3-899a-7fd1b08fd990"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8716), "192.168.1.64", null, (byte)3, 41.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("0dec135e-d519-459a-97e5-9dbf987e96a6"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9362), "192.168.1.50", null, (byte)3, 63.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("0e0b9fa3-2b3b-44c1-a0a3-3a3e527e877a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9195), "192.168.1.34", null, (byte)3, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("0e0e43ac-10ef-4ad6-912c-1426857c7b16"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8884), "192.168.1.3", null, (byte)3, 90.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("0e6e5d01-1c97-44f7-88bb-846561b1f272"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5993), "192.168.1.75", null, (byte)1, 23.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("0fe0d8c8-6759-4b1e-aba0-e4e0558d2154"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6931), "192.168.1.30", null, (byte)1, 42.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("0ffc26eb-4404-44ae-a740-a212f1cd9687"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8935), "192.168.1.99", null, (byte)3, 59.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("1007f6da-0c6d-4d5a-8059-7abecc3c19ea"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7980), "192.168.1.30", null, (byte)2, 11.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("10d40112-4780-4204-a33c-c7229f5ef73f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8345), "192.168.1.42", null, (byte)3, 0.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("10ee635e-ee0a-4dab-a118-0366c732016d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6745), "192.168.1.75", null, (byte)1, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("10eedb45-646e-4e21-85f5-83ec81a6f41e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7951), "192.168.1.64", null, (byte)2, 9.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("1159dd31-3538-4a12-8259-7e1ceaecb21a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7755), "192.168.1.81", null, (byte)2, 60.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("11f8f4d3-f95c-4f3d-8d90-850a61d658b6"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8419), "192.168.1.73", null, (byte)3, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("124383ae-f831-434d-adbf-868b16300691"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8512), "192.168.1.98", null, (byte)3, 7.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("124e04c8-d554-43e7-b9b9-92e8073ef50c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5914), "192.168.1.62", null, (byte)1, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("125227d1-3ac1-4b76-924f-b2595fe0e922"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9103), "192.168.1.17", null, (byte)3, 5.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("12bc733b-5325-4437-b6fe-e3261c0e6ece"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9046), "192.168.1.60", null, (byte)3, 97.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("12fbc971-39bb-4f45-908b-eb486a37b836"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7341), "192.168.1.47", null, (byte)2, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("13c5e0c9-a43d-4522-86aa-e8302c57d76c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6927), "192.168.1.83", null, (byte)1, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("13f5206a-1625-45b6-83bf-b6932d924c31"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6970), "192.168.1.69", null, (byte)1, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("1406b0ed-5aef-440c-9ea5-9084d7c540ad"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7193), "192.168.1.31", null, (byte)2, 10.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("145408a0-9e8e-4176-b07e-aa60cb288fdc"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7682), "192.168.1.29", null, (byte)2, 77.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("14d2eaa0-9bf8-4b42-b1ac-79e2201cbe4f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7725), "192.168.1.4", null, (byte)2, 10.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("156d7afc-efcb-4a41-be5d-48453c49b038"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7262), "192.168.1.22", null, (byte)2, 37.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("15e25248-1c03-47c0-ba85-df56beda1ce0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6696), "192.168.1.83", null, (byte)1, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("169ac7d6-c20a-46cb-aef9-63b527ce5a2c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6692), "192.168.1.58", null, (byte)1, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("16d937ac-d0c8-44f2-9040-3e52167d9d58"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8889), "192.168.1.49", null, (byte)3, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("1736944b-c123-4098-8c07-a4010be8dd91"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8221), "192.168.1.79", null, (byte)2, 93.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("1841efb1-1347-4e4e-b918-55aed039e318"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8298), "192.168.1.19", null, (byte)3, 35.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("188433fb-42a9-4990-b45d-2132b63bdf02"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7120), "192.168.1.4", null, (byte)1, 47.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("1908f500-d659-46d2-acb2-062d8c8f2c45"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8841), "192.168.1.42", null, (byte)3, 97.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("19845d5b-7b44-47c0-8a50-6f5a1a42b554"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7388), "192.168.1.52", null, (byte)2, 89.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("1a82e141-1704-4bcd-b131-d5cc2617843d"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8767), "192.168.1.85", null, (byte)3, 61.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("1a8852b0-d4cb-4afe-9881-7d20da42f319"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6991), "192.168.1.44", null, (byte)1, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("1bbf04ac-0b23-4226-ba20-b3c31d5c0da7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5776), "192.168.1.89", null, (byte)1, 13.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("1c1330b9-ba72-4e6c-997c-2ea6387e694a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6652), "192.168.1.3", null, (byte)1, 2.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("1d4ed933-9f76-4fb3-91c5-e90aa8ee16bc"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8402), "192.168.1.48", null, (byte)3, 76.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("1d5b59d4-094c-4561-83ce-71f9cb5006d7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7077), "192.168.1.20", null, (byte)1, 93.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("1d6d3efb-01cb-4051-8025-cbce481fb048"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6032), "192.168.1.49", null, (byte)1, 79.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("1e39ed01-4c69-45c6-a516-c509e75fd0e4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7706), "192.168.1.58", null, (byte)2, 24.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("1eacf3db-6fd1-4821-959c-ca3b2564cd46"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8866), "192.168.1.78", null, (byte)3, 75.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("1f405fa2-1115-4fa2-b080-988b4d78feb4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7572), "192.168.1.14", null, (byte)2, 9.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("203cf393-c051-401e-bcf2-5ae01bee5fb6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7509), "192.168.1.91", null, (byte)2, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("2041afef-ddcf-41b3-9f3d-f06cecd3c62c"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8245), "192.168.1.11", null, (byte)2, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("2098643b-53d9-4dd5-9279-1cddbe3180a0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9417), "192.168.1.6", null, (byte)3, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("20b7b9ec-6e52-4ca9-8713-a07632d0a50d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7031), "192.168.1.50", null, (byte)1, 37.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("20c044d2-ae54-4860-a266-9f9d720202ab"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7173), "192.168.1.97", null, (byte)2, 21.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("21a021ca-0f4b-45b5-ab23-c25478b09603"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6683), "192.168.1.83", null, (byte)1, 31.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("2272c1b4-7b97-413c-8e2e-2c7764f9c7f4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8282), "192.168.1.67", null, (byte)2, 32.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("23a2300c-4463-4620-98fa-8e3db60a97d6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7817), "192.168.1.90", null, (byte)2, 59.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("2419e38a-abe1-4f67-a7ac-fd7759ce5b47"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7223), "192.168.1.9", null, (byte)2, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("2446c1e0-f02f-485e-b794-a8c505ceba41"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5767), "192.168.1.98", null, (byte)1, 25.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("2463c9b6-084a-4487-ab74-18c88c77597a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9199), "192.168.1.42", null, (byte)3, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("25f96d87-83b0-4b45-81e7-19999c280302"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6195), "192.168.1.34", null, (byte)1, 94.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("25fdda22-8d14-40a0-92fb-c6c6d929a94d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8204), "192.168.1.69", null, (byte)2, 90.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("26c99496-0ebc-4ae1-b640-5da3cf79b424"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6170), "192.168.1.94", null, (byte)1, 30.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("273c63b8-ab0f-4d70-89f4-0d7ce4f074ea"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9217), "192.168.1.69", null, (byte)3, 30.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("27500625-dd2a-435f-97d7-cfd78bf460db"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6844), "192.168.1.79", null, (byte)1, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("27d18d14-191f-4559-a8ad-45f6af573f6c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6814), "192.168.1.99", null, (byte)1, 85.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("2801dc5b-8679-469e-959e-630288355aa1"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7470), "192.168.1.13", null, (byte)2, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("280d87bd-1d3e-4e4e-91a9-5c38ca5048f5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9392), "192.168.1.51", null, (byte)3, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("2839add6-502b-42a0-b4a5-ed2bc2538c84"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9150), "192.168.1.26", null, (byte)3, 61.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("28fa77dc-0942-4683-9f0e-05e05fa2264a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8486), "192.168.1.37", null, (byte)3, 40.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("29d46461-3421-4bbe-abfd-9530cab709fe"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7568), "192.168.1.91", null, (byte)2, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("29f1d9d4-a386-442f-bfa6-f02cacfacb00"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5864), "192.168.1.70", null, (byte)1, 28.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("2a0f6a3e-13aa-4d50-8ec2-ae91c3bdf48f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9427), "192.168.1.39", null, (byte)3, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("2a641add-9174-4563-a8cd-7ba3e34ec943"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7934), "192.168.1.47", null, (byte)2, 69.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("2ae7b60c-9ce9-4dac-bdd2-0bfd8d4fb01f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8900), "192.168.1.58", null, (byte)3, 68.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("2aebd51b-7bc5-451f-bf3c-15d959bfcf6c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8313), "192.168.1.41", null, (byte)3, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("2b2d7e09-e781-40d9-871d-ca2e6ed7ecab"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9037), "192.168.1.20", null, (byte)3, 5.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("2bf736aa-2231-46c2-9b39-96c7a3aa4c6b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7422), "192.168.1.9", null, (byte)2, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("2c066afb-826d-4570-bdd1-e5f48d1ed1cd"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7620), "192.168.1.99", null, (byte)2, 40.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("2cce1e09-5885-4232-a428-e4e272b8987a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9396), "192.168.1.76", null, (byte)3, 11.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("2cdc1434-d362-4cbb-a659-5c464930f3e3"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6889), "192.168.1.49", null, (byte)1, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("2cec87ce-2a0b-4844-b419-d7d7e8b9b6f4"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9248), "192.168.1.43", null, (byte)3, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("2d38ff8f-a972-4d04-bd07-49c9b27906ed"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8547), "192.168.1.95", null, (byte)3, 91.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("2ec0073d-f901-4380-9be8-c67b50027f98"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8152), "192.168.1.29", null, (byte)2, 43.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("2ec314df-193e-439e-92cd-b09e8ae5c2a2"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8094), "192.168.1.96", null, (byte)2, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("2f2a813b-0282-4abf-89cf-f2a0b3200689"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9405), "192.168.1.16", null, (byte)3, 77.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("2f3102e2-7433-4fc9-93fd-7486430d4d50"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7458), "192.168.1.63", null, (byte)2, 96.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("2f7ea88d-2ebf-4297-832d-bd819fe17b22"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7237), "192.168.1.25", null, (byte)2, 55.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("2f8190da-d98e-4c59-866f-93557ab8f9ad"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6628), "192.168.1.84", null, (byte)1, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("2f8996e0-081c-4d38-af38-628fa606124c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8695), "192.168.1.7", null, (byte)3, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("2fc13b26-efcd-4af2-a842-b451933661bc"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7345), "192.168.1.94", null, (byte)2, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("2fc6f09e-d33f-4beb-90f6-7a5acc460c63"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8085), "192.168.1.44", null, (byte)2, 29.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("2ffeed13-0a92-412f-89a8-2f7267a9e54a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8217), "192.168.1.91", null, (byte)2, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("30360532-4ada-4b3a-abe8-6c9234db8625"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6956), "192.168.1.40", null, (byte)1, 3.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("30cb654e-5387-4e57-abee-3e4083a661da"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7297), "192.168.1.75", null, (byte)2, 75.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("32354cab-25f0-44f7-807a-d856dbf32aa0"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7663), "192.168.1.26", null, (byte)2, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("3267b171-aa38-4078-822e-562a4c2aa37a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8802), "192.168.1.44", null, (byte)3, 7.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("32754bdf-f9f3-4ce2-ae0b-19b939d65640"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6559), "192.168.1.81", null, (byte)1, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("32caded1-77be-45e9-8bad-feb4266835ab"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8537), "192.168.1.15", null, (byte)3, 73.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("33020fc2-7a02-4bae-a68e-5b7038026b8b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9054), "192.168.1.31", null, (byte)3, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("338b0b88-3a24-4913-9375-caaf9308101e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7603), "192.168.1.52", null, (byte)2, 19.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("339d70dd-a12f-45d3-955d-ce241441be6b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6935), "192.168.1.35", null, (byte)1, 68.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("340f35f9-0062-421a-a9cf-d0680770e51a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8428), "192.168.1.71", null, (byte)3, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("34368988-e6e8-464d-96c4-dc08858fd892"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8498), "192.168.1.90", null, (byte)3, 84.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("34502482-be1c-473c-be94-121cad74ed54"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5725), "192.168.1.74", null, (byte)1, 40.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("349cd93d-38e7-428f-8502-a5fb3d69bd5e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8106), "192.168.1.30", null, (byte)2, 22.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("34a31667-e782-4978-93fa-fc3667bcc338"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8912), "192.168.1.52", null, (byte)3, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("354dc1a9-fd2d-4bd1-bf7b-bf4a5473b7e1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6090), "192.168.1.66", null, (byte)1, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("35bb3767-63a9-4578-bd99-62cc15cf6245"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5953), "192.168.1.85", null, (byte)1, 42.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("35f61768-0851-4ab1-91d1-5666aa2a5200"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8646), "192.168.1.85", null, (byte)3, 30.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("361dd5cc-a122-4770-8201-0553f0e189fc"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9099), "192.168.1.74", null, (byte)3, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("361dd86e-b82f-468f-8ec5-f373f3a75d01"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7791), "192.168.1.22", null, (byte)2, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("368f9ae8-94ef-4fe9-9c3a-213df37e01b7"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8730), "192.168.1.22", null, (byte)3, 25.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("36b3375a-6333-4a05-831a-9ce99afc3d4c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7058), "192.168.1.65", null, (byte)1, 69.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("37fec137-968e-4810-b753-f5d5644b226c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9089), "192.168.1.45", null, (byte)3, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("38ed9d2f-261e-40cd-8ed3-f3bcd15b6fc0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6114), "192.168.1.34", null, (byte)1, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("39323c57-4c37-40d5-a30e-2e54b39cb437"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7760), "192.168.1.45", null, (byte)2, 36.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("39897473-b248-4cd4-a00e-c749672e1055"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9064), "192.168.1.84", null, (byte)3, 33.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("39992572-358d-4483-87e1-0944344ed95b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5926), "192.168.1.58", null, (byte)1, 78.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("39df9a61-9b16-402b-891f-6fcf362cfc15"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8007), "192.168.1.96", null, (byte)2, 65.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("39f900ea-8dc7-4130-8bdc-c09a7f2151e2"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8757), "192.168.1.37", null, (byte)3, 36.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("39fae0d3-07bb-41b0-827a-0c36502bf959"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7108), "192.168.1.6", null, (byte)1, 52.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("3a8d2b83-7c6a-4b6b-a055-eb7aa0f992ac"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7646), "192.168.1.56", null, (byte)2, 82.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("3b15551e-e96b-4b24-ac29-f9f1c8c31a01"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8961), "192.168.1.50", null, (byte)3, 33.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("3bfcdb58-d833-4572-8f12-20199eec95f9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7112), "192.168.1.71", null, (byte)1, 36.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("3c2b00fd-dadc-41cd-adf1-1221b5eddf65"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7318), "192.168.1.57", null, (byte)2, 79.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("3c2e6bc7-c2f3-4c70-87cf-493f01f47211"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8117), "192.168.1.59", null, (byte)2, 23.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("3c5bfbe7-4096-4568-a629-41578d70ce99"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6124), "192.168.1.29", null, (byte)1, 48.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("3d00594a-a623-44e2-a432-4e6dbe8d022e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7013), "192.168.1.64", null, (byte)1, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("3d275936-725f-461f-ac28-ddd4ae03f8c7"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7678), "192.168.1.11", null, (byte)2, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("3d92733e-3e8c-4a2c-bc22-4c6a5b126f82"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6164), "192.168.1.61", null, (byte)1, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("3dfbf592-aa95-4c9f-814d-7a8917eece93"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7821), "192.168.1.82", null, (byte)2, 77.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("3e244ac8-6c19-4632-804e-ff6dd6b0fdc0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9307), "192.168.1.18", null, (byte)3, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("3e55b18f-f3c0-47fe-8938-318daec6c502"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7993), "192.168.1.98", null, (byte)2, 12.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("3e86fd92-db66-4402-8a81-50b364a3609f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8032), "192.168.1.20", null, (byte)2, 52.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("3f0b3cfa-29a5-46bf-adda-e9456300e5f4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8177), "192.168.1.43", null, (byte)2, 23.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("3f7535f8-be18-4f4a-9f55-6fbb90cf49f1"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9107), "192.168.1.55", null, (byte)3, 69.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("3fa5c583-fbe0-427d-b21d-4bd526bfcc78"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7837), "192.168.1.41", null, (byte)2, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("3fcdf5e2-db2c-4c36-8392-900df453ed56"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6675), "192.168.1.74", null, (byte)1, 76.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("3ffe28af-76e0-410e-b437-7d0c863c72d4"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8410), "192.168.1.43", null, (byte)3, 57.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("4160d646-57a0-4f3b-b09a-bd6f79ea601d"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8455), "192.168.1.47", null, (byte)3, 89.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("428938c2-ed28-4a36-b742-69359f424ad7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5846), "192.168.1.74", null, (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("43b0d397-adc6-4c24-a622-bf37ae60a3d9"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7782), "192.168.1.17", null, (byte)2, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("441b3663-818e-4717-8647-c6ff891d6c18"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9229), "192.168.1.97", null, (byte)3, 70.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("445ba8d1-f2ee-4abc-9278-94558b0be5be"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7628), "192.168.1.34", null, (byte)2, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("44abc5e8-674a-4b30-b8f2-358a18a2c1c1"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8793), "192.168.1.53", null, (byte)3, 18.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("44fc4ec0-bbac-41e8-805b-ca5425bda712"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6773), "192.168.1.71", null, (byte)1, 87.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("4523dc27-0468-4388-950e-5a2c20c10ae0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6800), "192.168.1.82", null, (byte)1, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("4547a129-005a-401b-b2f6-0fa33bb4cf04"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8541), "192.168.1.95", null, (byte)3, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("45a820c4-a0d4-4b76-9b35-36464ef3b34e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6199), "192.168.1.12", null, (byte)1, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("45e3e95a-a35e-453f-a63c-1f90161ea7a4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6787), "192.168.1.23", null, (byte)1, 15.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("45e796bc-af69-453e-8fe8-40019e8bbdc6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7333), "192.168.1.39", null, (byte)2, 71.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("461d57cb-a7d6-480c-a64d-10dddd3f6983"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8135), "192.168.1.56", null, (byte)2, 44.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("46c5c3f2-822d-4d90-8622-681da016f345"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9209), "192.168.1.91", null, (byte)3, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("473c6d1f-0373-43b0-a0e6-b3420e6464b7"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7151), "192.168.1.81", null, (byte)2, 65.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("4785460f-3179-48c7-b773-347c25e1e7fb"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6555), "192.168.1.33", null, (byte)1, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("47b931e9-5bfb-4eca-921d-00439a39a831"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5763), "192.168.1.27", null, (byte)1, 63.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("48144f21-c83e-461b-a46a-57aff33d35ac"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9168), "192.168.1.72", null, (byte)3, 50.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("483f5379-982e-4271-a55a-c450e21ddd4d"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8780), "192.168.1.84", null, (byte)3, 53.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("4870b35f-e83b-48cd-bc91-8cc2bb6631ae"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8235), "192.168.1.64", null, (byte)2, 4.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("48b046e8-210b-42c1-953b-c7512d3bc3a6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8067), "192.168.1.67", null, (byte)2, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("48bb775d-8160-4739-b1f1-e997486535d6"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8784), "192.168.1.66", null, (byte)3, 12.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("49505041-7aae-48bf-a4a5-4dd654faa21f"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6581), "192.168.1.61", null, (byte)1, 92.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("4960b11e-419e-4599-9555-1fd153015c1a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5940), "192.168.1.67", null, (byte)1, 24.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("499cb2a4-6589-4b24-bb3a-4605305c1a06"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8208), "192.168.1.53", null, (byte)2, 65.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("49a13964-4f08-4e20-b8d4-909ea7047eff"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9400), "192.168.1.59", null, (byte)3, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("4abd70a1-b6aa-47fc-8257-98340e18776c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5729), "192.168.1.33", null, (byte)1, 86.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("4aea773e-ee11-4288-8487-a9b44054697e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6128), "192.168.1.16", null, (byte)1, 38.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("4aecfd1c-5237-4e26-8987-5ee00976b99e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7864), "192.168.1.44", null, (byte)2, 1.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("4b20136b-7583-4e20-a931-a9791e729fb0"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7845), "192.168.1.89", null, (byte)2, 11.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("4b853481-7bf9-43f8-912b-3e8d0b3ba730"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5811), "192.168.1.37", null, (byte)1, 10.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("4bde9506-189d-4529-9f7c-5d41a27d38ba"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5819), "192.168.1.94", null, (byte)1, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("4c0cb5c6-d662-479b-ba7b-d103c3312130"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9127), "192.168.1.85", null, (byte)3, 74.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("4c18577e-422e-4cf7-88c1-eb02fa201826"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8255), "192.168.1.69", null, (byte)2, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("4c8d2acb-4a0a-4858-b5e2-a9acb0111029"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8359), "192.168.1.70", null, (byte)3, 12.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("4cb0e9a8-c8ea-413c-aa4d-d72684de1d49"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8832), "192.168.1.36", null, (byte)3, 25.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("4d2d53b4-046a-4fb9-8ed9-cfd242f31b8d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7528), "192.168.1.94", null, (byte)2, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("4d3f3092-a19d-4a48-976c-e5de0713f1a8"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8102), "192.168.1.57", null, (byte)2, 55.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("4d48dfe5-83de-45da-9fa5-d5a8a4bb7056"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5850), "192.168.1.8", null, (byte)1, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("4e03b981-5869-4159-a137-a2a0b7ba5056"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5751), "192.168.1.6", null, (byte)1, 82.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("4e202598-6c4b-4f3b-afd2-4b9b6a126fba"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6987), "192.168.1.15", null, (byte)1, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("4e35b15f-faa4-499f-b697-e2bdf546fe90"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8876), "192.168.1.66", null, (byte)3, 67.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("4e99d3d8-cdaa-4ead-965a-5effdfc5d74f"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5692), "192.168.1.74", null, (byte)1, 13.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("4e9d6ab8-1d33-4ccd-ab38-865d56f15b2f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7519), "192.168.1.74", null, (byte)2, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("4f06e7ad-85e8-43e6-ae69-fe7b96b93bc0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5979), "192.168.1.1", null, (byte)1, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("4f3ce626-2944-44fc-829d-c8fa69cc67f9"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7523), "192.168.1.29", null, (byte)2, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("4f59bc32-e565-435e-ad62-3f9bc89b6635"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6760), "192.168.1.6", null, (byte)1, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("4f77b31b-1bb7-4b68-8f57-ce12f307d3ed"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7642), "192.168.1.34", null, (byte)2, 80.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("4f9328a6-5e04-4e64-a465-8169c16a6dba"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6576), "192.168.1.51", null, (byte)1, 4.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("4fcbd604-d861-4a74-b42e-be5f6ed7802b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7376), "192.168.1.32", null, (byte)2, 59.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("4fdb0a14-a539-4f14-a05f-92cd97eedc99"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6687), "192.168.1.30", null, (byte)1, 39.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("503f9002-c096-4f78-8cdf-d6e3e255586e"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8691), "192.168.1.59", null, (byte)3, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("505925b6-80c9-4d6a-bed0-14b4bdd49808"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8490), "192.168.1.77", null, (byte)3, 92.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("50a35999-ddca-4c88-aea4-621e0adf5d4e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5975), "192.168.1.48", null, (byte)1, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("511aadee-38af-4905-a5f8-e49becfec884"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7067), "192.168.1.42", null, (byte)1, 73.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("5199327f-5ddb-4db2-88e1-26004d5ae2f1"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9058), "192.168.1.22", null, (byte)3, 14.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("51b0bae2-d17f-45f8-a506-0124ced31251"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7554), "192.168.1.52", null, (byte)2, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("52632973-25e5-400c-aa82-be91b5186d0e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6106), "192.168.1.58", null, (byte)1, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("535fa818-23e9-4deb-bc52-22c4ab10bf20"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7133), "192.168.1.79", null, (byte)1, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("5360ea66-3ea6-40d0-84d1-1f8d5b815eb4"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9423), "192.168.1.39", null, (byte)3, 70.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("53daf6c5-a3af-4247-9d7a-205625bb5c55"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7219), "192.168.1.65", null, (byte)2, 99.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("54488065-1f0d-41aa-81c4-30342de3ee7e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7712), "192.168.1.86", null, (byte)2, 77.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("5450544c-3ab0-471b-9579-a9abf3b81ef8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8862), "192.168.1.82", null, (byte)3, 24.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("546319c2-bcd5-4164-aed7-6165587d7024"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6818), "192.168.1.54", null, (byte)1, 53.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("547da428-2647-4188-b1a7-988d4c5f687f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7197), "192.168.1.44", null, (byte)2, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("54fb43d3-f4dd-4a33-8341-2fd97092c658"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5829), "192.168.1.11", null, (byte)1, 35.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("5553317f-b77f-4652-ad18-587975413962"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7581), "192.168.1.10", null, (byte)2, 48.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("5576e7cd-f587-40ae-b314-4a29f60299dd"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8738), "192.168.1.67", null, (byte)3, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("55acd692-59c2-4da7-b353-f0629dfb1158"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6853), "192.168.1.55", null, (byte)1, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("55ba7426-acb4-4730-b795-79b36fb7f21c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8966), "192.168.1.12", null, (byte)3, 21.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("56be663c-7768-4251-82b9-67f2db5d5f71"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7803), "192.168.1.96", null, (byte)2, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("56d91e99-41ea-4a8e-94f9-272b4c1f3da0"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7955), "192.168.1.99", null, (byte)2, 23.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("56ee6cfe-8e04-407c-b359-398e83f9c61a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7650), "192.168.1.32", null, (byte)2, 70.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("56fd6b4a-f8a8-4998-8ff5-18707df1b43a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9141), "192.168.1.85", null, (byte)3, 11.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("5766d12a-ec78-49f1-94d4-7e7031ef7dd7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6779), "192.168.1.13", null, (byte)1, 47.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("577a9d5e-1144-46f6-b6da-221c50a1e97d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6804), "192.168.1.30", null, (byte)1, 59.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("593558c6-624c-4218-b26a-8b51b9ae63d8"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5922), "192.168.1.4", null, (byte)1, 42.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("593acd9f-2132-43c7-aea5-d67d24b41c8c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6905), "192.168.1.60", null, (byte)1, 42.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("593f6ca3-952c-4aa6-bf74-85979a0bccb1"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8325), "192.168.1.36", null, (byte)3, 93.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("5962c2d5-4b3a-4123-803b-96299aaf8e95"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7404), "192.168.1.49", null, (byte)2, 53.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("5988cf17-7e20-46e1-a98f-a166fb2149d5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8372), "192.168.1.16", null, (byte)3, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("598a4316-678a-4564-8941-589af385f1c5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9287), "192.168.1.81", null, (byte)3, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("59fafb44-c14c-430e-8414-55be97b11d14"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6118), "192.168.1.32", null, (byte)1, 77.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("5a0c7e0b-403a-4629-ba71-b70adae0c0a1"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7885), "192.168.1.36", null, (byte)2, 10.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("5a5cfef6-8b3e-4037-9a5a-f230ed5e5f37"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8567), "192.168.1.16", null, (byte)3, 24.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("5a7f6d9a-fa9f-4f27-a91b-1e4cd48c152a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5785), "192.168.1.10", null, (byte)1, 27.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("5a831f85-0c01-486c-9bba-7ba996a5d728"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7868), "192.168.1.38", null, (byte)2, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("5aa95e93-45d3-457f-9894-35fac44b31e3"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7050), "192.168.1.96", null, (byte)1, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("5aabd331-f66d-4b56-9b14-64a262055938"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8260), "192.168.1.22", null, (byte)2, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("5ac2a3ee-bef6-4a92-a78e-c487b6a67412"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7747), "192.168.1.48", null, (byte)2, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("5ac5e17c-19ac-4205-a571-bba121067975"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8406), "192.168.1.66", null, (byte)3, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("5b78e72b-8e10-4546-89f0-03d471674ae1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6080), "192.168.1.30", null, (byte)1, 52.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("5bc104e9-6a3c-438c-bf77-5769fd672f84"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8742), "192.168.1.4", null, (byte)3, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("5c20b3bf-1d91-4247-bfb5-2cec22138550"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6607), "192.168.1.69", null, (byte)1, 73.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("5c3a83bc-063c-4188-acc5-98ce3c45bde0"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7946), "192.168.1.3", null, (byte)2, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("5c77bc69-284b-4bc7-b2e3-6513852e8687"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9115), "192.168.1.13", null, (byte)3, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("5d26512b-bc64-480e-a827-9883e09126ae"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8077), "192.168.1.62", null, (byte)2, 95.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("5d59e538-aaf7-4fad-be44-d2b269e3ca7a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8139), "192.168.1.84", null, (byte)2, 69.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("5d76b321-c0aa-4789-9d21-afa70b5bb44d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7876), "192.168.1.1", null, (byte)2, 87.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("5dd0dbb8-e284-4729-82ec-a70ded7b2fc8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9370), "192.168.1.29", null, (byte)3, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("5dfb7f05-331c-4ed0-bc19-f1db89f8df53"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7025), "192.168.1.86", null, (byte)1, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("5e61dd35-bab0-4878-94ad-68c039dc12bf"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7302), "192.168.1.69", null, (byte)2, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("5e7ddcb9-3c7f-442e-860a-25c4b3f7b8d6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7466), "192.168.1.18", null, (byte)2, 73.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("5ea4821b-4993-405e-8d6b-487c9e69b972"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5742), "192.168.1.39", null, (byte)1, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("5ea82149-cc36-404f-8f16-41bf409dd1d2"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5833), "192.168.1.24", null, (byte)1, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("5ec7df65-4b68-459d-9c7e-7c71aa5573df"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6961), "192.168.1.4", null, (byte)1, 89.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("5ecb5ae1-80c6-4b13-a115-fe8c0a26db58"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8054), "192.168.1.59", null, (byte)2, 30.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("5ff919bb-253c-47e8-867d-01160dca55df"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9004), "192.168.1.50", null, (byte)3, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("60011711-6b39-40c3-bb04-545365deca0b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8240), "192.168.1.41", null, (byte)2, 84.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("6058a79e-47d5-4ed2-ae63-55d487d7c375"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6187), "192.168.1.81", null, (byte)1, 54.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("60af6dbb-94e5-4466-a846-eca4caf661f6"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8524), "192.168.1.46", null, (byte)3, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("61e40443-dcaa-4577-8969-a4b6ff3bb2f4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5780), "192.168.1.82", null, (byte)1, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("62c4255d-3718-4a1c-af2c-56d917e9e31d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8059), "192.168.1.9", null, (byte)2, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("64028f7d-7ea9-40b2-9fb9-adc85419db71"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8947), "192.168.1.51", null, (byte)3, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("64984dd5-719b-4825-acb6-48dcb33e112f"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6028), "192.168.1.8", null, (byte)1, 51.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("64989d33-3997-4741-9564-198c8d7acf67"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8615), "192.168.1.84", null, (byte)3, 77.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("649edfa6-beac-4bc8-a623-593ae7b37258"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8992), "192.168.1.83", null, (byte)3, 2.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("657da134-7556-46ba-9097-a4a90fc08c58"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6568), "192.168.1.78", null, (byte)1, 96.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("65bbf901-b1fb-41ee-ac55-08b9fd54d5aa"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8720), "192.168.1.10", null, (byte)3, 0.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("65c1d24c-d389-4c2d-bf54-866c6e7b4351"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5799), "192.168.1.85", null, (byte)1, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("66269279-87b1-408c-b2de-572cb3f5de59"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7985), "192.168.1.28", null, (byte)2, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("66301f91-3d96-400d-a0da-86826b4cad45"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8943), "192.168.1.63", null, (byte)3, 50.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("66f213d0-cfba-4f81-af57-6972861e6e48"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6191), "192.168.1.38", null, (byte)1, 90.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("66f5063f-3b64-4ed5-85d6-b8a4da607318"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7462), "192.168.1.73", null, (byte)2, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("677da9a8-2a1f-46e0-b600-0214c8d67393"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6174), "192.168.1.3", null, (byte)1, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("67add327-2c17-412c-8d8d-6310dae8b66b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8872), "192.168.1.14", null, (byte)3, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("67c695a6-9f45-4376-b87f-a1b102c359b7"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9009), "192.168.1.48", null, (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("684b490f-4691-46c2-b901-dc8375feecdb"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7414), "192.168.1.71", null, (byte)2, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("6864f6c7-acaf-4fa7-9533-bb0a9bee94bc"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6110), "192.168.1.96", null, (byte)1, 31.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("68792ce9-bda7-42ec-8801-e51ab1427428"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8858), "192.168.1.63", null, (byte)3, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("687a5aed-97d7-401d-a93f-ac3d65b51f13"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5934), "192.168.1.77", null, (byte)1, 25.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("68986dd7-1e81-4244-b4f2-9b890f1913eb"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7267), "192.168.1.5", null, (byte)2, 56.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("689d8134-5df3-4b0d-8299-968c5f3ed028"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8703), "192.168.1.93", null, (byte)3, 91.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("693e55c9-c419-411a-b836-3ad62672c51f"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6586), "192.168.1.43", null, (byte)1, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("69567409-874b-42dc-925f-7473a180df11"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8762), "192.168.1.18", null, (byte)3, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("69e63ab3-7a7b-4465-a3df-5a54c3db3ea0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5896), "192.168.1.72", null, (byte)1, 45.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("6a2a4c82-9fe7-476d-94db-a3d1a7d317fa"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9013), "192.168.1.84", null, (byte)3, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("6a769a3b-448b-47da-9d2f-f16449bea38c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9269), "192.168.1.69", null, (byte)3, 71.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("6a76acdf-47f1-4ca3-87a0-04fcafdc9017"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8664), "192.168.1.81", null, (byte)3, 5.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("6a9d5857-0c70-49bf-9e2a-7adbeb51e0ee"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9146), "192.168.1.30", null, (byte)3, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("6aa0f7f2-65c9-47e2-aee1-32b1ad0d0d00"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9068), "192.168.1.83", null, (byte)3, 71.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("6adb4568-0fc9-4565-9802-e5d49c12cc6d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6710), "192.168.1.32", null, (byte)1, 51.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("6ae6fdbe-3e80-4ab2-bc48-328820941f9a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7607), "192.168.1.85", null, (byte)2, 95.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("6b662383-36a4-4926-bcf5-7cda78d503b9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6049), "192.168.1.41", null, (byte)1, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("6c97f136-74fe-4d56-8139-5aef28617323"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7799), "192.168.1.65", null, (byte)2, 76.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("6ca74afc-c41c-458f-9ae1-750b0e9fe3f6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7924), "192.168.1.67", null, (byte)2, 99.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("6cb9a79a-26db-4a9d-8bad-f4dd03ba3040"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6612), "192.168.1.46", null, (byte)1, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("6cffbb23-03a3-4e03-9846-7235d796715d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8148), "192.168.1.80", null, (byte)2, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("6d048d38-654e-4d56-9959-336f09218f63"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8563), "192.168.1.87", null, (byte)3, 22.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("6d6fe007-c200-41aa-8f15-8a702ba8caa8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8978), "192.168.1.41", null, (byte)3, 91.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("6dba0c70-105a-48f1-a67a-aad4bd489778"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9027), "192.168.1.43", null, (byte)3, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("6df94168-67c9-4b0b-a1a1-6e6a9866cde1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6726), "192.168.1.34", null, (byte)1, 59.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("6ea04eaa-ef0d-4c3a-a562-32fb02a695f2"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6917), "192.168.1.82", null, (byte)1, 5.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("6ef47cec-1e5b-4918-bde4-effaef1c5de4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6952), "192.168.1.36", null, (byte)1, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("6f22dca9-adff-4dd7-85e6-a31dcb4dfe38"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9213), "192.168.1.41", null, (byte)3, 27.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("6fb66eff-d536-4f20-b71b-1f69afdc4b71"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7435), "192.168.1.92", null, (byte)2, 21.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("6fda45bb-8757-454d-9a59-7f740eac34c7"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8625), "192.168.1.38", null, (byte)3, 94.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("702d5035-6871-418f-9379-b686817d7166"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8753), "192.168.1.82", null, (byte)3, 78.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("703216e6-d239-4e60-8d22-a2eef744a280"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8672), "192.168.1.50", null, (byte)3, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("7057a81d-5ca7-49f3-ab3e-6fe08284ad2e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5697), "192.168.1.45", null, (byte)1, 2.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("70af745e-5fc3-494b-bbe0-7327ecafa278"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9233), "192.168.1.50", null, (byte)3, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("711a47ff-aa6e-4e93-8e2e-ac7783d2b217"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8807), "192.168.1.24", null, (byte)3, 77.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("7153ae4d-1653-421e-ad05-5c68498f15c1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6874), "192.168.1.40", null, (byte)1, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("7170d868-6500-45fd-a9f2-71b69b360569"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9374), "192.168.1.80", null, (byte)3, 25.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("71cca6bb-2026-4844-9819-00737698567a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8349), "192.168.1.90", null, (byte)3, 44.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("721b2b9c-164c-4bfe-8432-0786fe9d734f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9076), "192.168.1.74", null, (byte)3, 6.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("725d952d-cf1a-4713-a1bc-a4296973f6fe"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7160), "192.168.1.32", null, (byte)2, 7.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("727acc38-b641-42d3-ba3c-2e4c49961411"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6014), "192.168.1.9", null, (byte)1, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("7369c287-ba7c-47fe-981e-4ea81573e6a7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6939), "192.168.1.29", null, (byte)1, 95.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("736ea3ba-82a8-4a43-80fd-fc83eb48d462"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9256), "192.168.1.43", null, (byte)3, 78.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("737663dc-6b65-4fd9-85e9-dc84e318f82b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6666), "192.168.1.7", null, (byte)1, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("73ef8a7e-9a7f-49c3-8c19-a030532c50ac"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6982), "192.168.1.45", null, (byte)1, 33.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("74010129-04ca-41e8-93ee-c07ff7c64f86"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6671), "192.168.1.97", null, (byte)1, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("740cffe2-7a26-4c31-ba77-3fb762f8763f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8611), "192.168.1.85", null, (byte)3, 80.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("7471cab1-a9ae-46ce-b214-521320ca37f6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8071), "192.168.1.11", null, (byte)2, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("748a95c5-d64f-4399-941f-6bf0a32d5a7c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7093), "192.168.1.38", null, (byte)1, 87.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("74b0d45f-01b2-4eaf-beb3-5631462af6f9"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7418), "192.168.1.6", null, (byte)2, 59.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("74f5a6ed-59bb-42e1-9689-7d927d6a9997"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8308), "192.168.1.41", null, (byte)3, 99.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("75aa3c2b-c797-4098-a8c0-a90ebf678ef4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7920), "192.168.1.9", null, (byte)2, 82.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("7613cbd4-838d-4289-a408-4eec72a2f2b0"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8011), "192.168.1.71", null, (byte)2, 1.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("766b9a34-f273-4cda-8ae6-5e1aeb2f288c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8819), "192.168.1.8", null, (byte)3, 14.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("7677bea5-0f8f-4c5a-a389-edccfb181879"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8707), "192.168.1.12", null, (byte)3, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("77a922a9-bb88-4bf7-abcc-9ee2004f7fa1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5883), "192.168.1.72", null, (byte)1, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("77b224a2-a59a-494a-82bd-6828e3b279f5"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6045), "192.168.1.36", null, (byte)1, 20.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("77b92ed7-9778-4e6b-9cae-3db7e2c4745d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6591), "192.168.1.49", null, (byte)1, 51.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("781a6687-c188-47e6-8303-6dd7c2739fda"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9295), "192.168.1.17", null, (byte)3, 62.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("7837f15d-602f-4801-b2a8-45cf7eff7f6f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7966), "192.168.1.50", null, (byte)2, 33.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("783ee677-5f76-4dbe-9e6e-7c5e50b22ac2"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8520), "192.168.1.19", null, (byte)3, 7.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("79a505c5-20ed-4792-a838-1adc771aa166"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7021), "192.168.1.47", null, (byte)1, 4.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("79eb4592-7b2f-4232-b41f-018581cb9982"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6835), "192.168.1.69", null, (byte)1, 72.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("7a56ba8c-fc6b-4b0d-a1df-6b5f43dff00e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7547), "192.168.1.96", null, (byte)2, 19.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("7a6da8e8-9090-42ae-9f47-b810ac845e22"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6974), "192.168.1.86", null, (byte)1, 50.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("7a92a77f-17a2-4819-a3cc-971de9395d10"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7716), "192.168.1.92", null, (byte)2, 31.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("7b15d2d9-6dc9-471d-a659-ad9771161c16"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7484), "192.168.1.43", null, (byte)2, 42.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("7baa5920-d459-41d6-b0f4-effbef9708d3"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6909), "192.168.1.11", null, (byte)1, 58.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("7c6c4cdd-3827-4a29-a440-d5e999c61d26"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6706), "192.168.1.20", null, (byte)1, 82.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("7d0a9b9f-6629-4968-9088-0403d582bc0b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5842), "192.168.1.78", null, (byte)1, 46.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("7d9329ec-677f-452d-be5b-a16b785a6d66"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8001), "192.168.1.14", null, (byte)2, 9.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("7e258072-eab5-4db7-81bd-f030acc85054"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8158), "192.168.1.9", null, (byte)2, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("7f067958-e564-4d9f-9b84-16f15d4c4b1a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7097), "192.168.1.67", null, (byte)1, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("7f17b4b6-1b4b-4f56-a730-4fd4b151292f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7720), "192.168.1.95", null, (byte)2, 72.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("7fb76cc1-97a1-4df2-8176-3cddea3c6ba3"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6769), "192.168.1.68", null, (byte)1, 4.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("800e8626-70ef-407e-afa2-540e9c5b127c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5905), "192.168.1.63", null, (byte)1, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("802f1b14-515c-4d92-a465-a2e7a057014b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8467), "192.168.1.9", null, (byte)3, 85.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("80325930-bc0d-4960-bcb7-5513ade62b66"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6862), "192.168.1.91", null, (byte)1, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("8080887e-fafb-4d4d-a528-2967301c829b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5676), "192.168.1.5", null, (byte)1, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("80bfc96b-12f8-4d38-bfa0-20421ce3d444"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8506), "192.168.1.57", null, (byte)3, 87.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("80de4ef7-596f-48eb-a54b-8658ea584e04"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9354), "192.168.1.52", null, (byte)3, 40.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("80fa244e-40c4-415a-9a30-c64dc558380a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8845), "192.168.1.45", null, (byte)3, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("820d6a45-44ad-457f-afda-8914ade40d72"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7492), "192.168.1.15", null, (byte)2, 71.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("8253abc9-af86-46c2-af3c-29f70d1fe802"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8734), "192.168.1.93", null, (byte)3, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("8268ca09-1903-43c9-b795-587c37aa6ace"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6572), "192.168.1.44", null, (byte)1, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("827566fa-36ea-420d-9f7d-1521f8c8796b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7970), "192.168.1.26", null, (byte)2, 16.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("8289d8b6-4cbe-4f18-baed-962598e7c9f0"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7768), "192.168.1.42", null, (byte)2, 68.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("8299dd01-b4a6-4afe-ba30-225e755833f7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5701), "192.168.1.54", null, (byte)1, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("82f4d4ee-5b2f-4ae3-9322-db1ca3aaa919"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8904), "192.168.1.29", null, (byte)3, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("833a6b1a-96d9-4406-8b8b-1dcc557ca69a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7850), "192.168.1.49", null, (byte)2, 62.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("83483a0c-9cff-4fb5-8d85-8e08faac03f1"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7807), "192.168.1.52", null, (byte)2, 25.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("845b708e-0474-41eb-a95e-f02bc182f396"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7128), "192.168.1.72", null, (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("846e49dc-455f-427b-96a2-c310521f29fc"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8266), "192.168.1.69", null, (byte)2, 72.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("84c13cda-9808-487b-8451-5d150c831524"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5961), "192.168.1.98", null, (byte)1, 23.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("84cdecdb-2e47-4f17-a6c2-5e2ecd8349e0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9388), "192.168.1.81", null, (byte)3, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("853c1a18-ff88-4f27-b6c4-d4747a316bad"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8463), "192.168.1.37", null, (byte)3, 6.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("8554666d-9650-4e6a-aefa-5fb4ad342e67"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9335), "192.168.1.30", null, (byte)3, 70.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("8575f2ea-3758-45a5-bb22-702b9d4662dd"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8182), "192.168.1.23", null, (byte)2, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("85c12c05-07e1-465e-be7a-b050bbb058d7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6160), "192.168.1.91", null, (byte)1, 67.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("85e8b4bc-ee07-49cd-8cc3-571aa97500d1"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7358), "192.168.1.54", null, (byte)2, 67.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("85fd2c0a-43ba-4e52-a1e9-d62d225ef2eb"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7256), "192.168.1.8", null, (byte)2, 90.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("860a2bfb-a3c8-4e83-8241-1fd246b053a3"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8797), "192.168.1.10", null, (byte)3, 21.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("86374742-0281-419e-92ea-c48f6754ccef"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8329), "192.168.1.86", null, (byte)3, 0.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("8663fc8f-34ca-463b-be2b-d697d0a50a3c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8551), "192.168.1.30", null, (byte)3, 49.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("86a35614-f0f9-4679-bddc-c26e15c641e5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8333), "192.168.1.34", null, (byte)3, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("86ffbe4a-53fa-4819-a128-3a41d32abf5d"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9331), "192.168.1.84", null, (byte)3, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("871ea835-e125-4bb8-a8e4-0b10cdf38f9b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9343), "192.168.1.55", null, (byte)3, 32.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("873eeb4c-1255-4226-87ec-f57561885de4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6730), "192.168.1.5", null, (byte)1, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("874ed9b8-624a-45df-a86b-8bf5adf4a701"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7737), "192.168.1.4", null, (byte)2, 87.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("87ce6146-0240-49b5-ad2b-fc02d78597d9"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9260), "192.168.1.60", null, (byte)3, 61.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("88bbabe2-7309-4d39-b0b0-1da5a9637855"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7930), "192.168.1.53", null, (byte)2, 89.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("89085dc4-6982-4f31-8cc6-5f6325d27065"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9323), "192.168.1.90", null, (byte)3, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("89c4c288-53ec-4ec4-9c14-8515a31309c0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8656), "192.168.1.91", null, (byte)3, 45.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("89da69e9-208b-442d-9785-0d4ea33eb74b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7872), "192.168.1.64", null, (byte)2, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("89eba666-cdee-484c-945c-63fa1f20f54a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7214), "192.168.1.96", null, (byte)2, 95.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("8a2a988a-389c-4277-9eb1-21a691a439b7"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9041), "192.168.1.39", null, (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("8a2d1b63-1d03-4caf-bc1f-7e2262350eb6"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9182), "192.168.1.14", null, (byte)3, 31.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("8ae1b704-e270-44b2-a1ae-74964ca93106"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8024), "192.168.1.80", null, (byte)2, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("8aeca89a-6ced-4299-a0c0-65a16a153070"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7372), "192.168.1.96", null, (byte)2, 11.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("8aee810b-c7db-476a-a9e4-4d5655b03b56"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9225), "192.168.1.81", null, (byte)3, 34.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("8b24abd6-6fb5-48ee-ac35-6987b2404449"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7860), "192.168.1.89", null, (byte)2, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("8b6da36e-67f9-432f-a003-90d747ce2e8e"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8376), "192.168.1.63", null, (byte)3, 57.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("8b81efcc-7d68-40d6-8390-7c32153437f6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7209), "192.168.1.99", null, (byte)2, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("8c0c9d60-c65f-49b7-915b-e6f26647e71f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7811), "192.168.1.32", null, (byte)2, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("8c11176d-4c95-449a-b848-3a7fed6718fd"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9283), "192.168.1.86", null, (byte)3, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("8c44cdcc-3357-4e6a-bec3-b2966949d1b5"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7659), "192.168.1.36", null, (byte)2, 96.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("8c4b35f5-9399-404a-9b50-2a0b60ec4a84"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6102), "192.168.1.65", null, (byte)1, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("8c617df1-65ff-4efc-8009-ffaa6701b8e4"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8908), "192.168.1.56", null, (byte)3, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("8c910833-e1f4-4df5-b6bb-c288dd246bd8"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7634), "192.168.1.80", null, (byte)2, 10.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("8d2d0a19-ae68-44f7-bc45-183f52bcc290"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8131), "192.168.1.58", null, (byte)2, 71.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("8e3849c0-8cc8-4e8f-8098-1af6f8edf76b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6884), "192.168.1.35", null, (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("8e5d75af-0314-499f-8726-0b481f52ffc4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6656), "192.168.1.4", null, (byte)1, 64.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("8ebef717-ab56-4d46-9a46-618da09e84f2"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6858), "192.168.1.51", null, (byte)1, 77.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("8f4572f8-8857-41d0-9459-85a9dba7e9c8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8699), "192.168.1.91", null, (byte)3, 98.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("8f4cd9ac-cf40-4639-9f96-7b37d1badcbc"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9243), "192.168.1.1", null, (byte)3, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("8f8f8c6b-c2ca-46f1-b2d5-cdc1883b7547"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8111), "192.168.1.66", null, (byte)2, 15.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("8fa49169-e401-46b2-b688-ca789c48bf30"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8459), "192.168.1.79", null, (byte)3, 46.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("8fce4f98-c6f3-45e6-89a7-44a8db708924"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6616), "192.168.1.30", null, (byte)1, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("8fd44cd8-51e6-4234-b7c3-fc71fd9c8a6c"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7593), "192.168.1.30", null, (byte)2, 10.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("90d61168-7533-49e2-8faf-5e72cff47df7"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9348), "192.168.1.58", null, (byte)3, 7.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("90f14359-58a5-4c0c-bc97-60ee21d4a727"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8225), "192.168.1.31", null, (byte)2, 61.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("911c361c-0668-45ed-bb49-2661a46280d6"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5930), "192.168.1.36", null, (byte)1, 51.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("9189cddc-dfe7-4a7f-9df7-75cfc97c046d"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8394), "192.168.1.95", null, (byte)3, 83.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("91a6c7ca-db45-470c-a819-99d23c54db41"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6966), "192.168.1.75", null, (byte)1, 83.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("92063ddb-f6a5-466c-b8c5-0d8efc283adf"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7009), "192.168.1.9", null, (byte)1, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("920de1f4-bef5-4365-a3ee-b8c5a889c28a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7124), "192.168.1.99", null, (byte)1, 89.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("922690c9-0370-41a6-bfbc-0c2c5ab3f88d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7693), "192.168.1.53", null, (byte)2, 1.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("9298ba78-2aeb-452c-90da-322b3a81a030"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5969), "192.168.1.28", null, (byte)1, 61.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("934c030d-e0da-48d6-9619-dd0f182bbc42"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9339), "192.168.1.23", null, (byte)3, 33.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("938e1f65-2eda-4001-9928-e70d22c528b0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6722), "192.168.1.80", null, (byte)1, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("93a3fc07-9931-4d8f-b643-b65a35f207c5"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6827), "192.168.1.59", null, (byte)1, 21.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("947780bb-4bb5-4413-8da4-6bc893790aa4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5738), "192.168.1.62", null, (byte)1, 23.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("955a3e17-a3d6-47f3-8c9a-6b53e63cc7d8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9154), "192.168.1.62", null, (byte)3, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("95627332-8821-489a-b96e-ddecab722af8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9278), "192.168.1.16", null, (byte)3, 49.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("9663069d-abf5-4bd4-b98b-c545aa6aa4c0"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7880), "192.168.1.55", null, (byte)2, 0.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("9671dbb4-76fb-448c-9ea1-b444f0e029d4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6831), "192.168.1.25", null, (byte)1, 58.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("969139ca-7c1f-4b3a-9ec3-237e5bfab899"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7233), "192.168.1.38", null, (byte)2, 38.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("97013ecc-e209-4334-863f-c802779d5ccd"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7673), "192.168.1.57", null, (byte)2, 65.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("97115b49-6f1a-4f31-86f9-bd0b92d9835b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6024), "192.168.1.81", null, (byte)1, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("975b1aec-3ec6-45be-9640-3ba019b8b8aa"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9023), "192.168.1.73", null, (byte)3, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("97a6079a-0c44-47b3-829d-c532b737fe5d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7576), "192.168.1.11", null, (byte)2, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("989eac0d-26db-4e54-9c19-979607cd37a1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6978), "192.168.1.16", null, (byte)1, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("993fbea4-4583-4dda-8f2a-1079d9d8a8dc"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5837), "192.168.1.56", null, (byte)1, 45.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("994da48c-38a6-4b71-9fec-825edf8e1b5a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9111), "192.168.1.57", null, (byte)3, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("995be723-6eec-4c93-b916-12be94267813"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7496), "192.168.1.45", null, (byte)2, 55.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("99882238-4fa3-436d-96e8-5034a577bef8"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7306), "192.168.1.36", null, (byte)2, 80.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("9a7cf936-08e7-4400-aed7-1902482e4efb"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9366), "192.168.1.41", null, (byte)3, 74.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("9a99e50b-3af0-4bff-bd38-6bfd31f75b5b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7279), "192.168.1.97", null, (byte)2, 58.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("9aba8d04-5657-40bc-960a-1026e69c62e7"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7314), "192.168.1.83", null, (byte)2, 53.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("9ac02b3b-e52c-4106-9dcb-43df2f87df6c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8559), "192.168.1.15", null, (byte)3, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("9b1a3fed-7df1-43c9-bd30-4c43ebd88462"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9291), "192.168.1.47", null, (byte)3, 22.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("9be62804-8e49-4baa-b19d-adaeb8a964e6"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6067), "192.168.1.52", null, (byte)1, 42.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("9c781081-69f1-4fd0-b094-14a6c0db68d5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8443), "192.168.1.53", null, (byte)3, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("9d5af5ad-3ced-424c-b010-35fbf4d45b5e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7246), "192.168.1.62", null, (byte)2, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("9d638da0-05d8-4abd-a373-e5d979372441"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8926), "192.168.1.54", null, (byte)3, 90.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("9d98739d-9a0c-427c-85b9-d3be9cb7b360"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7776), "192.168.1.80", null, (byte)2, 65.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("9d9c09a6-8a2f-455c-b802-86c44a9cfe8f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7205), "192.168.1.13", null, (byte)2, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("9da41232-7f29-401a-82a8-74f91aff3728"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8363), "192.168.1.28", null, (byte)3, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("9db80be2-52af-4c98-8189-7dce6347fe36"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8016), "192.168.1.5", null, (byte)2, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("9e07dc1d-da5d-4d8d-a0f8-bb78ccccb38f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8621), "192.168.1.28", null, (byte)3, 3.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("9e1db3e3-5963-4efe-bb22-1ae7e9b467b9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6132), "192.168.1.46", null, (byte)1, 88.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("9e6382ce-1bf7-46ff-b853-3b9586f0ed17"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8477), "192.168.1.86", null, (byte)3, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("9eb00eb1-45fd-430b-ac76-734e6131ec9d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7589), "192.168.1.84", null, (byte)2, 7.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("9f3a84fe-51ce-4667-b889-579ca1aaaf79"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7701), "192.168.1.24", null, (byte)2, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("a0d3baad-ac07-4768-85e6-67f598694f5e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7729), "192.168.1.77", null, (byte)2, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("a197612e-88af-49b3-84a7-c8d7d720db8e"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8776), "192.168.1.55", null, (byte)3, 42.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("a1b692a0-640b-4bd5-a1fe-60f3cbc5da9f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7669), "192.168.1.51", null, (byte)2, 76.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("a1ca24f9-f2e0-48b9-a0ef-31714117b100"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7102), "192.168.1.72", null, (byte)1, 53.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("a2655c09-1a26-408d-b12d-470551f3944c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6921), "192.168.1.80", null, (byte)1, 70.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("a32c03f8-bb40-4098-ad76-a2ed08781df9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7089), "192.168.1.56", null, (byte)1, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("a335028a-53c5-4694-8f05-e7e388d5cd9c"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7741), "192.168.1.51", null, (byte)2, 17.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("a35803e0-d2b0-4e06-8d7f-6f4bce129827"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8988), "192.168.1.79", null, (byte)3, 53.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("a41c7fe1-6688-4b1e-b23e-865f408329ab"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5910), "192.168.1.92", null, (byte)1, 22.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("a43560b1-32a3-4727-8d48-6c7879219862"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8725), "192.168.1.37", null, (byte)3, 34.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("a4551e89-7140-4dba-a900-cb94928c1b73"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7615), "192.168.1.87", null, (byte)2, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("a493ee84-1740-4f0d-bcac-f792d19f44bb"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6020), "192.168.1.70", null, (byte)1, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("a4dfc834-b468-4593-bc5c-44eca5812ba0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9378), "192.168.1.80", null, (byte)3, 66.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("a4f56b37-9d57-472f-912c-c34e7441946c"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8190), "192.168.1.91", null, (byte)2, 14.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("a50133f3-f22f-4209-bfc1-0fd4cad1e653"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8642), "192.168.1.95", null, (byte)3, 96.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("a50db517-552e-4b87-9a7b-72d61247ce57"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7997), "192.168.1.4", null, (byte)2, 48.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("a5d446c8-4076-4958-9197-5f2fc43aca25"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8042), "192.168.1.63", null, (byte)2, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("a634c228-a744-4d85-8825-d80190c12d88"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6878), "192.168.1.71", null, (byte)1, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("a6432e6a-d6e1-4ed4-a828-5da4bee70016"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6870), "192.168.1.36", null, (byte)1, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("a668ab91-4e8a-41f7-b146-dc3d80e6f3d7"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7854), "192.168.1.31", null, (byte)2, 53.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("a67b6057-881c-4069-aa5a-ac83d65be4cf"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9303), "192.168.1.69", null, (byte)3, 79.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("a67e8306-4366-43fd-90da-4b9a487590b6"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9085), "192.168.1.7", null, (byte)3, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("a6c049c3-5862-4da2-ba4b-71526dd79d50"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7537), "192.168.1.84", null, (byte)2, 66.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("a7187e8c-db34-4bec-8e9a-f01e2f91235a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5957), "192.168.1.57", null, (byte)1, 18.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("a782f8c5-8c40-4faa-83ed-26ca83c0c811"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8827), "192.168.1.31", null, (byte)3, 74.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("a79a80c3-a9ec-401b-b567-065c517618c3"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7449), "192.168.1.77", null, (byte)2, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("a7a18620-b38e-4ee7-a205-bc2839709f9e"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8494), "192.168.1.39", null, (byte)3, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("a7cb3312-62fe-4889-8cbc-2f00d1601134"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7322), "192.168.1.55", null, (byte)2, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("a7e2c654-d2c2-4fd0-a5a4-9522d0b8df39"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7085), "192.168.1.86", null, (byte)1, 15.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("a7ebf564-088c-44f9-b5ce-84fd0b8c692d"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9133), "192.168.1.19", null, (byte)3, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("a81047c4-933d-4b2d-9aa4-00d16592b727"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5918), "192.168.1.16", null, (byte)1, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("a83c7e4f-c0af-4102-9324-59460a78e6b0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8681), "192.168.1.54", null, (byte)3, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("a8f4165c-21af-4ba0-a376-5a88c6742507"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7275), "192.168.1.75", null, (byte)2, 47.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("a98870ad-233f-4339-87d8-969409896621"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7841), "192.168.1.77", null, (byte)2, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("aa9b2d2a-9225-4b2c-a980-54245e2b7ec4"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8293), "192.168.1.43", null, (byte)3, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("ab029b8c-8fbd-4053-b337-6143dcfe7079"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6136), "192.168.1.71", null, (byte)1, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("ab1c3230-e753-41e8-b681-fdc2e4ba5eac"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5823), "192.168.1.48", null, (byte)1, 8.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("ac10e453-7dc7-43e6-a4e2-f749e2bb16d7"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8414), "192.168.1.65", null, (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("aca2c1b0-b1a1-4643-9e92-8c4b76552ff6"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5807), "192.168.1.23", null, (byte)1, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("ad89ede8-2eb7-49d1-ad1e-0cd9da34a828"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7228), "192.168.1.98", null, (byte)2, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("aea9cdf0-07dc-417d-8d11-c9f6b96feba6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8200), "192.168.1.17", null, (byte)2, 59.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("aefd137f-3ca0-4500-bc6f-603a2cbc6991"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5989), "192.168.1.53", null, (byte)1, 18.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("afa2d063-0d0e-4756-aa85-698bedb88242"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7938), "192.168.1.16", null, (byte)2, 63.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("b00c556e-26ff-4ecf-8b3f-75de3ce56ae9"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7201), "192.168.1.60", null, (byte)2, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("b0d29a16-3e48-4b5e-b442-94b47702eacf"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5900), "192.168.1.43", null, (byte)1, 11.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("b14b5ad6-1f0b-4593-885c-1d32d063ff0d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8162), "192.168.1.10", null, (byte)2, 84.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("b163e731-2596-43b7-98f5-4f8688c67c86"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8918), "192.168.1.90", null, (byte)3, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("b166bff2-7537-49c1-ad43-31d14536e5a9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7116), "192.168.1.74", null, (byte)1, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("b1f28380-78b0-4811-b3aa-a7674722487e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7912), "192.168.1.26", null, (byte)2, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("b21b796c-2105-411c-85d5-37f79d984359"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6076), "192.168.1.78", null, (byte)1, 90.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("b22c92a1-d6e9-4e04-9b8f-ea4c3a1f684d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8063), "192.168.1.6", null, (byte)2, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("b23e5f3a-0c48-4633-9e6f-515cb2cebabc"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9093), "192.168.1.23", null, (byte)3, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("b3422ee5-44bd-4203-9d53-3f06ab5cb40a"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7899), "192.168.1.50", null, (byte)2, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("b41c43ed-cf47-48df-90a6-d1a3939c7405"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8555), "192.168.1.57", null, (byte)3, 96.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("b4a19e15-9baf-4d1b-9d17-ce69ac2560e4"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8341), "192.168.1.69", null, (byte)3, 56.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("b4b6dc0d-10fd-4a2d-8a9e-135696a78daa"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7599), "192.168.1.71", null, (byte)2, 4.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("b4da92f0-be2b-4fa2-8c74-e8b1f1e26818"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7017), "192.168.1.43", null, (byte)1, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("b4db963e-c9cf-407a-94d8-fec31287fd8a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8823), "192.168.1.49", null, (byte)3, 83.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("b5b61737-aac2-4c5a-801d-3227e2532e1e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7733), "192.168.1.63", null, (byte)2, 58.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("b5fed705-2e6f-4165-b20e-c48e34cec820"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7062), "192.168.1.76", null, (byte)1, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("b65db629-5a65-4d0d-a762-d4cd705d081d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6718), "192.168.1.62", null, (byte)1, 59.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("b6c95fa7-1668-4c45-9d56-737c96573f72"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7697), "192.168.1.53", null, (byte)2, 41.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("b70824ea-4a63-492b-8bdc-d6181400aa73"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6644), "192.168.1.25", null, (byte)1, 39.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("b7103347-053b-44aa-85ec-245b92a752f5"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6009), "192.168.1.88", null, (byte)1, 52.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("b74364a0-914e-4cee-ada2-d6dce17dfdfb"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8650), "192.168.1.64", null, (byte)3, 72.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("b7b71753-db7f-4a36-89bc-f7c2e67e7e35"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5789), "192.168.1.83", null, (byte)1, 67.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("b83a017b-9280-44bf-95ce-1dd4851047f4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6098), "192.168.1.75", null, (byte)1, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("b846f90a-f7b2-4866-90f4-b6b0cfeaad58"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7585), "192.168.1.13", null, (byte)2, 78.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("b9024653-3b71-41d2-99c9-1e214b3aaa6d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7655), "192.168.1.62", null, (byte)2, 82.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("b9d5479a-8118-41f4-97ab-b88f455d7786"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5815), "192.168.1.7", null, (byte)1, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("bad1767b-b160-4e23-912d-b660ec6da926"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8931), "192.168.1.71", null, (byte)3, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("bae79128-8535-40b2-a79c-c8e4cd0d4e85"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8957), "192.168.1.68", null, (byte)3, 96.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("bc516211-b286-42a2-8025-182b0f4435c1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5795), "192.168.1.93", null, (byte)1, 85.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("bddc4a78-2237-4e97-8cf1-3cff7d342c35"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8090), "192.168.1.64", null, (byte)2, 73.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("beef86dc-d06b-46d4-ae88-ae2ae78465e4"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5859), "192.168.1.20", null, (byte)1, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("bf692bc6-2549-40ca-aa5f-be02f38547f2"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5892), "192.168.1.78", null, (byte)1, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("bfbd0fb2-7c1f-49e0-b2f7-67af8f91034e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7380), "192.168.1.78", null, (byte)2, 83.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("c096b645-29f0-4e43-99b8-cff743be6196"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7989), "192.168.1.34", null, (byte)2, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("c0bcdd90-64c0-49e1-9495-f2706045b451"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8186), "192.168.1.4", null, (byte)2, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("c0bf87b1-b839-4e66-8aa5-59080c2d77d0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6632), "192.168.1.55", null, (byte)1, 10.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("c168d110-c2e1-48bc-93dd-0f04eac771c5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9017), "192.168.1.25", null, (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("c196aeb0-7f30-4a52-a0e7-415d3e72e39c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7143), "192.168.1.55", null, (byte)1, 69.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("c1973913-b6ce-4878-8be0-a81e08fb11d9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6595), "192.168.1.68", null, (byte)1, 56.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("c2d1e450-8fb2-4dd2-b45e-9a4427dafd27"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7505), "192.168.1.26", null, (byte)2, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("c2d65d79-42b1-4bb8-b06c-88cd2db53e20"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7169), "192.168.1.27", null, (byte)2, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("c30dba32-a952-47f5-9b94-ff9cee62d75c"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7384), "192.168.1.38", null, (byte)2, 33.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("c37ee692-44d2-40f2-8e86-ed719acf4158"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8337), "192.168.1.91", null, (byte)3, 10.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("c3babd77-a8d8-4dd1-bfaa-3f3f0d2cedde"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6156), "192.168.1.10", null, (byte)1, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("c457659e-f90a-4aa0-8b14-a1eae0fc6022"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8634), "192.168.1.59", null, (byte)3, 66.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("c5422349-8b19-4a97-b3cc-050e62f27444"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7189), "192.168.1.59", null, (byte)2, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("c564dc6f-fa76-46e1-be19-fd87a7f918b4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7283), "192.168.1.4", null, (byte)2, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("c5911f12-d7e1-4815-89cc-6ee66e509f2d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7959), "192.168.1.21", null, (byte)2, 49.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("c595d303-1740-4e9b-88d5-3924973f5eaa"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6037), "192.168.1.55", null, (byte)1, 24.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("c5ca0fc0-062c-4e06-8ffd-285c7016786b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7611), "192.168.1.55", null, (byte)2, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("c60a46ce-807c-46e8-a759-e20a2d3add61"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8438), "192.168.1.9", null, (byte)3, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("c6d0dccb-6ddc-4b67-abb4-dad131640e31"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8668), "192.168.1.50", null, (byte)3, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("c7389e38-f24c-43e3-853a-32083ede8451"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8028), "192.168.1.32", null, (byte)2, 77.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("c7450f28-618e-459c-9ee2-64962141fd75"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7795), "192.168.1.15", null, (byte)2, 79.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("c7db9590-a070-4d2b-97ad-a4f8be75f3be"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7427), "192.168.1.75", null, (byte)2, 83.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("c8d6ff63-2d59-4eea-8254-9684f78b1a3f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7349), "192.168.1.92", null, (byte)2, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("c8e31953-3f32-41a7-ba8f-48684828f151"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8974), "192.168.1.70", null, (byte)3, 71.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("c8fe767d-32b3-4c2f-8ae5-8a7cf042e105"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7889), "192.168.1.70", null, (byte)2, 14.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("c902da87-45ef-41e7-9c64-fadd6f6915b2"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7903), "192.168.1.27", null, (byte)2, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("c90d8e31-961f-4d16-bce0-79150c51ead1"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7439), "192.168.1.93", null, (byte)2, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("c91c676b-9aed-4c0f-998e-3c49183c01ae"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6041), "192.168.1.46", null, (byte)1, 50.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("c96c5283-1824-4343-aad8-cab4f3e7a681"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9119), "192.168.1.8", null, (byte)3, 6.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("ca613ad7-998b-43a1-b3f3-603c21609c50"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6059), "192.168.1.21", null, (byte)1, 19.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("ca7c9699-ed8d-4a43-afb4-ae327be57182"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7046), "192.168.1.71", null, (byte)1, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("cae2a0a9-ff00-4971-a1bd-e48dd47e2cb2"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8384), "192.168.1.56", null, (byte)3, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("cbd33521-0a9b-4b07-9769-1124842471ce"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8250), "192.168.1.54", null, (byte)2, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("cbe61976-4414-407e-9efc-daee53cf9fff"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9137), "192.168.1.45", null, (byte)3, 58.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("cc2fd0f0-7dc4-4f44-b68b-45eda4bcf966"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6623), "192.168.1.94", null, (byte)1, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("cceb81f1-0356-4b05-9562-ccbf6c3b151e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5854), "192.168.1.8", null, (byte)1, 76.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("cd38810d-f5c7-4dee-b31a-687c6571c91d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5887), "192.168.1.31", null, (byte)1, 26.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("cdd991dd-9ba7-466d-ab88-933fa0512bfe"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6756), "192.168.1.19", null, (byte)1, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("ceb4464b-f7aa-4429-aa77-db7309c9d47a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8516), "192.168.1.18", null, (byte)3, 34.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("cf5cde6b-6d09-4ae3-870c-3a7d8659590d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6140), "192.168.1.60", null, (byte)1, 6.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("cfc044be-c22c-4d2a-b581-11789bada6c4"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9327), "192.168.1.20", null, (byte)3, 99.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("d03b7698-2c70-4828-8ad2-8a9acf3a102b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6182), "192.168.1.10", null, (byte)1, 43.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("d04eb39d-ab31-47a1-b064-7c190e66b313"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7337), "192.168.1.35", null, (byte)2, 35.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("d10b6ce9-8c8b-4416-bc0f-89c05b56b32f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7558), "192.168.1.46", null, (byte)2, 33.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("d210e2db-e017-476a-ab32-4f25cc3f4598"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6084), "192.168.1.17", null, (byte)1, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("d268eeee-a405-4f82-bc55-1a28c579d8b6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7751), "192.168.1.27", null, (byte)2, 99.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("d2d95be0-4f0f-416a-bf86-7a4642ab46de"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7137), "192.168.1.30", null, (byte)1, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("d38894a9-c12b-4d9b-a07d-080d2498a4a3"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8685), "192.168.1.65", null, (byte)3, 21.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("d3b7f8dc-8169-4790-ae9c-6958f00908ef"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5771), "192.168.1.58", null, (byte)1, 92.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("d47178c1-ba0f-43ca-bc75-7df89ee370fb"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8677), "192.168.1.54", null, (byte)3, 65.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("d4b78fa8-3c6d-496d-932f-0cdc4a5deea8"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6765), "192.168.1.48", null, (byte)1, 64.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("d5f03e1d-6196-49dc-9d03-47c9568f30b1"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9162), "192.168.1.28", null, (byte)3, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("d6041094-6330-41fa-8cdb-b0febd12e329"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7310), "192.168.1.27", null, (byte)2, 61.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("d65da1f2-c717-4e63-9cdc-77bd2c302d94"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6178), "192.168.1.14", null, (byte)1, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("d688bcd1-e76e-4f62-8e10-84c971aca229"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8231), "192.168.1.18", null, (byte)2, 59.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("d6ae1260-76aa-4521-9254-79f5a9a4ae8d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7764), "192.168.1.56", null, (byte)2, 59.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("d6f080c2-3932-4e11-b6e0-ef76d41e64df"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6947), "192.168.1.20", null, (byte)1, 87.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("d76519f5-e34e-410f-beca-4edcc251dfa0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5716), "192.168.1.83", null, (byte)1, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("d767a994-056c-4524-8df0-91175c5c2cd3"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5868), "192.168.1.96", null, (byte)1, 25.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("d79c9bf5-57ee-437b-98e0-f9fbb5841c46"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8287), "192.168.1.4", null, (byte)2, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("d7ff3dd2-09f1-4bd6-bbe3-070bc9530d8a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5997), "192.168.1.18", null, (byte)1, 68.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("d81efca5-61e5-4780-a75b-59c366f25a6e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6791), "192.168.1.36", null, (byte)1, 11.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("d828b783-02a0-4163-88cf-967fd244cbc3"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7362), "192.168.1.73", null, (byte)2, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("d87c5b0e-0b2e-4f3e-9099-3971f5b38866"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6822), "192.168.1.65", null, (byte)1, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("d8bf146d-ab8e-45d0-8a29-68429371f8f1"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5983), "192.168.1.68", null, (byte)1, 78.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("d9209542-09ce-451a-b17a-e58f0d59d92e"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7443), "192.168.1.14", null, (byte)2, 61.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("d99b3cb4-6474-4c67-ac8f-57440d58d7b7"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7242), "192.168.1.77", null, (byte)2, 94.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("d9c45bad-c286-4809-8bfc-74bdc5a2c752"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6839), "192.168.1.67", null, (byte)1, 76.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("d9f6719e-b1a7-4386-853f-1cd4dac92339"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8303), "192.168.1.57", null, (byte)3, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("d9fbb279-db76-4791-bf4a-4c9402246ddd"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8380), "192.168.1.44", null, (byte)3, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("d9ffbd23-9de6-402d-ae01-8fdb57d9bb69"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9299), "192.168.1.43", null, (byte)3, 99.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("da3a4699-8a3a-4369-961a-24d1a30614cf"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8815), "192.168.1.64", null, (byte)3, 70.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("da92221e-0368-48ed-818e-5bdb14e8171e"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6094), "192.168.1.64", null, (byte)1, 99.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("dace9786-03d3-4b75-a044-9237ec43ca57"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8127), "192.168.1.14", null, (byte)2, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("dad05cdb-cd51-4b92-8cc2-9bcb871e1d78"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9252), "192.168.1.1", null, (byte)3, 70.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("db097cbc-7557-4bc0-b41b-0778651a1170"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7564), "192.168.1.98", null, (byte)2, 66.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("db0d7ad0-82cf-4740-b5eb-de64fd1700e8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8434), "192.168.1.26", null, (byte)3, 89.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("db9dabcf-450f-4578-b0ea-b912a358d100"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7292), "192.168.1.30", null, (byte)2, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("dbff682f-0544-4bdf-a9b9-b8046ab5959f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8528), "192.168.1.36", null, (byte)3, 52.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("dc2e34c5-1a1e-4a47-9551-6022841a834f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8638), "192.168.1.34", null, (byte)3, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("de36ef57-97f4-4a3f-b9e7-7382f79bfbba"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6563), "192.168.1.14", null, (byte)1, 74.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("de9d5461-bed2-416b-8e4c-8539a8212c34"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8629), "192.168.1.99", null, (byte)3, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("dedbbe46-0b4e-478b-a8a3-9ea53e43a7fb"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7624), "192.168.1.75", null, (byte)2, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("df092322-d5e9-45db-b283-4e8753146ce0"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6701), "192.168.1.82", null, (byte)1, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("df460567-7377-41b6-904b-b7eaf0b98b46"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8922), "192.168.1.51", null, (byte)3, 87.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("df54dc79-e66c-44e7-9170-26cb34de71a5"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8167), "192.168.1.52", null, (byte)2, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("df9dd2e8-d356-4d2c-a1f8-8e1fdf4b3c57"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8788), "192.168.1.60", null, (byte)3, 60.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("dfd24cde-7549-418a-b7ca-aa00cb25b78b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8388), "192.168.1.69", null, (byte)3, 63.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("dfeea18e-e69a-4311-a1ed-f46e2cd338a8"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5734), "192.168.1.54", null, (byte)1, 74.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("e01300fc-d150-484f-b5ba-54fb5542492d"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7786), "192.168.1.39", null, (byte)2, 80.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("e034c24b-bfc3-4e0d-9f0c-b63ac70cc410"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8533), "192.168.1.30", null, (byte)3, 11.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("e09b7e1a-a09b-42ea-8ca4-f3c4a8e99776"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9178), "192.168.1.39", null, (byte)3, 69.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("e0a41900-00fd-40c5-8f1b-787fa8fd808b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6063), "192.168.1.94", null, (byte)1, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("e0b83ab5-4700-40dc-90c4-fc61f9a48c0f"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7164), "192.168.1.70", null, (byte)2, 62.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("e15b1536-1548-4d7a-b14c-ff926826ffb0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9413), "192.168.1.23", null, (byte)3, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("e20b54ac-eb3a-4a68-9547-cb8efa315b55"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7005), "192.168.1.71", null, (byte)1, 39.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("e3100d7c-1f99-4560-adb0-77cc8c6054c0"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9358), "192.168.1.44", null, (byte)3, 9.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("e3b9b04c-d74f-4307-8640-2b3d0c0c9115"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6796), "192.168.1.86", null, (byte)1, 15.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("e3e33056-795a-47fc-8303-684edefcb407"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8953), "192.168.1.56", null, (byte)3, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("e3ed9b35-8676-4129-9406-7e8a2cccfbbc"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7825), "192.168.1.92", null, (byte)2, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("e50076e3-f63e-42a1-8eff-3e68ed02219d"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6849), "192.168.1.70", null, (byte)1, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("e51e2234-226f-477b-b158-4698bef20624"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6740), "192.168.1.41", null, (byte)1, 47.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("e570c5d3-89e7-43ed-aa10-06dabffd6150"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6943), "192.168.1.33", null, (byte)1, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("e59976c1-8d69-479a-8c23-0a32906b55e3"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7916), "192.168.1.72", null, (byte)2, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("e5ac7108-c006-4566-ab6e-c73c990818b5"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8036), "192.168.1.78", null, (byte)2, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("e60526f1-5762-400b-9fdf-c9254eecb456"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8939), "192.168.1.7", null, (byte)3, 51.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("e684a1dc-50e0-4180-b384-74ab5ce6bdf1"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7474), "192.168.1.83", null, (byte)2, 10.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("e68d8f55-61a3-4e34-b919-2205bfc7915a"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8660), "192.168.1.37", null, (byte)3, 93.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("e692ffbf-f06d-4976-bb73-6c71f50ee58a"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6808), "192.168.1.28", null, (byte)1, 53.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("e78b89e3-e4ae-4dfb-a2e2-3b05ed59ee1c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7042), "192.168.1.10", null, (byte)1, 85.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("e856bdf1-d300-40fa-acc6-8306dab5e373"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7942), "192.168.1.37", null, (byte)2, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("e93ec694-7932-42c8-8f22-7026f7e691cd"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6866), "192.168.1.74", null, (byte)1, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("e9850f8f-4d10-40b1-879c-fac4cbd60088"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6661), "192.168.1.22", null, (byte)1, 61.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("ea452763-8b20-4ac2-bb3c-99268fa272f8"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8144), "192.168.1.38", null, (byte)2, 37.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("eaf54d85-2199-4697-a912-1f94cc800af4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7453), "192.168.1.23", null, (byte)2, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("ebbc156a-4da7-4a41-a2bf-b681c4af33c5"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8854), "192.168.1.74", null, (byte)3, 56.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("ec1895b1-0aeb-44a2-8872-7da9ecde8db3"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8020), "192.168.1.49", null, (byte)2, 95.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("ec5fc546-cb37-4799-a22c-ea2692a68c3c"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7408), "192.168.1.72", null, (byte)2, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("ecd0140c-4199-4b1b-93c7-12428157c41f"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8970), "192.168.1.16", null, (byte)3, 96.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("ed1a52d7-4899-442c-9ae2-d77bd250da28"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7513), "192.168.1.56", null, (byte)2, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("edd4d822-8660-4307-873a-f39d7fddda08"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5759), "192.168.1.56", null, (byte)1, 48.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("ee27cfe7-f5b2-4be8-8a30-f6b5e95c06a4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8213), "192.168.1.56", null, (byte)2, 43.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("eeb6e312-eeb7-44cf-af4f-f7b7a2016ef2"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9000), "192.168.1.57", null, (byte)3, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("f0b6c8c8-7604-41c2-9c90-985fd4ac6fa9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6599), "192.168.1.92", null, (byte)1, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("f2042343-6ec8-425b-8945-99b25cdf5720"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9382), "192.168.1.39", null, (byte)3, 52.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("f2d5f9bb-c2eb-4683-9d9e-223a71e68aab"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8050), "192.168.1.37", null, (byte)2, 21.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("f3bca7b2-5ef2-4fc4-a82e-945830899f7e"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9080), "192.168.1.34", null, (byte)3, 81.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("f3c7601d-2f3c-493f-9481-64645e4cb77c"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6055), "192.168.1.5", null, (byte)1, 82.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("f4300520-31cd-4610-bddd-58c604aa4790"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8837), "192.168.1.75", null, (byte)3, 34.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("f44573fa-2cf3-4569-a42c-cc34bb8a5096"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7894), "192.168.1.45", null, (byte)2, 45.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("f4610d0b-01bf-49c8-8d7f-ec2e879fe108"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9072), "192.168.1.35", null, (byte)3, 89.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("f4d3b3b6-6ae7-4b08-ad53-a8367d71bfe4"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7532), "192.168.1.80", null, (byte)2, 14.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("f4e4dd80-8553-4e4b-b44d-0620d3a2dfba"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9273), "192.168.1.37", null, (byte)3, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("f525d668-083c-4af8-ad6b-6e339d39cbd8"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8368), "192.168.1.74", null, (byte)3, 20.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("f52b3434-e6bb-4305-9043-961caf4a4240"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9191), "192.168.1.85", null, (byte)3, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("f54e9120-3e70-427b-97ec-c9ff617bf8c3"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8081), "192.168.1.51", null, (byte)2, 85.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("f672a96e-e2a1-42ce-904b-35166fdb7f82"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7354), "192.168.1.21", null, (byte)2, 27.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("f69c96aa-8ff7-471c-ae59-b5440e1392be"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6900), "192.168.1.96", null, (byte)1, 46.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("f69ce5a9-46b5-4e65-afd1-2da04c12f14b"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9187), "192.168.1.16", null, (byte)3, 25.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("f6c00fcd-dd22-409e-9b34-b8c57f6582ae"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8398), "192.168.1.34", null, (byte)3, 40.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("f6c40aaa-c6e0-4f72-9528-07670d1d9c78"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8850), "192.168.1.86", null, (byte)3, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("f75be0d7-c5bf-4720-8e1a-11a2f9c5cd4b"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7478), "192.168.1.28", null, (byte)2, 68.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("f799e0cd-8cdb-4b85-86fb-2cfbe3cba8e6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7488), "192.168.1.81", null, (byte)2, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("f7eff1f5-5c96-4a2b-91e1-f92b9bdc55ca"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9409), "192.168.1.15", null, (byte)3, 41.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("f85f69d0-f7bd-4537-bfde-62d24adb01ea"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7054), "192.168.1.63", null, (byte)1, 6.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("f8651a11-b4ed-4f5e-bfd5-ace06abc6435"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9203), "192.168.1.37", null, (byte)3, 77.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("f9a4fea0-a9cc-4d9c-88ec-2af83ca46061"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6736), "192.168.1.78", null, (byte)1, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("f9a7a8d7-3140-4e0a-a6d1-626f7f4f60ac"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8196), "192.168.1.61", null, (byte)2, 79.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("fa38c09d-a98d-4c52-9c52-92f94f3f3ef9"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7072), "192.168.1.93", null, (byte)1, 72.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("fa428f86-d1fd-4f5e-8706-e9eec77edfa6"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5949), "192.168.1.46", null, (byte)1, 99.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("fabd4459-4fbd-4f0c-9489-4522528af026"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9221), "192.168.1.75", null, (byte)3, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("fb33d62b-b665-4fc9-9be6-49154e0de146"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7271), "192.168.1.38", null, (byte)2, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("fb906139-b35e-4f1a-b097-2b8c884843e3"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6648), "192.168.1.26", null, (byte)1, 67.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("fbbb1bf1-2ba6-475c-a670-c766ab47457b"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6996), "192.168.1.47", null, (byte)1, 63.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("fbc00783-d5ca-4bcf-bdff-84b015d47d68"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5803), "192.168.1.53", null, (byte)1, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("fbdb73f8-896b-44b1-99ee-779db332c24f"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7081), "192.168.1.19", null, (byte)1, 42.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("fc0576c5-63a2-40ba-b611-1e6147a2cac6"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(9238), "192.168.1.53", null, (byte)3, 11.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("fc1f7a5e-3a39-4e0a-bd61-5149ed496368"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5944), "192.168.1.52", null, (byte)1, 90.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("fc661253-b90e-4dab-98a1-84550c479932"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8996), "192.168.1.46", null, (byte)3, 2.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("fce6abed-a347-4725-9bf4-75c15419f8a6"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7327), "192.168.1.5", null, (byte)2, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("fced62d4-c2eb-4260-a047-aa4ea0682bcd"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(5710), "192.168.1.95", null, (byte)1, 93.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("fd06b830-515b-4e5a-ae44-a50c2e9f05a5"), "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(7185), "192.168.1.76", null, (byte)2, 20.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("fd5d4556-c16a-4634-94bb-03b0191422f7"), "Computer0", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(6714), "192.168.1.62", null, (byte)1, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("fdcc5e85-f010-4245-be72-949d1c21ae5c"), "Computer2", new DateTime(2024, 3, 1, 13, 15, 32, 531, DateTimeKind.Utc).AddTicks(8481), "192.168.1.7", null, (byte)3, 6.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("193d201d-effa-4d72-b120-7590f2403b23"), "1-A", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6018), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("3b2bd9bf-c6ce-43de-b2af-53c001e56a4b"), "4-C", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6037), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("4c4d18ab-c2f3-4a11-8e17-3af3d5d9bfe3"), "1-A", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6022), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null },
                    { new Guid("6bc0413f-5901-4c0e-9861-1bad3d9e7eb2"), "", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6014), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null },
                    { new Guid("79a5f317-372e-428e-89c1-ce1f8d70258e"), "", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6030), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("7c0c99bc-8402-4eab-8afc-675a5ee275bf"), "3-D", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6000), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("8d81c950-6638-46d8-b61e-4675e630de4d"), "2-B", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6027), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("8f59b652-7c24-4e8b-bc9b-4ff190b025d9"), "2-B", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5991), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null },
                    { new Guid("a3d7f305-a9f3-48e7-a27c-a9c4d2738c09"), "4-C", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6039), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null },
                    { new Guid("b13d5974-3dba-48f1-a934-a6cc49c8969d"), "2-B", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5993), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("d2c7b887-29b2-4ab8-8825-ed19af27a583"), "3-D", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5996), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("dae8962d-3b10-473d-af3e-5fe1cde45420"), "", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6011), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("e33e49df-660f-4d25-b780-8ec0012fa4ad"), "1-A", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5981), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("ed1c8968-f820-4762-8483-5f8f15c3a2d5"), "2-B", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6025), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null },
                    { new Guid("f53d1ea8-49fe-4cc7-8274-a05a1f4543f8"), "", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(6033), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("fa89e784-b93d-42cd-8874-28463cac21d4"), "1-A", "Computer1", new DateTime(2024, 3, 1, 13, 15, 32, 532, DateTimeKind.Utc).AddTicks(5988), "192.168.1.1", null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null }
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
