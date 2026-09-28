using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260928_172724 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NpcCorporationDivisions",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaderTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcCorporationDivisions", x => x.Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NpcCorporationDivisions");
        }
    }
}
