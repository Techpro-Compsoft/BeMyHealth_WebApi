using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeMyHealth_WebApi.Migrations
{
    public partial class editSubcriptionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "CustomSubscriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CustomSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CustomSubscriptions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Duration",
                table: "CustomSubscriptions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
