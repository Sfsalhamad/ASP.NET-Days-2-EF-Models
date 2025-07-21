using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class DoctorProrties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "specilaty",
                table: "Doctors",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "id", "name", "specilaty" },
                values: new object[,]
                {
                    { 1, "Dr. Smith", "Cardiology" },
                    { 2, "Dr. Jones", "Neurology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "specilaty",
                table: "Doctors");
        }
    }
}
