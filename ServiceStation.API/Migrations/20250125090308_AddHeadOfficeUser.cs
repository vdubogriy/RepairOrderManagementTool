using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceStation.API.Migrations
{
    public partial class AddHeadOfficeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into users (email, passwordhash) values ('test@headoffice.ru', '$2b$10$Ee.NJeDBAwLh8BcdwSD3HuXVwoIjlw2BDjKVkxIUNNSTLOhvzxxui');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
