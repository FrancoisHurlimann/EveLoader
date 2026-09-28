using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260928_163358 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Masteries",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masteries", x => x.Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Masteries");
        }
    }
}
