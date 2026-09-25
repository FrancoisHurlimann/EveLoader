using EveLoaderEntities;
using EveLoader.Console.StaticDataModels;
using EveLoader.Mappers;
using EveLoader.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;


public class LoadStaticData : ILoadStaticData
{

    private readonly IConfiguration _configuration;
    private readonly IServiceProvider _serviceProvider;

    public LoadStaticData(IConfiguration configuration, IServiceProvider serviceProvider)
    {
        _configuration = configuration;
        _serviceProvider = serviceProvider;
    }

    public async Task Load()
    {
        var path = _configuration["StaticDataPath"] ?? throw new InvalidOperationException("Configuration value StaticDataPath is missing.");

        var fileNames = GetFileNames(path);

        foreach (var fileName in fileNames)
        {
            var fullPath = System.IO.Path.Combine(path, fileName);

            switch (Path.GetFileName(fullPath)?.ToLowerInvariant())
            {
                //case "agentsinspace.jsonl":
                //    LoadBasic<AgentsInSpaceFile, AgentsInSpace>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "agenttypes.jsonl":
                //    LoadBasic<AgentTypeFile, AgentType>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "ancestries.jsonl":
                //    LoadBasic<AncestryFile, Ancestry>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "archetypes.jsonl":
                //    LoadBasic<ArchetypeFile, Archetype>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "bloodlines.jsonl":
                //    LoadBasic<BloodlineFile, Bloodline>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "blueprints.jsonl":
                //    LoadBasic<BlueprintFile, Blueprint>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "categories.jsonl":
                //    LoadBasic<CategoryFile, Category>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "certificates.jsonl":
                //    LoadBasic<CertificateFile, Certificate>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "characterattributes.jsonl":
                //    LoadBasic<CharacterAttributeFile, CharacterAttribute>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "charactertitles.jsonl":
                //    LoadBasic<CharacterTitleFile, CharacterTitle>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "clonegrades.jsonl":
                //    LoadBasic<CloneGradeFile, CloneGrade>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "compressibletypes.jsonl":
                //    LoadBasic<CompressibleTypeFile, CompressibleType>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "contrabandtypes.jsonl":
                //    LoadBasic<ContrabandTypeFile, ContrabandType>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "controltowerresources.jsonl":
                //    LoadBasic<ControlTowerResourceFile, ControlTowerResource>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "corporationactivities.jsonl":
                //    LoadBasic<CorporationActivityFile, CorporationActivity>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "dbuffcollections.jsonl":
                //    LoadBasic<DBuffCollectionFile, DBuffCollection>(fullPath, m => m.ToDbEntity());
                //    break;
                //case "dogmaattributecategories.jsonl":
                //    LoadBasic<DogmaAttributeCategoryFile, DogmaAttributeCategory>(fullPath, m => m.ToDbEntity());
                //    break;
                case "dogmaattributes.jsonl":
                    LoadBasic<DogmaAttributeFile, DogmaAttribute>(fullPath, m => m.ToDbEntity());
                    break;
                    //case "dogmaeffects.jsonl":
                    //    LoadBasic<DogmaEffectFile, DogmaEffect>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dogmaunits.jsonl":
                    //    LoadBasic<DogmaUnitFile, DogmaUnit>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dungeons.jsonl":
                    //    LoadBasic<DungeonFile, Dungeon>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dynamicitemattributes.jsonl":
                    //    LoadBasic<DynamicItemAttributeFile, DynamicItemAttribute>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "epicarcs.jsonl":
                    //    LoadBasic<EpicArcFile, EpicArc>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "factions.jsonl":
                    //    LoadBasic<FactionFile, Faction>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "freelancejobschemas.jsonl":
                    //    LoadBasic<FreelanceJobSchemaFile, FreelanceJobSchema>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "graphicmaterialsets.jsonl":
                    //    LoadBasic<GraphicMaterialSetFile, GraphicMaterialSet>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "graphics.jsonl":
                    //    LoadBasic<GraphicFile, Graphic>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "groups.jsonl":
                    //    LoadBasic<GroupFile, Group>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "icons.jsonl":
                    //    LoadBasic<IconFile, Icon>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "landmarks.jsonl":
                    //    LoadBasic<LandmarkFile, Landmark>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapasteroidbelts.jsonl":
                    //    LoadBasic<MapAsteroidBeltFile, MapAsteroidBelt>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapconstellations.jsonl":
                    //    LoadBasic<MapConstellationFile, MapConstellation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapmoons.jsonl":
                    //    LoadBasic<MapMoonFile, MapMoon>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapplanets.jsonl":
                    //    LoadBasic<MapPlanetFile, MapPlanet>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapregions.jsonl":
                    //    LoadBasic<MapRegionFile, MapRegion>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapsecondarysuns.jsonl":
                    //    LoadBasic<MapSecondarySunFile, MapSecondarySun>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapsolarsystems.jsonl":
                    //    LoadBasic<MapSolarSystemFile, MapSolarSystem>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapstargates.jsonl":
                    //    LoadBasic<MapStargateFile, MapStargate>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapstars.jsonl":
                    //    LoadBasic<MapStarFile, MapStar>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "marketgroups.jsonl":
                    //    LoadBasic<MarketGroupFile, MarketGroup>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "masteries.jsonl":
                    //    LoadBasic<MasteryFile, Mastery>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mercenarytacticaloperations.jsonl":
                    //    LoadBasic<MercenaryTacticalOperationFile, MercenaryTacticalOperation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "metagroups.jsonl":
                    //    LoadBasic<MetaGroupFile, MetaGroup>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "militarycampaignobjectives.jsonl":
                    //    LoadBasic<MilitaryCampaignObjectiveFile, MilitaryCampaignObjective>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "militarycampaigns.jsonl":
                    //    LoadBasic<MilitaryCampaignFile, MilitaryCampaign>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "missions.jsonl":
                    //    LoadBasic<MissionFile, Mission>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "npccharacters.jsonl":
                    //    LoadBasic<NpcCharacterFile, NpcCharacter>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "npccorporationdivisions.jsonl":
                    //    LoadBasic<NpcCorporationDivisionFile, NpcCorporationDivision>(fullPath, m => m.ToDbEntity());
                    //    break;
                    ////case "npccorporations.jsonl":
                    ////    LoadBasic<NpcCorporationFile, NpcCorporation>(fullPath, m => m.ToDbEntity());
                    ////    break;
                    //case "npcstations.jsonl":
                    //    LoadBasic<NpcStationFile, NpcStation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "planetresources.jsonl":
                    //    LoadBasic<PlanetResourceFile, PlanetResource>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "planetschematics.jsonl":
                    //    LoadBasic<PlanetSchematicFile, PlanetSchematic>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "races.jsonl":
                    //    LoadBasic<RaceFile, Race>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "shiptreeelements.jsonl":
                    //    LoadBasic<ShipTreeElementFile, ShipTreeElement>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "shiptreefactions.jsonl":
                    //    LoadBasic<ShipTreeFactionFile, ShipTreeFaction>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "shiptreegroups.jsonl":
                    //    LoadBasic<ShipTreeGroupFile, ShipTreeGroup>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinlicenses.jsonl":
                    //    LoadBasic<SkinLicenseFile, SkinLicense>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinmaterials.jsonl":
                    //    LoadBasic<SkinMaterialFile, SkinMaterial>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponentcategories.jsonl":
                    //    LoadBasic<SkinrComponentCategoryFile, SkinrComponentCategory>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponentpointvalues.jsonl":
                    //    LoadBasic<SkinrComponentPointValueFile, SkinrComponentPointValue>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponentrarities.jsonl":
                    //    LoadBasic<SkinrComponentRarityFile, SkinrComponentRarity>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponents.jsonl":
                    //    LoadBasic<SkinrComponentFile, SkinrComponent>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslotcategories.jsonl":
                    //    LoadBasic<SkinrSlotCategoryFile, SkinrSlotCategory>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslotconfigurations.jsonl":
                    //    LoadBasic<SkinrSlotConfigurationFile, SkinrSlotConfiguration>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslotnames.jsonl":
                    //    LoadBasic<SkinrSlotNameFile, SkinrSlotName>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslots.jsonl":
                    //    LoadBasic<SkinrSlotFile, SkinrSlot>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrtierthresholds.jsonl":
                    //    LoadBasic<SkinrTierThresholdFile, SkinrTierThreshold>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skins.jsonl":
                    //    LoadBasic<SkinFile, Skin>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "sovereigntyupgrades.jsonl":
                    //    LoadBasic<SovereigntyUpgradeFile, SovereigntyUpgrade>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "stationoperations.jsonl":
                    //    LoadBasic<StationOperationFile, StationOperation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "stationservices.jsonl":
                    //    LoadBasic<StationServiceFile, StationService>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "translationlanguages.jsonl":
                    //    LoadBasic<TranslationLanguageFile, TranslationLanguage>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typebonus.jsonl":
                    //    LoadBasic<TypeBonusFile, TypeBonus>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typedogma.jsonl":
                    //    LoadBasic<TypeDogmaFile, TypeDogma>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typeelements.jsonl":
                    //    LoadBasic<TypeElementFile, TypeElement>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typelists.jsonl":
                    //    LoadBasic<TypeListFile, TypeList>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typematerials.jsonl":
                    //    LoadBasic<TypeMaterialFile, TypeMaterial>(fullPath, m => m.ToDbEntity());
                    //    break;
                    ////case "types.jsonl":
                    ////    LoadBasic<TypeFile, Entities.Type>(fullPath, m => m.ToDbEntity());
                    ////    break;
            }
        }
    }

