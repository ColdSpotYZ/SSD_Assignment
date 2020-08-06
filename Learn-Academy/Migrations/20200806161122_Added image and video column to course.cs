using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn_Academy.Migrations
{
    public partial class Addedimageandvideocolumntocourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "video",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "video",
                table: "Course");
        }
    }
}
