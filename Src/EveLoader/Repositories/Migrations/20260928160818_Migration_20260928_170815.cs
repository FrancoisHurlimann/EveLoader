using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260928_170815 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NpcCharacters",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    BloodlineID = table.Column<long>(type: "bigint", nullable: false),
                    Ceo = table.Column<bool>(type: "bit", nullable: false),
                    CorporationID = table.Column<long>(type: "bigint", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    LocationID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceID = table.Column<long>(type: "bigint", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UniqueName = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcCharacters", x => x.Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NpcCharacters");
        }
    }
}
