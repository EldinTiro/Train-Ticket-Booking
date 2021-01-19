using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class migr7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 45, 39, 106, DateTimeKind.Local).AddTicks(7396), "CefMjK5A/bpXyb+dmGAkKYNalxE=", "UAUWVIDLTa8nXP+mLB1xvw==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 45, 39, 117, DateTimeKind.Local).AddTicks(4873), "l3wCk2Yu826Kg0IxAU6guMltv1s=", "ujIaTo4dXqNsQ0QZ782/nQ==" });

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 2,
                column: "Cijena",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 3,
                column: "Cijena",
                value: 6.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 4,
                column: "Cijena",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 5,
                column: "Cijena",
                value: 7.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 6,
                column: "Cijena",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 7,
                column: "Cijena",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 8,
                column: "Cijena",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 9,
                column: "Cijena",
                value: 9.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 10,
                column: "Cijena",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 11,
                column: "Cijena",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 12,
                column: "Cijena",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 13,
                column: "Cijena",
                value: 11.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 14,
                column: "Cijena",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 15,
                column: "Cijena",
                value: 12.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 16,
                column: "Cijena",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 17,
                column: "Cijena",
                value: 13.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 18,
                column: "Cijena",
                value: 14.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 19,
                column: "Cijena",
                value: 14.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 20,
                column: "Cijena",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 21,
                column: "Cijena",
                value: 15.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 22,
                column: "Cijena",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 23,
                column: "Cijena",
                value: 16.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 24,
                column: "Cijena",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 25,
                column: "Cijena",
                value: 17.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 26,
                column: "Cijena",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 27,
                column: "Cijena",
                value: 18.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 28,
                column: "Cijena",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 29,
                column: "Cijena",
                value: 19.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 30,
                column: "Cijena",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 31,
                column: "Cijena",
                value: 20.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 32,
                column: "Cijena",
                value: 21.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 33,
                column: "Cijena",
                value: 21.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 34,
                column: "Cijena",
                value: 22.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 35,
                column: "Cijena",
                value: 22.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 36,
                column: "Cijena",
                value: 23.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 37,
                column: "Cijena",
                value: 23.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 38,
                column: "Cijena",
                value: 24.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 39,
                column: "Cijena",
                value: 24.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 40,
                column: "Cijena",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 41,
                column: "Cijena",
                value: 25.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 42,
                column: "Cijena",
                value: 26.0);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 44,
                column: "Cijena",
                value: 6.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 45,
                column: "Cijena",
                value: 6.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 46,
                column: "Cijena",
                value: 7.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 47,
                column: "Cijena",
                value: 7.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 48,
                column: "Cijena",
                value: 8.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 49,
                column: "Cijena",
                value: 8.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 50,
                column: "Cijena",
                value: 9.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 51,
                column: "Cijena",
                value: 9.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 52,
                column: "Cijena",
                value: 10.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 53,
                column: "Cijena",
                value: 10.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 54,
                column: "Cijena",
                value: 11.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 55,
                column: "Cijena",
                value: 11.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 56,
                column: "Cijena",
                value: 12.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 57,
                column: "Cijena",
                value: 12.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 58,
                column: "Cijena",
                value: 13.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 59,
                column: "Cijena",
                value: 13.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 60,
                column: "Cijena",
                value: 14.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 61,
                column: "Cijena",
                value: 14.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 62,
                column: "Cijena",
                value: 15.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 63,
                column: "Cijena",
                value: 15.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 64,
                column: "Cijena",
                value: 16.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 65,
                column: "Cijena",
                value: 16.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 66,
                column: "Cijena",
                value: 17.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 67,
                column: "Cijena",
                value: 17.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 68,
                column: "Cijena",
                value: 18.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 69,
                column: "Cijena",
                value: 18.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 70,
                column: "Cijena",
                value: 19.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 71,
                column: "Cijena",
                value: 19.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 72,
                column: "Cijena",
                value: 20.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 73,
                column: "Cijena",
                value: 20.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 74,
                column: "Cijena",
                value: 21.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 75,
                column: "Cijena",
                value: 21.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 76,
                column: "Cijena",
                value: 22.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 77,
                column: "Cijena",
                value: 22.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 78,
                column: "Cijena",
                value: 23.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 79,
                column: "Cijena",
                value: 23.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 80,
                column: "Cijena",
                value: 24.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 81,
                column: "Cijena",
                value: 24.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 82,
                column: "Cijena",
                value: 25.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 83,
                column: "Cijena",
                value: 25.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 84,
                column: "Cijena",
                value: 26.25);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 86,
                column: "Cijena",
                value: 8.4499999999999993);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 87,
                column: "Cijena",
                value: 8.9499999999999993);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 88,
                column: "Cijena",
                value: 9.4499999999999993);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 89,
                column: "Cijena",
                value: 9.9499999999999993);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 90,
                column: "Cijena",
                value: 10.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 91,
                column: "Cijena",
                value: 10.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 92,
                column: "Cijena",
                value: 11.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 93,
                column: "Cijena",
                value: 11.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 94,
                column: "Cijena",
                value: 12.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 95,
                column: "Cijena",
                value: 12.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 96,
                column: "Cijena",
                value: 13.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 97,
                column: "Cijena",
                value: 13.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 98,
                column: "Cijena",
                value: 14.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 99,
                column: "Cijena",
                value: 14.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 100,
                column: "Cijena",
                value: 15.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 101,
                column: "Cijena",
                value: 15.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 102,
                column: "Cijena",
                value: 16.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 103,
                column: "Cijena",
                value: 16.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 104,
                column: "Cijena",
                value: 17.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 105,
                column: "Cijena",
                value: 17.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 106,
                column: "Cijena",
                value: 18.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 107,
                column: "Cijena",
                value: 18.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 108,
                column: "Cijena",
                value: 19.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 109,
                column: "Cijena",
                value: 19.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 110,
                column: "Cijena",
                value: 20.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 111,
                column: "Cijena",
                value: 20.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 112,
                column: "Cijena",
                value: 21.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 113,
                column: "Cijena",
                value: 21.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 114,
                column: "Cijena",
                value: 22.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 115,
                column: "Cijena",
                value: 22.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 116,
                column: "Cijena",
                value: 23.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 117,
                column: "Cijena",
                value: 23.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 118,
                column: "Cijena",
                value: 24.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 119,
                column: "Cijena",
                value: 24.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 120,
                column: "Cijena",
                value: 25.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 121,
                column: "Cijena",
                value: 25.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 122,
                column: "Cijena",
                value: 26.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 123,
                column: "Cijena",
                value: 26.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 124,
                column: "Cijena",
                value: 27.449999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 125,
                column: "Cijena",
                value: 27.949999999999999);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 126,
                column: "Cijena",
                value: 28.449999999999999);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 2,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 3,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 4,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 5,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 6,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 7,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 8,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 9,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 10,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 11,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 12,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 13,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 14,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 15,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 16,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 17,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 18,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 19,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 20,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 21,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 22,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 23,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 24,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 25,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 26,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 27,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 28,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 29,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 30,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 31,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 32,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 33,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 34,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 35,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 36,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 37,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 38,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 39,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 40,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 41,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 42,
                column: "Cijena",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 44,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 45,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 46,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 47,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 48,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 49,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 50,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 51,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 52,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 53,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 54,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 55,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 56,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 57,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 58,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 59,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 60,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 61,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 62,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 63,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 64,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 65,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 66,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 67,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 68,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 69,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 70,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 71,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 72,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 73,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 74,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 75,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 76,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 77,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 78,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 79,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 80,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 81,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 82,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 83,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 84,
                column: "Cijena",
                value: 5.75);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 86,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 87,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 88,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 89,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 90,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 91,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 92,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 93,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 94,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 95,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 96,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 97,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 98,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 99,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 100,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 101,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 102,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 103,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 104,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 105,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 106,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 107,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 108,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 109,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 110,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 111,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 112,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 113,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 114,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 115,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 116,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 117,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 118,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 119,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 120,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 121,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 122,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 123,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 124,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 125,
                column: "Cijena",
                value: 7.9500000000000002);

            migrationBuilder.UpdateData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 126,
                column: "Cijena",
                value: 7.9500000000000002);
        }
    }
}
