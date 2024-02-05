using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolAutomationProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Achievements_StudentId",
                table: "Achievements");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Achievements",
                newName: "Type");

            migrationBuilder.AddColumn<bool>(
                name: "IsPreRegistered",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalAbsenceCount",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "Capacity",
                table: "Classrooms",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_StudentId",
                table: "Achievements",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Achievements_StudentId",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "IsPreRegistered",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TotalAbsenceCount",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Classrooms");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Achievements",
                newName: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_StudentId",
                table: "Achievements",
                column: "StudentId",
                unique: true);
        }
    }
}
