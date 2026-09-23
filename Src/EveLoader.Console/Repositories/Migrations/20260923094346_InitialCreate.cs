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
                name: "BlueprintCopying",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintCopying", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInvention",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInvention", x => x.id);
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
                name: "BlueprintResearchMaterial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintResearchMaterial", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintResearchTime",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintResearchTime", x => x.id);
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
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAttributes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAttributes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInventionMaterial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintInventionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInventionMaterial", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintInventionMaterial_BlueprintInvention_BlueprintInventionId",
                        column: x => x.BlueprintInventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInventionProduct",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    Probability = table.Column<double>(type: "float", nullable: true),
                    BlueprintInventionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInventionProduct", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintInventionProduct_BlueprintInvention_BlueprintInventionId",
                        column: x => x.BlueprintInventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInventionSkill",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintInventionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInventionSkill", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintInventionSkill_BlueprintInvention_BlueprintInventionId",
                        column: x => x.BlueprintInventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturingMaterial",
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
                    table.PrimaryKey("PK_BlueprintManufacturingMaterial", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintManufacturingMaterial_BlueprintManufacturing_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturingProduct",
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
                    table.PrimaryKey("PK_BlueprintManufacturingProduct", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintManufacturingProduct_BlueprintManufacturing_BlueprintManufacturingid",
                        column: x => x.BlueprintManufacturingid,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturingSkill",
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
                    table.PrimaryKey("PK_BlueprintManufacturingSkill", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintManufacturingSkill_BlueprintManufacturing_BlueprintManufacturingid",
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
                    CopyingId = table.Column<int>(type: "int", nullable: true),
                    InventionId = table.Column<int>(type: "int", nullable: true),
                    ManufacturingId = table.Column<int>(type: "int", nullable: true),
                    ResearchMaterialId = table.Column<int>(type: "int", nullable: true),
                    ResearchTimeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintActivities", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintCopying_CopyingId",
                        column: x => x.CopyingId,
                        principalTable: "BlueprintCopying",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintInvention_InventionId",
                        column: x => x.InventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintManufacturing_ManufacturingId",
                        column: x => x.ManufacturingId,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintResearchMaterial_ResearchMaterialId",
                        column: x => x.ResearchMaterialId,
                        principalTable: "BlueprintResearchMaterial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintResearchTime_ResearchTimeId",
                        column: x => x.ResearchTimeId,
                        principalTable: "BlueprintResearchTime",
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
                name: "CertificateRecommendedFor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecommendedFor = table.Column<long>(type: "bigint", nullable: false),
                    Certificateid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateRecommendedFor", x => x.id);
                    table.ForeignKey(
                        name: "FK_CertificateRecommendedFor_Certificates_Certificateid",
                        column: x => x.Certificateid,
                        principalTable: "Certificates",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CertificateSkillType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Advanced = table.Column<long>(type: "bigint", nullable: false),
                    Basic = table.Column<long>(type: "bigint", nullable: false),
                    Elite = table.Column<long>(type: "bigint", nullable: false),
                    Improved = table.Column<long>(type: "bigint", nullable: false),
                    Standard = table.Column<long>(type: "bigint", nullable: false),
                    Certificateid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateSkillType", x => x.id);
                    table.ForeignKey(
                        name: "FK_CertificateSkillType_Certificates_Certificateid",
                        column: x => x.Certificateid,
                        principalTable: "Certificates",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_BlueprintId",
                table: "BlueprintActivities",
                column: "BlueprintId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_CopyingId",
                table: "BlueprintActivities",
                column: "CopyingId",
                unique: true,
                filter: "[CopyingId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_InventionId",
                table: "BlueprintActivities",
                column: "InventionId",
                unique: true,
                filter: "[InventionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_ManufacturingId",
                table: "BlueprintActivities",
                column: "ManufacturingId",
                unique: true,
                filter: "[ManufacturingId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_ResearchMaterialId",
                table: "BlueprintActivities",
                column: "ResearchMaterialId",
                unique: true,
                filter: "[ResearchMaterialId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintActivities_ResearchTimeId",
                table: "BlueprintActivities",
                column: "ResearchTimeId",
                unique: true,
                filter: "[ResearchTimeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintInventionMaterial_BlueprintInventionId",
                table: "BlueprintInventionMaterial",
                column: "BlueprintInventionId");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintInventionProduct_BlueprintInventionId",
                table: "BlueprintInventionProduct",
                column: "BlueprintInventionId");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintInventionSkill_BlueprintInventionId",
                table: "BlueprintInventionSkill",
                column: "BlueprintInventionId");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintManufacturingMaterial_BlueprintManufacturingid",
                table: "BlueprintManufacturingMaterial",
                column: "BlueprintManufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintManufacturingProduct_BlueprintManufacturingid",
                table: "BlueprintManufacturingProduct",
                column: "BlueprintManufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintManufacturingSkill_BlueprintManufacturingid",
                table: "BlueprintManufacturingSkill",
                column: "BlueprintManufacturingid");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateRecommendedFor_Certificateid",
                table: "CertificateRecommendedFor",
                column: "Certificateid");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateSkillType_Certificateid",
                table: "CertificateSkillType",
                column: "Certificateid");
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
                name: "BlueprintActivities");

            migrationBuilder.DropTable(
                name: "BlueprintInventionMaterial");

            migrationBuilder.DropTable(
                name: "BlueprintInventionProduct");

            migrationBuilder.DropTable(
                name: "BlueprintInventionSkill");

            migrationBuilder.DropTable(
                name: "BlueprintManufacturingMaterial");

            migrationBuilder.DropTable(
                name: "BlueprintManufacturingProduct");

            migrationBuilder.DropTable(
                name: "BlueprintManufacturingSkill");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CertificateRecommendedFor");

            migrationBuilder.DropTable(
                name: "CertificateSkillType");

            migrationBuilder.DropTable(
                name: "CharacterAttributes");

            migrationBuilder.DropTable(
                name: "BlueprintCopying");

            migrationBuilder.DropTable(
                name: "BlueprintResearchMaterial");

            migrationBuilder.DropTable(
                name: "BlueprintResearchTime");

            migrationBuilder.DropTable(
                name: "Blueprints");

            migrationBuilder.DropTable(
                name: "BlueprintInvention");

            migrationBuilder.DropTable(
                name: "BlueprintManufacturing");

            migrationBuilder.DropTable(
                name: "Certificates");
        }
    }
}
