using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticApp.Migrations.LogisticDbContextV3Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Vehicle_VehicleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_VehicleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "DriverId",
                table: "Vehicle",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VehicleLocation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Location_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hour = table.Column<TimeSpan>(type: "time", nullable: false),
                    DriverId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleLocation_AspNetUsers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_DriverId",
                table: "Vehicle",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLocation_DriverId",
                table: "VehicleLocation",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_AspNetUsers_DriverId",
                table: "Vehicle",
                column: "DriverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_AspNetUsers_DriverId",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehicleLocation");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_DriverId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Vehicle");

            migrationBuilder.AddColumn<string>(
                name: "VehicleId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VehicleId",
                table: "AspNetUsers",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Vehicle_VehicleId",
                table: "AspNetUsers",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
