
using EveLoader.Entities.Db;
using Microsoft.EntityFrameworkCore;


namespace EveLoader.DbContexts
{
    public class EveDbContext : DbContext
    {
        public EveDbContext(DbContextOptions<EveDbContext> options)
         : base(options)
        {
        }

        public DbSet<AgentsInSpace> AgentsInSpace { get; set; }
        public DbSet<AgentType> AgentTypes { get; set; }
        public DbSet<Ancestry> Ancestries { get; set; }
        public DbSet<Archetype> Archetypes { get; set; }
        public DbSet<Bloodline> Bloodlines { get; set; }
        public DbSet<Blueprint> Blueprints { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<CharacterAttribute> CharacterAttributes { get; set; }
        public DbSet<CharacterTitle> CharacterTitles { get; set; }
        public DbSet<CloneGrade> CloneGrades { get; set; }
        public DbSet<CompressibleType> CompressibleTypes { get; set; }
        public DbSet<ContrabandType> ContrabandTypes { get; set; }
        public DbSet<ControlTowerResource> ControlTowerResources { get; set; }
        public DbSet<CorporationActivity> CorporationActivities { get; set; }
        public DbSet<DBuffCollection> DBuffCollections { get; set; }
        public DbSet<DogmaAttributeCategory> DogmaAttributeCategories { get; set; }
        public DbSet<DogmaAttribute> DogmaAttributes { get; set; }
        public DbSet<DogmaEffect> DogmaEffects { get; set; }
        public DbSet<DogmaUnit> DogmaUnits { get; set; }
        public DbSet<Dungeon> Dungeons { get; set; }
        public DbSet<DynamicItemAttribute> DynamicItemAttributes { get; set; }
        public DbSet<EpicArc> EpicArcs { get; set; }
        public DbSet<Faction> Factions { get; set; }
        public DbSet<FreelanceJobSchema> FreelanceJobSchemas { get; set; }
        public DbSet<GraphicMaterialSet> GraphicMaterialSets { get; set; }
        public DbSet<Graphic> Graphics { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Landmark> Landmarks { get; set; }
        public DbSet<MapAsteroidBelt> MapAsteroidBelts { get; set; }
        public DbSet<MapConstellation> MapConstellations { get; set; }
        public DbSet<MapMoon> MapMoons { get; set; }
        public DbSet<MapPlanet> MapPlanets { get; set; }
        public DbSet<MapRegion> MapRegions { get; set; }
        public DbSet<MapSecondarySun> MapSecondarySuns { get; set; }
        public DbSet<MapSolarSystem> MapSolarSystems { get; set; }
        public DbSet<MapStargate> MapStargates { get; set; }
        public DbSet<MapStar> MapStars { get; set; }
        public DbSet<MarketGroup> MarketGroups { get; set; }
        public DbSet<Mastery> Masteries { get; set; }
        public DbSet<MercenaryTacticalOperation> MercenaryTacticalOperations { get; set; }
        public DbSet<MetaGroup> MetaGroups { get; set; }
        public DbSet<MilitaryCampaignObjective> MilitaryCampaignObjectives { get; set; }
        public DbSet<MilitaryCampaign> MilitaryCampaigns { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<NpcCharacter> NpcCharacters { get; set; }
        public DbSet<NpcCorporationDivision> NpcCorporationDivisions { get; set; }
        public DbSet<NpcCorporation> NpcCorporations { get; set; }
        public DbSet<NpcStation> NpcStations { get; set; }
        public DbSet<PlanetResource> PlanetResources { get; set; }
        public DbSet<PlanetSchematic> PlanetSchematics { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Sde> Sdes { get; set; }
        public DbSet<ShipTreeElement> ShipTreeElements { get; set; }
        public DbSet<ShipTreeFaction> ShipTreeFactions { get; set; }
        public DbSet<ShipTreeGroup> ShipTreeGroups { get; set; }
        public DbSet<SkinLicense> SkinLicenses { get; set; }
        public DbSet<SkinMaterial> SkinMaterials { get; set; }
        public DbSet<SkinrComponentCategories> SkinrComponentCategories { get; set; }
        public DbSet<SkinrComponentCategory> SkinrComponentCategoryEntries { get; set; }
        public DbSet<SkinrComponentPointValue> SkinrComponentPointValues { get; set; }
        public DbSet<SkinrComponentRarity> SkinrComponentRarities { get; set; }
        public DbSet<SkinrComponent> SkinrComponents { get; set; }
        public DbSet<SkinrSlotCategories> SkinrSlotCategories { get; set; }
        public DbSet<SkinrSlotCategory> SkinrSlotCategoryEntries { get; set; }
        public DbSet<SkinrSlotConfiguration> SkinrSlotConfigurations { get; set; }
        public DbSet<SkinrSlotName> SkinrSlotNames { get; set; }
        public DbSet<SkinrSlot> SkinrSlots { get; set; }
        public DbSet<SkinrTierThreshold> SkinrTierThresholds { get; set; }
        public DbSet<Skin> Skins { get; set; }
        public DbSet<SovereigntyUpgrade> SovereigntyUpgrades { get; set; }
        public DbSet<StationOperation> StationOperations { get; set; }
        public DbSet<StationService> StationServices { get; set; }
        public DbSet<TranslationLanguage> TranslationLanguages { get; set; }
        //public DbSet<Entities.Type> Types { get; set; }
        public DbSet<TypeBonus> TypeBonuses { get; set; }
        public DbSet<TypeDogma> TypeDogmas { get; set; }
        public DbSet<TypeElement> TypeElements { get; set; }
        public DbSet<TypeList> TypeLists { get; set; }
        public DbSet<TypeMaterial> TypeMaterials { get; set; }

    }
}
