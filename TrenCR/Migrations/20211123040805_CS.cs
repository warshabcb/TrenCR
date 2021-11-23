using Microsoft.EntityFrameworkCore.Migrations;

namespace TrenCR.Migrations
{
    public partial class CS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LosAngeles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstacionCartago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TresRios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UACA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cfia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulatina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstacionAtlantico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CS");
        }
    }
}
