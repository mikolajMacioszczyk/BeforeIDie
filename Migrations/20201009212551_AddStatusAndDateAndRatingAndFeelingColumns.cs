using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeforeIDie.Migrations
{
    public partial class AddStatusAndDateAndRatingAndFeelingColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRealization",
                table: "GoalItems",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Feelings",
                table: "GoalItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "GoalItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "GoalItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfRealization",
                table: "GoalItems");

            migrationBuilder.DropColumn(
                name: "Feelings",
                table: "GoalItems");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "GoalItems");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "GoalItems");
        }
    }
}
