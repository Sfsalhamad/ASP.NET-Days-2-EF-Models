using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class Appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorId = table.Column<int>(type: "int", nullable: false),
                    patientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Appointment_Doctors_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_doctorId",
                table: "Appointment",
                column: "doctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");
        }
    }
}
