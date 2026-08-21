using EveLoader.DbContexts;
using EveLoader.Entities;
using EveLoader.Mappers;
using EveLoader.Repositories;
using EveLoader.Services;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

public class LoadStaticData : ILoadStaticData
{

    private readonly IConfiguration _configuration;
    private readonly IAsyncRepository<SkinrComponentCategories> _repository;

    public LoadStaticData(IConfiguration configuration, IAsyncRepository<SkinrComponentCategories> repository)
    {
        _configuration = configuration;
        _repository = repository;
    }

    public async Task Load()
    {
        var path = _configuration["StaticDataPath"] ?? throw new InvalidOperationException("Configuration value StaticDataPath is missing.");

        var fileNames = GetFileNames(path);

        foreach (var fileName in fileNames)
        {
            Type? loadType = fileName switch
            {
                var f when f == "skinrComponentCategories.jsonl" => typeof(SkinrComponentCategories),
                _ => null
            };

            Console.WriteLine(loadType);

            if (loadType != null)
            {
                var x = File.ReadLines(path + fileName)
                    .Select(line => JsonSerializer.Deserialize(line, loadType)!)
                    .ToList();
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
            .EnumerateFiles(path)
            .Select(Path.GetFileName)
            .Where(fileName => !string.IsNullOrWhiteSpace(fileName))
            .Cast<string>()
            .ToList();
    }
}
