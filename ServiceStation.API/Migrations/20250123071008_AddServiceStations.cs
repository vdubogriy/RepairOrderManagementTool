using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceStation.API.Migrations
{
    public partial class AddServiceStations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into carservicestations (Name, TaxNumber) values ('Car Service Station 1', '123456789')");
            migrationBuilder.Sql("insert into carservicestations (Name, TaxNumber) values ('Car Service Station 2', '987654321')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
