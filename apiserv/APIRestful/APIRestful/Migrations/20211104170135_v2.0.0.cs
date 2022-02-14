using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIRestful.Migrations
{
    public partial class v200 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    personaid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIF = table.Column<int>(type: "int", nullable: false),
                    NOMBRES = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FECHANAC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOCEL = table.Column<int>(type: "int", nullable: false),
                    NOTEL = table.Column<int>(type: "int", nullable: false),
                    EST = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.personaid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
