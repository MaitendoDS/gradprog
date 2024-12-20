using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StripsDL.Migrations
{
    /// <inheritdoc />
    public partial class Strips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteur",
                columns: table => new
                {
                    AuteurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteur", x => x.AuteurID);
                });

            migrationBuilder.CreateTable(
                name: "Reeks",
                columns: table => new
                {
                    ReeksID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReeksNaam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reeks", x => x.ReeksID);
                });

            migrationBuilder.CreateTable(
                name: "Uitgeverij",
                columns: table => new
                {
                    UitgeverijID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uitgeverij", x => x.UitgeverijID);
                });

            migrationBuilder.CreateTable(
                name: "Strip",
                columns: table => new
                {
                    StripID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nummer = table.Column<int>(type: "int", nullable: false),
                    ReeksID = table.Column<int>(type: "int", nullable: false),
                    UitgeverijID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strip", x => x.StripID);
                    table.ForeignKey(
                        name: "FK_Strip_Reeks_ReeksID",
                        column: x => x.ReeksID,
                        principalTable: "Reeks",
                        principalColumn: "ReeksID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Strip_Uitgeverij_UitgeverijID",
                        column: x => x.UitgeverijID,
                        principalTable: "Uitgeverij",
                        principalColumn: "UitgeverijID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuteurEFStripEF",
                columns: table => new
                {
                    AuteursAuteurID = table.Column<int>(type: "int", nullable: false),
                    StripsStripID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuteurEFStripEF", x => new { x.AuteursAuteurID, x.StripsStripID });
                    table.ForeignKey(
                        name: "FK_AuteurEFStripEF_Auteur_AuteursAuteurID",
                        column: x => x.AuteursAuteurID,
                        principalTable: "Auteur",
                        principalColumn: "AuteurID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuteurEFStripEF_Strip_StripsStripID",
                        column: x => x.StripsStripID,
                        principalTable: "Strip",
                        principalColumn: "StripID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuteurEFStripEF_StripsStripID",
                table: "AuteurEFStripEF",
                column: "StripsStripID");

            migrationBuilder.CreateIndex(
                name: "IX_Strip_ReeksID",
                table: "Strip",
                column: "ReeksID");

            migrationBuilder.CreateIndex(
                name: "IX_Strip_UitgeverijID",
                table: "Strip",
                column: "UitgeverijID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuteurEFStripEF");

            migrationBuilder.DropTable(
                name: "Auteur");

            migrationBuilder.DropTable(
                name: "Strip");

            migrationBuilder.DropTable(
                name: "Reeks");

            migrationBuilder.DropTable(
                name: "Uitgeverij");
        }
    }
}
