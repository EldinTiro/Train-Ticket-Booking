using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class finalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 1,
                columns: new[] { "Naziv", "Sadrzaj" },
                values: new object[] { "Sarajevo", null });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DatumObjave", "Naziv", "Sadrzaj" },
                values: new object[,]
                {
                    { 10, null, "Info o saobraćaju", "Željeznice Federacije Bosne i Hercegovine od 01.06.2020. godine uspostavljaju željeznički putnički prevoz u lokalnom saobraćaju, a vozovi će voziti u skladu sa izmijenjenim Redom vožnje." },
                    { 9, null, "Putnički voz 2154", "Željeznice FBiH obavještavaju putnike da se do daljnjeg otkazuje saobraćaj lokalnog putničkog voza 2154 koji je saobraćao na relaciji Sarajevo-Zenica sa polaskom iz Sarajeva u 11:02 h i lokalnog putničkog voza 2155 koji je saobraćao na relaciji Zenica-Sarajevo sa polaskom iz Zenice u 11:07 h.    Saobraćaj ovih vozova otkazuje se zbog izvođenja radova na pruzi, odnosno, zbog radova na ugradnji optičkog kabla na pomenutoj dionici.    O ponovnoj uspostavi saobraćaja navedenih vozova, putnici će biti blagovremeno obaviješteni." },
                    { 8, null, "Obavještenje za putnike", "Željeznice FBiH obavještavaju putnike da BH vozovi koji redovno saobraćaju na relacijama Sarajevo-Bihać-Sarajevo i Sarajevo- Banja Luka- Sarajevo do daljnjeg saobraćaju samo na relaciji Sarajevo-Doboj- Sarajevo, zbog vanrednog događaja na dijelu pruge Željeznica Republike Srpske između Doboja i Banja Luke 05.01.2019. godine, kada je došlo do iskakanje iz šina lokalnog putničkog voza Željeznica RS.    Po okončanju posljedica izazvanih ovim vanrednim događajem, ponovo će biti uspostavljena linija Sarajevo-Bihać- Sarajevo i Sarajevo –Banja Luka- Sarajevo.    Putnički saobraćaj na ostalim relacijama odvija se po Redu vožnje ŽFBiH." },
                    { 7, null, "Split", null },
                    { 2, null, "Mostar", null },
                    { 5, null, "Beograd", null },
                    { 4, null, "Banja luka", null },
                    { 3, null, "Tuzla", null },
                    { 6, null, "Zagreb", null }
                });

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
                column: "RedniBrojSjedista",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 7,
                column: "RedniBrojSjedista",
                value: 23);

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
                column: "RedniBrojSjedista",
                value: 15);

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
                column: "RedniBrojVagona",
                value: 5);

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
                column: "RedniBrojVagona",
                value: 4);

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
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 14, 3 });

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
                column: "RedniBrojSjedista",
                value: 10);

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
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2143", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(8652), 14.0, 7 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 6,
                columns: new[] { "BrojRacuna", "DatumProdaje", "RezervacijaID" },
                values: new object[] { "1/19/2156", new DateTime(2021, 1, 19, 20, 33, 25, 683, DateTimeKind.Local).AddTicks(8879), 18 });

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
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2171", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(885), 67.0, 14 });

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
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2116", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1671), 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 29,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2140", new DateTime(2021, 1, 19, 20, 33, 25, 684, DateTimeKind.Local).AddTicks(1789), 58.0 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 4,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 29, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 5,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 6,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 13, 23 });

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
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 34, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 10,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 7, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 11,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 36, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 12,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 13,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 14,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 38, 27 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 20, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 17,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 19, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 18,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 16, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 19,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 10, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 20,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 7, 9 });

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
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 23,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 22, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 24,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 19, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 25,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 19, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 26,
                columns: new[] { "Ocjena", "RezervacijaID" },
                values: new object[] { 3, 14 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 31,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 41, 23 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 29, 10 });

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
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 21, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 36,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 5, 19 });

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
                columns: new[] { "Ocjena", "RezervacijaID" },
                values: new object[] { 3, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 43,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 17, 4 });

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
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 5, 12 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 50,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 32, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 51,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 36, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 52,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 13, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 53,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 54,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 22, 16 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 58,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 31, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 59,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 32, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 60,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 2, 29 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 40, 29 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 39, 4 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 12, 5 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 19, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 72,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 73,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 15, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 74,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 27, 3 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 2, 18 });

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
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 29, 16 });

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
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 33, 2 });

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
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 21, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 94,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 15, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 95,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 17, 20 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 1,
                columns: new[] { "Naziv", "Sadrzaj" },
                values: new object[] { "Docker test2", "Docker test2" });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 1,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 25, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 2,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 23, 6 });

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
                values: new object[] { 19, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 5,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 16, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 6,
                column: "RedniBrojSjedista",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 7,
                column: "RedniBrojSjedista",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 8,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 9,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 22, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 10,
                column: "RedniBrojSjedista",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 11,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 18, 3 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 12,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 19, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 13,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 14,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 15,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 28, 8 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 16,
                column: "RedniBrojVagona",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 17,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 29, 3 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 18,
                column: "RedniBrojVagona",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 19,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 20,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 21,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 15, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 22,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 29, 4 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 23,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 24,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 16, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 25,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 26, 5 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 26,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 13, 7 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 27,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 13, 9 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 28,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 29,
                columns: new[] { "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 30,
                column: "RedniBrojSjedista",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 818, DateTimeKind.Local).AddTicks(5399), "8yFCvkTQ9O7XL7UxtttDbTg8VHQ=", "Fl1ORDsYE7AQ+KqpMb4TLA==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 826, DateTimeKind.Local).AddTicks(1826), "3/CEUWT/hr/FXWCGeHibCvzcwYI=", "hOm+EA/VYFV2M3GXF0t0Fg==" });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 1,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2198", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(359), 75.0, 5 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 2,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2104", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(4119), 71.0, 18 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 3,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2168", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(4476), 3.0, 26 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 4,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2123", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(4633), 25.0, 26 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 5,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2126", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(4751), 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 6,
                columns: new[] { "BrojRacuna", "DatumProdaje", "RezervacijaID" },
                values: new object[] { "1/19/2150", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(4877), 20 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 7,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2144", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(4993), 64.0, 23 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 8,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2190", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(5108), 17.0, 29 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 9,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2105", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(5223), 20.0, 24 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 10,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2152", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(5344), 54.0, 5 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 11,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2179", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(5461), 68.0, 11 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 12,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2151", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(5577), 25.0, 18 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 13,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2126", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(5804), 35.0, 23 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 14,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2178", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(5969), 8.0, 5 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 15,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2161", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(6090), 24.0, 8 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 16,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2148", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(6204), 33.0, 14 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 17,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2107", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(6319), 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 18,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2114", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(6442), 42.0, 26 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 19,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2139", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(6559), 72.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 20,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2144", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(6676), 55.0, 9 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 21,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2113", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(6876), 70.0, 9 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 22,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2158", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7009), 37.0, 24 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 23,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2191", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7126), 10.0, 27 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 24,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2107", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7369), 36.0, 10 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 25,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2193", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7503), 16.0, 14 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 26,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2121", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7618), 35.0, 26 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 27,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2112", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7733), 53.0, 27 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 28,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2173", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7849), 20.0, 18 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 29,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena" },
                values: new object[] { "1/19/2175", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(7963), 21.0 });

            migrationBuilder.UpdateData(
                table: "KupljeneKarte",
                keyColumn: "ProdanaKartaID",
                keyValue: 30,
                columns: new[] { "BrojRacuna", "DatumProdaje", "KonacnaCijena", "RezervacijaID" },
                values: new object[] { "1/19/2108", new DateTime(2021, 1, 19, 20, 26, 15, 834, DateTimeKind.Local).AddTicks(8080), 32.0, 5 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 1,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 33, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 2,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 22, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 3,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 31, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 4,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 24, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 5,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 19, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 6,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 4, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 7,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 28, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 8,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 26, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 9,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 1, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 10,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 17, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 11,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 12,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 36, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 13,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 30, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 14,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 20, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 15,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 2, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 16,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 21, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 17,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 7, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 18,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 37, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 19,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 20,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 21,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 22 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 22,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 10, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 23,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 24,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 25, 27 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 25,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 26,
                columns: new[] { "Ocjena", "RezervacijaID" },
                values: new object[] { 4, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 27,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 19, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 28,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 29,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 40, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 30,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 24, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 31,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 34, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 32,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 40, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 33,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 34,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 38, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 35,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 15, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 36,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 2, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 37,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 32, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 38,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 26, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 39,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 28, 29 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 40,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 38, 3 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 41,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 32, 22 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 42,
                columns: new[] { "Ocjena", "RezervacijaID" },
                values: new object[] { 4, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 43,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 31, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 44,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 12, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 45,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 1, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 46,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 47,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 25, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 48,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 49,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 32, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 50,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 19, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 51,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 6, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 52,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 28, 16 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 53,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 41, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 54,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 23, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 55,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 20, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 56,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 33, 27 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 57,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 39, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 58,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 18, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 59,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 19, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 60,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 6, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 61,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 17, 18 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 62,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 11, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 63,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 11, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 64,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 5, 12 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 65,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 38, 6 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 66,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 37, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 67,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 36, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 68,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 9, 17 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 69,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 30, 24 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 70,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 8, 27 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 71,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 13, 11 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 72,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 8, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 73,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 40, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 74,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 5, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 75,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 76,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 27, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 77,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 29, 9 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 78,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 14, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 79,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 1, 25 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 80,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 28, 22 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 81,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 37, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 82,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 83,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 11, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 84,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 26, 26 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 85,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 86,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 4, 13, 13 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 87,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 21, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 88,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 25, 7 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 89,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 7, 20 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 90,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 5, 18 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 91,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 11, 28 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 92,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 38, 21 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 93,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 7, 14 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 94,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 40, 1 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 95,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 18, 23 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 96,
                columns: new[] { "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 37, 19 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 97,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 17, 15 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 98,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Pretrage",
                keyColumn: "PretragaID",
                keyValue: 99,
                columns: new[] { "RelacijaID", "RezervacijaID" },
                values: new object[] { 9, 14 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(3702), 70 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7163), 59 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7421), 70 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 4,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7526), 85 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 5,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7597), 125 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 6,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7674), 24 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 7,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7743), 62 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 8,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7810), 79 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 9,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7879), 122 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 10,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(7949), 4 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 11,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8018), 66 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 12,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8085), 29 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 13,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8153), 109 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 14,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8219), 23 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 15,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8286), 93 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 16,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8353), 21 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 17,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8420), 31 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 18,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8492), 28 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 19,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8561), 60 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 20,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8694), 74 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 21,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8786), 3 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 22,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8858), 13 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 23,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8929), 38 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 24,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(8997), 57 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 25,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(9066), 53 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 26,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(9135), 86 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 27,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(9204), 89 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 28,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(9271), 9 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 29,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(9340), 48 });

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 30,
                columns: new[] { "DatumRezervacije", "PutovanjeID" },
                values: new object[] { new DateTime(2021, 1, 19, 20, 26, 15, 831, DateTimeKind.Local).AddTicks(9409), 121 });
        }
    }
}
