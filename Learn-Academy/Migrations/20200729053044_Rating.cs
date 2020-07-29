using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn_Academy.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Course",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CourseRating",
                table: "Course",
                type: "decimal(3, 2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseRating",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Course");
        }
    }
}
