using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkWifi.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkWifi",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FunctionFlag = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParkName = table.Column<string>(nullable: true),
                    wifiName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkWifi", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 1L, "действует", "Точка доступа №337", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 659L, "действует", "Точка доступа №768", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 660L, "действует", "Точка доступа №769", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 661L, "действует", "Точка доступа №770", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 662L, "действует", "Точка доступа №771", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 663L, "действует", "Точка доступа №772", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 664L, "действует", "Точка доступа №773", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 665L, "действует", "Точка доступа №774", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 666L, "действует", "Точка доступа №775", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 667L, "действует", "Точка доступа №776", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 668L, "действует", "Точка доступа №777", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 669L, "действует", "Точка доступа №778", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 670L, "действует", "Точка доступа №779", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 671L, "действует", "Точка доступа №780", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 672L, "действует", "Точка доступа №781", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 673L, "действует", "Точка доступа №782", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 674L, "действует", "Точка доступа №783", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 675L, "действует", "Точка доступа №784", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 676L, "действует", "Точка доступа №785", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 677L, "действует", "Точка доступа №786", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 678L, "действует", "Точка доступа №787", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 679L, "действует", "Точка доступа №788", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 680L, "действует", "Точка доступа №789", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 681L, "действует", "Точка доступа №790", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 682L, "действует", "Точка доступа №791", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 683L, "действует", "Точка доступа №792", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 684L, "действует", "Точка доступа №793", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 685L, "действует", "Точка доступа №794", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 658L, "действует", "Точка доступа №767", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 686L, "действует", "Точка доступа №795", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 657L, "действует", "Точка доступа №766", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 655L, "действует", "Точка доступа №692", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 628L, "действует", "Точка доступа №665", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 629L, "действует", "Точка доступа №666", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 630L, "действует", "Точка доступа №667", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 631L, "действует", "Точка доступа №668", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 632L, "действует", "Точка доступа №669", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 633L, "действует", "Точка доступа №670", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 634L, "действует", "Точка доступа №671", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 635L, "действует", "Точка доступа №672", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 636L, "действует", "Точка доступа №673", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 637L, "действует", "Точка доступа №674", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 638L, "действует", "Точка доступа №675", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 639L, "действует", "Точка доступа №676", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 640L, "действует", "Точка доступа №677", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 641L, "действует", "Точка доступа №678", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 642L, "действует", "Точка доступа №679", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 643L, "действует", "Точка доступа №680", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 644L, "действует", "Точка доступа №681", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 645L, "действует", "Точка доступа №682", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 646L, "действует", "Точка доступа №683", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 647L, "действует", "Точка доступа №684", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 648L, "действует", "Точка доступа №685", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 649L, "действует", "Точка доступа №686", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 650L, "действует", "Точка доступа №687", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 651L, "действует", "Точка доступа №688", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 652L, "действует", "Точка доступа №689", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 653L, "действует", "Точка доступа №690", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 654L, "действует", "Точка доступа №691", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 656L, "действует", "Точка доступа №824", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 687L, "действует", "Точка доступа №796", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 688L, "действует", "Точка доступа №797", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 689L, "действует", "Точка доступа №798", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 722L, "действует", "Точка доступа №734", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 723L, "действует", "Точка доступа №735", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 724L, "действует", "Точка доступа №736", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 725L, "действует", "Точка доступа №737", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 726L, "действует", "Точка доступа №738", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 727L, "действует", "Точка доступа №739", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 728L, "действует", "Точка доступа №740", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 729L, "действует", "Точка доступа №741", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 730L, "действует", "Точка доступа №742", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 731L, "действует", "Точка доступа №743", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 732L, "действует", "Точка доступа №744", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 733L, "действует", "Точка доступа №745", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 734L, "действует", "Точка доступа №746", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 735L, "действует", "Точка доступа №747", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 736L, "действует", "Точка доступа №748", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 737L, "действует", "Точка доступа №749", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 738L, "действует", "Точка доступа №750", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 739L, "действует", "Точка доступа №751", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 740L, "действует", "Точка доступа №752", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 741L, "действует", "Точка доступа №696", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 742L, "действует", "Точка доступа №697", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 743L, "действует", "Точка доступа №698", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 744L, "действует", "Точка доступа №699", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 745L, "действует", "Точка доступа №700", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 746L, "действует", "Точка доступа №701", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 747L, "действует", "Точка доступа №702", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 748L, "действует", "Точка доступа №703", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 721L, "действует", "Точка доступа №733", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 720L, "действует", "Точка доступа №732", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 719L, "действует", "Точка доступа №731", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 718L, "действует", "Точка доступа №730", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 690L, "действует", "Точка доступа №799", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 691L, "действует", "Точка доступа №800", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 692L, "действует", "Точка доступа №801", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 693L, "действует", "Точка доступа №802", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 694L, "действует", "Точка доступа №803", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 695L, "действует", "Точка доступа №804", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 696L, "действует", "Точка доступа №805", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 697L, "действует", "Точка доступа №806", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 698L, "действует", "Точка доступа №807", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 699L, "действует", "Точка доступа №808", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 700L, "действует", "Точка доступа №809", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 701L, "действует", "Точка доступа №810", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 702L, "действует", "Точка доступа №811", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 627L, "действует", "Точка доступа №664", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 703L, "действует", "Точка доступа №812", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 705L, "действует", "Точка доступа №814", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 706L, "действует", "Точка доступа №815", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 707L, "действует", "Точка доступа №816", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 708L, "действует", "Точка доступа №817", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 709L, "действует", "Точка доступа №818", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 710L, "действует", "Точка доступа №819", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 711L, "действует", "Точка доступа №820", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 712L, "действует", "Точка доступа №821", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 713L, "действует", "Точка доступа №822", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 714L, "действует", "Точка доступа №823", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 715L, "действует", "Точка доступа №727", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 716L, "действует", "Точка доступа №728", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 717L, "действует", "Точка доступа №729", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 704L, "действует", "Точка доступа №813", "Государственное бюджетное учреждение города Москвы «Молодежный центр «Сетуньский Стан»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 749L, "действует", "Точка доступа №704", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 626L, "действует", "Точка доступа №663", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 624L, "действует", "Точка доступа №661", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 534L, "действует", "Точка доступа №534", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 535L, "действует", "Точка доступа №535", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 536L, "действует", "Точка доступа №536", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 537L, "действует", "Точка доступа №537", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 538L, "действует", "Точка доступа №538", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 539L, "действует", "Точка доступа №539", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 540L, "действует", "Точка доступа №540", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 541L, "действует", "Точка доступа №541", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 542L, "действует", "Точка доступа №542", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 543L, "действует", "Точка доступа №543", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 544L, "действует", "Точка доступа №544", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 545L, "действует", "Точка доступа №545", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 546L, "действует", "Точка доступа №546", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 547L, "действует", "Точка доступа №547", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 548L, "действует", "Точка доступа №548", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 549L, "действует", "Точка доступа №549", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 550L, "действует", "Точка доступа №550", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 551L, "действует", "Точка доступа №551", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 552L, "действует", "Точка доступа №552", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 553L, "действует", "Точка доступа №553", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 554L, "действует", "Точка доступа №554", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 555L, "действует", "Точка доступа №555", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 556L, "действует", "Точка доступа №556", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 557L, "действует", "Точка доступа №557", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 558L, "действует", "Точка доступа №558", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 559L, "действует", "Точка доступа №559", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 560L, "действует", "Точка доступа №560", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 533L, "действует", "Точка доступа №533", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 561L, "действует", "Точка доступа №561", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 532L, "действует", "Точка доступа №532", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 530L, "действует", "Точка доступа №530", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 503L, "действует", "Точка доступа №503", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 504L, "действует", "Точка доступа №504", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 505L, "действует", "Точка доступа №505", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 506L, "действует", "Точка доступа №506", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 507L, "действует", "Точка доступа №507", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 508L, "действует", "Точка доступа №508", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 509L, "действует", "Точка доступа №509", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 510L, "действует", "Точка доступа №510", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 511L, "действует", "Точка доступа №511", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 512L, "действует", "Точка доступа №512", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 513L, "действует", "Точка доступа №513", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 514L, "действует", "Точка доступа №514", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 515L, "действует", "Точка доступа №515", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 516L, "действует", "Точка доступа №516", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 517L, "действует", "Точка доступа №517", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 518L, "действует", "Точка доступа №518", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 519L, "действует", "Точка доступа №519", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 520L, "действует", "Точка доступа №520", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 521L, "действует", "Точка доступа №521", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 522L, "действует", "Точка доступа №522", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 523L, "действует", "Точка доступа №523", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 524L, "действует", "Точка доступа №524", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 525L, "действует", "Точка доступа №525", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 526L, "действует", "Точка доступа №526", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 527L, "действует", "Точка доступа №527", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 528L, "действует", "Точка доступа №528", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 529L, "действует", "Точка доступа №529", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 531L, "действует", "Точка доступа №531", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 562L, "действует", "Точка доступа №563", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 563L, "действует", "Точка доступа №564", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 564L, "действует", "Точка доступа №565", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 597L, "действует", "Точка доступа №598", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 598L, "действует", "Точка доступа №605", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 599L, "действует", "Точка доступа №606", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 600L, "действует", "Точка доступа №607", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 601L, "действует", "Точка доступа №608", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 602L, "действует", "Точка доступа №609", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 603L, "действует", "Точка доступа №610", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 604L, "действует", "Точка доступа №611", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 605L, "действует", "Точка доступа №612", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 606L, "действует", "Точка доступа №613", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 607L, "действует", "Точка доступа №614", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 608L, "действует", "Точка доступа №615", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 609L, "действует", "Точка доступа №616", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 610L, "действует", "Точка доступа №617", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 611L, "действует", "Точка доступа №618", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 612L, "действует", "Точка доступа №619", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 613L, "действует", "Точка доступа №620", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 614L, "действует", "Точка доступа №599", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 615L, "действует", "Точка доступа №600", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 616L, "действует", "Точка доступа №601", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 617L, "действует", "Точка доступа №602", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 618L, "действует", "Точка доступа №603", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 619L, "действует", "Точка доступа №604", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 620L, "действует", "Точка доступа №562", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 621L, "действует", "Точка доступа №693", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 622L, "действует", "Точка доступа №694", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 623L, "действует", "Точка доступа №695", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 596L, "действует", "Точка доступа №597", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 595L, "действует", "Точка доступа №596", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 594L, "действует", "Точка доступа №595", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 593L, "действует", "Точка доступа №594", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 565L, "действует", "Точка доступа №566", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 566L, "действует", "Точка доступа №567", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 567L, "действует", "Точка доступа №568", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 568L, "действует", "Точка доступа №569", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 569L, "действует", "Точка доступа №570", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 570L, "действует", "Точка доступа №571", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 571L, "действует", "Точка доступа №572", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 572L, "действует", "Точка доступа №573", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 573L, "действует", "Точка доступа №574", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 574L, "действует", "Точка доступа №575", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 575L, "действует", "Точка доступа №576", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 576L, "действует", "Точка доступа №577", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 577L, "действует", "Точка доступа №578", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 625L, "действует", "Точка доступа №662", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 578L, "действует", "Точка доступа №579", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 580L, "действует", "Точка доступа №581", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 581L, "действует", "Точка доступа №582", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 582L, "действует", "Точка доступа №583", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 583L, "действует", "Точка доступа №584", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 584L, "действует", "Точка доступа №585", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 585L, "действует", "Точка доступа №586", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 586L, "действует", "Точка доступа №587", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 587L, "действует", "Точка доступа №588", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 588L, "действует", "Точка доступа №589", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 589L, "действует", "Точка доступа №590", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 590L, "действует", "Точка доступа №591", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 591L, "действует", "Точка доступа №592", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 592L, "действует", "Точка доступа №593", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Таганский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 579L, "действует", "Точка доступа №580", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 502L, "действует", "Точка доступа №502", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 750L, "действует", "Точка доступа №705", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 752L, "действует", "Точка доступа №707", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 909L, "действует", "Точка доступа №982", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 910L, "действует", "Точка доступа №983", "Государственное бюджетное учреждение культуры города Москвы «Центр социокультурных программ «Интеграция»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 911L, "действует", "Точка доступа №984", "Государственное бюджетное учреждение культуры города Москвы «Центр социокультурных программ «Интеграция»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 912L, "действует", "Точка доступа №985", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 913L, "действует", "Точка доступа №986", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 914L, "действует", "Точка доступа №987", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 915L, "действует", "Точка доступа №988", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 916L, "действует", "Точка доступа №989", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 917L, "действует", "Точка доступа №990", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 918L, "действует", "Точка доступа №991", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 919L, "действует", "Точка доступа №992", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 920L, "действует", "Точка доступа №993", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 921L, "действует", "Точка доступа №994", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 922L, "действует", "Точка доступа №995", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 923L, "действует", "Точка доступа №996", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 924L, "действует", "Точка доступа №997", "Префектура Зеленоградского административного округа города Москвы (Парк Победы)", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 925L, "действует", "Точка доступа №998", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», зона отдыха «Покровский берег»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 926L, "действует", "Точка доступа №999", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», зона отдыха «Покровский берег»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 927L, "действует", "Точка доступа №1000", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», зона отдыха «Покровский берег»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 928L, "действует", "Точка доступа №1001", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», зона отдыха «Покровский берег»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 929L, "действует", "Точка доступа №1002", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», зона отдыха «Покровский берег»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 930L, "действует", "Точка доступа №1003", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», зона отдыха «Покровский берег»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 931L, "действует", "Точка доступа №1004", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Озелененная территория между Шипиловский проездом и Каширским шоссе", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 932L, "действует", "Точка доступа №1005", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Озелененная территория между Шипиловский проездом и Каширским шоссе", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 933L, "действует", "Точка доступа №1006", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Озелененная территория между Шипиловский проездом и Каширским шоссе", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 934L, "действует", "Точка доступа №1007", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха», Парк «Северные Дубки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 935L, "действует", "Точка доступа №1008", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха», Парк «Северные Дубки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 908L, "действует", "Точка доступа №981", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 936L, "действует", "Точка доступа №1009", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха», Парк «Северные Дубки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 907L, "действует", "Точка доступа №980", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 905L, "действует", "Точка доступа №978", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 878L, "действует", "Точка доступа №951", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 879L, "действует", "Точка доступа №952", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 880L, "действует", "Точка доступа №953", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 881L, "действует", "Точка доступа №954", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 882L, "действует", "Точка доступа №955", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 883L, "действует", "Точка доступа №956", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 884L, "действует", "Точка доступа №957", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 885L, "действует", "Точка доступа №958", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 886L, "действует", "Точка доступа №959", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 887L, "действует", "Точка доступа №960", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 888L, "действует", "Точка доступа №961", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 889L, "действует", "Точка доступа №962", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 890L, "действует", "Точка доступа №963", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 891L, "действует", "Точка доступа №964", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 892L, "действует", "Точка доступа №965", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 893L, "действует", "Точка доступа №966", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 894L, "действует", "Точка доступа №967", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 895L, "действует", "Точка доступа №968", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 896L, "действует", "Точка доступа №969", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 897L, "действует", "Точка доступа №970", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 898L, "действует", "Точка доступа №971", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 899L, "действует", "Точка доступа №972", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 900L, "действует", "Точка доступа №973", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 901L, "действует", "Точка доступа №974", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 902L, "действует", "Точка доступа №975", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 903L, "действует", "Точка доступа №976", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 904L, "действует", "Точка доступа №977", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 906L, "действует", "Точка доступа №979", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 937L, "действует", "Точка доступа №1010", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха», Парк «Северные Дубки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 938L, "действует", "Точка доступа №1011", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха», Парк «Северные Дубки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 939L, "действует", "Точка доступа №1012", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха», Парк «Северные Дубки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 972L, "действует", "Точка доступа №857", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 973L, "действует", "Точка доступа №858", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 974L, "действует", "Точка доступа №859", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 975L, "действует", "Точка доступа №860", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 976L, "действует", "Точка доступа №861", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 977L, "действует", "Точка доступа №862", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 978L, "действует", "Точка доступа №863", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 979L, "действует", "Точка доступа №864", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 980L, "действует", "Точка доступа №865", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 981L, "действует", "Точка доступа №866", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 982L, "действует", "Точка доступа №867", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 983L, "действует", "Точка доступа №868", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 984L, "действует", "Точка доступа №869", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 985L, "действует", "Точка доступа №870", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 986L, "действует", "Точка доступа №871", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 987L, "действует", "Точка доступа №872", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 988L, "действует", "Точка доступа №873", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 989L, "действует", "Точка доступа №874", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 990L, "действует", "Точка доступа №875", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 991L, "действует", "Точка доступа №876", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 992L, "действует", "Точка доступа №877", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 993L, "действует", "Точка доступа №878", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 994L, "действует", "Точка доступа №879", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 995L, "действует", "Точка доступа №880", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 996L, "действует", "Точка доступа №881", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 997L, "действует", "Точка доступа №882", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 998L, "действует", "Точка доступа №883", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 971L, "действует", "Точка доступа №856", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 970L, "действует", "Точка доступа №855", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 969L, "действует", "Точка доступа №854", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 968L, "действует", "Точка доступа №853", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 940L, "действует", "Точка доступа №1013", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 941L, "действует", "Точка доступа №1014", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 942L, "действует", "Точка доступа №1015", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 943L, "действует", "Точка доступа №1016", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 944L, "действует", "Точка доступа №1017", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 945L, "действует", "Точка доступа №1018", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 946L, "действует", "Точка доступа №1019", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 947L, "действует", "Точка доступа №1020", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 948L, "действует", "Точка доступа №1021", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 949L, "действует", "Точка доступа №1022", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 950L, "действует", "Точка доступа №1023", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня», зона отдыха «Красногвардейские пруды»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 951L, "действует", "Точка доступа №1024", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», зона отдыха «Левобережье»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 952L, "действует", "Точка доступа №837", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 877L, "действует", "Точка доступа №950", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 953L, "действует", "Точка доступа №838", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 955L, "действует", "Точка доступа №840", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 956L, "действует", "Точка доступа №841", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 957L, "действует", "Точка доступа №842", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 958L, "действует", "Точка доступа №843", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 959L, "действует", "Точка доступа №844", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 960L, "действует", "Точка доступа №845", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 961L, "действует", "Точка доступа №846", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 962L, "действует", "Точка доступа №847", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 963L, "действует", "Точка доступа №848", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 964L, "действует", "Точка доступа №849", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 965L, "действует", "Точка доступа №850", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 966L, "действует", "Точка доступа №851", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 967L, "действует", "Точка доступа №852", "Государственное бюджетное учреждение культуры города Москвы «Государственный историко-архитектурный, художественный и ландшафтный музей-заповедник «Царицыно»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 954L, "действует", "Точка доступа №839", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 751L, "действует", "Точка доступа №706", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 876L, "действует", "Точка доступа №949", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 874L, "действует", "Точка доступа №947", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 784L, "действует", "Точка доступа №765", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 785L, "действует", "Точка доступа №621", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 786L, "действует", "Точка доступа №622", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 787L, "действует", "Точка доступа №623", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха Фили»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 788L, "действует", "Точка доступа №624", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 789L, "действует", "Точка доступа №625", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 790L, "действует", "Точка доступа №626", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 791L, "действует", "Точка доступа №627", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 792L, "действует", "Точка доступа №628", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 793L, "действует", "Точка доступа №629", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 794L, "действует", "Точка доступа №630", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 795L, "действует", "Точка доступа №631", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 796L, "действует", "Точка доступа №632", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 797L, "действует", "Точка доступа №633", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 798L, "действует", "Точка доступа №634", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 799L, "действует", "Точка доступа №635", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 800L, "действует", "Точка доступа №636", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 801L, "действует", "Точка доступа №637", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 802L, "действует", "Точка доступа №638", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 803L, "действует", "Точка доступа №639", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 804L, "действует", "Точка доступа №640", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 805L, "действует", "Точка доступа №641", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 806L, "действует", "Точка доступа №642", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 807L, "действует", "Точка доступа №643", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 808L, "действует", "Точка доступа №644", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 809L, "действует", "Точка доступа №645", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 810L, "действует", "Точка доступа №646", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 783L, "действует", "Точка доступа №764", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 811L, "действует", "Точка доступа №647", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 782L, "действует", "Точка доступа №763", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 780L, "действует", "Точка доступа №761", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 753L, "действует", "Точка доступа №708", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 754L, "действует", "Точка доступа №709", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 755L, "действует", "Точка доступа №710", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 756L, "действует", "Точка доступа №711", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 757L, "действует", "Точка доступа №712", "Государственное автономное учреждение культуры города Москвы «Поклонная гора»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 758L, "действует", "Точка доступа №713", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 759L, "действует", "Точка доступа №714", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 760L, "действует", "Точка доступа №715", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 761L, "действует", "Точка доступа №716", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 762L, "действует", "Точка доступа №717", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 763L, "действует", "Точка доступа №718", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 764L, "действует", "Точка доступа №719", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 765L, "действует", "Точка доступа №720", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 766L, "действует", "Точка доступа №721", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 767L, "действует", "Точка доступа №722", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 768L, "действует", "Точка доступа №723", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 769L, "действует", "Точка доступа №724", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 770L, "действует", "Точка доступа №725", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 771L, "действует", "Точка доступа №726", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького» Воробьевская набережная", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 772L, "действует", "Точка доступа №753", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 773L, "действует", "Точка доступа №754", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 774L, "действует", "Точка доступа №755", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 775L, "действует", "Точка доступа №756", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 776L, "действует", "Точка доступа №757", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 777L, "действует", "Точка доступа №758", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 778L, "действует", "Точка доступа №759", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 779L, "действует", "Точка доступа №760", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 781L, "действует", "Точка доступа №762", "Государственное автономное учреждение культуры города Москвы «Центральный парк культуры и отдыха имени М.Горького», Парк искусств «Музеон»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 812L, "действует", "Точка доступа №648", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 813L, "действует", "Точка доступа №649", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 814L, "действует", "Точка доступа №650", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 847L, "действует", "Точка доступа №920", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 848L, "действует", "Точка доступа №921", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 849L, "действует", "Точка доступа №922", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 850L, "действует", "Точка доступа №923", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 851L, "действует", "Точка доступа №924", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 852L, "действует", "Точка доступа №925", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 853L, "действует", "Точка доступа №926", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 854L, "действует", "Точка доступа №927", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 855L, "действует", "Точка доступа №928", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 856L, "действует", "Точка доступа №929", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 857L, "действует", "Точка доступа №930", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 858L, "действует", "Точка доступа №931", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 859L, "действует", "Точка доступа №932", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 860L, "действует", "Точка доступа №933", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 861L, "действует", "Точка доступа №934", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 862L, "действует", "Точка доступа №935", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 863L, "действует", "Точка доступа №936", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 864L, "действует", "Точка доступа №937", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 865L, "действует", "Точка доступа №938", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 866L, "действует", "Точка доступа №939", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 867L, "действует", "Точка доступа №940", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 868L, "действует", "Точка доступа №941", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 869L, "действует", "Точка доступа №942", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 870L, "действует", "Точка доступа №943", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 871L, "действует", "Точка доступа №944", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 872L, "действует", "Точка доступа №945", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 873L, "действует", "Точка доступа №946", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 846L, "действует", "Точка доступа №919", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 845L, "действует", "Точка доступа №918", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 844L, "действует", "Точка доступа №917", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 843L, "действует", "Точка доступа №916", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 815L, "действует", "Точка доступа №651", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 816L, "действует", "Точка доступа №652", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 817L, "действует", "Точка доступа №653", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 818L, "действует", "Точка доступа №654", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 819L, "действует", "Точка доступа №655", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 820L, "действует", "Точка доступа №656", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 821L, "действует", "Точка доступа №657", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 822L, "действует", "Точка доступа №658", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 823L, "действует", "Точка доступа №659", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 824L, "действует", "Точка доступа №660", "Государственное автономное учреждение культуры города Москвы «Перовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 825L, "действует", "Точка доступа №825", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 826L, "действует", "Точка доступа №826", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 827L, "действует", "Точка доступа №827", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 875L, "действует", "Точка доступа №948", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 828L, "действует", "Точка доступа №828", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 830L, "действует", "Точка доступа №830", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 831L, "действует", "Точка доступа №831", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 832L, "действует", "Точка доступа №832", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 833L, "действует", "Точка доступа №833", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 834L, "действует", "Точка доступа №834", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 835L, "действует", "Точка доступа №835", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 836L, "действует", "Точка доступа №836", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 837L, "действует", "Точка доступа №910", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 838L, "действует", "Точка доступа №911", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 839L, "действует", "Точка доступа №912", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 840L, "действует", "Точка доступа №913", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 841L, "действует", "Точка доступа №914", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 842L, "действует", "Точка доступа №915", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 829L, "действует", "Точка доступа №829", "Государственное бюджетное учреждение города Москвы «Социально реабилитационный центр ветеранов войн и вооружонных сил», Екатерининский парк", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 501L, "действует", "Точка доступа №501", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 500L, "действует", "Точка доступа №500", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 499L, "действует", "Точка доступа №499", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 158L, "действует", "Точка доступа №125", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 159L, "действует", "Точка доступа №126", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 160L, "действует", "Точка доступа №127", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 161L, "действует", "Точка доступа №128", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 162L, "действует", "Точка доступа №129", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 163L, "действует", "Точка доступа №130", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 164L, "действует", "Точка доступа №131", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 165L, "действует", "Точка доступа №132", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 166L, "действует", "Точка доступа №133", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 167L, "действует", "Точка доступа №134", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 168L, "действует", "Точка доступа №135", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 169L, "действует", "Точка доступа №12", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 170L, "действует", "Точка доступа №13", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 171L, "действует", "Точка доступа №14", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 172L, "действует", "Точка доступа №15", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 173L, "действует", "Точка доступа №16", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 174L, "действует", "Точка доступа №17", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 175L, "действует", "Точка доступа №18", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 176L, "действует", "Точка доступа №19", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 177L, "действует", "Точка доступа №20", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 178L, "действует", "Точка доступа №21", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 179L, "действует", "Точка доступа №22", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 180L, "действует", "Точка доступа №23", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 181L, "действует", "Точка доступа №24", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 182L, "действует", "Точка доступа №25", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 183L, "действует", "Точка доступа №26", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 184L, "действует", "Точка доступа №27", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 157L, "действует", "Точка доступа №124", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 185L, "действует", "Точка доступа №28", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 156L, "действует", "Точка доступа №123", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 154L, "действует", "Точка доступа №121", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 127L, "действует", "Точка доступа №94", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 128L, "действует", "Точка доступа №95", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 129L, "действует", "Точка доступа №96", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 130L, "действует", "Точка доступа №97", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 131L, "действует", "Точка доступа №98", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 132L, "действует", "Точка доступа №99", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 133L, "действует", "Точка доступа №100", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 134L, "действует", "Точка доступа №101", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 135L, "действует", "Точка доступа №102", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 136L, "действует", "Точка доступа №103", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 137L, "действует", "Точка доступа №104", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 138L, "действует", "Точка доступа №105", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 139L, "действует", "Точка доступа №106", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 140L, "действует", "Точка доступа №107", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 141L, "действует", "Точка доступа №108", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 142L, "действует", "Точка доступа №109", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 143L, "действует", "Точка доступа №110", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 144L, "действует", "Точка доступа №111", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 145L, "действует", "Точка доступа №112", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 146L, "действует", "Точка доступа №113", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 147L, "действует", "Точка доступа №114", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 148L, "действует", "Точка доступа №115", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 149L, "действует", "Точка доступа №116", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 150L, "действует", "Точка доступа №117", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 151L, "действует", "Точка доступа №118", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 152L, "действует", "Точка доступа №119", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 153L, "действует", "Точка доступа №120", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 155L, "действует", "Точка доступа №122", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 186L, "действует", "Точка доступа №29", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 187L, "действует", "Точка доступа №30", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 188L, "действует", "Точка доступа №31", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 221L, "действует", "Точка доступа №178", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 222L, "действует", "Точка доступа №179", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 223L, "действует", "Точка доступа №180", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 224L, "действует", "Точка доступа №181", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 225L, "действует", "Точка доступа №182", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 226L, "действует", "Точка доступа №183", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 227L, "действует", "Точка доступа №184", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 228L, "действует", "Точка доступа №185", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 229L, "действует", "Точка доступа №186", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 230L, "действует", "Точка доступа №187", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 231L, "действует", "Точка доступа №188", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 232L, "действует", "Точка доступа №320", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 233L, "действует", "Точка доступа №321", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 234L, "действует", "Точка доступа №322", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 235L, "действует", "Точка доступа №323", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 236L, "действует", "Точка доступа №324", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 237L, "действует", "Точка доступа №325", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 238L, "действует", "Точка доступа №326", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 239L, "действует", "Точка доступа №327", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 240L, "действует", "Точка доступа №328", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 241L, "действует", "Точка доступа №329", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 242L, "действует", "Точка доступа №330", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 243L, "действует", "Точка доступа №331", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 244L, "действует", "Точка доступа №332", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 245L, "действует", "Точка доступа №333", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 246L, "действует", "Точка доступа №334", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 247L, "действует", "Точка доступа №335", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 220L, "действует", "Точка доступа №177", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 219L, "действует", "Точка доступа №176", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 218L, "действует", "Точка доступа №175", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 217L, "действует", "Точка доступа №167", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 189L, "действует", "Точка доступа №32", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 190L, "действует", "Точка доступа №33", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 191L, "действует", "Точка доступа №34", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 192L, "действует", "Точка доступа №35", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 193L, "действует", "Точка доступа №36", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 194L, "действует", "Точка доступа №37", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 195L, "действует", "Точка доступа №38", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 196L, "действует", "Точка доступа №39", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 197L, "действует", "Точка доступа №40", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 198L, "действует", "Точка доступа №41", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 199L, "действует", "Точка доступа №42", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 200L, "действует", "Точка доступа №43", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 201L, "действует", "Точка доступа №44", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 126L, "действует", "Точка доступа №93", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 202L, "действует", "Точка доступа №45", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 204L, "действует", "Точка доступа №47", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 205L, "действует", "Точка доступа №48", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 206L, "действует", "Точка доступа №49", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 207L, "действует", "Точка доступа №50", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 208L, "действует", "Точка доступа №51", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 209L, "действует", "Точка доступа №52", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 210L, "действует", "Точка доступа №53", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 211L, "действует", "Точка доступа №54", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 212L, "действует", "Точка доступа №162", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 213L, "действует", "Точка доступа №163", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 214L, "действует", "Точка доступа №164", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 215L, "действует", "Точка доступа №165", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 216L, "действует", "Точка доступа №166", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 203L, "действует", "Точка доступа №46", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 248L, "действует", "Точка доступа №336", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 125L, "действует", "Точка доступа №92", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 123L, "действует", "Точка доступа №90", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 33L, "действует", "Точка доступа №265", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 34L, "действует", "Точка доступа №266", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 35L, "действует", "Точка доступа №267", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 36L, "действует", "Точка доступа №268", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 37L, "действует", "Точка доступа №269", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 38L, "действует", "Точка доступа №270", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 39L, "действует", "Точка доступа №271", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 40L, "действует", "Точка доступа №272", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 41L, "действует", "Точка доступа №273", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 42L, "действует", "Точка доступа №274", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 43L, "действует", "Точка доступа №275", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 44L, "действует", "Точка доступа №344", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 45L, "действует", "Точка доступа №345", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 46L, "действует", "Точка доступа №346", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 47L, "действует", "Точка доступа №347", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 48L, "действует", "Точка доступа №348", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 49L, "действует", "Точка доступа №349", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 50L, "действует", "Точка доступа №350", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 51L, "действует", "Точка доступа №351", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 52L, "действует", "Точка доступа №352", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 53L, "действует", "Точка доступа №353", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 54L, "действует", "Точка доступа №354", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 55L, "действует", "Точка доступа №355", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 56L, "действует", "Точка доступа №356", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 57L, "действует", "Точка доступа №1", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 58L, "действует", "Точка доступа №2", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 59L, "действует", "Точка доступа №3", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 32L, "действует", "Точка доступа №264", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 60L, "действует", "Точка доступа №4", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 31L, "действует", "Точка доступа №263", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 29L, "действует", "Точка доступа №261", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 2L, "действует", "Точка доступа №338", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 3L, "действует", "Точка доступа №339", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 4L, "действует", "Точка доступа №340", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 5L, "действует", "Точка доступа №341", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 6L, "действует", "Точка доступа №342", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 7L, "действует", "Точка доступа №343", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 8L, "действует", "Точка доступа №240", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 9L, "действует", "Точка доступа №241", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 10L, "действует", "Точка доступа №242", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 11L, "действует", "Точка доступа №243", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 12L, "действует", "Точка доступа №244", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 13L, "действует", "Точка доступа №245", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 14L, "действует", "Точка доступа №246", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 15L, "действует", "Точка доступа №247", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 16L, "действует", "Точка доступа №248", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 17L, "действует", "Точка доступа №249", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 18L, "действует", "Точка доступа №250", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 19L, "действует", "Точка доступа №251", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 20L, "действует", "Точка доступа №252", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 21L, "действует", "Точка доступа №253", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 22L, "действует", "Точка доступа №254", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 23L, "действует", "Точка доступа №255", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 24L, "действует", "Точка доступа №256", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 25L, "действует", "Точка доступа №257", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 26L, "действует", "Точка доступа №258", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 27L, "действует", "Точка доступа №259", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 28L, "действует", "Точка доступа №260", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 30L, "действует", "Точка доступа №262", "Государственное автономное учреждение культуры города Москвы «Московский городской сад «Эрмитаж»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 61L, "действует", "Точка доступа №5", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 62L, "действует", "Точка доступа №6", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 63L, "действует", "Точка доступа №7", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 96L, "действует", "Точка доступа №63", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 97L, "действует", "Точка доступа №64", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 98L, "действует", "Точка доступа №65", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 99L, "действует", "Точка доступа №66", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 100L, "действует", "Точка доступа №67", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 101L, "действует", "Точка доступа №68", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 102L, "действует", "Точка доступа №69", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 103L, "действует", "Точка доступа №70", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 104L, "действует", "Точка доступа №71", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 105L, "действует", "Точка доступа №72", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 106L, "действует", "Точка доступа №73", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 107L, "действует", "Точка доступа №74", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 108L, "действует", "Точка доступа №75", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 109L, "действует", "Точка доступа №76", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 110L, "действует", "Точка доступа №77", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 111L, "действует", "Точка доступа №78", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 112L, "действует", "Точка доступа №79", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 113L, "действует", "Точка доступа №80", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 114L, "действует", "Точка доступа №81", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 115L, "действует", "Точка доступа №82", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 116L, "действует", "Точка доступа №83", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 117L, "действует", "Точка доступа №84", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 118L, "действует", "Точка доступа №85", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 119L, "действует", "Точка доступа №86", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 120L, "действует", "Точка доступа №87", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 121L, "действует", "Точка доступа №88", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 122L, "действует", "Точка доступа №89", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 95L, "действует", "Точка доступа №62", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 94L, "действует", "Точка доступа №61", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 93L, "действует", "Точка доступа №60", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 92L, "действует", "Точка доступа №59", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 64L, "действует", "Точка доступа №8", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 65L, "действует", "Точка доступа №9", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 66L, "действует", "Точка доступа №10", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 67L, "действует", "Точка доступа №11", "Государственное автономное учреждение культуры города Москвы «Сад культуры и отдыха имени Н.Э.Баумана»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 68L, "действует", "Точка доступа №168", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 69L, "действует", "Точка доступа №169", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 70L, "действует", "Точка доступа №170", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 71L, "действует", "Точка доступа №171", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 72L, "действует", "Точка доступа №172", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 73L, "действует", "Точка доступа №173", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 74L, "действует", "Точка доступа №174", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 75L, "действует", "Точка доступа №227", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 76L, "действует", "Точка доступа №228", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 124L, "действует", "Точка доступа №91", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 77L, "действует", "Точка доступа №229", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 79L, "действует", "Точка доступа №231", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 80L, "действует", "Точка доступа №232", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 81L, "действует", "Точка доступа №233", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 82L, "действует", "Точка доступа №234", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 83L, "действует", "Точка доступа №235", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 84L, "действует", "Точка доступа №236", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 85L, "действует", "Точка доступа №237", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 86L, "действует", "Точка доступа №238", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 87L, "действует", "Точка доступа №239", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 88L, "действует", "Точка доступа №55", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 89L, "действует", "Точка доступа №56", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 90L, "действует", "Точка доступа №57", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 91L, "действует", "Точка доступа №58", "Государственное автономное учреждение культуры города Москвы «Измайловский Парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 78L, "действует", "Точка доступа №230", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 249L, "действует", "Точка доступа №189", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 250L, "действует", "Точка доступа №190", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 251L, "действует", "Точка доступа №191", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 409L, "действует", "Точка доступа №409", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 410L, "действует", "Точка доступа №410", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 411L, "действует", "Точка доступа №411", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 412L, "действует", "Точка доступа №412", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 413L, "действует", "Точка доступа №413", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 414L, "действует", "Точка доступа №414", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 415L, "действует", "Точка доступа №415", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 416L, "действует", "Точка доступа №416", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 417L, "действует", "Точка доступа №417", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 418L, "действует", "Точка доступа №418", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 419L, "действует", "Точка доступа №419", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 420L, "действует", "Точка доступа №420", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 421L, "действует", "Точка доступа №421", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 422L, "действует", "Точка доступа №422", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 423L, "действует", "Точка доступа №423", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 424L, "действует", "Точка доступа №424", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 425L, "действует", "Точка доступа №425", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 426L, "действует", "Точка доступа №426", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 427L, "действует", "Точка доступа №427", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 428L, "действует", "Точка доступа №428", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 429L, "действует", "Точка доступа №429", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 430L, "действует", "Точка доступа №430", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 431L, "действует", "Точка доступа №431", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 432L, "действует", "Точка доступа №432", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 433L, "действует", "Точка доступа №433", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 434L, "действует", "Точка доступа №434", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 435L, "действует", "Точка доступа №435", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 408L, "действует", "Точка доступа №408", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 436L, "действует", "Точка доступа №436", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 407L, "действует", "Точка доступа №407", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 405L, "действует", "Точка доступа №405", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 378L, "действует", "Точка доступа №378", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 379L, "действует", "Точка доступа №379", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 380L, "действует", "Точка доступа №380", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 381L, "действует", "Точка доступа №381", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 382L, "действует", "Точка доступа №382", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 383L, "действует", "Точка доступа №383", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 384L, "действует", "Точка доступа №384", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 385L, "действует", "Точка доступа №385", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 386L, "действует", "Точка доступа №386", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 387L, "действует", "Точка доступа №387", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 388L, "действует", "Точка доступа №388", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 389L, "действует", "Точка доступа №389", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 390L, "действует", "Точка доступа №390", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 391L, "действует", "Точка доступа №391", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 392L, "действует", "Точка доступа №392", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 393L, "действует", "Точка доступа №393", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 394L, "действует", "Точка доступа №394", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 395L, "действует", "Точка доступа №395", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 396L, "действует", "Точка доступа №396", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 397L, "действует", "Точка доступа №397", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 398L, "действует", "Точка доступа №398", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 399L, "действует", "Точка доступа №399", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 400L, "действует", "Точка доступа №400", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 401L, "действует", "Точка доступа №401", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 402L, "действует", "Точка доступа №402", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 403L, "действует", "Точка доступа №403", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 404L, "действует", "Точка доступа №404", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 406L, "действует", "Точка доступа №406", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 437L, "действует", "Точка доступа №437", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 438L, "действует", "Точка доступа №438", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 439L, "действует", "Точка доступа №439", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 472L, "действует", "Точка доступа №472", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 473L, "действует", "Точка доступа №473", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 474L, "действует", "Точка доступа №474", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 475L, "действует", "Точка доступа №475", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 476L, "действует", "Точка доступа №476", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 477L, "действует", "Точка доступа №477", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 478L, "действует", "Точка доступа №478", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 479L, "действует", "Точка доступа №479", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 480L, "действует", "Точка доступа №480", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 481L, "действует", "Точка доступа №481", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 482L, "действует", "Точка доступа №482", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 483L, "действует", "Точка доступа №483", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 484L, "действует", "Точка доступа №484", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 485L, "действует", "Точка доступа №485", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 486L, "действует", "Точка доступа №486", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 487L, "действует", "Точка доступа №487", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 488L, "действует", "Точка доступа №488", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 489L, "действует", "Точка доступа №489", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 490L, "действует", "Точка доступа №490", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 491L, "действует", "Точка доступа №491", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 492L, "действует", "Точка доступа №492", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 493L, "действует", "Точка доступа №493", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 494L, "действует", "Точка доступа №494", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 495L, "действует", "Точка доступа №495", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 496L, "действует", "Точка доступа №496", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 497L, "действует", "Точка доступа №497", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 498L, "действует", "Точка доступа №498", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 471L, "действует", "Точка доступа №471", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 470L, "действует", "Точка доступа №470", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 469L, "действует", "Точка доступа №469", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 468L, "действует", "Точка доступа №468", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 440L, "действует", "Точка доступа №440", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 441L, "действует", "Точка доступа №441", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 442L, "действует", "Точка доступа №442", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 443L, "действует", "Точка доступа №443", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 444L, "действует", "Точка доступа №444", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 445L, "действует", "Точка доступа №445", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 446L, "действует", "Точка доступа №446", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 447L, "действует", "Точка доступа №447", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 448L, "действует", "Точка доступа №448", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 449L, "действует", "Точка доступа №449", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 450L, "действует", "Точка доступа №450", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 451L, "действует", "Точка доступа №451", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 452L, "действует", "Точка доступа №452", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 377L, "действует", "Точка доступа №377", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 453L, "действует", "Точка доступа №453", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 455L, "действует", "Точка доступа №455", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 456L, "действует", "Точка доступа №456", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 457L, "действует", "Точка доступа №457", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 458L, "действует", "Точка доступа №458", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 459L, "действует", "Точка доступа №459", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 460L, "действует", "Точка доступа №460", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 461L, "действует", "Точка доступа №461", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 462L, "действует", "Точка доступа №462", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 463L, "действует", "Точка доступа №463", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 464L, "действует", "Точка доступа №464", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 465L, "действует", "Точка доступа №465", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 466L, "действует", "Точка доступа №466", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 467L, "действует", "Точка доступа №467", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 454L, "действует", "Точка доступа №454", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Сокольники»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 376L, "действует", "Точка доступа №376", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 375L, "действует", "Точка доступа №375", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 374L, "действует", "Точка доступа №374", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 284L, "действует", "Точка доступа №224", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 285L, "действует", "Точка доступа №225", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 286L, "действует", "Точка доступа №226", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 287L, "действует", "Точка доступа №276", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 288L, "действует", "Точка доступа №277", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 289L, "действует", "Точка доступа №278", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 290L, "действует", "Точка доступа №279", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 291L, "действует", "Точка доступа №280", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 292L, "действует", "Точка доступа №281", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 293L, "действует", "Точка доступа №282", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 294L, "действует", "Точка доступа №283", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 295L, "действует", "Точка доступа №284", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 296L, "действует", "Точка доступа №285", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 297L, "действует", "Точка доступа №286", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 298L, "действует", "Точка доступа №287", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 299L, "действует", "Точка доступа №288", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 300L, "действует", "Точка доступа №289", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 301L, "действует", "Точка доступа №290", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 302L, "действует", "Точка доступа №291", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 303L, "действует", "Точка доступа №292", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 304L, "действует", "Точка доступа №293", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 305L, "действует", "Точка доступа №294", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 306L, "действует", "Точка доступа №295", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 307L, "действует", "Точка доступа №296", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 308L, "действует", "Точка доступа №297", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 309L, "действует", "Точка доступа №298", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 310L, "действует", "Точка доступа №299", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 283L, "действует", "Точка доступа №223", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 282L, "действует", "Точка доступа №222", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 281L, "действует", "Точка доступа №221", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 280L, "действует", "Точка доступа №220", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 252L, "действует", "Точка доступа №192", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 253L, "действует", "Точка доступа №193", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 254L, "действует", "Точка доступа №194", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 255L, "действует", "Точка доступа №195", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 256L, "действует", "Точка доступа №196", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 257L, "действует", "Точка доступа №197", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 258L, "действует", "Точка доступа №198", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 259L, "действует", "Точка доступа №199", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 260L, "действует", "Точка доступа №200", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 261L, "действует", "Точка доступа №201", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 262L, "действует", "Точка доступа №202", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 263L, "действует", "Точка доступа №203", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 264L, "действует", "Точка доступа №204", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 311L, "действует", "Точка доступа №300", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 265L, "действует", "Точка доступа №205", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 267L, "действует", "Точка доступа №207", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 268L, "действует", "Точка доступа №208", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 269L, "действует", "Точка доступа №209", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 270L, "действует", "Точка доступа №210", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 271L, "действует", "Точка доступа №211", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 272L, "действует", "Точка доступа №212", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 273L, "действует", "Точка доступа №213", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 274L, "действует", "Точка доступа №214", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 275L, "действует", "Точка доступа №215", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 276L, "действует", "Точка доступа №216", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 277L, "действует", "Точка доступа №217", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 278L, "действует", "Точка доступа №218", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 279L, "действует", "Точка доступа №219", "Государственное автономное учреждение культуры города Москвы «Лианозовский парк культуры и отдыха»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 266L, "действует", "Точка доступа №206", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 999L, "действует", "Точка доступа №884", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 312L, "действует", "Точка доступа №301", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 314L, "действует", "Точка доступа №303", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 347L, "действует", "Точка доступа №152", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 348L, "действует", "Точка доступа №153", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 349L, "действует", "Точка доступа №154", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 350L, "действует", "Точка доступа №155", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 351L, "действует", "Точка доступа №156", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 352L, "действует", "Точка доступа №157", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 353L, "действует", "Точка доступа №158", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 354L, "действует", "Точка доступа №159", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 355L, "действует", "Точка доступа №160", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 356L, "действует", "Точка доступа №161", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 357L, "действует", "Точка доступа №357", "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник «Кузьминки-Люблино», Парк «Кузьминки»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 358L, "действует", "Точка доступа №358", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 359L, "действует", "Точка доступа №359", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 360L, "действует", "Точка доступа №360", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 361L, "действует", "Точка доступа №361", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 362L, "действует", "Точка доступа №362", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 363L, "действует", "Точка доступа №363", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 364L, "действует", "Точка доступа №364", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 365L, "действует", "Точка доступа №365", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 366L, "действует", "Точка доступа №366", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 367L, "действует", "Точка доступа №367", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 368L, "действует", "Точка доступа №368", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 369L, "действует", "Точка доступа №369", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 370L, "действует", "Точка доступа №370", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Люблино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 371L, "действует", "Точка доступа №371", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 372L, "действует", "Точка доступа №372", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 373L, "действует", "Точка доступа №373", "Государственное автономное учреждение культуры города Москвы «Музейно-парковый комплекс «Северное Тушино», парк «Северное Тушино»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 346L, "действует", "Точка доступа №151", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 345L, "действует", "Точка доступа №150", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 344L, "действует", "Точка доступа №149", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 343L, "действует", "Точка доступа №148", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 315L, "действует", "Точка доступа №304", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 316L, "действует", "Точка доступа №305", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 317L, "действует", "Точка доступа №306", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 318L, "действует", "Точка доступа №307", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 319L, "действует", "Точка доступа №308", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 320L, "действует", "Точка доступа №309", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 321L, "действует", "Точка доступа №310", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 322L, "действует", "Точка доступа №311", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 323L, "действует", "Точка доступа №312", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 324L, "действует", "Точка доступа №313", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 325L, "действует", "Точка доступа №314", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 326L, "действует", "Точка доступа №315", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 327L, "действует", "Точка доступа №316", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 313L, "действует", "Точка доступа №302", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 328L, "действует", "Точка доступа №317", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 330L, "действует", "Точка доступа №319", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 331L, "действует", "Точка доступа №136", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 332L, "действует", "Точка доступа №137", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 333L, "действует", "Точка доступа №138", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 334L, "действует", "Точка доступа №139", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 335L, "действует", "Точка доступа №140", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 336L, "действует", "Точка доступа №141", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 337L, "действует", "Точка доступа №142", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 338L, "действует", "Точка доступа №143", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 339L, "действует", "Точка доступа №144", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 340L, "действует", "Точка доступа №145", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 341L, "действует", "Точка доступа №146", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 342L, "действует", "Точка доступа №147", "Государственное автономное учреждение города Москвы «Московский государственный зоологический парк»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 329L, "действует", "Точка доступа №318", "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Красная Пресня»", "Moscow_WiFi_Free" });

            migrationBuilder.InsertData(
                table: "ParkWifi",
                columns: new[] { "Id", "FunctionFlag", "Name", "ParkName", "wifiName" },
                values: new object[] { 1000L, "действует", "Точка доступа №885", "Государственное бюджетное учреждение культуры города Москвы «Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник», усадьба «Коломенское»", "Moscow_WiFi_Free" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkWifi");
        }
    }
}
