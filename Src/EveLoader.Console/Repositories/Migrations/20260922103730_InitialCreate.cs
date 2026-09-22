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
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    DungeonID = table.Column<long>(type: "bigint", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    SpawnPointID = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentsInSpace", x => x.Key);
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
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Willpower = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Archetypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bloodlines",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Charisma = table.Column<long>(type: "bigint", nullable: false),
                    CorporationID = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: false),
                    Intelligence = table.Column<long>(type: "bigint", nullable: false),
                    Memory = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perception = table.Column<long>(type: "bigint", nullable: false),
                    RaceID = table.Column<long>(type: "bigint", nullable: false),
                    Willpower = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloodlines", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturing",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintManufacturing", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Blueprints",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintTypeID = table.Column<long>(type: "bigint", nullable: false),
                    MaxProductionLimit = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blueprints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintMaterial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintManufacturingid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintMaterial", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintMaterial_BlueprintManufacturing_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintProduct",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    Probability = table.Column<double>(type: "float", nullable: true),
                    BlueprintManufacturingid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintProduct", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintProduct_BlueprintManufacturing_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintSkill",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintManufacturingid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintSkill", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintSkill_BlueprintManufacturing_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintActivities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlueprintId = table.Column<long>(type: "bigint", nullable: false),
                    ManufacturingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintActivities", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintManufacturing_ManufacturingId",
                        column: x => x.ManufacturingId,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_Blueprints_BlueprintId",
                        column: x => x.BlueprintId,
                        principalTable: "Blueprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintCopying",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivitiesId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintCopying", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintCopying_BlueprintActivities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "BlueprintActivities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_BlueprintId",
                table: "BlueprintActivities",
                column: "BlueprintId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_ManufacturingId",
                table: "BlueprintActivities",
                column: "ManufacturingId",
                unique: true,
                filter: "[ManufacturingId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintCopying_ActivitiesId",
                table: "BlueprintCopying",
                column: "ActivitiesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintMaterial_BlueprintManufacturingid",
                table: "BlueprintMaterial",
                column: "BlueprintManufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintProduct_BlueprintManufacturingid",
                table: "BlueprintProduct",
                column: "BlueprintManufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintSkill_BlueprintManufacturingid",
                table: "BlueprintSkill",
                column: "BlueprintManufacturingid");
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
                name: "Archetypes");

            migrationBuilder.DropTable(
                name: "Bloodlines");

            migrationBuilder.DropTable(
                name: "BlueprintCopying");

            migrationBuilder.DropTable(
                name: "BlueprintMaterial");

            migrationBuilder.DropTable(
                name: "BlueprintProduct");

            migrationBuilder.DropTable(
                name: "BlueprintSkill");

            migrationBuilder.DropTable(
                name: "BlueprintActivities");

            migrationBuilder.DropTable(
                name: "BlueprintManufacturing");

            migrationBuilder.DropTable(
                name: "Blueprints");
        }
    }
}
