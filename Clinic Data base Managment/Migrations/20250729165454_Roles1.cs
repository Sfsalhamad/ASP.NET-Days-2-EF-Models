using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_Data_base_Managment.Migrations
{
    /// <inheritdoc />
    public partial class Roles1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 1,
                column: "appointmentDate",
                value: new DateTime(2024, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 1,
                column: "appointmentDate",
                value: new DateTime(2025, 7, 30, 19, 45, 34, 329, DateTimeKind.Local).AddTicks(1159));
        }
    }
}
