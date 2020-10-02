using Microsoft.EntityFrameworkCore.Migrations;

namespace testprojectaspnetcre3_1.Data.Migrations
{
    public partial class Add_Customer_fild_to_aspnetuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerFafily",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerFafily",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "AspNetUsers");
        }
    }
}
