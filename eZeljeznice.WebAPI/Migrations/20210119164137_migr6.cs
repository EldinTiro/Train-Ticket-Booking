using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class migr6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 49);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 41, 36, 416, DateTimeKind.Local).AddTicks(3316), "X9jHX9TvSKtq5zdFPFEhu2mScuo=", "+vQfnURDOtmfHx+21ShNpg==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 41, 36, 426, DateTimeKind.Local).AddTicks(9753), "MgUhFwDOhJ3TbAMWhqvAIop8nWo=", "66smX8rvVkzoPuJHM6shTw==" });

            migrationBuilder.InsertData(
                table: "Putovanja",
                columns: new[] { "PutovanjeID", "Cijena", "DatumPolaska", "RelacijaID", "VrijemeDolaska", "VrijemePolaska" },
                values: new object[,]
                {
                    { 94, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 93, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 92, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 91, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 90, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 89, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 88, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 87, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 86, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 84, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 42, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 83, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 41, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 82, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 40, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 95, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 81, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 39, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 79, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 37, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 78, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 36, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 77, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 35, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 76, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 34, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 75, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 33, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 74, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 32, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 73, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 31, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 72, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 30, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 71, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 29, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 70, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 28, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 69, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 27, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 68, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 26, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 67, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 25, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 80, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 38, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 66, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 24, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 96, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 98, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 126, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 42, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 125, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 41, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 124, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 40, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 123, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 39, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 122, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 38, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 121, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 37, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 120, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 36, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 119, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 35, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 118, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 34, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 117, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 33, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 116, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 32, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 115, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 31, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 114, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 30, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 97, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 113, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 29, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 111, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 27, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 110, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 26, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 109, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 25, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 108, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 24, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 107, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 23, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 106, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 22, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 105, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 21, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 104, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 103, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 102, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 101, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 100, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 99, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 112, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 28, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 65, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 23, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 85, 7.9500000000000002, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 63, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 21, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 29, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 29, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 28, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 28, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 27, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 27, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 26, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 26, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 25, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 25, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 24, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 24, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 23, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 23, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 22, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 22, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 21, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 21, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 20, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 19, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 18, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 17, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 30, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 30, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 16, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 14, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 13, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 12, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 64, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 22, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 10, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 9, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 8, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 7, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 6, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 5, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 4, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 3, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 2, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 15, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 31, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 31, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 11, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 33, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 33, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 32, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 32, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 62, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 61, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 60, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 59, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 58, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 57, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 56, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 55, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 54, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 53, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 52, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 51, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 50, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 49, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 1, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 47, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 35, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 35, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 36, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 36, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 34, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 34, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 38, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 38, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 39, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 39, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 40, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 40, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 37, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 37, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 42, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 42, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 43, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 44, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 45, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 46, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 41, 5.5, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 41, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 48, 5.75, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 1,
                column: "ZeljeznickaStanicaDOID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 2,
                column: "ZeljeznickaStanicaDOID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 3,
                column: "ZeljeznickaStanicaDOID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 4,
                column: "ZeljeznickaStanicaDOID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 5,
                column: "ZeljeznickaStanicaDOID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 6,
                column: "ZeljeznickaStanicaDOID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 7,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 8,
                column: "ZeljeznickaStanicaDOID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 9,
                column: "ZeljeznickaStanicaDOID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 10,
                column: "ZeljeznickaStanicaDOID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 11,
                column: "ZeljeznickaStanicaDOID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 12,
                column: "ZeljeznickaStanicaDOID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 13,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 14,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 15,
                column: "ZeljeznickaStanicaDOID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 16,
                column: "ZeljeznickaStanicaDOID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 17,
                column: "ZeljeznickaStanicaDOID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 18,
                column: "ZeljeznickaStanicaDOID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 19,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 20,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 21,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 22,
                column: "ZeljeznickaStanicaDOID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 23,
                column: "ZeljeznickaStanicaDOID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 24,
                column: "ZeljeznickaStanicaDOID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 25,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 26,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 27,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 28,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 29,
                column: "ZeljeznickaStanicaDOID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 30,
                column: "ZeljeznickaStanicaDOID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 31,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 32,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 33,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 34,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 35,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 36,
                column: "ZeljeznickaStanicaDOID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 37,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 38,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 39,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 40,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 41,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 42,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 6, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 126);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 0, 43, 520, DateTimeKind.Local).AddTicks(6346), "KjU9Eb6QhxC+aNEXdm6cDlDLkRQ=", "9IkPM47ay45XOr0Ea5pbTg==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 0, 43, 528, DateTimeKind.Local).AddTicks(2733), "KmYv6L2N5zHaKvquJkjLQMDH73E=", "2HGgKnDTh9X3Ns+pKCDi4A==" });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 1,
                column: "ZeljeznickaStanicaDOID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 2,
                column: "ZeljeznickaStanicaDOID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 3,
                column: "ZeljeznickaStanicaDOID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 4,
                column: "ZeljeznickaStanicaDOID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 5,
                column: "ZeljeznickaStanicaDOID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 6,
                column: "ZeljeznickaStanicaDOID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 7,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 8,
                column: "ZeljeznickaStanicaDOID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 9,
                column: "ZeljeznickaStanicaDOID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 10,
                column: "ZeljeznickaStanicaDOID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 11,
                column: "ZeljeznickaStanicaDOID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 12,
                column: "ZeljeznickaStanicaDOID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 13,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 14,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 15,
                column: "ZeljeznickaStanicaDOID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 16,
                column: "ZeljeznickaStanicaDOID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 17,
                column: "ZeljeznickaStanicaDOID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 18,
                column: "ZeljeznickaStanicaDOID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 19,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 5, 3 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 20,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 21,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 22,
                column: "ZeljeznickaStanicaDOID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 23,
                column: "ZeljeznickaStanicaDOID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 24,
                column: "ZeljeznickaStanicaDOID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 25,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 26,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 27,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 28,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 29,
                column: "ZeljeznickaStanicaDOID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 30,
                column: "ZeljeznickaStanicaDOID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 31,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 32,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 33,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 34,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 35,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 36,
                column: "ZeljeznickaStanicaDOID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 37,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 38,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 39,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 40,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 41,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 42,
                columns: new[] { "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[] { 7, 6 });

            migrationBuilder.InsertData(
                table: "Relacije",
                columns: new[] { "RelacijaID", "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[,]
                {
                    { 48, 6, 7 },
                    { 44, 2, 7 },
                    { 45, 3, 7 },
                    { 46, 4, 7 },
                    { 47, 5, 7 },
                    { 49, 7, 7 },
                    { 43, 1, 7 }
                });
        }
    }
}
