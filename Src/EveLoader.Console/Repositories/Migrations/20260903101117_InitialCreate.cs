using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Console.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentsInSpace",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    DungeonID = table.Column<long>(type: "bigint", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    SpawnPointID = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentsInSpace", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SkinrComponentCategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    key = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinrComponentCategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SkinrSlotCategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    key = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinrSlotCategories", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentsInSpace");

            migrationBuilder.DropTable(
                name: "SkinrComponentCategories");

            migrationBuilder.DropTable(
                name: "SkinrSlotCategories");
        }
    }
}
