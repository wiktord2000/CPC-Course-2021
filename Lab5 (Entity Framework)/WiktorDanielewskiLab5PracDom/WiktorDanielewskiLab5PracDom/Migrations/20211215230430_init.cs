using Microsoft.EntityFrameworkCore.Migrations;

namespace WiktorDanielewskiLab5PracDom.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    HeadOffice = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarParts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ProducentID = table.Column<int>(nullable: false),
                    Availability = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarParts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarParts_Producents_ProducentID",
                        column: x => x.ProducentID,
                        principalTable: "Producents",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Opinions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarPartID = table.Column<int>(nullable: false),
                    Header = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Rate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opinions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Opinions_CarParts_CarPartID",
                        column: x => x.CarPartID,
                        principalTable: "CarParts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarPartID = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_CarParts_CarPartID",
                        column: x => x.CarPartID,
                        principalTable: "CarParts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarParts_ProducentID",
                table: "CarParts",
                column: "ProducentID");

            migrationBuilder.CreateIndex(
                name: "IX_Opinions_CarPartID",
                table: "Opinions",
                column: "CarPartID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CarPartID",
                table: "Orders",
                column: "CarPartID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opinions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "CarParts");

            migrationBuilder.DropTable(
                name: "Producents");
        }
    }
}
