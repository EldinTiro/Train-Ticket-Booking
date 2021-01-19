using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class db_two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 100,
                columns: new[] { "Naziv", "Sadrzaj" },
                values: new object[] { "Docker test2", "Docker test2" });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikID", "DatumRodjenja", "Email", "GradID", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Status" },
                values: new object[] { 1, new DateTime(2021, 1, 19, 16, 41, 57, 130, DateTimeKind.Local).AddTicks(5420), "desktop@mail.com", null, "test", "desktop", "xvzsyhO6zcxyK6t256yDg/HaSd8=", "oW1iyd4TSryMQRGmVk2nOA==", "test", null });

            migrationBuilder.InsertData(
                table: "Kupci",
                columns: new[] { "KupacID", "DatumRegistracije", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[] { 1, new DateTime(2021, 1, 19, 16, 41, 57, 138, DateTimeKind.Local).AddTicks(7277), "mobile@mail.com", "test", "mobile", "rT4clOAV2Uz3AdtF1yVRPpFugMw=", "DQhvnV49hp+xUSWDgwTb3g==", "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 100,
                columns: new[] { "Naziv", "Sadrzaj" },
                values: new object[] { "Docker test", "Docker test" });
        }
    }
}