    public IReadOnlyList<string> GetFileNames(string path)
    {
        if (!Directory.Exists(path))
        {
            return new List<string>();
        }

        return Directory
            .EnumerateFiles(path, "*.jsonl")
            .Select(Path.GetFileName)
            .Where(static fileName => !string.IsNullOrWhiteSpace(fileName))
            .ToList();
    }

    public void LoadBasic<TFile, TEntity>(string fileName, Func<TFile, TEntity> map)
        where TFile : class
        where TEntity : class
    {
        //read file line by line and deserialize each line to TFile, then map to TEntity and add to repository
        var lines = File.ReadLines(fileName);

        var itemsTest = lines
    .Select(line => JsonSerializer.Deserialize<TFile>(line))
    .Where(item => item != null)
    .ToList();


        var items = lines
            .Select(line => JsonSerializer.Deserialize<TFile>(line))
            .Where(item => item != null)
            .Select(item => map(item!))
            .ToList();

        try
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var repository = scope.ServiceProvider.GetRequiredService<IAsyncRepository<TEntity>>();
                repository.DeleteAllAsync().Wait();
                repository.AddRangeAsync(items!).Wait();
            }
        }
        catch (Exception ex)
        {

            var x = ex;

        }

        //write to repository
        //using (var scope = _serviceProvider.CreateScope())
        //{
        //    var repository = scope.ServiceProvider.GetRequiredService<IAsyncRepository<TEntity>>();
        //    repository.DeleteAllAsync().Wait();
        //    repository.AddRangeAsync(items!).Wait();
        //}

      
    }
}


