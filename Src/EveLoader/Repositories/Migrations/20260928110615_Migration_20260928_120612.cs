using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveLoader.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260928_120612 : Migration
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
                name: "Color",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    A = table.Column<double>(type: "float", nullable: false),
                    B = table.Column<double>(type: "float", nullable: false),
                    G = table.Column<double>(type: "float", nullable: false),
                    R = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Key);
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
                name: "DogmaAttributes",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    AttributeCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    DataType = table.Column<long>(type: "bigint", nullable: false),
                    DefaultValue = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayWhenZero = table.Column<bool>(type: "bit", nullable: false),
                    HighIsGood = table.Column<bool>(type: "bit", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    Stackable = table.Column<bool>(type: "bit", nullable: false),
                    TooltipDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TooltipTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogmaAttributes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "DogmaEffects",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisallowAutoRepeat = table.Column<bool>(type: "bit", nullable: false),
                    DischargeAttributeID = table.Column<long>(type: "bigint", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distribution = table.Column<long>(type: "bigint", nullable: true),
                    DurationAttributeID = table.Column<long>(type: "bigint", nullable: true),
                    EffectCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    ElectronicChance = table.Column<bool>(type: "bit", nullable: false),
                    FalloffAttributeID = table.Column<long>(type: "bigint", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconID = table.Column<long>(type: "bigint", nullable: true),
                    IsAssistance = table.Column<bool>(type: "bit", nullable: false),
                    IsOffensive = table.Column<bool>(type: "bit", nullable: false),
                    IsWarpSafe = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropulsionChance = table.Column<bool>(type: "bit", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    RangeAttributeID = table.Column<long>(type: "bigint", nullable: true),
                    RangeChance = table.Column<bool>(type: "bit", nullable: false),
                    TrackingSpeedAttributeID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogmaEffects", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "DogmaUnits",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogmaUnits", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Dungeons",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    AllowedShipsList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchetypeID = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactionID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dungeons", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "DynamicItemAttributes",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicItemAttributes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "EpicArcs",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    ArcRestartInterval = table.Column<long>(type: "bigint", nullable: false),
                    FactionID = table.Column<long>(type: "bigint", nullable: true),
                    IconID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpicArcs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    CorporationID = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlatLogoWithName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconID = table.Column<long>(type: "bigint", nullable: false),
                    MemberRaces = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MilitiaCorporationID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeFactor = table.Column<double>(type: "float", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    UniqueName = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaBooleanOption",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaBooleanOption", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaContributionMultiplier",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultValue = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxValue = table.Column<double>(type: "float", nullable: false),
                    MinValue = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnsetDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaContributionMultiplier", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaInventoryType",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptedValueTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnsetDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaInventoryType", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaLimit",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnsetDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaLimit", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaMatcher",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptedValueTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxEntries = table.Column<long>(type: "bigint", nullable: true),
                    Optional = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnsetDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaMatcher", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemas",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemas", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Graphics",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    GraphicFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconFolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SofFactionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SofHullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SofRaceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graphics", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Anchorable = table.Column<bool>(type: "bit", nullable: false),
                    Anchored = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false),
                    FittableNonSingleton = table.Column<bool>(type: "bit", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    UseBasePrice = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    IconFile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Landmarks",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionX = table.Column<double>(type: "float", nullable: false),
                    PositionY = table.Column<double>(type: "float", nullable: false),
                    PositionZ = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmarks", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapAsteroidBeltCelestialStatistics",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Density = table.Column<double>(type: "float", nullable: false),
                    Eccentricity = table.Column<double>(type: "float", nullable: false),
                    EscapeVelocity = table.Column<double>(type: "float", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    MassDust = table.Column<double>(type: "float", nullable: false),
                    MassGas = table.Column<double>(type: "float", nullable: false),
                    OrbitPeriod = table.Column<double>(type: "float", nullable: false),
                    OrbitRadius = table.Column<double>(type: "float", nullable: false),
                    Pressure = table.Column<double>(type: "float", nullable: true),
                    RotationRate = table.Column<double>(type: "float", nullable: false),
                    SpectralClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurfaceGravity = table.Column<double>(type: "float", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapAsteroidBeltCelestialStatistics", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapAsteroidBeltPosition",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    Z = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapAsteroidBeltPosition", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapConstellationPosition",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    Z = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapConstellationPosition", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapMoonCelestialStatistics",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Density = table.Column<double>(type: "float", nullable: false),
                    Eccentricity = table.Column<double>(type: "float", nullable: false),
                    EscapeVelocity = table.Column<double>(type: "float", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    MassDust = table.Column<double>(type: "float", nullable: false),
                    MassGas = table.Column<double>(type: "float", nullable: false),
                    OrbitPeriod = table.Column<double>(type: "float", nullable: false),
                    OrbitRadius = table.Column<double>(type: "float", nullable: false),
                    Pressure = table.Column<double>(type: "float", nullable: true),
                    RotationRate = table.Column<double>(type: "float", nullable: false),
                    SpectralClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurfaceGravity = table.Column<double>(type: "float", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapMoonCelestialStatistics", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapPlanetCelestialStatistics",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Density = table.Column<double>(type: "float", nullable: false),
                    Eccentricity = table.Column<double>(type: "float", nullable: false),
                    EscapeVelocity = table.Column<double>(type: "float", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    MassDust = table.Column<double>(type: "float", nullable: false),
                    MassGas = table.Column<double>(type: "float", nullable: false),
                    OrbitPeriod = table.Column<double>(type: "float", nullable: false),
                    OrbitRadius = table.Column<double>(type: "float", nullable: false),
                    Pressure = table.Column<double>(type: "float", nullable: true),
                    RotationRate = table.Column<double>(type: "float", nullable: false),
                    SpectralClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurfaceGravity = table.Column<double>(type: "float", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPlanetCelestialStatistics", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapRegions",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    ConstellationIDs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactionID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NebulaID = table.Column<long>(type: "bigint", nullable: false),
                    PositionX = table.Column<double>(type: "float", nullable: false),
                    PositionY = table.Column<double>(type: "float", nullable: false),
                    PositionZ = table.Column<double>(type: "float", nullable: false),
                    WormholeClassID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapRegions", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapSecondarySuns",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    EffectBeaconTypeID = table.Column<long>(type: "bigint", nullable: false),
                    PositionX = table.Column<double>(type: "float", nullable: false),
                    PositionY = table.Column<double>(type: "float", nullable: false),
                    PositionZ = table.Column<double>(type: "float", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapSecondarySuns", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapSolarSystems",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Border = table.Column<bool>(type: "bit", nullable: true),
                    ConstellationID = table.Column<long>(type: "bigint", nullable: false),
                    Corridor = table.Column<bool>(type: "bit", nullable: true),
                    Fringe = table.Column<bool>(type: "bit", nullable: true),
                    Hub = table.Column<bool>(type: "bit", nullable: true),
                    International = table.Column<bool>(type: "bit", nullable: true),
                    Luminosity = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanetIDs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionX = table.Column<double>(type: "float", nullable: false),
                    PositionY = table.Column<double>(type: "float", nullable: false),
                    PositionZ = table.Column<double>(type: "float", nullable: false),
                    Position2DX = table.Column<double>(type: "float", nullable: false),
                    Position2DY = table.Column<double>(type: "float", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    RegionID = table.Column<long>(type: "bigint", nullable: false),
                    Regional = table.Column<bool>(type: "bit", nullable: true),
                    SecurityClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStatus = table.Column<double>(type: "float", nullable: false),
                    StarID = table.Column<long>(type: "bigint", nullable: false),
                    StargateIDs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapSolarSystems", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapStargates",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    DestinationSolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    DestinationStargateID = table.Column<long>(type: "bigint", nullable: false),
                    PositionX = table.Column<double>(type: "float", nullable: false),
                    PositionY = table.Column<double>(type: "float", nullable: false),
                    PositionZ = table.Column<double>(type: "float", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapStargates", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "MapStars",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    Radius = table.Column<long>(type: "bigint", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    StatisticsAge = table.Column<double>(type: "float", nullable: false),
                    StatisticsLife = table.Column<double>(type: "float", nullable: false),
                    StatisticsLuminosity = table.Column<double>(type: "float", nullable: false),
                    StatisticsSpectralClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatisticsTemperature = table.Column<double>(type: "float", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapStars", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "PlanetAttributes",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeightMap1 = table.Column<long>(type: "bigint", nullable: false),
                    HeightMap2 = table.Column<long>(type: "bigint", nullable: false),
                    Population = table.Column<bool>(type: "bit", nullable: false),
                    ShaderPreset = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetAttributes", x => x.Key);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
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
                name: "GraphicMaterialSets",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    ColorHullKey = table.Column<long>(type: "bigint", nullable: false),
                    ColorPrimaryKey = table.Column<long>(type: "bigint", nullable: false),
                    ColorSecondaryKey = table.Column<long>(type: "bigint", nullable: false),
                    ColorWindowKey = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SofFactionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SofRaceHint = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicMaterialSets", x => x.Key);
                    table.ForeignKey(
                        name: "FK_GraphicMaterialSets_Color_ColorHullKey",
                        column: x => x.ColorHullKey,
                        principalTable: "Color",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GraphicMaterialSets_Color_ColorPrimaryKey",
                        column: x => x.ColorPrimaryKey,
                        principalTable: "Color",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GraphicMaterialSets_Color_ColorSecondaryKey",
                        column: x => x.ColorSecondaryKey,
                        principalTable: "Color",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GraphicMaterialSets_Color_ColorWindowKey",
                        column: x => x.ColorWindowKey,
                        principalTable: "Color",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DogmaEffectModifierInfo",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Func = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAttributeID = table.Column<long>(type: "bigint", nullable: false),
                    ModifyingAttributeID = table.Column<long>(type: "bigint", nullable: false),
                    Operation = table.Column<long>(type: "bigint", nullable: false),
                    DogmaEffectKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogmaEffectModifierInfo", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DogmaEffectModifierInfo_DogmaEffects_DogmaEffectKey",
                        column: x => x.DogmaEffectKey,
                        principalTable: "DogmaEffects",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "DynamicItemAttributeRange",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HighIsGood = table.Column<bool>(type: "bit", nullable: true),
                    Max = table.Column<double>(type: "float", nullable: false),
                    Min = table.Column<double>(type: "float", nullable: false),
                    DynamicItemAttributeKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicItemAttributeRange", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DynamicItemAttributeRange_DynamicItemAttributes_DynamicItemAttributeKey",
                        column: x => x.DynamicItemAttributeKey,
                        principalTable: "DynamicItemAttributes",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "DynamicItemInputOutputMapping",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicableTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResultingType = table.Column<long>(type: "bigint", nullable: false),
                    DynamicItemAttributeKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicItemInputOutputMapping", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DynamicItemInputOutputMapping_DynamicItemAttributes_DynamicItemAttributeKey",
                        column: x => x.DynamicItemAttributeKey,
                        principalTable: "DynamicItemAttributes",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "EpicArcMission",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentID = table.Column<long>(type: "bigint", nullable: false),
                    FailMissionID = table.Column<long>(type: "bigint", nullable: true),
                    NextMissions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpicArcKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpicArcMission", x => x.Key);
                    table.ForeignKey(
                        name: "FK_EpicArcMission_EpicArcs_EpicArcKey",
                        column: x => x.EpicArcKey,
                        principalTable: "EpicArcs",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaBooleanParameter",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChoiceLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Default = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionFalseKey = table.Column<long>(type: "bigint", nullable: false),
                    OptionTrueKey = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaBooleanParameter", x => x.Key);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaBooleanParameter_FreelanceJobSchemaBooleanOption_OptionFalseKey",
                        column: x => x.OptionFalseKey,
                        principalTable: "FreelanceJobSchemaBooleanOption",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaBooleanParameter_FreelanceJobSchemaBooleanOption_OptionTrueKey",
                        column: x => x.OptionTrueKey,
                        principalTable: "FreelanceJobSchemaBooleanOption",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaItemDelivery",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryLocationKey = table.Column<long>(type: "bigint", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxEntries = table.Column<long>(type: "bigint", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnsetDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaItemDelivery", x => x.Key);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaItemDelivery_FreelanceJobSchemaMatcher_DeliveryLocationKey",
                        column: x => x.DeliveryLocationKey,
                        principalTable: "FreelanceJobSchemaMatcher",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaEntry",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContentTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxContributionsPerParticipantKey = table.Column<long>(type: "bigint", nullable: false),
                    ProgressDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RewardDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContributionMultiplierKey = table.Column<long>(type: "bigint", nullable: false),
                    MaxProgressPerContributionKey = table.Column<long>(type: "bigint", nullable: false),
                    FreelanceJobSchemaKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaEntry", x => x.Key);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaEntry_FreelanceJobSchemaContributionMultiplier_ContributionMultiplierKey",
                        column: x => x.ContributionMultiplierKey,
                        principalTable: "FreelanceJobSchemaContributionMultiplier",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaEntry_FreelanceJobSchemaLimit_MaxContributionsPerParticipantKey",
                        column: x => x.MaxContributionsPerParticipantKey,
                        principalTable: "FreelanceJobSchemaLimit",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaEntry_FreelanceJobSchemaLimit_MaxProgressPerContributionKey",
                        column: x => x.MaxProgressPerContributionKey,
                        principalTable: "FreelanceJobSchemaLimit",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaEntry_FreelanceJobSchemas_FreelanceJobSchemaKey",
                        column: x => x.FreelanceJobSchemaKey,
                        principalTable: "FreelanceJobSchemas",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapAsteroidBelts",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    CelestialIndex = table.Column<long>(type: "bigint", nullable: false),
                    OrbitID = table.Column<long>(type: "bigint", nullable: false),
                    OrbitIndex = table.Column<long>(type: "bigint", nullable: false),
                    MapAsteroidBeltPositionKey = table.Column<long>(type: "bigint", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    StatisticsKey = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapAsteroidBelts", x => x.Key);
                    table.ForeignKey(
                        name: "FK_MapAsteroidBelts_MapAsteroidBeltCelestialStatistics_StatisticsKey",
                        column: x => x.StatisticsKey,
                        principalTable: "MapAsteroidBeltCelestialStatistics",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapAsteroidBelts_MapAsteroidBeltPosition_MapAsteroidBeltPositionKey",
                        column: x => x.MapAsteroidBeltPositionKey,
                        principalTable: "MapAsteroidBeltPosition",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapConstellations",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    FactionID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapConstellationPositionKey = table.Column<long>(type: "bigint", nullable: false),
                    RegionID = table.Column<long>(type: "bigint", nullable: false),
                    SolarSystemIDs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WormholeClassID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapConstellations", x => x.Key);
                    table.ForeignKey(
                        name: "FK_MapConstellations_MapConstellationPosition_MapConstellationPositionKey",
                        column: x => x.MapConstellationPositionKey,
                        principalTable: "MapConstellationPosition",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapMoons",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    AttributesKey = table.Column<long>(type: "bigint", nullable: false),
                    CelestialIndex = table.Column<long>(type: "bigint", nullable: false),
                    OrbitID = table.Column<long>(type: "bigint", nullable: false),
                    PositionX = table.Column<double>(type: "float", nullable: false),
                    PositionY = table.Column<double>(type: "float", nullable: false),
                    PositionZ = table.Column<double>(type: "float", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    StatisticsKey = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapMoons", x => x.Key);
                    table.ForeignKey(
                        name: "FK_MapMoons_MapMoonCelestialStatistics_StatisticsKey",
                        column: x => x.StatisticsKey,
                        principalTable: "MapMoonCelestialStatistics",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapMoons_PlanetAttributes_AttributesKey",
                        column: x => x.AttributesKey,
                        principalTable: "PlanetAttributes",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapPlanets",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false),
                    AsteroidBeltIDs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributesKey = table.Column<long>(type: "bigint", nullable: false),
                    CelestialIndex = table.Column<long>(type: "bigint", nullable: false),
                    MoonIDs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NpcStationIDs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrbitID = table.Column<long>(type: "bigint", nullable: false),
                    PositionX = table.Column<double>(type: "float", nullable: false),
                    PositionY = table.Column<double>(type: "float", nullable: false),
                    PositionZ = table.Column<double>(type: "float", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    SolarSystemID = table.Column<long>(type: "bigint", nullable: false),
                    StatisticsKey = table.Column<long>(type: "bigint", nullable: false),
                    TypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPlanets", x => x.Key);
                    table.ForeignKey(
                        name: "FK_MapPlanets_MapPlanetCelestialStatistics_StatisticsKey",
                        column: x => x.StatisticsKey,
                        principalTable: "MapPlanetCelestialStatistics",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapPlanets_PlanetAttributes_AttributesKey",
                        column: x => x.AttributesKey,
                        principalTable: "PlanetAttributes",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreelanceJobSchemaParameter",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatcherKey = table.Column<long>(type: "bigint", nullable: false),
                    ItemDeliveryKey = table.Column<long>(type: "bigint", nullable: false),
                    InventoryTypeKey = table.Column<long>(type: "bigint", nullable: false),
                    BooleanKey = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxEntries = table.Column<long>(type: "bigint", nullable: true),
                    Optional = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnsetDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FreelanceJobSchemaEntryKey = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceJobSchemaParameter", x => x.Key);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaParameter_FreelanceJobSchemaBooleanParameter_BooleanKey",
                        column: x => x.BooleanKey,
                        principalTable: "FreelanceJobSchemaBooleanParameter",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaParameter_FreelanceJobSchemaEntry_FreelanceJobSchemaEntryKey",
                        column: x => x.FreelanceJobSchemaEntryKey,
                        principalTable: "FreelanceJobSchemaEntry",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaParameter_FreelanceJobSchemaInventoryType_InventoryTypeKey",
                        column: x => x.InventoryTypeKey,
                        principalTable: "FreelanceJobSchemaInventoryType",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaParameter_FreelanceJobSchemaItemDelivery_ItemDeliveryKey",
                        column: x => x.ItemDeliveryKey,
                        principalTable: "FreelanceJobSchemaItemDelivery",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelanceJobSchemaParameter_FreelanceJobSchemaMatcher_MatcherKey",
                        column: x => x.MatcherKey,
                        principalTable: "FreelanceJobSchemaMatcher",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_DogmaEffectModifierInfo_DogmaEffectKey",
                table: "DogmaEffectModifierInfo",
                column: "DogmaEffectKey");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicItemAttributeRange_DynamicItemAttributeKey",
                table: "DynamicItemAttributeRange",
                column: "DynamicItemAttributeKey");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicItemInputOutputMapping_DynamicItemAttributeKey",
                table: "DynamicItemInputOutputMapping",
                column: "DynamicItemAttributeKey");

            migrationBuilder.CreateIndex(
                name: "IX_EpicArcMission_EpicArcKey",
                table: "EpicArcMission",
                column: "EpicArcKey");

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaBooleanParameter_OptionFalseKey",
                table: "FreelanceJobSchemaBooleanParameter",
                column: "OptionFalseKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaBooleanParameter_OptionTrueKey",
                table: "FreelanceJobSchemaBooleanParameter",
                column: "OptionTrueKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaEntry_ContributionMultiplierKey",
                table: "FreelanceJobSchemaEntry",
                column: "ContributionMultiplierKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaEntry_FreelanceJobSchemaKey",
                table: "FreelanceJobSchemaEntry",
                column: "FreelanceJobSchemaKey");

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaEntry_MaxContributionsPerParticipantKey",
                table: "FreelanceJobSchemaEntry",
                column: "MaxContributionsPerParticipantKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaEntry_MaxProgressPerContributionKey",
                table: "FreelanceJobSchemaEntry",
                column: "MaxProgressPerContributionKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaItemDelivery_DeliveryLocationKey",
                table: "FreelanceJobSchemaItemDelivery",
                column: "DeliveryLocationKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaParameter_BooleanKey",
                table: "FreelanceJobSchemaParameter",
                column: "BooleanKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaParameter_FreelanceJobSchemaEntryKey",
                table: "FreelanceJobSchemaParameter",
                column: "FreelanceJobSchemaEntryKey");

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaParameter_InventoryTypeKey",
                table: "FreelanceJobSchemaParameter",
                column: "InventoryTypeKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaParameter_ItemDeliveryKey",
                table: "FreelanceJobSchemaParameter",
                column: "ItemDeliveryKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelanceJobSchemaParameter_MatcherKey",
                table: "FreelanceJobSchemaParameter",
                column: "MatcherKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GraphicMaterialSets_ColorHullKey",
                table: "GraphicMaterialSets",
                column: "ColorHullKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GraphicMaterialSets_ColorPrimaryKey",
                table: "GraphicMaterialSets",
                column: "ColorPrimaryKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GraphicMaterialSets_ColorSecondaryKey",
                table: "GraphicMaterialSets",
                column: "ColorSecondaryKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GraphicMaterialSets_ColorWindowKey",
                table: "GraphicMaterialSets",
                column: "ColorWindowKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapAsteroidBelts_MapAsteroidBeltPositionKey",
                table: "MapAsteroidBelts",
                column: "MapAsteroidBeltPositionKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapAsteroidBelts_StatisticsKey",
                table: "MapAsteroidBelts",
                column: "StatisticsKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapConstellations_MapConstellationPositionKey",
                table: "MapConstellations",
                column: "MapConstellationPositionKey");

            migrationBuilder.CreateIndex(
                name: "IX_MapMoons_AttributesKey",
                table: "MapMoons",
                column: "AttributesKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapMoons_StatisticsKey",
                table: "MapMoons",
                column: "StatisticsKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapPlanets_AttributesKey",
                table: "MapPlanets",
                column: "AttributesKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapPlanets_StatisticsKey",
                table: "MapPlanets",
                column: "StatisticsKey",
                unique: true);
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
                name: "DogmaAttributes");

            migrationBuilder.DropTable(
                name: "DogmaEffectModifierInfo");

            migrationBuilder.DropTable(
                name: "DogmaUnits");

            migrationBuilder.DropTable(
                name: "Dungeons");

            migrationBuilder.DropTable(
                name: "DynamicItemAttributeRange");

            migrationBuilder.DropTable(
                name: "DynamicItemInputOutputMapping");

            migrationBuilder.DropTable(
                name: "EpicArcMission");

            migrationBuilder.DropTable(
                name: "Factions");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaParameter");

            migrationBuilder.DropTable(
                name: "GraphicMaterialSets");

            migrationBuilder.DropTable(
                name: "Graphics");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Icons");

            migrationBuilder.DropTable(
                name: "Landmarks");

            migrationBuilder.DropTable(
                name: "MapAsteroidBelts");

            migrationBuilder.DropTable(
                name: "MapConstellations");

            migrationBuilder.DropTable(
                name: "MapMoons");

            migrationBuilder.DropTable(
                name: "MapPlanets");

            migrationBuilder.DropTable(
                name: "MapRegions");

            migrationBuilder.DropTable(
                name: "MapSecondarySuns");

            migrationBuilder.DropTable(
                name: "MapSolarSystems");

            migrationBuilder.DropTable(
                name: "MapStargates");

            migrationBuilder.DropTable(
                name: "MapStars");

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

            migrationBuilder.DropTable(
                name: "DogmaEffects");

            migrationBuilder.DropTable(
                name: "DynamicItemAttributes");

            migrationBuilder.DropTable(
                name: "EpicArcs");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaBooleanParameter");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaEntry");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaInventoryType");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaItemDelivery");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "MapAsteroidBeltCelestialStatistics");

            migrationBuilder.DropTable(
                name: "MapAsteroidBeltPosition");

            migrationBuilder.DropTable(
                name: "MapConstellationPosition");

            migrationBuilder.DropTable(
                name: "MapMoonCelestialStatistics");

            migrationBuilder.DropTable(
                name: "MapPlanetCelestialStatistics");

            migrationBuilder.DropTable(
                name: "PlanetAttributes");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaBooleanOption");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaContributionMultiplier");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaLimit");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemas");

            migrationBuilder.DropTable(
                name: "FreelanceJobSchemaMatcher");
        }
    }
}
