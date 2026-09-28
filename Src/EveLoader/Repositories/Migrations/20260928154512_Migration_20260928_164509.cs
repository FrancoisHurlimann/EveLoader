using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260928_164509 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MetaGroups_ColorRGB_ColorKey",
                table: "MetaGroups");

            migrationBuilder.DropTable(
                name: "ColorRGB");

            migrationBuilder.DropIndex(
                name: "IX_MetaGroups_ColorKey",
                table: "MetaGroups");

            migrationBuilder.DropColumn(
                name: "ColorKey",
                table: "MetaGroups");

            migrationBuilder.AddColumn<double>(
                name: "B",
                table: "MetaGroups",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "G",
                table: "MetaGroups",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "R",
                table: "MetaGroups",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "B",
                table: "MetaGroups");

            migrationBuilder.DropColumn(
                name: "G",
                table: "MetaGroups");

            migrationBuilder.DropColumn(
                name: "R",
                table: "MetaGroups");

            migrationBuilder.AddColumn<long>(
                name: "ColorKey",
                table: "MetaGroups",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ColorRGB",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B = table.Column<double>(type: "float", nullable: false),
                    G = table.Column<double>(type: "float", nullable: false),
                    R = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorRGB", x => x.Key);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MetaGroups_ColorKey",
                table: "MetaGroups",
                column: "ColorKey");

            migrationBuilder.AddForeignKey(
                name: "FK_MetaGroups_ColorRGB_ColorKey",
                table: "MetaGroups",
                column: "ColorKey",
                principalTable: "ColorRGB",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
