using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriviaApi.Migrations
{
    public partial class firstdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95c"),
                column: "Difficulty",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95d"),
                columns: new[] { "Category", "Difficulty", "Questions" },
                values: new object[] { 6, 0, " In a game of bingo, which number is represented by the phrase \"two little duck\"?" });

            migrationBuilder.InsertData(
                table: "Trivias",
                columns: new[] { "Id", "Answers", "Category", "Difficulty", "Questions" },
                values: new object[,]
                {
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98d"), "Volcanos", 3, 0, "Fissures, vents and plugs are all associated with which geological feature?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98c"), "A.A.Milne", 0, 0, "Which author wrote the ‘Winnie-the-Pooh’ books?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98b"), "Vermeer", 6, 0, "Which Dutch artist painted “Girl with a Pearl Earring”?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98a"), "Forx Knox", 6, 0, "Where were the Declaration of Independence, the Constitution, and the Bill of Rights stored during World War II?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b99b"), "Switzerland", 6, 0, "Which country consumes the most chocolate per capita?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97f"), "Arizona and Hawaii", 6, 0, "Which two U.S. states don’t observe Daylight Saving Time?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97e"), "Sperm Whale", 6, 0, "What is the loudest animal on Earth?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97d"), "Mr.Potato Head", 6, 0, "What was the first toy to be advertised on television?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97c"), "Aglet", 6, 0, "What is the tiny piece at the end of a shoelace called?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97b"), "Boxing Day", 4, 0, "In the United Kingdom, what is the day after Christmas known as?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b99a"), "Great Dane", 6, 0, "What is the tallest breed of dog in the world?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96f"), "Dakota Building", 2, 0, "Outside which New York building was John Lennon killed?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96e"), "Gwen Stafani", 4, 0, "Kingston, Zuma, and Apollo are the sons of which American female pop star ?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96d"), "The Platypus", 3, 0, "The only known monotremes in the animal kingdom are the echidna and which other creature?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96c"), "Lady Gaga", 4, 0, "Which singer’s real name is Stefani Joanne Angelina Germanotta?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96b"), "Paris", 6, 0, "In which European city would you find Orly airport?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96a"), "The Australian Open", 6, 0, "Tennis star Serena Williams won which major tournament while pregnant with her first child?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b99c"), "Ethopia", 6, 0, "Which African country was formerly known as Abyssinia?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95f"), "They won the popular vote, but lost the electoral-college vote", 2, 0, "Samuel Tilden, Grover Cleveland, Al Gore and Hillary Clinton share what distinction among U.S. presidential candidates?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97a"), "Hamlet", 6, 0, "Which of Shakespeare’s plays is the longest?" },
                    { new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95e"), "Pandora", 2, 1, "According to Greek mythology who was the first woman on earth?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95e"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95f"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96a"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96b"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96c"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96d"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96e"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b96f"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97a"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97b"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97c"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97d"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97e"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b97f"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98a"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98b"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98c"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b98d"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b99a"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b99b"));

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b99c"));

            migrationBuilder.UpdateData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95c"),
                column: "Difficulty",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95d"),
                columns: new[] { "Category", "Difficulty", "Questions" },
                values: new object[] { 2, 1, " In a game of bingo, which number is represented by the phrase “two little ducks”?" });
        }
    }
}
