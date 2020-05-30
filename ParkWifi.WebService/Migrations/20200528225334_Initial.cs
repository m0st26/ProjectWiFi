using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkWifi.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkWifis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    status = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParkName = table.Column<string>(nullable: true),
                    wifiName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkWifis", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkWifis",
                columns: new[] { "Id", "Name", "ParkName", "status", "wifiName" },
                values: new object[] { 1L, "Точка доступа №337", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", "действует", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifis",
                columns: new[] { "Id", "Name", "ParkName", "status", "wifiName" },
                values: new object[] { 2L, "Точка доступа №338", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", "действует", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifis",
                columns: new[] { "Id", "Name", "ParkName", "status", "wifiName" },
                values: new object[] { 3L, "Точка доступа №339", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", "действует", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifis",
                columns: new[] { "Id", "Name", "ParkName", "status", "wifiName" },
                values: new object[] { 4L, "Точка доступа №340", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", "действует", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifis",
                columns: new[] { "Id", "Name", "ParkName", "status", "wifiName" },
                values: new object[] { 5L, "Точка доступа №267", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "действует", "Moscow_WiFi_Free" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkWifis");
        }
    }
}
