using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn_Academy.Migrations
{
    public partial class Membershipmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    PurchaseId = table.Column<string>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Plan = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_Membership_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Membership_ApplicationUserId",
                table: "Membership",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membership");
        }
    }
}
