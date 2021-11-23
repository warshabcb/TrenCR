using Microsoft.EntityFrameworkCore.Migrations;

namespace TrenCR.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boletos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstacionAtlantico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulatina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cfia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UACA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TresRios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstacionCartago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LosAngeles = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SC", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boletos");

            migrationBuilder.DropTable(
                name: "SC");
        }
    }
}
