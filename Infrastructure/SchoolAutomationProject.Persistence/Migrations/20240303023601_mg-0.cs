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
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(4682), "192.168.1.3", null, "10-A", null, null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(4681), "192.168.1.2", null, "9-B", null, null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(4679), "192.168.1.1", null, "9-A", null, null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(4684), "192.168.1.4", null, "10-B", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5972), "192.168.1.1", null, "Matematik", null, null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5975), "192.168.1.2", null, "Türkçe", null, null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5976), "192.168.1.3", null, "Biyoloji", null, null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5978), "192.168.1.4", null, "Fizik", null, null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5979), "192.168.1.5", null, "Kimya", null, null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5982), "192.168.1.6", null, "Tarih", null, null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5983), "192.168.1.7", null, "Coğrafya", null, null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5985), "192.168.1.8", null, "İngilizce", null, null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5986), "192.168.1.9", null, "Müzik", null, null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(5988), "192.168.1.10", null, "Görsel Sanatlar", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(6981), "192.168.1.3", null, "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7001), "192.168.1.8", null, "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(6987), "192.168.1.5", null, "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(6977), "192.168.1.2", null, "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(6984), "192.168.1.4", null, "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7003), "192.168.1.9", null, "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(6997), "192.168.1.6", null, "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(6999), "192.168.1.7", null, "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7006), "192.168.1.10", null, "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(6971), "192.168.1.1", null, "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7800), "192.168.1.5", null, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7797), "192.168.1.4", null, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7793), "192.168.1.2", null, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7789), "192.168.1.1", null, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(7795), "192.168.1.3", null, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null }
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
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8872), "192.168.1.11", null, "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", null, "110-24", null, null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8850), "192.168.1.6", null, "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", null, "105-24", null, null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8834), "192.168.1.1", null, "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", null, "100-24", null, null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8858), "192.168.1.7", null, "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", null, "106-24", null, null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8874), "192.168.1.12", null, "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", null, "111-24", null, null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8863), "192.168.1.8", null, "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", null, "107-24", null, null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8869), "192.168.1.10", null, "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", null, "109-24", null, null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8843), "192.168.1.4", null, "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", null, "103-24", null, null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8847), "192.168.1.5", null, "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", null, "104-24", null, null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8837), "192.168.1.2", null, "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", null, "101-24", null, null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8840), "192.168.1.3", null, "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", null, "102-24", null, null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(8866), "192.168.1.9", null, "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", null, "108-24", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9707), "192.168.1.13", null, new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9677), "192.168.1.2", null, new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9714), "192.168.1.16", null, new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9709), "192.168.1.14", null, new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9693), "192.168.1.7", null, new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9679), "192.168.1.3", null, new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9700), "192.168.1.10", null, new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9722), "192.168.1.17", null, new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9727), "192.168.1.19", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9705), "192.168.1.12", null, new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9697), "192.168.1.9", null, new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9724), "192.168.1.18", null, new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9685), "192.168.1.5", null, new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9682), "192.168.1.4", null, new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9712), "192.168.1.15", null, new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9702), "192.168.1.11", null, new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9688), "192.168.1.6", null, new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9674), "192.168.1.1", null, new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9695), "192.168.1.8", null, new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(9729), "192.168.1.20", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "FirstName", "LastName", "MainCourseId", "Title", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(492), "192.168.1.5", null, "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(498), "192.168.1.10", null, "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(500), "192.168.1.11", null, "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(484), "192.168.1.2", null, "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(490), "192.168.1.4", null, "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(488), "192.168.1.3", null, "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(479), "192.168.1.1", null, "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(505), "192.168.1.13", null, "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(502), "192.168.1.12", null, "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Başöğretmen", null, null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(507), "192.168.1.14", null, "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(496), "192.168.1.6", null, "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("034fd621-6660-491b-9668-d6b9c183a5a9"), "Computer7", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2470), "192.168.1.43", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("090f96ac-39d7-4eba-ad31-62db61ebd29f"), "Computer9", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2478), "192.168.1.76", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null, null },
                    { new Guid("09687f30-4da6-4312-acbe-b4a9adbb8dbc"), "Computer16", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2510), "192.168.1.65", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("0a1216d0-7617-4573-959c-a64a734f4123"), "Computer22", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2535), "192.168.1.89", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("12937217-c955-493f-9148-63bdb01ecd62"), "Computer17", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2514), "192.168.1.63", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null, null },
                    { new Guid("14a32127-9ac3-473f-8e84-bf585e12985f"), "Computer53", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2686), "192.168.1.52", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null, null },
                    { new Guid("15527069-7818-4676-b983-073b6e7b99b9"), "Computer31", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2576), "192.168.1.42", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null, null },
                    { new Guid("1a7e0c7a-b596-4f58-a63e-4646f0b4abe6"), "Computer13", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2496), "192.168.1.94", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("22458558-5787-49c3-8c49-7e5f834f8013"), "Computer37", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2617), "192.168.1.59", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("23cb7b14-834b-486f-b847-e151db152a4f"), "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2444), "192.168.1.90", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null, null },
                    { new Guid("285a0278-d05e-4395-be98-3c3bad88ec55"), "Computer29", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2566), "192.168.1.84", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null, null },
                    { new Guid("2b409e5b-6e4b-4e6f-a4d1-e5f926bd8314"), "Computer39", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2627), "192.168.1.32", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("2b80367b-1cbb-489b-89bc-ee3226c2e240"), "Computer43", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2644), "192.168.1.86", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null, null },
                    { new Guid("30745b30-6d5f-4894-a101-695c1d8e3c75"), "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2439), "192.168.1.11", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null, null },
                    { new Guid("31a546e9-5d9a-46cc-80fa-be00706b7411"), "Computer6", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2464), "192.168.1.51", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null, null },
                    { new Guid("32d54730-a3d6-4683-bc63-f463a6b4b23c"), "Computer54", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2690), "192.168.1.20", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null, null },
                    { new Guid("37220992-80bf-42f4-a6c9-81a7b4153ccf"), "Computer44", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2648), "192.168.1.66", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null, null },
                    { new Guid("38deb48e-2fa0-457c-87cf-ba00f2a2a7a4"), "Computer56", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2700), "192.168.1.72", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null, null },
                    { new Guid("3afa1429-5b23-4c9e-a489-0ce205240912"), "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2459), "192.168.1.29", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null, null },
                    { new Guid("3d380600-62c8-4fbc-848e-c9cf801bfec2"), "Computer45", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2652), "192.168.1.8", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null, null },
                    { new Guid("4322564e-d862-4530-ae83-1bc9128803aa"), "Computer33", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2584), "192.168.1.32", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null, null },
                    { new Guid("4e2fc0e8-c371-4fe2-997a-bc5461631556"), "Computer49", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2670), "192.168.1.46", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("4e9fa9f5-d4d9-49cb-b941-415ec955b0e7"), "Computer60", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2719), "192.168.1.80", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null, null },
                    { new Guid("5350ab8c-ae62-453e-9cd6-d8c461057dbf"), "Computer24", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2546), "192.168.1.82", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("5407a2a9-ca89-452e-a235-2b724829e713"), "Computer20", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2527), "192.168.1.4", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null, null },
                    { new Guid("543a7eef-fa1d-455c-ae3d-5f2275cc7e14"), "Computer23", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2542), "192.168.1.93", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null, null },
                    { new Guid("54b83b51-f05b-4f92-ba4d-350bdc8c40c3"), "Computer26", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2554), "192.168.1.83", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null, null },
                    { new Guid("622a7d99-c134-4ba4-ac6b-de8216ea8ac8"), "Computer30", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2570), "192.168.1.73", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null, null },
                    { new Guid("69783464-cf47-42ac-8fcc-f42ef3a3e45c"), "Computer55", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2695), "192.168.1.48", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("6a159b8b-7aab-41fb-8044-f4f0700337c4"), "Computer42", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2640), "192.168.1.53", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null, null },
                    { new Guid("6bb3c09b-03be-4ddc-936d-09c1f48dc3cc"), "Computer10", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2483), "192.168.1.50", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("72ae1cdb-9fba-4d0f-b3d4-b9037b3cc933"), "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2404), "192.168.1.6", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null, null },
                    { new Guid("740967a5-390c-46d7-add1-ce263662eb9d"), "Computer38", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2621), "192.168.1.76", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null, null },
                    { new Guid("7d2e04bc-7167-42b7-b154-fed01d901c90"), "Computer14", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2500), "192.168.1.94", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("86c5d803-1853-4d1e-a224-2cbb48d94743"), "Computer52", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2682), "192.168.1.52", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null, null },
                    { new Guid("95fb77f8-43de-4529-8847-d5a648cab530"), "Computer12", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2491), "192.168.1.21", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("97159bf5-6f64-42bb-8a6f-5c41ee93eb86"), "Computer19", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2523), "192.168.1.23", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null, null },
                    { new Guid("a269836f-b15a-47fe-be64-43cd8ffc2dc9"), "Computer15", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2506), "192.168.1.69", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("a51c3f62-6ace-4ba2-9d8a-3a3626f25845"), "Computer58", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2708), "192.168.1.61", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null, null },
                    { new Guid("b13d6a22-d637-4a70-bbdc-a0ddeea09346"), "Computer51", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2678), "192.168.1.55", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null, null },
                    { new Guid("b736b47b-bd6f-4cee-b75e-bda75d2c951f"), "Computer36", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2612), "192.168.1.34", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null, null },
                    { new Guid("bebd2d00-3021-4507-a84b-47b2c675b83a"), "Computer59", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2714), "192.168.1.20", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("d0c236a5-e0d5-49ff-9768-a5b96fd7a44f"), "Computer46", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2656), "192.168.1.52", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("d38d09e8-dcef-4879-af2c-b16903f547cc"), "Computer50", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2674), "192.168.1.71", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null, null },
                    { new Guid("d76e50e0-8e88-4099-9e9b-33ddc47b8f29"), "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2448), "192.168.1.76", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("d9d1a050-8080-4bd9-8472-0320e9289bc8"), "Computer21", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2531), "192.168.1.11", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null },
                    { new Guid("db1fac12-6e14-4d44-8fef-733099b73c12"), "Computer34", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2604), "192.168.1.4", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("dfbf37a0-6c92-44fe-b4f9-494689b02fe8"), "Computer57", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2704), "192.168.1.56", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null, null },
                    { new Guid("dfc873c3-0bf6-445b-851c-d06188106c89"), "Computer47", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2662), "192.168.1.39", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null, null },
                    { new Guid("e8df0c65-6d5e-4f07-94b2-eaa011a8f496"), "Computer18", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2519), "192.168.1.2", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null, null },
                    { new Guid("e91f4fea-bf9c-4f69-9df0-14fb8dcf0f35"), "Computer8", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2474), "192.168.1.17", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null, null },
                    { new Guid("ebf022fa-6441-4f51-8c58-ff4d8cf04d2a"), "Computer25", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2550), "192.168.1.93", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null, null },
                    { new Guid("ed54a073-361d-4468-bc26-075630bc0d84"), "Computer32", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2580), "192.168.1.33", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null, null },
                    { new Guid("efc74d9f-8bbf-4a51-a44f-54545cfc786d"), "Computer27", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2558), "192.168.1.11", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null, null },
                    { new Guid("f09ffd3d-6a3a-40ab-8456-9aefe3648ee1"), "Computer11", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2487), "192.168.1.14", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("f12d2e1e-bba1-4c7d-b890-143dfd5b0373"), "Computer35", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2609), "192.168.1.54", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("f29e6a88-a389-4e06-be4a-5d66b6ee9540"), "Computer48", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2666), "192.168.1.57", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("fa1401df-e94b-483d-9e4b-11d1ded6415f"), "Computer41", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2636), "192.168.1.96", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null, null },
                    { new Guid("fbea159b-7519-412b-b1a3-927bbb39cfe1"), "Computer28", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2562), "192.168.1.87", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null, null },
                    { new Guid("fcb9192f-b535-4b3d-8e91-0f29caf1cea4"), "Computer40", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(2632), "192.168.1.96", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("010c2093-6d47-456a-894d-6f9c07bd1012"), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer23", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3760), "192.168.1.86", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("025d9c19-3c4e-4e86-8741-965d91cbefbe"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer37", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3836), "192.168.1.12", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("04d4b28b-cc55-4497-9cee-f122d6d45b58"), new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer16", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3716), "192.168.1.61", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("05faa432-56ef-479b-a508-f3bdc7c6275d"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer21", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3743), "192.168.1.32", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("0af1fab1-e2be-4ffb-91b2-c4ac80714572"), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer38", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3842), "192.168.1.45", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("10d1c9b0-82ae-4a9c-a67f-745b88335f6a"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer39", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3847), "192.168.1.70", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("1e0e5925-5ff2-404b-942c-c6a64f1513ba"), new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer14", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3704), "192.168.1.11", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("2061c532-768b-4106-8ef3-fc21ba1270d8"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer11", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3688), "192.168.1.63", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("25d19eef-07c5-40e2-9e26-7ab0c85863c0"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3631), "192.168.1.28", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("2735ad9c-789a-4704-a5e4-c06f6ec041ee"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer36", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3831), "192.168.1.11", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("2e5574a8-f86a-4369-aaed-f2d0159d7bda"), new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer41", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3860), "192.168.1.84", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("30d036d6-4604-40b2-adf9-907131d5dfbb"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer18", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3728), "192.168.1.82", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("44c83a22-7748-4aa4-9a24-fb02a8173210"), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer31", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3804), "192.168.1.86", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("4565c40b-2b15-40a6-8325-69099320fead"), new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer26", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3777), "192.168.1.55", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("4ba8fb12-9d7b-4101-95ba-1a9355e053c2"), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer5", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3654), "192.168.1.65", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("4d2dd4ba-1230-4392-8af5-c3a974c568ed"), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer19", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3734), "192.168.1.32", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("54ed74b9-084a-4c57-a53c-96f949d3c656"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer35", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3826), "192.168.1.34", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("5be53579-4335-4ab7-bfb2-8e6b104d8cf4"), new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3798), "192.168.1.68", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("5c6fb199-89d7-4787-8731-8a59d2cd2cf5"), new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer2", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3636), "192.168.1.7", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("689652f3-ddab-42e7-93a7-81ec7d868bb3"), new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer42", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3865), "192.168.1.73", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("6a3f3813-d497-43a4-99cd-bb9a724e2f67"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer22", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3755), "192.168.1.40", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("6c278190-fb6e-44b7-88a8-39730e5f664f"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer9", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3677), "192.168.1.61", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("6f7e4b12-9fd9-4cf7-9cbe-98d2034cc81c"), new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer28", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3788), "192.168.1.48", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("7a182d77-bddf-4583-89de-54197acb2e92"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer4", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3648), "192.168.1.78", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("88fe76a3-a951-4bfa-8626-9aa676ea7d37"), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer32", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3810), "192.168.1.32", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("97de62e8-6a22-4ec0-8505-438588c5603c"), new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer13", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3699), "192.168.1.19", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("981ce330-8d99-489d-a580-cf4533bd2c74"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer34", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3821), "192.168.1.60", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("9c6a28a2-4d1d-4018-8042-98e96bd60bb6"), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer25", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3772), "192.168.1.36", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("a9c749b9-6561-4b88-bf4e-bd17bbee1345"), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer17", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3721), "192.168.1.95", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("b06c6732-f249-4849-a05f-e0cd42cf57c8"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer33", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3816), "192.168.1.20", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("b8cb42b5-b0e2-460c-8a97-4c4d474e2aa9"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer12", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3693), "192.168.1.17", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("c0fae748-65bf-41f7-9e2f-e61d7fe777e9"), new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer40", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3854), "192.168.1.77", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("c3b174e9-9d9b-4d68-8af9-d4ed1c26dcfa"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer10", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3682), "192.168.1.94", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("c9b6bf6d-049c-4a7b-86e1-4edbf3acb9d5"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer3", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3643), "192.168.1.31", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("ca4b65c1-940f-44af-95d7-76e9e024119a"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer27", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3783), "192.168.1.43", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("cc73f8d7-3e0b-4eef-8e0f-c9bddb7f6143"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer20", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3738), "192.168.1.65", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("cfa4f53b-650b-4e8b-b10c-b0c7db29e154"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer8", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3671), "192.168.1.34", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("d544543f-8f91-4a0d-a8c7-5d98cb7c0287"), new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer7", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3665), "192.168.1.38", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("d5fd58e0-1673-4bbb-9c44-21aa0f6001a5"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer24", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3767), "192.168.1.4", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("ddbd297c-6cb1-4d2e-bb07-f0462a2c9f01"), new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer6", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3661), "192.168.1.33", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("f1696be7-d1fb-4910-8151-7d7dfa32ae3f"), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer15", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3708), "192.168.1.51", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("f3714b12-5a84-4720-ac4a-f03f66638ea2"), new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer0", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3618), "192.168.1.69", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("fefa0e17-188d-42d5-b0ec-d0a0602c9e1d"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer29", new DateTime(2024, 3, 3, 2, 36, 1, 630, DateTimeKind.Utc).AddTicks(3794), "192.168.1.76", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null }
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
                    { new Guid("973972d5-6489-4d99-8d8b-e3ac10decdef"), "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(2900), "192.168.1.94", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null, null },
                    { new Guid("e44ff2c6-2c2b-4b87-85d7-250496da1e99"), "Computer0", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(2861), "192.168.1.22", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("1451593e-191d-41cc-b2e0-1082499caec3"), "1-A", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1220), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null },
                    { new Guid("234cb719-bb85-4afb-ad52-e110d55fc9ec"), "2-B", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1194), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("2be67e3f-1a47-443e-9d8e-57e87fdcf86b"), "3-D", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1197), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("2dc953b6-dbe8-44e9-bd61-b0c2d38e3aa8"), "1-A", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1216), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("39097f78-d850-470c-965f-b6de5dbac4ed"), "", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1211), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("41b824e4-0e73-49fe-842d-4aa219be954b"), "4-C", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1237), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null },
                    { new Guid("423cb564-4f10-4264-b4a4-1fd8096a3186"), "2-B", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1225), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("5df3922c-e311-4aed-9894-969082a7f0d4"), "1-A", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1184), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("6d4522c2-fbc6-4762-bcaf-ebe8e8a755f0"), "", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1232), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("71216b9b-3459-401a-b526-d3cc485bb718"), "1-A", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1189), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null },
                    { new Guid("8f61bd0a-2522-4cda-97f8-5068f029a518"), "2-B", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1222), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null },
                    { new Guid("a6a243e8-e403-4309-a1b0-709958213f5c"), "", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1227), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("ad3bf73d-4c34-4e67-8916-3e77e063a5ae"), "4-C", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1234), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("be5dc285-1347-43ff-bcd5-f1afb057de52"), "2-B", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1191), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null },
                    { new Guid("be5ff821-9017-40c0-b799-5e6c9ab91812"), "3-D", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1208), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("ff0fd3c0-229a-4dd7-b687-dd5b8de243c6"), "", "Computer1", new DateTime(2024, 3, 3, 2, 36, 1, 631, DateTimeKind.Utc).AddTicks(1214), "192.168.1.1", null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null }
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
