using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
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
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentTypes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    BloodlineID = table.Column<long>(type: "bigint", nullable: false),
                    Charisma = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconID = table.Column<long>(type: "bigint", nullable: false),
                    Intelligence = table.Column<long>(type: "bigint", nullable: false),
                    Memory = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perception = table.Column<long>(type: "bigint", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Willpower = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Archetypes",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Bloodlines",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Bloodlines", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintCopying",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintCopying", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInvention",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInvention", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturing",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintManufacturing", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintResearchMaterial",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintResearchMaterial", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintResearchTime",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintResearchTime", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Blueprints",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintTypeID = table.Column<long>(type: "bigint", nullable: false),
                    MaxProductionLimit = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blueprints", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAttributes",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAttributes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTitles",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTitles", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CloneGrades",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloneGrades", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CompressibleTypes",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    CompressedTypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompressibleTypes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ContrabandTypes",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContrabandTypes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ControlTowerResources",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlTowerResources", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CorporationActivities",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporationActivities", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "DBuffCollections",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    AggregateMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeveloperDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowOutputValueInUI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBuffCollections", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "DogmaAttributeCategories",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogmaAttributeCategories", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInventionMaterial",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintInventionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInventionMaterial", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BlueprintInventionMaterial_BlueprintInvention_BlueprintInventionId",
                        column: x => x.BlueprintInventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInventionProduct",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    Probability = table.Column<double>(type: "float", nullable: true),
                    BlueprintInventionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInventionProduct", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BlueprintInventionProduct_BlueprintInvention_BlueprintInventionId",
                        column: x => x.BlueprintInventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintInventionSkill",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintInventionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintInventionSkill", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BlueprintInventionSkill_BlueprintInvention_BlueprintInventionId",
                        column: x => x.BlueprintInventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturingMaterial",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintManufacturingKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintManufacturingMaterial", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BlueprintManufacturingMaterial_BlueprintManufacturing_BlueprintManufacturingKey",
                        column: x => x.BlueprintManufacturingKey,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturingProduct",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintManufacturingKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintManufacturingProduct", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BlueprintManufacturingProduct_BlueprintManufacturing_BlueprintManufacturingKey",
                        column: x => x.BlueprintManufacturingKey,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintManufacturingSkill",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    BlueprintManufacturingKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintManufacturingSkill", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BlueprintManufacturingSkill_BlueprintManufacturing_BlueprintManufacturingKey",
                        column: x => x.BlueprintManufacturingKey,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "BlueprintActivities",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlueprintId = table.Column<long>(type: "bigint", nullable: false),
                    CopyingId = table.Column<long>(type: "bigint", nullable: true),
                    InventionId = table.Column<long>(type: "bigint", nullable: true),
                    ManufacturingId = table.Column<long>(type: "bigint", nullable: true),
                    ResearchMaterialId = table.Column<long>(type: "bigint", nullable: true),
                    ResearchTimeId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintActivities", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintCopying_CopyingId",
                        column: x => x.CopyingId,
                        principalTable: "BlueprintCopying",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintInvention_InventionId",
                        column: x => x.InventionId,
                        principalTable: "BlueprintInvention",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintManufacturing_ManufacturingId",
                        column: x => x.ManufacturingId,
                        principalTable: "BlueprintManufacturing",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintResearchMaterial_ResearchMaterialId",
                        column: x => x.ResearchMaterialId,
                        principalTable: "BlueprintResearchMaterial",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_BlueprintResearchTime_ResearchTimeId",
                        column: x => x.ResearchTimeId,
                        principalTable: "BlueprintResearchTime",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlueprintActivities_Blueprints_BlueprintId",
                        column: x => x.BlueprintId,
                        principalTable: "Blueprints",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificateRecommendedFor",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecommendedFor = table.Column<long>(type: "bigint", nullable: false),
                    CertificateKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateRecommendedFor", x => x.Key);
                    table.ForeignKey(
                        name: "FK_CertificateRecommendedFor_Certificates_CertificateKey",
                        column: x => x.CertificateKey,
                        principalTable: "Certificates",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "CertificateSkillType",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Advanced = table.Column<long>(type: "bigint", nullable: false),
                    Basic = table.Column<long>(type: "bigint", nullable: false),
                    Elite = table.Column<long>(type: "bigint", nullable: false),
                    Improved = table.Column<long>(type: "bigint", nullable: false),
                    Standard = table.Column<long>(type: "bigint", nullable: false),
                    CertificateKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateSkillType", x => x.Key);
                    table.ForeignKey(
                        name: "FK_CertificateSkillType_Certificates_CertificateKey",
                        column: x => x.CertificateKey,
                        principalTable: "Certificates",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "CloneGradeSkill",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false),
                    CloneGradeKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloneGradeSkill", x => x.Key);
                    table.ForeignKey(
                        name: "FK_CloneGradeSkill_CloneGrades_CloneGradeKey",
                        column: x => x.CloneGradeKey,
                        principalTable: "CloneGrades",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "ContrabandFaction",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttackMinSec = table.Column<double>(type: "float", nullable: false),
                    ConfiscateMinSec = table.Column<double>(type: "float", nullable: false),
                    FineByValue = table.Column<double>(type: "float", nullable: false),
                    StandingLoss = table.Column<double>(type: "float", nullable: false),
                    ContrabandTypeKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContrabandFaction", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ContrabandFaction_ContrabandTypes_ContrabandTypeKey",
                        column: x => x.ContrabandTypeKey,
                        principalTable: "ContrabandTypes",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "ControlTowerResourceItem",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    ResourceTypeID = table.Column<long>(type: "bigint", nullable: false),
                    FactionID = table.Column<long>(type: "bigint", nullable: true),
                    MinSecurityLevel = table.Column<double>(type: "float", nullable: true),
                    ControlTowerResourceKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlTowerResourceItem", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ControlTowerResourceItem_ControlTowerResources_ControlTowerResourceKey",
                        column: x => x.ControlTowerResourceKey,
                        principalTable: "ControlTowerResources",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "DBuffItemModifier",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogmaAttributeID = table.Column<long>(type: "bigint", nullable: false),
                    DBuffCollectionKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBuffItemModifier", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DBuffItemModifier_DBuffCollections_DBuffCollectionKey",
                        column: x => x.DBuffCollectionKey,
                        principalTable: "DBuffCollections",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "DBuffLocationGroupModifier",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogmaAttributeID = table.Column<long>(type: "bigint", nullable: false),
                    GroupID = table.Column<long>(type: "bigint", nullable: false),
                    DBuffCollectionKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBuffLocationGroupModifier", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DBuffLocationGroupModifier_DBuffCollections_DBuffCollectionKey",
                        column: x => x.DBuffCollectionKey,
                        principalTable: "DBuffCollections",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "DBuffLocationModifier",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogmaAttributeID = table.Column<long>(type: "bigint", nullable: false),
                    DBuffCollectionKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBuffLocationModifier", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DBuffLocationModifier_DBuffCollections_DBuffCollectionKey",
                        column: x => x.DBuffCollectionKey,
                        principalTable: "DBuffCollections",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "DBuffLocationRequiredSkillModifier",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogmaAttributeID = table.Column<long>(type: "bigint", nullable: false),
                    SkillID = table.Column<long>(type: "bigint", nullable: false),
                    DBuffCollectionKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBuffLocationRequiredSkillModifier", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DBuffLocationRequiredSkillModifier_DBuffCollections_DBuffCollectionKey",
                        column: x => x.DBuffCollectionKey,
                        principalTable: "DBuffCollections",
                        principalColumn: "Key");
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
                name: "IX_BlueprintManufacturingMaterial_BlueprintManufacturingKey",
                table: "BlueprintManufacturingMaterial",
                column: "BlueprintManufacturingKey");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintManufacturingProduct_BlueprintManufacturingKey",
                table: "BlueprintManufacturingProduct",
                column: "BlueprintManufacturingKey");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintManufacturingSkill_BlueprintManufacturingKey",
                table: "BlueprintManufacturingSkill",
                column: "BlueprintManufacturingKey");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateRecommendedFor_CertificateKey",
                table: "CertificateRecommendedFor",
                column: "CertificateKey");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateSkillType_CertificateKey",
                table: "CertificateSkillType",
                column: "CertificateKey");

            migrationBuilder.CreateIndex(
                name: "IX_CloneGradeSkill_CloneGradeKey",
                table: "CloneGradeSkill",
                column: "CloneGradeKey");

            migrationBuilder.CreateIndex(
                name: "IX_ContrabandFaction_ContrabandTypeKey",
                table: "ContrabandFaction",
                column: "ContrabandTypeKey");

            migrationBuilder.CreateIndex(
                name: "IX_ControlTowerResourceItem_ControlTowerResourceKey",
                table: "ControlTowerResourceItem",
                column: "ControlTowerResourceKey");

            migrationBuilder.CreateIndex(
                name: "IX_DBuffItemModifier_DBuffCollectionKey",
                table: "DBuffItemModifier",
                column: "DBuffCollectionKey");

            migrationBuilder.CreateIndex(
                name: "IX_DBuffLocationGroupModifier_DBuffCollectionKey",
                table: "DBuffLocationGroupModifier",
                column: "DBuffCollectionKey");

            migrationBuilder.CreateIndex(
                name: "IX_DBuffLocationModifier_DBuffCollectionKey",
                table: "DBuffLocationModifier",
                column: "DBuffCollectionKey");

            migrationBuilder.CreateIndex(
                name: "IX_DBuffLocationRequiredSkillModifier_DBuffCollectionKey",
                table: "DBuffLocationRequiredSkillModifier",
                column: "DBuffCollectionKey");
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
                name: "CharacterTitles");

            migrationBuilder.DropTable(
                name: "CloneGradeSkill");

            migrationBuilder.DropTable(
                name: "CompressibleTypes");

            migrationBuilder.DropTable(
                name: "ContrabandFaction");

            migrationBuilder.DropTable(
                name: "ControlTowerResourceItem");

            migrationBuilder.DropTable(
                name: "CorporationActivities");

            migrationBuilder.DropTable(
                name: "DBuffItemModifier");

            migrationBuilder.DropTable(
                name: "DBuffLocationGroupModifier");

            migrationBuilder.DropTable(
                name: "DBuffLocationModifier");

            migrationBuilder.DropTable(
                name: "DBuffLocationRequiredSkillModifier");

            migrationBuilder.DropTable(
                name: "DogmaAttributeCategories");

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

            migrationBuilder.DropTable(
                name: "CloneGrades");

            migrationBuilder.DropTable(
                name: "ContrabandTypes");

            migrationBuilder.DropTable(
                name: "ControlTowerResources");

            migrationBuilder.DropTable(
                name: "DBuffCollections");
        }
    }
}
