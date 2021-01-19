using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class migr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 100);

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DatumObjave", "Naziv", "Sadrzaj" },
                values: new object[] { 1, null, "Docker test2", "Docker test2" });

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

            migrationBuilder.InsertData(
                table: "ZeljeznickeStanice",
                columns: new[] { "ZeljeznickaStanicaID", "Adresa", "Email", "GradID", "Naziv", "Telefon" },
                values: new object[,]
                {
                    { 1, "Halida Kajtaza 10", "ztsarajevo@hotmail.com", 1, "Ž.S. Sarajevo", "033251251" },
                    { 2, "Ložionička 12", "zsmostar@hotmail.com", 1, "Ž.S. Mostar", "036565565" },
                    { 3, "Radnička 23", "zttuzla@hotmail.com", 1, "Ž.S. Tuzla", "035458754" },
                    { 4, "Trg pobjede 56", "ztbanjaluka@hotmail.com", 1, "Ž.S. Banja Luka", "051478724" },
                    { 5, "Strojarska cesta 11", "zkzagreb@hotmail.com", 1, "Ž.S. Zagreb", "+385013333200" },
                    { 6, "Dubrovačka 11", "zksplit@hotmail.com", 1, "Ž.S. Split", "+385078924233" },
                    { 7, "Jurija Gagarina 33", "ztbeograd@hotmail.com", 1, "Ž.S. Beograd", "+381112222300" }
                });

            migrationBuilder.InsertData(
                table: "Relacije",
                columns: new[] { "RelacijaID", "ZeljeznickaStanicaDOID", "ZeljeznickaStanicaODID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 13, 6, 2 },
                    { 20, 6, 3 },
                    { 27, 6, 4 },
                    { 34, 6, 5 },
                    { 36, 1, 6 },
                    { 37, 2, 6 },
                    { 38, 3, 6 },
                    { 39, 4, 6 },
                    { 40, 5, 6 },
                    { 41, 6, 6 },
                    { 7, 7, 1 },
                    { 14, 7, 2 },
                    { 21, 7, 3 },
                    { 28, 7, 4 },
                    { 35, 7, 5 },
                    { 42, 7, 6 },
                    { 43, 1, 7 },
                    { 44, 2, 7 },
                    { 45, 3, 7 },
                    { 46, 4, 7 },
                    { 47, 5, 7 },
                    { 6, 6, 1 },
                    { 48, 6, 7 },
                    { 33, 5, 5 },
                    { 31, 3, 5 },
                    { 2, 2, 1 },
                    { 8, 1, 2 },
                    { 9, 2, 2 },
                    { 3, 3, 1 },
                    { 10, 3, 2 },
                    { 15, 1, 3 },
                    { 16, 2, 3 },
                    { 17, 3, 3 },
                    { 4, 4, 1 },
                    { 11, 4, 2 },
                    { 18, 4, 3 },
                    { 22, 1, 4 },
                    { 23, 2, 4 },
                    { 24, 3, 4 },
                    { 25, 4, 4 },
                    { 5, 5, 1 },
                    { 12, 5, 2 },
                    { 19, 5, 3 },
                    { 26, 5, 4 },
                    { 29, 1, 5 },
                    { 30, 2, 5 },
                    { 32, 4, 5 },
                    { 49, 7, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Relacije",
                keyColumn: "RelacijaID",
                keyValue: 42);

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

            migrationBuilder.DeleteData(
                table: "ZeljeznickeStanice",
                keyColumn: "ZeljeznickaStanicaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ZeljeznickeStanice",
                keyColumn: "ZeljeznickaStanicaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ZeljeznickeStanice",
                keyColumn: "ZeljeznickaStanicaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ZeljeznickeStanice",
                keyColumn: "ZeljeznickaStanicaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ZeljeznickeStanice",
                keyColumn: "ZeljeznickaStanicaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ZeljeznickeStanice",
                keyColumn: "ZeljeznickaStanicaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ZeljeznickeStanice",
                keyColumn: "ZeljeznickaStanicaID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DatumObjave", "Naziv", "Sadrzaj" },
                values: new object[] { 100, null, "Docker test2", "Docker test2" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 16, 41, 57, 130, DateTimeKind.Local).AddTicks(5420), "xvzsyhO6zcxyK6t256yDg/HaSd8=", "oW1iyd4TSryMQRGmVk2nOA==" });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 1, 19, 16, 41, 57, 138, DateTimeKind.Local).AddTicks(7277), "rT4clOAV2Uz3AdtF1yVRPpFugMw=", "DQhvnV49hp+xUSWDgwTb3g==" });
        }
    }
}
