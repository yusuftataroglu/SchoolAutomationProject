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
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_Announcements_AspNetUsers_SenderId",
                        column: x => x.SenderId,
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
                    { new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), (byte)25, "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(1404), "192.168.1.3", null, "10-A", null, null, null, null },
                    { new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), (byte)25, "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(1402), "192.168.1.2", null, "9-B", null, null, null, null },
                    { new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), (byte)25, "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(1399), "192.168.1.1", null, "9-A", null, null, null, null },
                    { new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), (byte)25, "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(1406), "192.168.1.4", null, "10-B", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCourses",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Name", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3475), "192.168.1.1", null, "Matematik", null, null, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3479), "192.168.1.2", null, "Türkçe", null, null, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3480), "192.168.1.3", null, "Biyoloji", null, null, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3482), "192.168.1.4", null, "Fizik", null, null, null, null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3484), "192.168.1.5", null, "Kimya", null, null, null, null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Computer6", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3487), "192.168.1.6", null, "Tarih", null, null, null, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Computer7", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3488), "192.168.1.7", null, "Coğrafya", null, null, null, null },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Computer8", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3490), "192.168.1.8", null, "İngilizce", null, null, null, null },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Computer9", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3492), "192.168.1.9", null, "Müzik", null, null, null, null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Computer10", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(3494), "192.168.1.10", null, "Görsel Sanatlar", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4860), "192.168.1.3", null, "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null, null, null },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4877), "192.168.1.8", null, "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, null, null, "5556789012" },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4866), "192.168.1.5", null, "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null, null, null },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4857), "192.168.1.2", null, "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, null, null, "5553456789" },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4862), "192.168.1.4", null, "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, null, null, "5554567890" },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4879), "192.168.1.9", null, "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null, null, null },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4871), "192.168.1.6", null, "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, null, null, "5555678901" },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4874), "192.168.1.7", null, "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null, null, null },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4882), "192.168.1.10", null, "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, null, null, "5557890123" },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(4852), "192.168.1.1", null, "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, null, null, "5557654321" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "EndDate", "Name", "StartDate", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(5864), "192.168.1.5", null, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024-2025 Spring Season", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(5862), "192.168.1.4", null, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Fall Season", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(5858), "192.168.1.2", null, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Fall Season", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(5855), "192.168.1.1", null, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022-2023 Spring Season", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(5860), "192.168.1.3", null, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-2024 Spring Season", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null }
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
                    { new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 2, "Computer11", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7444), "192.168.1.11", null, "Sema", 85.400000000000006, 0, "Necmettin Erbakan Ortaokulu", false, "Tekin", null, "110-24", null, null, null, null, null, null },
                    { new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer6", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7428), "192.168.1.6", null, "Emine", 87.299999999999997, 0, "Hacı Ahmet İlkokulu", true, "Yılmaz", null, "105-24", null, null, null, null, null, null },
                    { new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7405), "192.168.1.1", null, "Fatma", 88.200000000000003, 0, "Cumhuriyet İlkokulu", false, "Yıldırım", null, "100-24", null, null, null, null, null, null },
                    { new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer7", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7432), "192.168.1.7", null, "Mehmet", 83.599999999999994, 1, "Mustafa Kemal Ortaokulu", false, "Kurt", null, "106-24", null, null, null, null, null, null },
                    { new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"), 3, "Computer12", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7447), "192.168.1.12", null, "Can", 92.099999999999994, 1, "Abdullah Gül İlkokulu", true, "Aydın", null, "111-24", null, null, null, null, null, null },
                    { new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer8", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7435), "192.168.1.8", null, "Fatih", 94.200000000000003, 1, "Cumhuriyet İlkokulu", true, "Sarı", null, "107-24", null, null, null, null, null, null },
                    { new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer10", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7441), "192.168.1.10", null, "Ali", 88.700000000000003, 1, "İsmet İnönü İlkokulu", true, "Özdemir", null, "109-24", null, null, null, null, null, null },
                    { new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7415), "192.168.1.4", null, "Ayşe", 91.5, 0, "Mehmet Akif İlkokulu", true, "Kaya", null, "103-24", null, null, null, null, null, null },
                    { new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"), 1, "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7418), "192.168.1.5", null, "Ahmet", 79.799999999999997, 1, "Ali Rıza Ortaokulu", false, "Arslan", null, "104-24", null, null, null, null, null, null },
                    { new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7409), "192.168.1.2", null, "Mustafa", 95.0, 1, "Şehit Hasan Ortaokulu", true, "Şahin", null, "101-24", null, null, null, null, null, null },
                    { new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"), 1, "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7413), "192.168.1.3", null, "Zeynep", 82.700000000000003, 0, "Atatürk İlkokulu", false, "Güler", null, "102-24", null, null, null, null, null, null },
                    { new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"), 1, "Computer9", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(7437), "192.168.1.9", null, "Elif", 78.900000000000006, 0, "Fatih Sultan Mehmet Ortaokulu", false, "Demir", null, "108-24", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCourses",
                columns: new[] { "Id", "Code", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "MainCourseId", "Position", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "WeeklyHour" },
                values: new object[,]
                {
                    { new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), "GEO101", "Computer13", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8643), "192.168.1.13", null, new Guid("77777777-7777-7777-7777-777777777777"), 1, null, null, null, null, 3 },
                    { new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), "MAT102", "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8615), "192.168.1.2", null, new Guid("11111111-1111-1111-1111-111111111111"), 2, null, null, null, null, 3 },
                    { new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), "ENG102", "Computer16", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8651), "192.168.1.16", null, new Guid("88888888-8888-8888-8888-888888888888"), 2, null, null, null, null, 4 },
                    { new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), "GEO102", "Computer14", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8646), "192.168.1.14", null, new Guid("77777777-7777-7777-7777-777777777777"), 2, null, null, null, null, 3 },
                    { new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), "PHY101", "Computer7", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8629), "192.168.1.7", null, new Guid("44444444-4444-4444-4444-444444444444"), 1, null, null, null, null, 4 },
                    { new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), "TUR101", "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8618), "192.168.1.3", null, new Guid("22222222-2222-2222-2222-222222222222"), 1, null, null, null, null, 4 },
                    { new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), "CHEM102", "Computer10", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8636), "192.168.1.10", null, new Guid("55555555-5555-5555-5555-555555555555"), 2, null, null, null, null, 3 },
                    { new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), "MUS101", "Computer17", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8653), "192.168.1.17", null, new Guid("99999999-9999-9999-9999-999999999999"), 1, null, null, null, null, 3 },
                    { new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), "ART101", "Computer19", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8659), "192.168.1.19", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 1, null, null, null, null, 4 },
                    { new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), "HIS102", "Computer12", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8641), "192.168.1.12", null, new Guid("66666666-6666-6666-6666-666666666666"), 2, null, null, null, null, 4 },
                    { new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), "CHEM101", "Computer9", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8633), "192.168.1.9", null, new Guid("55555555-5555-5555-5555-555555555555"), 1, null, null, null, null, 3 },
                    { new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), "MUS102", "Computer18", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8657), "192.168.1.18", null, new Guid("99999999-9999-9999-9999-999999999999"), 2, null, null, null, null, 3 },
                    { new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), "BIO101", "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8623), "192.168.1.5", null, new Guid("33333333-3333-3333-3333-333333333333"), 1, null, null, null, null, 3 },
                    { new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), "TUR102", "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8620), "192.168.1.4", null, new Guid("22222222-2222-2222-2222-222222222222"), 2, null, null, null, null, 4 },
                    { new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), "ENG101", "Computer15", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8648), "192.168.1.15", null, new Guid("88888888-8888-8888-8888-888888888888"), 1, null, null, null, null, 4 },
                    { new Guid("bd914d22-1482-497d-a552-6926b915f669"), "HIS101", "Computer11", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8639), "192.168.1.11", null, new Guid("66666666-6666-6666-6666-666666666666"), 1, null, null, null, null, 4 },
                    { new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), "BIO102", "Computer6", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8626), "192.168.1.6", null, new Guid("33333333-3333-3333-3333-333333333333"), 2, null, null, null, null, 3 },
                    { new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), "MAT101", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8611), "192.168.1.1", null, new Guid("11111111-1111-1111-1111-111111111111"), 1, null, null, null, null, 3 },
                    { new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), "PHY102", "Computer8", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8631), "192.168.1.8", null, new Guid("44444444-4444-4444-4444-444444444444"), 2, null, null, null, null, 4 },
                    { new Guid("fb221081-45cd-42be-abd4-45976e996233"), "ART102", "Computer20", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(8661), "192.168.1.20", null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 2, null, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "FirstName", "LastName", "MainCourseId", "Title", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"), "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9808), "192.168.1.5", null, "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null, null, null },
                    { new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"), "Computer10", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9816), "192.168.1.10", null, "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"), "Computer11", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9818), "192.168.1.11", null, "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null, null, null },
                    { new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"), "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9800), "192.168.1.2", null, "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"), "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9806), "192.168.1.4", null, "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null, null, null },
                    { new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"), "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9803), "192.168.1.3", null, "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null, null, null },
                    { new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9796), "192.168.1.1", null, "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null, null, null },
                    { new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"), "Computer13", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9824), "192.168.1.13", null, "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null, null, null },
                    { new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"), "Computer12", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9821), "192.168.1.12", null, "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Başöğretmen", null, null, null, null, null },
                    { new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"), "Computer14", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9827), "192.168.1.14", null, "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Uzman Öğretmen", null, null, null, null, null },
                    { new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"), "Computer6", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(9813), "192.168.1.6", null, "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("0363fa1b-d96e-45cc-9fd6-39412aa3cd84"), "Computer54", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8695), "192.168.1.10", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null, null },
                    { new Guid("051768a5-3c85-45dc-87c1-4933e48e6d7c"), "Computer46", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8657), "192.168.1.98", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("063089fd-383f-4b20-8771-c0507b49ab25"), "Computer56", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8711), "192.168.1.83", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null, null },
                    { new Guid("0658dcc2-595f-4030-8235-c65356896e6e"), "Computer39", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8624), "192.168.1.90", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("0eed341c-3ff5-4a4a-b38d-0fc3ee65f342"), "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8357), "192.168.1.6", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null, null },
                    { new Guid("15301098-bdc6-4399-8d5e-10a8d42e6351"), "Computer17", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8497), "192.168.1.73", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null, null },
                    { new Guid("2419cb1a-c5eb-454f-a04c-695959d43d3f"), "Computer33", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8594), "192.168.1.85", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null, null },
                    { new Guid("2aee1fbc-30d8-4901-8c89-ed9172798def"), "Computer52", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8685), "192.168.1.54", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null, null },
                    { new Guid("2dfbbd81-d07b-4589-96c6-200e93b8cfdb"), "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8362), "192.168.1.47", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null, null },
                    { new Guid("2e3d9e67-e9b2-4f07-a9bd-3bc55c58bc21"), "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8313), "192.168.1.15", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("3125a2d2-5559-40bb-ba78-b847138f7760"), "Computer55", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8706), "192.168.1.97", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("3b896074-1eb3-498a-9ac7-06d348ed9f87"), "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8385), "192.168.1.15", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null, null },
                    { new Guid("469a2c2e-431c-41a9-b503-7e2da7ff8f81"), "Computer43", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8642), "192.168.1.80", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null, null },
                    { new Guid("46c3942c-b253-4fd9-ad7f-02b5f1e6545f"), "Computer45", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8653), "192.168.1.94", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null },
                    { new Guid("46dfa0d2-53ef-4636-8da3-3424f1434ea9"), "Computer11", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8427), "192.168.1.55", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("49a0535a-70d4-4701-9096-c5b6bf7c5367"), "Computer32", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8590), "192.168.1.2", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null, null },
                    { new Guid("4a95e526-78cd-4be9-8c75-475ccdeed6aa"), "Computer57", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8715), "192.168.1.11", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null },
                    { new Guid("4cb254dc-4518-437d-9691-d2d9162c0acd"), "Computer31", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8585), "192.168.1.73", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("4d240edd-bf78-46ab-a3b2-9c0ab98e8275"), "Computer24", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8531), "192.168.1.34", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("5e20ec0a-1213-4109-ae8e-2f504b92d36c"), "Computer7", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8396), "192.168.1.27", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("60ccfcb7-df3a-4911-b9b1-0fe7da0fa23f"), "Computer44", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8647), "192.168.1.7", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null, null },
                    { new Guid("65f9bf5d-6cb4-431d-8167-64505b8d303f"), "Computer13", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8443), "192.168.1.75", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null, null },
                    { new Guid("6d647062-8b1c-4876-a127-780249427e43"), "Computer60", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8729), "192.168.1.51", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null, null },
                    { new Guid("71ec7f3b-80a6-4378-a21f-64c3141e4da7"), "Computer37", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8615), "192.168.1.41", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null, null },
                    { new Guid("733d5e14-1fa1-4765-8e52-ec6bba6de047"), "Computer20", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8511), "192.168.1.98", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null, null },
                    { new Guid("74f0785b-9182-417a-a203-89e70917bf0b"), "Computer58", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8720), "192.168.1.72", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null, null },
                    { new Guid("87834993-ada0-421e-90a4-de55cbd4ac30"), "Computer19", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8507), "192.168.1.90", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null, null },
                    { new Guid("88b7dde4-5ac7-479c-b8bd-302367048537"), "Computer42", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8638), "192.168.1.27", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null, null },
                    { new Guid("898baa78-8059-415d-bbda-d20a9e293662"), "Computer18", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8502), "192.168.1.18", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null, null },
                    { new Guid("8b0c0979-c3d5-47d7-9401-75254adcc72b"), "Computer51", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8680), "192.168.1.61", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null, null },
                    { new Guid("8c2d1b36-4a86-4a0e-8f3c-21994ec420c6"), "Computer48", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8666), "192.168.1.76", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null, null },
                    { new Guid("92549c4c-6017-439f-b32e-89a83e500b53"), "Computer38", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8620), "192.168.1.5", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null, null },
                    { new Guid("94fc2286-98f4-4a58-92f5-60549ff529fc"), "Computer29", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8575), "192.168.1.32", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null, null },
                    { new Guid("957d6014-f67f-476f-9d20-ac5cd068a39b"), "Computer10", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8422), "192.168.1.10", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null, null },
                    { new Guid("96d6fa41-8814-4cd2-8a92-4ab9640d3112"), "Computer53", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8691), "192.168.1.63", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null, null },
                    { new Guid("9b3ff10f-d799-49cb-979f-3addf79dfdc0"), "Computer12", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8431), "192.168.1.32", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null, null },
                    { new Guid("9c7054c5-e457-44ce-9d74-81899adff507"), "Computer59", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8724), "192.168.1.1", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null, null },
                    { new Guid("a48a6990-b003-4f9f-857b-14c73afc54ee"), "Computer36", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8609), "192.168.1.65", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null, null },
                    { new Guid("a77fdf0a-2b66-4c37-877e-e346e14d8f25"), "Computer6", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8391), "192.168.1.52", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null, null },
                    { new Guid("a8328881-ce36-486e-8a7b-91831744429c"), "Computer27", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8555), "192.168.1.7", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null, null },
                    { new Guid("a9461a28-d2a8-4f5e-9af6-1ba20004beed"), "Computer49", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8671), "192.168.1.47", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null, null },
                    { new Guid("aba72f97-9f8c-4744-aeb2-102f619d0c9d"), "Computer25", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8537), "192.168.1.53", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null, null },
                    { new Guid("baeb758e-0283-4045-876d-09afffa44af7"), "Computer28", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8560), "192.168.1.94", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null, null },
                    { new Guid("c826a08a-77a8-400a-9243-50a0c232138e"), "Computer21", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8517), "192.168.1.47", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null, null },
                    { new Guid("ca0cd949-1478-4332-bfec-25ea07f50967"), "Computer40", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8629), "192.168.1.28", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("d2a01625-8388-4a13-9488-205df1ebfa92"), "Computer15", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8453), "192.168.1.68", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null, null },
                    { new Guid("d3986571-7f75-4592-ac00-db65e0ccbbf3"), "Computer35", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8604), "192.168.1.57", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("d4d79bf8-5b7b-4458-9ae2-a868296533bb"), "Computer50", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8676), "192.168.1.16", null, null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null, null },
                    { new Guid("d88cbbe0-44cf-49ad-a1c5-935d9be0fa63"), "Computer47", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8662), "192.168.1.19", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null, null },
                    { new Guid("d9af344d-8bd3-4469-b143-31b7b09b26be"), "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8367), "192.168.1.30", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null, null },
                    { new Guid("dc2394ac-1450-4967-9720-e37e8d707250"), "Computer30", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8580), "192.168.1.60", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null, null },
                    { new Guid("de8fb63b-6ef9-4e89-a48b-255f55721519"), "Computer16", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8490), "192.168.1.97", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null, null },
                    { new Guid("dff9d96f-77e4-48ed-9551-ed39536244c8"), "Computer14", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8448), "192.168.1.93", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null, null },
                    { new Guid("e17a8488-295c-473a-9ec4-7553d8e8fe46"), "Computer26", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8542), "192.168.1.62", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null, null },
                    { new Guid("e64009c6-9403-4fea-a3be-54049187f8cc"), "Computer9", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8407), "192.168.1.47", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null, null },
                    { new Guid("ec03019e-8602-42f9-b974-12bf2b8c3171"), "Computer23", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8526), "192.168.1.72", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null, null },
                    { new Guid("f1dfe90b-4aee-4f38-8bc9-3cc95be8b028"), "Computer22", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8522), "192.168.1.95", null, null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null, null },
                    { new Guid("f25a90af-ff83-4467-8fd3-225cfceeeb7d"), "Computer34", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8600), "192.168.1.78", null, null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null, null },
                    { new Guid("fcb57f19-4b85-411a-9983-4f819b5e1da7"), "Computer8", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8400), "192.168.1.82", null, null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null, null },
                    { new Guid("ffa82055-4b9c-4f91-b946-a0bb3f003017"), "Computer41", new DateTime(2024, 3, 5, 20, 48, 58, 157, DateTimeKind.Utc).AddTicks(8633), "192.168.1.82", null, null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("00a56ca4-9ef2-4ded-9dd1-f243221ae5bf"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer32", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(267), "192.168.1.96", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("02a44490-f50f-4dad-ab12-059f9c6869a6"), new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer20", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(187), "192.168.1.52", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("0b98aa1c-a2f1-4f6f-9754-4e826efc94da"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer4", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(74), "192.168.1.71", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("1eab1b52-07df-43b8-8b41-634b3dc4624a"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer9", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(106), "192.168.1.93", null, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("254c2d01-8b8a-48ca-824d-9912d77165f5"), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer6", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(88), "192.168.1.43", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("25bdd841-ad32-44a2-819e-35b6952b2c3c"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer23", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(206), "192.168.1.71", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("41e6fefe-4b68-4cce-9aeb-440146c1890c"), new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer7", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(93), "192.168.1.11", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("45f1658c-f2fa-49ab-a632-4fde951294f6"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer13", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(139), "192.168.1.31", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("485801b3-2067-4c1c-9732-75baa8a28866"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer31", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(260), "192.168.1.65", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null },
                    { new Guid("51ffcec4-dc3c-4476-b401-34995c3c1719"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer19", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(181), "192.168.1.67", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null, null },
                    { new Guid("5cf20ce6-1873-411f-80fd-cf6f9150d4d0"), new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer2", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(61), "192.168.1.91", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null, null },
                    { new Guid("670abe11-9aaf-40e3-b0bf-ed6c33af1ac3"), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer11", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(128), "192.168.1.10", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("6a3210bc-02c6-4ce3-b52f-8d0e53a7c0d6"), new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer25", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(218), "192.168.1.88", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null, null },
                    { new Guid("71d1af01-38bf-4ee0-bdb5-9751bfcad054"), new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer14", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(146), "192.168.1.90", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("8477efa4-b963-47ed-b4df-280b8d13e08c"), new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer8", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(98), "192.168.1.87", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("8a60e68f-be9e-47bf-b853-df419b748d3e"), new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer26", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(224), "192.168.1.68", null, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null, null },
                    { new Guid("8bccdb05-92a5-451e-a5ee-d6ea3ec52413"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer16", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(157), "192.168.1.40", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null, null },
                    { new Guid("8ce75a89-00fa-4f60-9731-983b5d08d13c"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer21", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(193), "192.168.1.87", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("90b07073-08bb-4820-80e5-6b7b48ded03f"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer15", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(152), "192.168.1.27", null, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("a54d4468-7c15-4fcc-9a1e-98e2f4da99ab"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer10", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(121), "192.168.1.66", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("a7ccbf69-3dd7-47c0-9440-66312beae740"), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer3", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(66), "192.168.1.60", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null, null },
                    { new Guid("ad82a2e1-8923-481c-b492-822d96ac9a07"), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer29", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(245), "192.168.1.8", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("b539b4d5-0690-4e92-a925-852c9f9e7339"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer0", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(38), "192.168.1.69", null, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null, null },
                    { new Guid("ba9a6200-e555-4eb2-82c6-ac13bd4c86b4"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer12", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(133), "192.168.1.35", null, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("c088d4af-4358-4432-bd1c-c0c1534bf833"), new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer30", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(252), "192.168.1.73", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null, null },
                    { new Guid("c6a3a69f-977f-45ef-bbf9-1f2c33441671"), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer28", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(235), "192.168.1.27", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null, null },
                    { new Guid("ceed9874-c691-4431-85f0-525e505c371f"), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer22", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(200), "192.168.1.86", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null, null },
                    { new Guid("d10474ca-c942-436c-b675-ed99aba01ab4"), new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer27", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(230), "192.168.1.80", null, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null, null },
                    { new Guid("d12efe01-c52a-4f1a-869d-ace9864371b5"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer24", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(211), "192.168.1.17", null, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null, null },
                    { new Guid("d4f5df98-02e9-46b7-8060-941ef0537320"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer17", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(165), "192.168.1.35", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null, null },
                    { new Guid("e037e58e-b0aa-4a2e-9864-64e652de256c"), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(55), "192.168.1.5", null, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null, null },
                    { new Guid("e8b7c3c6-a784-477f-95d6-39783deba822"), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer18", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(171), "192.168.1.4", null, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null, null },
                    { new Guid("fe447659-3830-48f6-9f4c-2357af5a61ba"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer5", new DateTime(2024, 3, 5, 20, 48, 58, 158, DateTimeKind.Utc).AddTicks(80), "192.168.1.89", null, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null, null }
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
                    { new Guid("6ce8f4ca-b4aa-4d2b-9cf8-3715cebe0bf2"), "Computer0", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(3403), "192.168.1.34", null, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null, null },
                    { new Guid("7938194a-3a93-4dbb-a319-6693d950e17a"), "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(3442), "192.168.1.44", null, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "TeacherSchedules",
                columns: new[] { "Id", "Classroom", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CreatedUser", "DateTime", "Day", "TeacherId", "TimeSlot", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("0b3eeaee-2b33-4d2a-bfb3-a601250163d1"), "2-B", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1018), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("152c44a8-fb06-4f84-826b-aad662e4e13b"), "2-B", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1053), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)4, null, null, null, null },
                    { new Guid("22c20997-993b-4ab1-bdfc-947b80ecf9e4"), "", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1060), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("29cf3e81-8beb-448b-948a-ba09a37d4ab0"), "4-C", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1063), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("3c57a195-6025-40d1-a871-b95a9e510c86"), "1-A", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1047), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null },
                    { new Guid("3e8ef9c6-615a-4ae5-b18b-f73aa669d367"), "1-A", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1044), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("4cbdf917-35bf-480d-8d29-2b3936f4234d"), "2-B", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1050), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null },
                    { new Guid("553819af-3074-43ef-847c-8c5c554013d2"), "1-A", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1011), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)2, null, null, null, null },
                    { new Guid("6f1de646-0057-4f24-9bf1-fc4c7c52f0ba"), "1-A", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1002), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)1, null, null, null, null },
                    { new Guid("901e651b-e6a0-49b4-b998-e7dbd2a916c5"), "2-B", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1014), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)3, null, null, null, null },
                    { new Guid("95b52fb1-dbfd-4999-861a-ec8a2ab43541"), "", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1037), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)7, null, null, null, null },
                    { new Guid("9f02feb0-e17d-4af2-ab72-8f83b17cdad1"), "", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1040), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null },
                    { new Guid("acf33ee7-a193-41d2-9044-166bfddd9b82"), "3-D", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1034), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)6, null, null, null, null },
                    { new Guid("d50f3f05-6a13-4a21-b12a-f0a2c59afd6b"), "", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1056), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("e380b4a4-9451-46db-965a-f89b525b9623"), "3-D", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1021), "192.168.1.1", null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)5, null, null, null, null },
                    { new Guid("f0188721-472a-4198-89db-dd79bacac6de"), "4-C", "Computer1", new DateTime(2024, 3, 5, 20, 48, 58, 159, DateTimeKind.Utc).AddTicks(1066), "192.168.1.1", null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"), (byte)8, null, null, null, null }
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
                name: "IX_Announcements_SenderId",
                table: "Announcements",
                column: "SenderId");

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
                name: "Administrators");

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
