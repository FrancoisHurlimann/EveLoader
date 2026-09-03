using EveLoader.Entities.StaticDataModels;
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
                case "agentsinspace.jsonl":
                    LoadBasic<EveLoader.Entities.StaticDataModels.AgentsInSpace, EveLoader.Entities.Db.AgentsInSpace>(fullPath, m => m.ToDbEntity());
                    break;
                case "agenttypes.jsonl":
                    LoadBasic<EveLoader.Entities.StaticDataModels.AgentType, EveLoader.Entities.Db.AgentType>(fullPath, m => m.ToDbEntity());
                    break;
                case "ancestries.jsonl":
                    LoadBasic<EveLoader.Entities.StaticDataModels.Ancestry, EveLoader.Entities.Db.Ancestry>(fullPath, m => m.ToDbEntity());
                    break;
                case "Archetype.jsonl":
                    LoadBasic<EveLoader.Entities.StaticDataModels.Archetype, EveLoader.Entities.Db.Archetype>(fullPath, m => m.ToDbEntity());
                break;
                    //case "skinrcomponentcategories.jsonl":
                    //    LoadBasic<SkinrComponentCategories>(fullPath);
                    //    break;
                    //case "skinrslotcategories.jsonl":
                    //    LoadBasic<SkinrSlotCategories>(fullPath);
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

    public void LoadBasic<TModel, TEntity>(string fileName, Func<TModel, TEntity> map)
        where TModel : class
        where TEntity : class
    {
        var lines = File.ReadLines(fileName);
        var items = lines
            .Select(line => JsonSerializer.Deserialize<TModel>(line))
            .Where(item => item != null)
            .Select(item => map(item!))
            .ToList();

        using (var scope = _serviceProvider.CreateScope())
        {
            var repository = scope.ServiceProvider.GetRequiredService<IAsyncRepository<TEntity>>();
            repository.DeleteAllAsync().Wait();
            repository.AddRangeAsync(items!).Wait();
        }
    }
}


