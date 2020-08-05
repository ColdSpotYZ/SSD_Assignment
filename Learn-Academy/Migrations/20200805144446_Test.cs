using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn_Academy.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membership_AspNetUsers_ApplicationUserId",
                table: "Membership");

            migrationBuilder.DropIndex(
                name: "IX_Membership_ApplicationUserId",
                table: "Membership");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Membership",
                newName: "NormalizedName");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Testimonials",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Testimonials",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Membership",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Membership",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Membership",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Membership",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Membership_Id",
                table: "Membership",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_AspNetUsers_Id",
                table: "Membership",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membership_AspNetUsers_Id",
                table: "Membership");

            migrationBuilder.DropIndex(
                name: "IX_Membership_Id",
                table: "Membership");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Membership");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Membership");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Membership");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "Membership",
                newName: "ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Testimonials",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Testimonials",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Membership",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Membership_ApplicationUserId",
                table: "Membership",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_AspNetUsers_ApplicationUserId",
                table: "Membership",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
