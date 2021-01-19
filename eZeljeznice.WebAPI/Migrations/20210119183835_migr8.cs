using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class migr8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Karte",
                columns: new[] { "KartaID", "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[,]
                {
                    { 1, 28, 4 },
                    { 30, 22, 9 },
                    { 29, 3, 5 },
                    { 28, 17, 9 },
                    { 27, 4, 4 },
                    { 26, 20, 9 },
                    { 25, 1, 2 },
                    { 24, 17, 1 },
                    { 23, 13, 9 },
                    { 22, 11, 3 },
                    { 21, 11, 5 },
                    { 20, 23, 7 },
                    { 19, 26, 2 },
                    { 18, 13, 1 },
                    { 17, 10, 7 },
                    { 16, 12, 6 },
                    { 15, 15, 7 },
                    { 14, 7, 3 },
                    { 13, 20, 8 },
                    { 12, 9, 3 },
                    { 11, 19, 9 },
                    { 10, 14, 6 },
                    { 9, 9, 1 },
                    { 8, 8, 4 },
                    { 7, 6, 9 },
                    { 6, 18, 5 },
                    { 5, 12, 1 },
                    { 4, 10, 6 },
                    { 3, 22, 5 },
                    { 2, 25, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 19, 38, 34, 634, DateTimeKind.Local).AddTicks(1162), "1LYVO8P7dJB9cQWUW3MYqQdeHAk=", "DboeQRhalawrTzyO2xvLxw==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 19, 38, 34, 645, DateTimeKind.Local).AddTicks(1072), "WmjFbl4kTDGJ8cv2j0S0fWP/VD4=", "1FEC8hQQ90X2D8pEfvQNQw==" });

            migrationBuilder.InsertData(
                table: "Rezervacije",
                columns: new[] { "RezervacijaID", "DatumRezervacije", "KartaID", "Kompletirana", "KupacID", "PutovanjeID" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(1678), 1, true, 1, 39 },
                    { 28, new DateTime(2021, 1, 19, 19, 38, 34, 654, DateTimeKind.Local).AddTicks(532), 28, true, 1, 119 },
                    { 27, new DateTime(2021, 1, 19, 19, 38, 34, 654, DateTimeKind.Local).AddTicks(398), 27, true, 1, 61 },
                    { 26, new DateTime(2021, 1, 19, 19, 38, 34, 654, DateTimeKind.Local).AddTicks(256), 26, true, 1, 57 },
                    { 25, new DateTime(2021, 1, 19, 19, 38, 34, 654, DateTimeKind.Local).AddTicks(110), 25, true, 1, 3 },
                    { 24, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9987), 24, true, 1, 40 },
                    { 23, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9880), 23, true, 1, 34 },
                    { 22, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9771), 22, true, 1, 14 },
                    { 21, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9656), 21, true, 1, 26 },
                    { 20, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9524), 20, true, 1, 95 },
                    { 19, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9390), 19, true, 1, 108 },
                    { 18, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9245), 18, true, 1, 123 },
                    { 17, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(9098), 17, true, 1, 74 },
                    { 16, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(8981), 16, true, 1, 14 },
                    { 15, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(8839), 15, true, 1, 36 },
                    { 14, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(8616), 14, true, 1, 93 },
                    { 13, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(8482), 13, true, 1, 35 },
                    { 12, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(8345), 12, true, 1, 16 },
                    { 11, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(8207), 11, true, 1, 69 },
                    { 10, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(8091), 10, true, 1, 21 },
                    { 9, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(7978), 9, true, 1, 68 },
                    { 8, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(7872), 8, true, 1, 53 },
                    { 7, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(7752), 7, true, 1, 23 },
                    { 6, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(7616), 6, true, 1, 125 },
                    { 5, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(7464), 5, true, 1, 89 },
                    { 4, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(7316), 4, true, 1, 86 },
                    { 3, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(7166), 3, true, 1, 15 },
                    { 2, new DateTime(2021, 1, 19, 19, 38, 34, 653, DateTimeKind.Local).AddTicks(6911), 2, true, 1, 7 },
                    { 29, new DateTime(2021, 1, 19, 19, 38, 34, 654, DateTimeKind.Local).AddTicks(654), 29, true, 1, 26 },
                    { 30, new DateTime(2021, 1, 19, 19, 38, 34, 654, DateTimeKind.Local).AddTicks(764), 30, true, 1, 57 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Karte",
                keyColumn: "KartaID",
                keyValue: 30);

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
        }
    }
}
