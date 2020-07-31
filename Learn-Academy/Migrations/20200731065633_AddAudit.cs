using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Learn_Academy.Migrations
{
    public partial class AddAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CourseRating",
                table: "Course",
                type: "decimal(3, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(1, 2)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AuditRecords",
                columns: table => new
                {
                    Audit_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuditActionType = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    DateTimeStamp = table.Column<DateTime>(nullable: false),
                    KeyCourseFieldID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRecords", x => x.Audit_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditRecords");

            migrationBuilder.AlterColumn<decimal>(
                name: "CourseRating",
                table: "Course",
                type: "decimal(1, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3, 2)",
                oldNullable: true);
        }
    }
}
