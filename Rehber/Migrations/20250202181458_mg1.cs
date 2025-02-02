using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rehber.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    KisiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.KisiId);
                });

            migrationBuilder.CreateTable(
                name: "KisiDetaylar",
                columns: table => new
                {
                    KisiDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcKimlik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KisiDetaylar", x => x.KisiDetayId);
                    table.ForeignKey(
                        name: "FK_KisiDetaylar_Kisiler_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisiler",
                        principalColumn: "KisiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KisiDetaylar_KisiId",
                table: "KisiDetaylar",
                column: "KisiId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KisiDetaylar");

            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
