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
                name: "BlueprintActivity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintActivity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintActivities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Copyingid = table.Column<int>(type: "int", nullable: false),
                    Manufacturingid = table.Column<int>(type: "int", nullable: false),
                    Inventionid = table.Column<int>(type: "int", nullable: false),
                    ResearchMaterialid = table.Column<int>(type: "int", nullable: false),
                    ResearchTimeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintActivities", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintActivity_Copyingid",
                        column: x => x.Copyingid,
                        principalTable: "BlueprintActivity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintActivity_Inventionid",
                        column: x => x.Inventionid,
                        principalTable: "BlueprintActivity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintActivity_Manufacturingid",
                        column: x => x.Manufacturingid,
                        principalTable: "BlueprintActivity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintActivity_ResearchMaterialid",
                        column: x => x.ResearchMaterialid,
                        principalTable: "BlueprintActivity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintActivity_ResearchTimeid",
                        column: x => x.ResearchTimeid,
                        principalTable: "BlueprintActivity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintMaterial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintManufacturingid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintMaterial", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintMaterial_BlueprintActivity_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintActivity",
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
                        name: "FK_BlueprintProduct_BlueprintActivity_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintActivity",
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
                        name: "FK_BlueprintSkill_BlueprintActivity_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintActivity",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Blueprints",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Activitiesid = table.Column<int>(type: "int", nullable: false),
                    BlueprintTypeID = table.Column<long>(type: "bigint", nullable: false),
                    MaxProductionLimit = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blueprints", x => x.id);
                    table.ForeignKey(
                        name: "FK_Blueprints_BlueprintActivities_Activitiesid",
                        column: x => x.Activitiesid,
                        principalTable: "BlueprintActivities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_Copyingid",
                table: "BlueprintActivities",
                column: "Copyingid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_Inventionid",
                table: "BlueprintActivities",
                column: "Inventionid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_Manufacturingid",
                table: "BlueprintActivities",
                column: "Manufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_ResearchMaterialid",
                table: "BlueprintActivities",
                column: "ResearchMaterialid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_ResearchTimeid",
                table: "BlueprintActivities",
                column: "ResearchTimeid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintMaterial_BlueprintManufacturingid",
                table: "BlueprintMaterial",
                column: "BlueprintManufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintProduct_BlueprintManufacturingid",
                table: "BlueprintProduct",
                column: "BlueprintManufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_Blueprints_Activitiesid",
                table: "Blueprints",
                column: "Activitiesid");

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
                name: "BlueprintMaterial");

            migrationBuilder.DropTable(
                name: "BlueprintProduct");

            migrationBuilder.DropTable(
                name: "Blueprints");

            migrationBuilder.DropTable(
                name: "BlueprintSkill");

            migrationBuilder.DropTable(
                name: "BlueprintActivities");

            migrationBuilder.DropTable(
                name: "BlueprintActivity");
        }
    }
}
