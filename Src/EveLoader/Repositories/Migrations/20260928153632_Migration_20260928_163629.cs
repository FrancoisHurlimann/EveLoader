using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260928_163629 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MercenaryTacticalOperations",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    AnarchyImpact = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevelopmentImpact = table.Column<long>(type: "bigint", nullable: false),
                    DungeonID = table.Column<long>(type: "bigint", nullable: false),
                    InfomorphBonus = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MercenaryTacticalOperations", x => x.Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MercenaryTacticalOperations");
        }
    }
}
