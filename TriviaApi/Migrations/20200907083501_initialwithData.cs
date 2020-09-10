using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriviaApi.Migrations
{
    public partial class initialwithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trivias",
                columns: new[] { "Id", "Answers", "Category", "Difficulty", "Questions" },
                values: new object[,]
                {
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95a"), "Brown", 6, 0, "What is the rarest M&M color?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95b"), "World Wide Web", 6, 0, "In a website browser address bar, what does “www” stand for?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95c"), "1987", 2, 1, "In what year were the first Air Jordan sneakers released?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95d"), "21", 2, 1, " In a game of bingo, which number is represented by the phrase “two little ducks”?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95a"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95b"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95c"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95d"));
        }
    }
}
