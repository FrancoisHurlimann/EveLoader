using EveLoader.DbContexts;
using EveLoader.Entities;
using EveLoader.Mappers;
using EveLoader.Repositories;
using EveLoader.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
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
                    LoadBasic<AgentsInSpace>(fullPath);
                    break;
                case "skinrcomponentcategories.jsonl":
                    LoadBasic<SkinrComponentCategories>(fullPath);
                    break;
                case "skinrslotcategories.jsonl":
                    LoadBasic<SkinrSlotCategories>(fullPath);
                    break;
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

    public void LoadBasic<T>(string fileName) where T : class
    {
        var lines = File.ReadLines(fileName);
        var items = lines
            .Select(line => JsonSerializer.Deserialize<T>(line))
            .Where(item => item != null)
            .ToList();
        using (var scope = _serviceProvider.CreateScope())
        {
            var repository = scope.ServiceProvider.GetRequiredService<IAsyncRepository<T>>();
            repository.DeleteAllAsync().Wait();
            repository.AddRangeAsync(items!).Wait();
        }
    }
}
