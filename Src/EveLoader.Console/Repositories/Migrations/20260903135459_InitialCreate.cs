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
                name: "AgentTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    BloodlineID = table.Column<long>(type: "bigint", nullable: false),
                    Charisma = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: false),
                    Intelligence = table.Column<long>(type: "bigint", nullable: false),
                    Memory = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perception = table.Column<long>(type: "bigint", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Willpower = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries", x => x.id);
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
                name: "AgentTypes");

            migrationBuilder.DropTable(
                name: "Ancestries");

            migrationBuilder.DropTable(
                name: "SkinrComponentCategories");

            migrationBuilder.DropTable(
                name: "SkinrSlotCategories");
        }
    }
}
