using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260928_164315 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColorRGB",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    R = table.Column<double>(type: "float", nullable: false),
                    G = table.Column<double>(type: "float", nullable: false),
                    B = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorRGB", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MetaGroups",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    ColorKey = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: true),
                    IconSuffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaGroups", x => x.Key);
                    table.ForeignKey(
                        name: "FK_MetaGroups_ColorRGB_ColorKey",
                        column: x => x.ColorKey,
                        principalTable: "ColorRGB",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MetaGroups_ColorKey",
                table: "MetaGroups",
                column: "ColorKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MetaGroups");

            migrationBuilder.DropTable(
                name: "ColorRGB");
        }
    }
}
