using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelatorioFluids.Migrations
{
    /// <inheritdoc />
    public partial class addColumReceita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Receita",
                table: "Dosagem",
                type: "nvarchar(40)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receita",
                table: "Dosagem");
        }
    }
}
