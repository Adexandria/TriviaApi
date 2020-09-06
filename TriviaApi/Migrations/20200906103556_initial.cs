using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriviaApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trivias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Questions = table.Column<string>(nullable: true),
                    Answers = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trivias", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trivias");
        }
    }
}
