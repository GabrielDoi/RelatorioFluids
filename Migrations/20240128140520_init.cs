using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelatorioFluids.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dosagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Masseira = table.Column<int>(type: "int", nullable: false),
                    QtdOX328 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoteOX328 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdEN328 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoteEN328 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdSO102 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoteSO102 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdMF3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoteMF3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosagem", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dosagem");
        }
    }
}
