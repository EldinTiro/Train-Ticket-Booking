using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eZeljeznice.WebAPI.Migrations
{
    public partial class initial : Migration
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

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DatumObjave", "Naziv", "Sadrzaj" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(4382), "Sarajevo", null },
                    { 2, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(5179), "Mostar", null },
                    { 3, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(5235), "Tuzla", null },
                    { 4, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(5261), "Banja luka", null },
                    { 5, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(5282), "Beograd", null },
                    { 6, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(5308), "Zagreb", null },
                    { 7, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(5330), "Split", null },
                    { 8, new DateTime(2021, 2, 17, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(5994), "Obavještenje za putnike", "Željeznice FBiH obavještavaju putnike da BH vozovi koji redovno saobraćaju na relacijama Sarajevo-Bihać-Sarajevo i Sarajevo- Banja Luka- Sarajevo do daljnjeg saobraćaju samo na relaciji Sarajevo-Doboj- Sarajevo, zbog vanrednog događaja na dijelu pruge Željeznica Republike Srpske između Doboja i Banja Luke 05.01.2019. godine, kada je došlo do iskakanje iz šina lokalnog putničkog voza Željeznica RS.    Po okončanju posljedica izazvanih ovim vanrednim događajem, ponovo će biti uspostavljena linija Sarajevo-Bihać- Sarajevo i Sarajevo –Banja Luka- Sarajevo.    Putnički saobraćaj na ostalim relacijama odvija se po Redu vožnje ŽFBiH." },
                    { 9, new DateTime(2021, 2, 19, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(6104), "Putnički voz 2154", "Željeznice FBiH obavještavaju putnike da se do daljnjeg otkazuje saobraćaj lokalnog putničkog voza 2154 koji je saobraćao na relaciji Sarajevo-Zenica sa polaskom iz Sarajeva u 11:02 h i lokalnog putničkog voza 2155 koji je saobraćao na relaciji Zenica-Sarajevo sa polaskom iz Zenice u 11:07 h.    Saobraćaj ovih vozova otkazuje se zbog izvođenja radova na pruzi, odnosno, zbog radova na ugradnji optičkog kabla na pomenutoj dionici.    O ponovnoj uspostavi saobraćaja navedenih vozova, putnici će biti blagovremeno obaviješteni." },
                    { 10, new DateTime(2021, 2, 18, 0, 13, 28, 196, DateTimeKind.Local).AddTicks(6166), "Info o saobraćaju", "Željeznice Federacije Bosne i Hercegovine od 01.06.2020. godine uspostavljaju željeznički putnički prevoz u lokalnom saobraćaju, a vozovi će voziti u skladu sa izmijenjenim Redom vožnje." }
                });

            migrationBuilder.InsertData(
                table: "Karte",
                columns: new[] { "KartaID", "RedniBrojSjedista", "RedniBrojVagona" },
                values: new object[,]
                {
                    { 18, 12, 5 },
                    { 19, 21, 1 },
                    { 20, 17, 2 },
                    { 21, 4, 6 },
                    { 22, 8, 5 },
                    { 23, 16, 3 },
                    { 28, 5, 8 },
                    { 25, 2, 9 },
                    { 26, 2, 9 },
                    { 27, 6, 8 },
                    { 17, 15, 4 },
                    { 29, 18, 8 },
                    { 30, 10, 4 },
                    { 24, 15, 9 },
                    { 16, 7, 5 },
                    { 11, 2, 1 },
                    { 14, 28, 1 },
                    { 13, 7, 5 },
                    { 12, 21, 8 },
                    { 10, 27, 5 },
                    { 9, 10, 9 },
                    { 8, 24, 6 },
                    { 7, 3, 2 },
                    { 6, 24, 8 },
                    { 5, 16, 4 },
                    { 4, 12, 5 },
                    { 3, 26, 4 },
                    { 2, 23, 6 },
                    { 1, 26, 3 },
                    { 15, 16, 1 }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikID", "DatumRodjenja", "Email", "GradID", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Status" },
                values: new object[] { 1, new DateTime(2021, 2, 17, 0, 13, 28, 190, DateTimeKind.Local).AddTicks(6357), "desktop@mail.com", null, "test", "desktop", "biXFn0TWom1Qi5z9fuN4R9kGsUI=", "8NxoXw6zHuXwv932m0u6Zg==", "test", null });

            migrationBuilder.InsertData(
                table: "Kupci",
                columns: new[] { "KupacID", "DatumRegistracije", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[] { 1, new DateTime(2021, 2, 17, 0, 13, 28, 195, DateTimeKind.Local).AddTicks(8598), "mobile@mail.com", "test", "mobile", "99f/lVZTW43c0SAirxB0YGFC0Qg=", "/rFM+9xYdeyNLkPAyXXYDA==", "test" });

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
                    { 1, 2, 1 },
                    { 11, 6, 2 },
                    { 17, 6, 3 },
                    { 23, 6, 4 },
                    { 29, 6, 5 },
                    { 31, 1, 6 },
                    { 32, 2, 6 },
                    { 33, 3, 6 },
                    { 34, 4, 6 },
                    { 35, 5, 6 },
                    { 6, 7, 1 },
                    { 12, 7, 2 },
                    { 18, 7, 3 },
                    { 24, 7, 4 },
                    { 30, 7, 5 },
                    { 36, 7, 6 },
                    { 37, 1, 7 },
                    { 38, 2, 7 },
                    { 39, 3, 7 },
                    { 40, 4, 7 },
                    { 5, 6, 1 },
                    { 41, 5, 7 },
                    { 28, 4, 5 },
                    { 26, 2, 5 },
                    { 7, 1, 2 },
                    { 51, 2, 1 },
                    { 52, 2, 1 },
                    { 53, 1, 2 },
                    { 2, 3, 1 },
                    { 8, 3, 2 },
                    { 13, 1, 3 },
                    { 14, 2, 3 },
                    { 3, 4, 1 },
                    { 9, 4, 2 },
                    { 15, 4, 3 },
                    { 19, 1, 4 },
                    { 20, 2, 4 },
                    { 21, 3, 4 },
                    { 4, 5, 1 },
                    { 10, 5, 2 },
                    { 16, 5, 3 },
                    { 22, 5, 4 },
                    { 25, 1, 5 },
                    { 27, 3, 5 },
                    { 42, 6, 7 }
                });

            migrationBuilder.InsertData(
                table: "Putovanja",
                columns: new[] { "PutovanjeID", "Cijena", "DatumPolaska", "RelacijaID", "VrijemeDolaska", "VrijemePolaska" },
                values: new object[,]
                {
                    { 1, 5.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 6, 8.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 119, 24.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 35, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 77, 22.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 35, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 35, 22.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 35, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 118, 24.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 34, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 76, 22.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 34, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 34, 22.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 34, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 117, 23.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 33, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 75, 21.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 33, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 33, 21.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 33, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 116, 23.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 32, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 74, 21.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 32, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 32, 21.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 32, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 48, 8.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 115, 22.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 31, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 31, 20.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 31, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 113, 21.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 29, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 71, 19.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 29, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 29, 19.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 29, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 107, 18.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 23, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 65, 16.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 23, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 23, 16.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 23, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 101, 15.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 59, 13.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 17, 13.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 95, 12.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 53, 10.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 11, 10.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 73, 20.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 31, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 90, 10.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 12, 11.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 54, 11.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 42, 26.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 42, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 125, 27.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 41, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 83, 25.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 41, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 41, 25.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 41, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 124, 27.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 40, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 82, 25.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 40, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 40, 25.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 40, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 123, 26.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 39, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 81, 24.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 39, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 39, 24.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 39, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 122, 26.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 38, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 80, 24.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 38, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 38, 24.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 38, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 121, 25.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 37, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 79, 23.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 37, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 37, 23.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 37, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 120, 25.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 36, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 78, 23.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 36, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 36, 23.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 36, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 114, 22.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 30, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 72, 20.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 30, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 30, 20.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 30, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 108, 19.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 24, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 66, 17.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 24, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 24, 17.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 24, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 102, 16.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 60, 14.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 18, 14.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 96, 13.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 89, 9.9499999999999993, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 84, 26.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 42, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 47, 7.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 112, 21.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 28, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 57, 12.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 15, 12.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 93, 11.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 51, 9.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 9, 9.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 87, 8.9499999999999993, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 45, 6.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 3, 6.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 98, 14.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 56, 12.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 14, 12.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 97, 13.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 55, 11.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 99, 14.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 13, 11.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 50, 9.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 8, 9.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 129, 28.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 86, 8.4499999999999993, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 44, 6.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 2, 6.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 91, 10.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 49, 8.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 7, 8.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 128, 28.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 127, 28.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 85, 7.9500000000000002, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 43, 5.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 92, 11.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 19, 14.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 61, 14.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 103, 16.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 70, 19.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 28, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 28, 19.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 28, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 111, 20.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 27, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 69, 18.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 27, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 27, 18.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 27, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 110, 20.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 26, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 68, 18.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 26, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 26, 18.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 26, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 109, 19.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 25, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 67, 17.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 25, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 25, 17.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 25, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 106, 18.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 22, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 64, 16.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 22, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 22, 16.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 22, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 100, 15.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 58, 13.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 16, 13.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 94, 12.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 52, 10.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 10, 10.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 88, 9.4499999999999993, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 46, 7.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 4, 7.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 105, 17.949999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 21, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 63, 15.75, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 21, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 21, 15.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 21, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 104, 17.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 62, 15.25, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0) },
                    { 20, 15.0, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 5, 7.5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 3, 30, 0, 0) },
                    { 126, 28.449999999999999, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 42, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 5, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Rezervacije",
                columns: new[] { "RezervacijaID", "DatumRezervacije", "KartaID", "Kompletirana", "KupacID", "PutovanjeID" },
                values: new object[,]
                {
                    { 13, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4723), 13, true, 1, 43 },
                    { 28, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(5075), 28, false, 1, 82 },
                    { 10, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4602), 10, true, 1, 39 },
                    { 6, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4509), 6, true, 1, 39 },
                    { 23, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4957), 23, false, 1, 120 },
                    { 3, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4433), 3, true, 1, 120 },
                    { 12, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4648), 12, true, 1, 36 },
                    { 18, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4840), 18, true, 1, 24 },
                    { 5, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4483), 5, true, 1, 24 },
                    { 14, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4748), 14, true, 1, 96 },
                    { 2, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4344), 2, true, 1, 48 },
                    { 21, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4911), 21, false, 1, 118 },
                    { 20, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4886), 20, false, 1, 117 },
                    { 26, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(5028), 26, false, 1, 33 },
                    { 29, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(5098), 29, false, 1, 31 },
                    { 24, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4980), 24, false, 1, 71 },
                    { 15, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4770), 15, true, 1, 47 },
                    { 30, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(5164), 30, false, 1, 69 },
                    { 11, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4625), 11, true, 1, 106 },
                    { 25, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(5004), 25, false, 1, 4 },
                    { 1, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(1997), 1, true, 1, 51 },
                    { 8, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4554), 8, true, 1, 87 },
                    { 19, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4863), 19, true, 1, 45 },
                    { 4, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4460), 4, true, 1, 56 },
                    { 17, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4815), 17, true, 1, 97 },
                    { 9, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4577), 9, true, 1, 97 },
                    { 16, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4793), 16, true, 1, 50 },
                    { 7, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4532), 7, true, 1, 44 },
                    { 22, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(4934), 22, false, 1, 125 },
                    { 27, new DateTime(2021, 2, 17, 0, 13, 28, 199, DateTimeKind.Local).AddTicks(5051), 27, false, 1, 42 }
                });

            migrationBuilder.InsertData(
                table: "KupljeneKarte",
                columns: new[] { "ProdanaKartaID", "BrojRacuna", "DatumProdaje", "KonacnaCijena", "KupacID", "Popust", "RezervacijaID" },
                values: new object[,]
                {
                    { 14, "2/17/2101", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5072), 31.0, 1, 0, 13 },
                    { 5, "2/17/2193", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4496), 17.0, 1, 0, 10 },
                    { 25, "2/17/2113", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5959), 11.0, 1, 0, 25 },
                    { 23, "2/17/2114", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5798), 74.0, 1, 0, 23 },
                    { 30, "2/17/2111", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(6704), 33.0, 1, 0, 30 },
                    { 13, "2/17/2136", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5025), 32.0, 1, 0, 15 },
                    { 9, "2/17/2173", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4822), 32.0, 1, 0, 18 },
                    { 24, "2/17/2119", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5906), 67.0, 1, 0, 24 },
                    { 16, "2/17/2155", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5166), 54.0, 1, 0, 29 },
                    { 29, "2/17/2107", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(6450), 16.0, 1, 0, 29 },
                    { 8, "2/17/2147", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4713), 59.0, 1, 0, 5 },
                    { 7, "2/17/2191", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4664), 57.0, 1, 0, 5 },
                    { 1, "2/17/2137", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(407), 64.0, 1, 0, 26 },
                    { 26, "2/17/2130", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(6009), 75.0, 1, 0, 26 },
                    { 20, "2/17/2137", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5405), 1.0, 1, 0, 20 },
                    { 10, "2/17/2118", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4878), 58.0, 1, 0, 14 },
                    { 4, "2/17/2182", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4299), 62.0, 1, 0, 21 },
                    { 21, "2/17/2126", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5457), 48.0, 1, 0, 21 },
                    { 19, "2/17/2167", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5352), 18.0, 1, 0, 17 },
                    { 6, "2/17/2172", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4611), 63.0, 1, 0, 28 },
                    { 11, "2/17/2179", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4928), 32.0, 1, 0, 2 },
                    { 15, "2/17/2170", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5119), 71.0, 1, 0, 13 },
                    { 17, "2/17/2101", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5214), 17.0, 1, 0, 13 },
                    { 12, "2/17/2129", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4977), 30.0, 1, 0, 16 },
                    { 22, "2/17/2183", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5568), 54.0, 1, 0, 22 },
                    { 18, "2/17/2101", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(5263), 1.0, 1, 0, 13 },
                    { 27, "2/17/2176", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(6141), 9.0, 1, 0, 27 },
                    { 28, "2/17/2122", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(6351), 63.0, 1, 0, 28 },
                    { 3, "2/17/2179", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4210), 57.0, 1, 0, 22 },
                    { 2, "2/17/2151", new DateTime(2021, 2, 17, 0, 13, 28, 201, DateTimeKind.Local).AddTicks(4093), 9.0, 1, 0, 22 }
                });

            migrationBuilder.InsertData(
                table: "Pretrage",
                columns: new[] { "PretragaID", "KupacID", "Ocjena", "RelacijaID", "RezervacijaID" },
                values: new object[,]
                {
                    { 7, 1, 3, 14, 28 },
                    { 18, 1, 4, 36, 22 },
                    { 99, 1, 4, 25, 5 },
                    { 84, 1, 4, 26, 5 },
                    { 27, 1, 4, 22, 22 },
                    { 68, 1, 3, 34, 22 },
                    { 51, 1, 3, 16, 5 },
                    { 96, 1, 4, 24, 22 },
                    { 22, 1, 4, 9, 27 },
                    { 86, 1, 3, 29, 14 },
                    { 53, 1, 3, 9, 14 },
                    { 34, 1, 3, 10, 27 },
                    { 3, 1, 3, 13, 14 },
                    { 75, 1, 3, 29, 2 },
                    { 54, 1, 3, 17, 2 },
                    { 49, 1, 4, 20, 2 },
                    { 92, 1, 4, 19, 22 },
                    { 4, 1, 3, 15, 18 },
                    { 11, 1, 3, 25, 12 },
                    { 14, 1, 4, 40, 22 },
                    { 61, 1, 3, 10, 28 },
                    { 45, 1, 3, 34, 10 },
                    { 44, 1, 4, 27, 10 },
                    { 35, 1, 4, 17, 10 },
                    { 30, 1, 3, 29, 10 },
                    { 16, 1, 4, 17, 10 },
                    { 74, 1, 4, 31, 28 },
                    { 77, 1, 4, 13, 6 },
                    { 2, 1, 3, 20, 6 },
                    { 67, 1, 3, 28, 18 },
                    { 91, 1, 4, 26, 23 },
                    { 55, 1, 3, 7, 23 },
                    { 39, 1, 4, 36, 23 },
                    { 13, 1, 4, 22, 2 },
                    { 48, 1, 4, 35, 3 },
                    { 24, 1, 4, 8, 3 },
                    { 23, 1, 3, 14, 3 },
                    { 62, 1, 3, 8, 12 },
                    { 40, 1, 4, 10, 12 },
                    { 21, 1, 4, 38, 12 },
                    { 69, 1, 4, 39, 23 },
                    { 33, 1, 3, 13, 23 },
                    { 80, 1, 3, 25, 20 },
                    { 29, 1, 4, 27, 21 },
                    { 73, 1, 4, 16, 8 },
                    { 1, 1, 4, 27, 8 },
                    { 63, 1, 4, 19, 19 },
                    { 42, 1, 4, 4, 4 },
                    { 70, 1, 4, 27, 17 },
                    { 46, 1, 4, 8, 17 },
                    { 43, 1, 4, 37, 17 },
                    { 19, 1, 3, 3, 9 },
                    { 5, 1, 3, 17, 9 },
                    { 71, 1, 3, 27, 16 },
                    { 57, 1, 4, 10, 16 },
                    { 78, 1, 3, 8, 8 },
                    { 38, 1, 4, 33, 16 },
                    { 28, 1, 4, 3, 16 },
                    { 20, 1, 3, 15, 16 },
                    { 10, 1, 3, 17, 16 },
                    { 95, 1, 4, 2, 7 },
                    { 59, 1, 4, 40, 7 },
                    { 58, 1, 4, 26, 7 },
                    { 15, 1, 4, 26, 7 },
                    { 8, 1, 3, 16, 7 },
                    { 6, 1, 3, 11, 7 },
                    { 26, 1, 4, 41, 13 },
                    { 25, 1, 3, 9, 13 },
                    { 32, 1, 3, 15, 16 },
                    { 89, 1, 3, 13, 8 },
                    { 98, 1, 4, 13, 8 },
                    { 31, 1, 3, 22, 1 },
                    { 94, 1, 3, 35, 20 },
                    { 90, 1, 4, 13, 20 },
                    { 85, 1, 4, 28, 20 },
                    { 66, 1, 4, 13, 27 },
                    { 72, 1, 3, 5, 20 },
                    { 83, 1, 4, 28, 26 },
                    { 52, 1, 3, 37, 26 },
                    { 93, 1, 3, 2, 29 },
                    { 36, 1, 4, 14, 29 },
                    { 12, 1, 3, 7, 29 },
                    { 60, 1, 4, 4, 24 },
                    { 47, 1, 3, 30, 24 },
                    { 97, 1, 4, 37, 15 },
                    { 81, 1, 4, 3, 15 },
                    { 37, 1, 3, 36, 15 },
                    { 17, 1, 4, 37, 15 },
                    { 87, 1, 3, 4, 11 },
                    { 79, 1, 3, 9, 11 },
                    { 65, 1, 3, 31, 11 },
                    { 56, 1, 4, 10, 11 },
                    { 50, 1, 3, 31, 11 },
                    { 64, 1, 4, 5, 25 },
                    { 9, 1, 3, 3, 25 },
                    { 82, 1, 3, 12, 1 },
                    { 41, 1, 4, 31, 1 },
                    { 76, 1, 4, 36, 21 },
                    { 88, 1, 3, 16, 27 }
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
