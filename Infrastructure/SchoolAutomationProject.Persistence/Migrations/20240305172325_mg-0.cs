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
                name: "Administrators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_Administrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrators_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Administrators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Administrators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Announcements_Teachers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Teachers",
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

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeworks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homeworks_SubCourses_SubCourseId",
                        column: x => x.SubCourseId,
                        principalTable: "SubCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementRoles",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnnouncementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementRoles", x => new { x.AnnouncementId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AnnouncementRoles_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnnouncementRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
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
                columns: new[] { "Id", "Capacity", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(5197), "192.168.1.3", null, "10-A", null, null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(5195), "192.168.1.2", null, "9-B", null, null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(5192), "192.168.1.1", null, "9-A", null, null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(5199), "192.168.1.4", null, "10-B", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6884), "192.168.1.1", null, "Matematik", null, null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6887), "192.168.1.2", null, "Türkçe", null, null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6889), "192.168.1.3", null, "Biyoloji", null, null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6891), "192.168.1.4", null, "Fizik", null, null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6892), "192.168.1.5", null, "Kimya", null, null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6895), "192.168.1.6", null, "Tarih", null, null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6896), "192.168.1.7", null, "Coğrafya", null, null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6898), "192.168.1.8", null, "İngilizce", null, null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6900), "192.168.1.9", null, "Müzik", null, null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(6902), "192.168.1.10", null, "Görsel Sanatlar", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7918), "192.168.1.3", null, "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7929), "192.168.1.8", null, "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7922), "192.168.1.5", null, "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7916), "192.168.1.2", null, "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7920), "192.168.1.4", null, "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7931), "192.168.1.9", null, "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7925), "192.168.1.6", null, "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7927), "192.168.1.7", null, "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7934), "192.168.1.10", null, "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(7911), "192.168.1.1", null, "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(8877), "192.168.1.5", null, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(8875), "192.168.1.4", null, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(8871), "192.168.1.2", null, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(8868), "192.168.1.1", null, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(8873), "192.168.1.3", null, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null }
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
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(49), "192.168.1.11", null, "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", null, "110-24", null, null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(35), "192.168.1.6", null, "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", null, "105-24", null, null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(13), "192.168.1.1", null, "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", null, "100-24", null, null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(38), "192.168.1.7", null, "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", null, "106-24", null, null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(52), "192.168.1.12", null, "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", null, "111-24", null, null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(41), "192.168.1.8", null, "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", null, "107-24", null, null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(47), "192.168.1.10", null, "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", null, "109-24", null, null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(23), "192.168.1.4", null, "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", null, "103-24", null, null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(25), "192.168.1.5", null, "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", null, "104-24", null, null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(17), "192.168.1.2", null, "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", null, "101-24", null, null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(20), "192.168.1.3", null, "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", null, "102-24", null, null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(44), "192.168.1.9", null, "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", null, "108-24", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(942), "192.168.1.13", null, new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(915), "192.168.1.2", null, new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(954), "192.168.1.16", null, new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(950), "192.168.1.14", null, new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(927), "192.168.1.7", null, new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(917), "192.168.1.3", null, new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(935), "192.168.1.10", null, new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(956), "192.168.1.17", null, new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(962), "192.168.1.19", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(939), "192.168.1.12", null, new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(932), "192.168.1.9", null, new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(960), "192.168.1.18", null, new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(922), "192.168.1.5", null, new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(920), "192.168.1.4", null, new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(952), "192.168.1.15", null, new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(937), "192.168.1.11", null, new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(925), "192.168.1.6", null, new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(912), "192.168.1.1", null, new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(930), "192.168.1.8", null, new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(964), "192.168.1.20", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "FirstName", "LastName", "MainCourseId", "Title", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5375), "192.168.1.5", null, "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5383), "192.168.1.10", null, "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5385), "192.168.1.11", null, "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5366), "192.168.1.2", null, "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5371), "192.168.1.4", null, "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5369), "192.168.1.3", null, "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5362), "192.168.1.1", null, "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5390), "192.168.1.13", null, "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5387), "192.168.1.12", null, "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Başöğretmen", null, null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5393), "192.168.1.14", null, "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(5380), "192.168.1.6", null, "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("02d271d6-c089-40ec-a498-ac6509ac3f28"), "Computer38", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2939), "192.168.1.24", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("0e4afc81-a163-421d-a1bd-899b30ce6bcb"), "Computer46", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2973), "192.168.1.54", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null, null },
                    { new Guid("11773a79-1d32-4d4a-ba18-91a1c1db07e3"), "Computer43", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2961), "192.168.1.36", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("12164ad3-488b-4da5-ae3d-fc311ade45d5"), "Computer27", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2887), "192.168.1.62", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("177eaf63-d711-4b5b-8821-7e6ab77039c8"), "Computer50", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2991), "192.168.1.18", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("232002fd-3a28-40bb-bc24-55d242fe6ca9"), "Computer30", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2904), "192.168.1.43", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null, null },
                    { new Guid("2875960f-0bde-4062-9136-3666e8837aed"), "Computer48", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2981), "192.168.1.37", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("2a653ea5-198b-4e3f-bdba-ee8421dd4e38"), "Computer20", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2853), "192.168.1.67", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null, null },
                    { new Guid("2ac97377-3a3b-4189-99b6-9fa3196f0c99"), "Computer40", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2948), "192.168.1.3", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("2c30c198-1713-4cbf-bbbd-f9a9c62b6c38"), "Computer35", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2927), "192.168.1.72", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null, null },
                    { new Guid("2df6d60d-8af7-4c6d-aa4a-1f3b0d004eb7"), "Computer45", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2969), "192.168.1.36", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null },
                    { new Guid("2e86f6a2-183b-4572-9255-0bd91cb2e65f"), "Computer14", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2826), "192.168.1.8", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null, null },
                    { new Guid("367661c1-46a6-4dd1-ae62-767f5d2c310d"), "Computer56", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3026), "192.168.1.61", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null, null },
                    { new Guid("414feeee-1923-416a-a79c-07926ef959fa"), "Computer33", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2917), "192.168.1.42", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null, null },
                    { new Guid("41cbe129-1875-4e28-a6cf-95b4a96cd6e2"), "Computer18", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2845), "192.168.1.13", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null, null },
                    { new Guid("44164bde-3f20-4bc1-89ba-676613fe34c9"), "Computer52", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2999), "192.168.1.60", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("44f8b14b-8f94-4c7e-b38e-04ea32d404c8"), "Computer58", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3036), "192.168.1.18", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null, null },
                    { new Guid("482357d1-9ffc-4ac6-b44a-be22314de87a"), "Computer55", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3022), "192.168.1.60", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("4bc7f053-eae7-4bbe-a02b-40645a09a851"), "Computer15", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2830), "192.168.1.56", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null, null },
                    { new Guid("51411f20-55ea-4575-bdbb-aa6acfdfccb6"), "Computer41", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2952), "192.168.1.53", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null, null },
                    { new Guid("53b869b3-8523-40f7-bc31-f260855b0461"), "Computer57", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3030), "192.168.1.68", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null },
                    { new Guid("53c706e0-18bf-4ff7-8fef-2029b097685a"), "Computer13", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2822), "192.168.1.34", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null, null },
                    { new Guid("5c238820-b8f1-4093-b7d4-02afa4a18240"), "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2726), "192.168.1.94", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("6f40118c-9911-40c0-ac02-77ea76a2f357"), "Computer8", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2798), "192.168.1.11", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null, null },
                    { new Guid("715342ae-2217-475c-ad09-a2a4636ef2ed"), "Computer37", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2935), "192.168.1.30", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("75e88da4-2e49-4d51-8bac-23302921e533"), "Computer10", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2810), "192.168.1.52", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null, null },
                    { new Guid("7884eab5-b25d-4fbf-9b81-a50acad2e033"), "Computer25", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2873), "192.168.1.71", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null, null },
                    { new Guid("795ffff8-a62f-4df1-b493-58cdce3548cb"), "Computer21", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2857), "192.168.1.97", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null, null },
                    { new Guid("81325659-3026-43d5-8122-5cd5b6d5b1f7"), "Computer26", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2879), "192.168.1.78", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("81f477ed-371f-4f6f-a48d-94df2f8d09d8"), "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2785), "192.168.1.89", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null, null },
                    { new Guid("82498b68-fb38-43dc-9395-a36e9629c986"), "Computer49", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2985), "192.168.1.54", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null, null },
                    { new Guid("861c5176-b7cf-4499-9b2d-cb0de184ab56"), "Computer29", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2900), "192.168.1.15", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null, null },
                    { new Guid("86f22ade-8ffb-43f8-95fb-ad496da25227"), "Computer60", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3043), "192.168.1.85", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null, null },
                    { new Guid("8c6eed0a-d2f2-433c-b11c-100a72520777"), "Computer36", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2931), "192.168.1.76", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null, null },
                    { new Guid("924775e6-153f-4124-8a87-82cebd5b1617"), "Computer17", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2838), "192.168.1.73", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null, null },
                    { new Guid("92ca899b-7610-4bd5-97b3-40b1b2158ad7"), "Computer6", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2790), "192.168.1.85", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null, null },
                    { new Guid("92e9f6ea-3ca4-4910-bddb-60f821a71109"), "Computer42", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2957), "192.168.1.31", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null, null },
                    { new Guid("9b8b0178-b8f0-46a5-8e73-55be5f92b08e"), "Computer19", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2849), "192.168.1.22", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("a3cdfb35-e2d8-4129-9083-1a790b11fd20"), "Computer11", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2814), "192.168.1.92", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("a5836a95-32ba-412d-8699-8583db862d0a"), "Computer47", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2977), "192.168.1.99", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null, null },
                    { new Guid("a95540c8-ff0a-45bd-a615-10bfd0540494"), "Computer53", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3003), "192.168.1.63", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null, null },
                    { new Guid("ab5305f0-a45c-40dd-b515-ac5008eeb908"), "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2781), "192.168.1.90", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null, null },
                    { new Guid("ae48e5de-b033-4a3c-9b6c-ea36aae9bd19"), "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2777), "192.168.1.12", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null, null },
                    { new Guid("aec0f283-cb61-4be5-a522-91b7d7877508"), "Computer22", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2861), "192.168.1.59", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null, null },
                    { new Guid("ba8e04f4-10f3-4a3e-a1b0-31225d2b469e"), "Computer31", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2908), "192.168.1.51", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null, null },
                    { new Guid("bb61c465-f6de-443a-bb50-83b6de604dc9"), "Computer59", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3039), "192.168.1.53", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("bbe7a754-9bbd-4df7-93c4-bd6394d5aa62"), "Computer54", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(3007), "192.168.1.62", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null, null },
                    { new Guid("be1df604-2cf1-4301-9402-06453d3d8890"), "Computer32", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2912), "192.168.1.95", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null, null },
                    { new Guid("c7d9cc3d-d4d9-4b18-8d46-ea084430f3f8"), "Computer7", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2794), "192.168.1.93", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("c807f1e5-131f-4f07-9f6c-f3af67cc5e89"), "Computer9", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2802), "192.168.1.96", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null, null },
                    { new Guid("cc4fbd6a-fce2-4488-81fd-eaa53524d66d"), "Computer44", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2965), "192.168.1.57", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null, null },
                    { new Guid("d1d7799b-c2c3-44e7-aa05-7d32d903f404"), "Computer39", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2943), "192.168.1.84", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("d4064484-b551-4c19-a5a9-b67368c18b44"), "Computer23", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2865), "192.168.1.23", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("d7b21f35-1570-4239-85fc-152f376aeb5a"), "Computer28", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2896), "192.168.1.40", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("de7aba32-0d3b-402b-a777-c92be1d7a212"), "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2772), "192.168.1.6", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("df87ff0e-dfaf-44c2-903e-7fca3ae2a2ea"), "Computer16", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2834), "192.168.1.8", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null, null },
                    { new Guid("e1c68eda-04d4-4f2a-bcff-66c35f98f28e"), "Computer24", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2869), "192.168.1.16", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null, null },
                    { new Guid("e9f83b66-67d1-4058-83ec-3de1a69db34d"), "Computer34", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2923), "192.168.1.8", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("f95f1f8d-2100-4540-a661-9ed2eea06a31"), "Computer51", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2995), "192.168.1.36", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("fbd4f2bd-f2ce-4bdc-83fb-69c286aa9fc9"), "Computer12", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(2818), "192.168.1.41", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("045ad8fe-b93f-46a1-b9b1-f556914d059c"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer19", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4265), "192.168.1.23", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("1378b262-6a0c-48a1-a32e-c0b2a69bd660"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer26", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4307), "192.168.1.5", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("264f66b2-99ff-4096-bd21-1a5f4517639b"), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer21", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4280), "192.168.1.12", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("279fd634-b052-4a9c-bb29-6426977e9cd7"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer29", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4325), "192.168.1.45", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null, null },
                    { new Guid("2a5068b0-4b95-4f3e-84d8-da3eb4522a0c"), new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer15", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4243), "192.168.1.45", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("2afb1a17-cbab-4d3d-9897-4f04e44afa7f"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer6", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4189), "192.168.1.43", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("2d2afe0e-eafe-4b01-84f7-22b71789a3f9"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer13", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4234), "192.168.1.56", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null, null },
                    { new Guid("30cc8698-dd29-47d4-9362-07dc039eeaf4"), new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer24", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4297), "192.168.1.73", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("42b2688d-da4d-47b2-a54e-995f9cd2a030"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer25", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4302), "192.168.1.89", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null, null },
                    { new Guid("450227a0-606a-44ca-ba1a-c5d880d7b228"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer31", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4336), "192.168.1.12", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("4bc0e971-21f9-458c-9aad-71f7e3498b2a"), new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer10", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4217), "192.168.1.23", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("51bc91fc-8733-4940-b20c-84125464f4e7"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer7", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4200), "192.168.1.81", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("5880b46b-b3b7-4278-b81e-c1cfaf356c74"), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer11", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4224), "192.168.1.41", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("59e290cc-e82b-4239-8804-52ad377af158"), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4158), "192.168.1.31", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("5c7d34d5-0a26-493a-8d29-b820a85d340b"), new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer2", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4163), "192.168.1.2", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("62e3f7a4-f59c-4cb4-8141-9077093c0817"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer18", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4259), "192.168.1.82", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("6ae066bb-daaa-4cd9-ae88-9ce9cc373208"), new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer14", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4239), "192.168.1.68", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("74231fc1-3db1-479e-87ee-0d2cd60431fb"), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer4", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4176), "192.168.1.49", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("74e8371f-b1c9-4daf-88e8-0e67fdf3ff21"), new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer22", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4285), "192.168.1.14", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("7a4a4867-8ff0-4b9e-959d-609be361d467"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer27", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4314), "192.168.1.95", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("8097bb79-4385-4449-b8fe-074cdc650792"), new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer33", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4347), "192.168.1.44", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("84e1a3db-547d-4bca-bf87-86fae6815602"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer32", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4342), "192.168.1.93", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("864f355a-12a5-48d1-9dad-3f6d90e5ab04"), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer5", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4184), "192.168.1.80", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("979a8c8d-0f9a-46af-9afe-d281547548f9"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer20", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4275), "192.168.1.47", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("985bf2af-8af3-4898-8412-cef6bac3256c"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer3", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4172), "192.168.1.64", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("ba843fa6-9eeb-4f22-a3a0-be23ba85de2a"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer9", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4212), "192.168.1.7", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("bba32dca-9085-4c2e-9e7f-1de8913ccdba"), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer0", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4146), "192.168.1.68", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("c3cfa326-698f-47a9-b79b-36c45c0b4c60"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer23", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4291), "192.168.1.92", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("ca7f3f22-11a5-428c-8b1d-f3deeaf12d46"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer16", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4248), "192.168.1.75", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("d582b1b7-1dff-4961-93d3-7e4973c87fb4"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer8", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4205), "192.168.1.7", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("e38d44b4-2317-4316-9f30-27e1216ab03c"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer17", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4254), "192.168.1.93", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null, null },
                    { new Guid("e6feebbb-6c2e-4c74-9a2d-217fc885f4ae"), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer12", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4230), "192.168.1.15", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("f1207ead-98d8-4854-bcde-354d3c0bbc25"), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer30", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4330), "192.168.1.1", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("f8dfede6-e9d2-496c-9e80-183e81e0350d"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer28", new DateTime(2024, 3, 5, 17, 23, 25, 455, DateTimeKind.Utc).AddTicks(4318), "192.168.1.55", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null }
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
                    { new Guid("05796208-807a-48fb-aa7c-183f4164950f"), "Computer0", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(8042), "192.168.1.40", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null, null },
                    { new Guid("98ced7de-e66a-462a-9a12-6bf2b020cf84"), "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(8069), "192.168.1.49", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("004e9469-dd8d-40ab-a495-7f36eed0a1ba"), "1-A", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6616), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null },
                    { new Guid("11345c98-55dd-4dc9-9008-be3cf59c919b"), "1-A", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6610), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("1cbb6853-dc9f-4134-8e82-a684d2d5729e"), "4-C", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6631), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null },
                    { new Guid("2055f491-519d-4936-99ce-56a821dcfdf9"), "1-A", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6574), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("4707befe-6aef-4a2b-bf74-4bfc66994227"), "", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6625), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("4f3706ed-116e-481d-b645-fdb13ac45ae9"), "2-B", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6594), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("536e0b71-bb71-4e91-9c3c-3dc770c95931"), "3-D", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6597), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("72f73264-5ef5-4e0f-a927-7ee324f9aca1"), "", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6604), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("7a37b1d5-15e2-48a2-9ad0-8b9fd028b2f7"), "1-A", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6588), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null },
                    { new Guid("a87b5e2e-b22f-40be-8d4e-022af91ec157"), "2-B", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6621), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("a9d6a0e8-59e4-48f6-a9a1-caf2f2968161"), "4-C", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6628), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("b8f234e6-7b59-4b07-a6b7-e29a58ce43c8"), "2-B", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6591), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null },
                    { new Guid("b9d1e878-f422-41bd-b482-61ff16d54cd2"), "", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6607), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null },
                    { new Guid("c744b6e5-85a1-45f7-baf4-43a9160c3b51"), "", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6623), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("da79cd95-e147-45d3-9e27-cd43359fe526"), "3-D", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6601), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("f67a2930-0067-4486-96c7-7183c971bae7"), "2-B", "Computer1", new DateTime(2024, 3, 5, 17, 23, 25, 456, DateTimeKind.Utc).AddTicks(6618), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null }
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
                name: "IX_Administrators_UserId",
                table: "Administrators",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementRoles_RoleId",
                table: "AnnouncementRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CreatorId",
                table: "Announcements",
                column: "CreatorId");

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
                name: "IX_Homeworks_StudentId",
                table: "Homeworks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_SubCourseId",
                table: "Homeworks",
                column: "SubCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

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
                name: "AnnouncementRoles");

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
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "TeacherSchedules");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SubCourses");

            migrationBuilder.DropTable(
                name: "Administrators");

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
