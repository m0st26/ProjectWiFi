using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementOrganizations.WebService.Migrations
{
    public partial class PWInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkWiFis",
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
                    table.PrimaryKey("PK_ParkWiFis", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkWiFis",
                columns: new[] { "Id", "Name", "ParkName", "status", "wifiName" },
                values: new object[] { 1L, "Точка доступа №337", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", "действует", "Moscow_WiFi_Free" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkWiFis");
        }
    }
}
