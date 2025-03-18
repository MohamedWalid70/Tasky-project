using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManagementSystem.Migrations
{
    public partial class populateCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories " +
                "VALUES ('Research'),('Writing'),('Meeting'),('Administrative')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Categories");
        }
    }
}
