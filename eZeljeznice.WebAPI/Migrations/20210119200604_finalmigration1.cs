using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class finalmigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 2,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 3,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 4,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 5,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 6,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 7,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 8,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 19, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 9,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 21, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 10,
                column: "DatumObjave",
                value: new DateTime(2021, 1, 20, 21, 6, 3, 562, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 1,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 13, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 2,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 3,
                column: "RedniBrojSjedista",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 4,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 8, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 5,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 6,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 7,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 12, 3 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 8,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 21, 9 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 9,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 6, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 10,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 11,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 12,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 15, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 13,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 27, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 14,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 15,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 16, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 16,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 17,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 18,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 11, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 19,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 19, 2 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 20,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 19, 3 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 21,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 22,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 12, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 23,
                column: "RedniBrojSjedista",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 24,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 17, 9 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 25,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 26,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 24, 8 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 27,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 12, 8 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 28,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 24, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 29,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 30,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 553, DateTimeKind.Local).AddTicks(4945), "pBc+3Dya6V+ZdwXNelPhKARURgI=", "Y2veuRM4r33725j2ghXfYw==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 561, DateTimeKind.Local).AddTicks(6957), "bSCdsLFUe1SsU8N5bmhro3TRlw8=", "0lmlbX8IG/5mnM78sEuk0Q==" });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 1,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2153", new DateTime(2021, 1, 19, 21, 6, 3, 569, DateTimeKind.Local).AddTicks(8445), 42.0, 22 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 2,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2142", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(2280), 45.0, 12 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 3,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2182", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(2597), 69.0, 6 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 4,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2132", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(2751), 48.0, 13 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 5,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2149", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(2879), 73.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 6,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2102", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(3011), 9.0, 7 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 7,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2180", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(3135), 33.0, 1 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 8,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2196", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(3258), 59.0, 29 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 9,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2173", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(3382), 51.0, 21 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 10,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2163", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(3512), 5.0, 17 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 11,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2178", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(3636), 63.0, 22 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 12,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2190", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(3842), 14.0, 14 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 13,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2155", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(4137), 53.0, 7 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 14,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2181", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(4295), 70.0, 16 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 15,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2117", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(4420), 54.0, 5 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 16,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2156", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(4545), 61.0, 20 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 17,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2178", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(4668), 76.0, 9 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 18,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2149", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(4800), 58.0, 8 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 19,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2181", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(4922), 38.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 20,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2151", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5042), 30.0, 16 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 21,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2134", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5165), 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 22,
                columns: new[] { "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5288), 51.0, 27 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 23,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2126", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5413), 52.0, 11 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 24,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2112", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5606), 16.0, 11 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 25,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2129", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5744), 65.0, 8 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 26,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2168", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5866), 40.0, 22 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 27,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2146", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(5989), 7.0, 22 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 28,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2170", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(6113), 70.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 29,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2108", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(6233), 18.0, 3 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 30,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2148", new DateTime(2021, 1, 19, 21, 6, 3, 570, DateTimeKind.Local).AddTicks(6356), 40.0, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 1,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 22, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 2,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 12, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 3,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 1, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 4,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 5,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 8, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 6,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 38, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 7,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 24, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 8,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 28, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 9,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 6, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 10,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 31, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 11,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 18, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 12,
                column: "RelacijaID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 13,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 17, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 14,
                column: "RelacijaID",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 15,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 16,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 17, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 17,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 22, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 18,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 17, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 19,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 1, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 20,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 23, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 21,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 26, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 22,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 23, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 23,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 24,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 7, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 25,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 37, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 26,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 13, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 27,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 18, 18 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 28,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 36, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 29,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 16, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 30,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 34, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 31,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 17, 27 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 32,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 24, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 33,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 10, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 34,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 19, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 35,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 15, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 36,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 37, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 37,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 11, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 38,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 23, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 39,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 34, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 40,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 19, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 41,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 31, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 42,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 43,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 8, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 44,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 35, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 45,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 24, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 46,
                columns: new[] { "Ocjena", "RelacijaID" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 47,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 36, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 48,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 11, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 49,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 28, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 50,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 22 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 51,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 52,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 14, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 53,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 12, 2 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 54,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 18 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 55,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 56,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 5, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 57,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 58,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 6, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 59,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 60,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 33, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 61,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 38, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 62,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 39, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 63,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 33, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 64,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 15, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 65,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 13, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 66,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 14, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 67,
                column: "RelacijaID",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 68,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 26, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 69,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 12, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 70,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 28, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 71,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 15, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 72,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 29, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 73,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 26, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 74,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 16, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 75,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 35, 22 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 76,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 40, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 77,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 35, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 78,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 23, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 79,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 41, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 80,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 21, 18 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 81,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 3, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 82,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 83,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 16, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 84,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 21, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 85,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 20, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 86,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 7, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 87,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 11, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 88,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 28, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 89,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 16, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 90,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 41, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 91,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 30, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 92,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 36, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 93,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 94,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 19, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 95,
                columns: new[] { "Ocjena", "RezervacijaID" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 96,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 37, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 97,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 26, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 98,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 20, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 99,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 28, 11 });

            migrationBuilder.InsertData(
                table: "Putovanja",
                columns: new[] { "PutovanjeID", "Cijena", "DatumPolaska", "RelacijaID", "VrijemeDolaska", "VrijemePolaska" },
                values: new object[,]
                {
                    { 129, 28.449999999999999, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 128, 28.449999999999999, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 127, 28.449999999999999, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(1830), 8 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5105), 24 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5423), 19 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 4,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5532), 97 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 5,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5609), 22 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 6,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5692), 106 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 7,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5765), 13 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 8,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5838), 56 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 9,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5909), 120 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 10,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(5985), 2 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 11,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6058), 39 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 12,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6130), 6 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 13,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6202), 10 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 14,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6276), 94 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 15,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6348), 36 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 16,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6420), 94 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 17,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6492), 81 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 18,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6570), 15 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 19,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6644), 78 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 20,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6781), 73 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 21,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6873), 99 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 22,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(6948), 47 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 23,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7020), 80 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 24,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7094), 30 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 25,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7167), 77 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 26,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7240), 59 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 27,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7312), 24 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 28,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7383), 38 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 29,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7454), 19 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 30,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 6, 3, 567, DateTimeKind.Local).AddTicks(7526), 122 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Putovanja",
                keyColumn: "PutovanjeID",
                keyValue: 129);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 1,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 2,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 3,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 4,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 5,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 6,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 7,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 8,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 9,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 10,
                column: "DatumObjave",
                value: null);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 1,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 2,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 3,
                column: "RedniBrojSjedista",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 4,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 5,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 6,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 7,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 8,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 9,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 10,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 15, 3 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 11,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 12,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 13,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 14,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 15,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 16,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 17,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 27, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 18,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 17, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 19,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 29, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 20,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 18, 9 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 21,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 17, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 22,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 25, 9 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 23,
                column: "RedniBrojSjedista",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 24,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 25,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 26,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 27,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 28,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 25, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 29,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 15, 8 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 30,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 668, DateTimeKind.Local).AddTicks(480), "50fykJXBaEyqeBQ9Bx98wh6/Bf0=", "kg1Tyw8s6xsnyiz0OoVEpA==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 675, DateTimeKind.Local).AddTicks(8821), "vGT1EcxBfDMXZugJlisj7C+lpAM=", "DD0L6V2on8NpfPbYoPWjzg==" });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 1,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2167", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(4217), 12.0, 26 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 2,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2125", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(8171), 63.0, 9 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 3,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2184", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(8403), 33.0, 19 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 4,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2116", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(8533), 22.0, 28 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 5,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2143", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(8652), 14.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 6,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2156", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(8879), 69.0, 18 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 7,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2191", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9021), 36.0, 21 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 8,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2145", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9139), 25.0, 11 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 9,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2110", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9257), 34.0, 2 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 10,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2144", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9382), 42.0, 1 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 11,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2144", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9500), 60.0, 9 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 12,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2107", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9618), 42.0, 23 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 13,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2101", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9735), 57.0, 27 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 14,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2159", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9853), 34.0, 9 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 15,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2112", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(9970), 71.0, 2 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 16,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2114", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(141), 29.0, 24 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 17,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2123", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(282), 30.0, 25 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 18,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2173", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(415), 27.0, 23 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 19,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2152", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(533), 51.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 20,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2143", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(653), 17.0, 27 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 21,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2154", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(769), 40.0, 11 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 22,
                columns: new[] { "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(885), 67.0, 14 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 23,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2186", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1000), 75.0, 5 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 24,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2164", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1116), 30.0, 24 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 25,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2139", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1231), 13.0, 1 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 26,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2185", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1348), 2.0, 23 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 27,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2153", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1543), 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 28,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2116", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1671), 7.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 29,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2140", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1789), 58.0, 11 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 30,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2112", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1906), 70.0, 27 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 1,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 21, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 2,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 15, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 3,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 14, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 4,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 29, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 5,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 34, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 6,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 13, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 7,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 39, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 8,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 18, 27 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 9,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 10,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 7, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 11,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 36, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 12,
                column: "RelacijaID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 13,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 8, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 14,
                column: "RelacijaID",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 15,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 1, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 16,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 20, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 17,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 19, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 18,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 16, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 19,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 10, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 20,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 7, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 21,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 22,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 23,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 22, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 24,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 19, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 25,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 19, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 26,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 9, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 27,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 32, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 28,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 41, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 29,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 21, 27 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 30,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 2, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 31,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 41, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 32,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 36, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 33,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 29, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 34,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 31, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 35,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 21, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 36,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 5, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 37,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 22, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 38,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 36, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 39,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 12, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 40,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 4, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 41,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 36, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 42,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 24, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 43,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 17, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 44,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 45,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 34, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 46,
                columns: new[] { "Ocjena", "RelacijaID" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 47,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 11, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 48,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 49,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 4, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 50,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 32, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 51,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 36, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 52,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 13, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 53,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 34, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 54,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 22, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 55,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 25, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 56,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 12, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 57,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 34, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 58,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 31, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 59,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 32, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 60,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 2, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 61,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 20, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 62,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 40, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 63,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 40, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 64,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 39, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 65,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 7, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 66,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 9, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 67,
                column: "RelacijaID",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 68,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 11, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 69,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 26, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 70,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 13, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 71,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 19, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 72,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 10, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 73,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 15, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 74,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 27, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 75,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 10, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 76,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 9, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 77,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 20, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 78,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 35, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 79,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 8, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 80,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 24, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 81,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 82,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 13, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 83,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 5, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 84,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 25, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 85,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 2, 18 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 86,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 26, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 87,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 23, 2 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 88,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 29, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 89,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 1, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 90,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 33, 2 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 91,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 18, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 92,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 39, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 93,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 21, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 94,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 15, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 95,
                columns: new[] { "Ocjena", "RezervacijaID" },
                values: new object[] { 4, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 96,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 9, 22 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 97,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 98,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 25, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 99,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 25, 28 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 680, DateTimeKind.Local).AddTicks(8764), 34 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(1868), 20 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2041), 102 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 4,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2127), 70 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 5,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2201), 94 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 6,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2281), 37 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 7,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2353), 77 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 8,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2518), 48 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 9,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2612), 110 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 10,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2696), 81 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 11,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2771), 63 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 12,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2844), 116 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 13,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2916), 60 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 14,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(2988), 71 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 15,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3060), 81 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 16,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3133), 39 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 17,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3204), 101 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 18,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3283), 88 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 19,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3356), 7 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 20,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3427), 99 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 21,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3497), 110 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 22,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3568), 66 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 23,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3640), 108 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 24,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3711), 47 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 25,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3849), 61 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 26,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(3930), 104 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 27,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(4002), 59 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 28,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(4075), 30 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 29,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(4147), 70 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 30,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 33, 25, 681, DateTimeKind.Local).AddTicks(4217), 62 });
        }
    }
}
