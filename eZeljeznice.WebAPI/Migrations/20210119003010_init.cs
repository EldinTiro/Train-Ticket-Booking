using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    DatumObjave = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Gradovi__B0F3C984A618A983", x => x.GradID);
                });

            migrationBuilder.CreateTable(
                name: "Karte",
                columns: table => new
                {
                    KartaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RedniBrojVagona = table.Column<int>(nullable: true),
                    RedniBrojSjedista = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Karte__EC3FA98E79DF499B", x => x.KartaID);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KupacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(maxLength: 15, nullable: true),
                    LozinkaSalt = table.Column<string>(maxLength: 150, nullable: true),
                    LozinkaHash = table.Column<string>(maxLength: 150, nullable: true),
                    Ime = table.Column<string>(maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(maxLength: 20, nullable: true),
                    DatumRegistracije = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kupci__A9593C7BAA97602F", x => x.KupacID);
                });

            migrationBuilder.CreateTable(
                name: "Obavjestenja",
                columns: table => new
                {
                    ObavjestenjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Obavjest__C87A815D68EC0B31", x => x.ObavjestenjaID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(maxLength: 15, nullable: true),
                    LozinkaSalt = table.Column<string>(maxLength: 150, nullable: true),
                    LozinkaHash = table.Column<string>(maxLength: 150, nullable: true),
                    Ime = table.Column<string>(maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(maxLength: 20, nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    GradID = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Korisnic__80B06D61BA5B40FA", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK__Korisnici__GradI__1BFD2C07",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZeljeznickeStanice",
                columns: table => new
                {
                    ZeljeznickaStanicaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: true),
                    GradID = table.Column<int>(nullable: true),
                    Adresa = table.Column<string>(maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Zeljezni__8FEBF7C4CFE3D4D0", x => x.ZeljeznickaStanicaID);
                    table.ForeignKey(
                        name: "FK__Zeljeznic__GradI__1273C1CD",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relacije",
                columns: table => new
                {
                    RelacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZeljeznickaStanicaODID = table.Column<int>(nullable: true),
                    ZeljeznickaStanicaDOID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Relacije__545AFBE54D92C334", x => x.RelacijaID);
                    table.ForeignKey(
                        name: "FK__Relacije__Zeljez__164452B1",
                        column: x => x.ZeljeznickaStanicaDOID,
                        principalTable: "ZeljeznickeStanice",
                        principalColumn: "ZeljeznickaStanicaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Relacije__Zeljez__15502E78",
                        column: x => x.ZeljeznickaStanicaODID,
                        principalTable: "ZeljeznickeStanice",
                        principalColumn: "ZeljeznickaStanicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Putovanja",
                columns: table => new
                {
                    PutovanjeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelacijaID = table.Column<int>(nullable: true),
                    DatumPolaska = table.Column<DateTime>(type: "date", nullable: true),
                    VrijemePolaska = table.Column<TimeSpan>(nullable: true),
                    VrijemeDolaska = table.Column<TimeSpan>(nullable: true),
                    Cijena = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Putovanj__D47C40F973E85F36", x => x.PutovanjeID);
                    table.ForeignKey(
                        name: "FK__Putovanja__Relac__267ABA7A",
                        column: x => x.RelacijaID,
                        principalTable: "Relacije",
                        principalColumn: "RelacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacID = table.Column<int>(nullable: true),
                    PutovanjeID = table.Column<int>(nullable: true),
                    KartaID = table.Column<int>(nullable: true),
                    DatumRezervacije = table.Column<DateTime>(type: "datetime", nullable: true),
                    Kompletirana = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rezervac__CABA44FDB6409F3A", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Karta__2D27B809",
                        column: x => x.KartaID,
                        principalTable: "Karte",
                        principalColumn: "KartaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Kupac__2B3F6F97",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Putov__2C3393D0",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KupljeneKarte",
                columns: table => new
                {
                    ProdanaKartaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojRacuna = table.Column<string>(maxLength: 10, nullable: true),
                    DatumProdaje = table.Column<DateTime>(type: "date", nullable: true),
                    KupacID = table.Column<int>(nullable: true),
                    RezervacijaID = table.Column<int>(nullable: true),
                    KonacnaCijena = table.Column<double>(nullable: true),
                    Popust = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kupljene__CB8E62892CC2A10F", x => x.ProdanaKartaID);
                    table.ForeignKey(
                        name: "FK__KupljeneK__Kupac__01142BA1",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__KupljeneK__Rezer__4F7CD00D",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pretrage",
                columns: table => new
                {
                    PretragaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelacijaID = table.Column<int>(nullable: true),
                    KupacID = table.Column<int>(nullable: true),
                    Ocjena = table.Column<int>(nullable: true),
                    RezervacijaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pretrage__75C8FA1B23B7AAC2", x => x.PretragaID);
                    table.ForeignKey(
                        name: "FK__Pretrage__KupacI__32E0915F",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Pretrage__Relaci__31EC6D26",
                        column: x => x.RelacijaID,
                        principalTable: "Relacije",
                        principalColumn: "RelacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Pretrage__Rezervacije__01142BA1",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_GradID",
                table: "Korisnici",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_KupljeneKarte_KupacID",
                table: "KupljeneKarte",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_KupljeneKarte_RezervacijaID",
                table: "KupljeneKarte",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretrage_KupacID",
                table: "Pretrage",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretrage_RelacijaID",
                table: "Pretrage",
                column: "RelacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretrage_RezervacijaID",
                table: "Pretrage",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_RelacijaID",
                table: "Putovanja",
                column: "RelacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Relacije_ZeljeznickaStanicaDOID",
                table: "Relacije",
                column: "ZeljeznickaStanicaDOID");

            migrationBuilder.CreateIndex(
                name: "IX_Relacije_ZeljeznickaStanicaODID",
                table: "Relacije",
                column: "ZeljeznickaStanicaODID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KartaID",
                table: "Rezervacije",
                column: "KartaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KupacID",
                table: "Rezervacije",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_PutovanjeID",
                table: "Rezervacije",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_ZeljeznickeStanice_GradID",
                table: "ZeljeznickeStanice",
                column: "GradID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "KupljeneKarte");

            migrationBuilder.DropTable(
                name: "Obavjestenja");

            migrationBuilder.DropTable(
                name: "Pretrage");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Karte");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Putovanja");

            migrationBuilder.DropTable(
                name: "Relacije");

            migrationBuilder.DropTable(
                name: "ZeljeznickeStanice");

            migrationBuilder.DropTable(
                name: "Gradovi");
        }
    }
}
