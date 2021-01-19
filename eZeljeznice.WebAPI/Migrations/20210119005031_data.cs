using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DatumObjave", "Naziv", "Sadrzaj" },
                values: new object[] { 100, null, "Docker test", "Docker test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gradovi",
                keyColumn: "GradID",
                keyValue: 100);
        }
    }
}
