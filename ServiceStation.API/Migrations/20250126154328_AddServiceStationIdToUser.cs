using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceStation.API.Migrations
{
    public partial class AddServiceStationIdToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarServiceStationId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CarServiceStationId",
                table: "Users",
                column: "CarServiceStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_CarServiceStations_CarServiceStationId",
                table: "Users",
                column: "CarServiceStationId",
                principalTable: "CarServiceStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_CarServiceStations_CarServiceStationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CarServiceStationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CarServiceStationId",
                table: "Users");
        }
    }
}
