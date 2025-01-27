using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceStation.API.Migrations
{
    public partial class AddServiceStationUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into users (email, passwordhash, carservicestationid) values('test@service1.ru', '$2b$10$XoyAzpmpzgZf8JhhajE7xu4c5uTBlDepDbzEKMVIh1M06wyGOw.wS', 1);");
            migrationBuilder.Sql("insert into users (email, passwordhash, carservicestationid) values('test@service2.ru', '$2b$10$Vn9KCizfKHykmJ8S8CwbruHgz7XeYnWDBnmrbeIgknWCNQTZsNhfS', 2);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
