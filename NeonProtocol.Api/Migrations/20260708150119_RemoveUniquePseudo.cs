using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeonProtocol.Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniquePseudo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Players_Pseudo",
                table: "Players");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Players_Pseudo",
                table: "Players",
                column: "Pseudo",
                unique: true);
        }
    }
}
