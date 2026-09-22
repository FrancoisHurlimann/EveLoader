using EveLoader.Console.Entities;
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
                //    LoadBasic<AgentsInSpaceFile,AgentsInSpace>(fullPath, m => m.ToDbEntity());
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
                case "blueprints.jsonl":
                    LoadBasic<BlueprintFile, Blueprint>(fullPath, m => m.ToDbEntity());
                    break;
                    //case "categories.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Category, EveLoader.Entities.Db.Category>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "certificates.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Certificate, EveLoader.Entities.Db.Certificate>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "characterattributes.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.CharacterAttribute, EveLoader.Entities.Db.CharacterAttribute>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "charactertitles.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.CharacterTitle, EveLoader.Entities.Db.CharacterTitle>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "clonegrades.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.CloneGrade, EveLoader.Entities.Db.CloneGrade>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "compressibletypes.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.CompressibleType, EveLoader.Entities.Db.CompressibleType>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "contrabandtypes.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.ContrabandType, EveLoader.Entities.Db.ContrabandType>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "controltowerresources.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.ControlTowerResource, EveLoader.Entities.Db.ControlTowerResource>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "corporationactivities.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.CorporationActivity, EveLoader.Entities.Db.CorporationActivity>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dbuffcollections.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.DBuffCollection, EveLoader.Entities.Db.DBuffCollection>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dogmaattributecategories.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.DogmaAttributeCategory, EveLoader.Entities.Db.DogmaAttributeCategory>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dogmaattributes.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.DogmaAttribute, EveLoader.Entities.Db.DogmaAttribute>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dogmaeffects.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.DogmaEffect, EveLoader.Entities.Db.DogmaEffect>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dogmaunits.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.DogmaUnit, EveLoader.Entities.Db.DogmaUnit>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dungeons.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Dungeon, EveLoader.Entities.Db.Dungeon>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "dynamicitemattributes.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.DynamicItemAttribute, EveLoader.Entities.Db.DynamicItemAttribute>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "epicarcs.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.EpicArc, EveLoader.Entities.Db.EpicArc>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "factions.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Faction, EveLoader.Entities.Db.Faction>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "freelancejobschemas.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.FreelanceJobSchema, EveLoader.Entities.Db.FreelanceJobSchema>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "graphicmaterialsets.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.GraphicMaterialSet, EveLoader.Entities.Db.GraphicMaterialSet>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "graphics.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Graphic, EveLoader.Entities.Db.Graphic>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "groups.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Group, EveLoader.Entities.Db.Group>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "icons.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Icon, EveLoader.Entities.Db.Icon>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "landmarks.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Landmark, EveLoader.Entities.Db.Landmark>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapasteroidbelts.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapAsteroidBelt, EveLoader.Entities.Db.MapAsteroidBelt>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapconstellations.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapConstellation, EveLoader.Entities.Db.MapConstellation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapmoons.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapMoon, EveLoader.Entities.Db.MapMoon>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapplanets.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapPlanet, EveLoader.Entities.Db.MapPlanet>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapregions.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapRegion, EveLoader.Entities.Db.MapRegion>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapsecondarysuns.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapSecondarySun, EveLoader.Entities.Db.MapSecondarySun>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapsolarsystems.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapSolarSystem, EveLoader.Entities.Db.MapSolarSystem>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapstargates.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapStargate, EveLoader.Entities.Db.MapStargate>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mapstars.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MapStar, EveLoader.Entities.Db.MapStar>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "marketgroups.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MarketGroup, EveLoader.Entities.Db.MarketGroup>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "masteries.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Mastery, EveLoader.Entities.Db.Mastery>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "mercenarytacticaloperations.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MercenaryTacticalOperation, EveLoader.Entities.Db.MercenaryTacticalOperation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "metagroups.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MetaGroup, EveLoader.Entities.Db.MetaGroup>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "militarycampaignobjectives.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MilitaryCampaignObjective, EveLoader.Entities.Db.MilitaryCampaignObjective>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "militarycampaigns.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.MilitaryCampaign, EveLoader.Entities.Db.MilitaryCampaign>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "missions.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Mission, EveLoader.Entities.Db.Mission>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "npccharacters.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.NpcCharacter, EveLoader.Entities.Db.NpcCharacter>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "npccorporationdivisions.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.NpcCorporationDivision, EveLoader.Entities.Db.NpcCorporationDivision>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "npccorporations.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.NpcCorporation, EveLoader.Entities.Db.NpcCorporation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "npcstations.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.NpcStation, EveLoader.Entities.Db.NpcStation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "planetresources.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.PlanetResource, EveLoader.Entities.Db.PlanetResource>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "planetschematics.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.PlanetSchematic, EveLoader.Entities.Db.PlanetSchematic>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "races.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Race, EveLoader.Entities.Db.Race>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "shiptreeelements.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.ShipTreeElement, EveLoader.Entities.Db.ShipTreeElement>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "shiptreefactions.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.ShipTreeFaction, EveLoader.Entities.Db.ShipTreeFaction>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "shiptreegroups.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.ShipTreeGroup, EveLoader.Entities.Db.ShipTreeGroup>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinlicenses.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinLicense, EveLoader.Entities.Db.SkinLicense>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinmaterials.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinMaterial, EveLoader.Entities.Db.SkinMaterial>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponentcategories.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrComponentCategory, EveLoader.Entities.Db.SkinrComponentCategory>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponentpointvalues.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrComponentPointValue, EveLoader.Entities.Db.SkinrComponentPointValue>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponentrarities.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrComponentRarity, EveLoader.Entities.Db.SkinrComponentRarity>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrcomponents.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrComponent, EveLoader.Entities.Db.SkinrComponent>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslotcategories.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrSlotCategory, EveLoader.Entities.Db.SkinrSlotCategory>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslotconfigurations.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrSlotConfiguration, EveLoader.Entities.Db.SkinrSlotConfiguration>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslotnames.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrSlotName, EveLoader.Entities.Db.SkinrSlotName>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrslots.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrSlot, EveLoader.Entities.Db.SkinrSlot>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skinrtierthresholds.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SkinrTierThreshold, EveLoader.Entities.Db.SkinrTierThreshold>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "skins.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Skin, EveLoader.Entities.Db.Skin>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "sovereigntyupgrades.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.SovereigntyUpgrade, EveLoader.Entities.Db.SovereigntyUpgrade>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "stationoperations.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.StationOperation, EveLoader.Entities.Db.StationOperation>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "stationservices.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.StationService, EveLoader.Entities.Db.StationService>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "translationlanguages.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.TranslationLanguage, EveLoader.Entities.Db.TranslationLanguage>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typebonus.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.TypeBonus, EveLoader.Entities.Db.TypeBonus>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typedogma.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.TypeDogma, EveLoader.Entities.Db.TypeDogma>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typeelements.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.TypeElement, EveLoader.Entities.Db.TypeElement>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typelists.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.TypeList, EveLoader.Entities.Db.TypeList>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "typematerials.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.TypeMaterial, EveLoader.Entities.Db.TypeMaterial>(fullPath, m => m.ToDbEntity());
                    //    break;
                    //case "types.jsonl":
                    //    LoadBasic<EveLoader.Entities.StaticDataModels.Type, EveLoader.Entities.Db.Type>(fullPath, m => m.ToDbEntity());
                    //    break;
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
            .Where(fileName => !string.IsNullOrWhiteSpace(fileName))
            .ToList();
    }

    public void LoadBasic<TFile, TEntity>(string fileName, Func<TFile, TEntity> map)
        where TFile : class
        where TEntity : class
    {
        var lines = File.ReadLines(fileName);
        var items = lines
            .Select(line => JsonSerializer.Deserialize<TFile>(line))
            .Where(item => item != null)
            .Select(item => map(item!))
            .ToList();

     

        //var itemst = lines
        //   .Select(line => JsonSerializer.Deserialize<TFile>(line))
        //   .Where(item => item != null)
        //   .ToList();

        using (var scope = _serviceProvider.CreateScope())
        {
            var repository = scope.ServiceProvider.GetRequiredService<IAsyncRepository<TEntity>>();
            repository.DeleteAllAsync().Wait();
            repository.AddRangeAsync(items!).Wait();
        }
    }
}


