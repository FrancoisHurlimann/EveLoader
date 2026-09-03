using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using EveLoader.DbContexts;
using EveLoader.Entities;
using EveLoader.Repositories;
using EveLoader.Services;

public class Program
{
    private readonly ILogger<Program> _logger;
    private readonly ILoadStaticData _loadStaticData;

    public Program(ILogger<Program> logger, ILoadStaticData loadStaticData)
    {
        _logger = logger;
        _loadStaticData = loadStaticData;
    }

    public static async Task Main(string[] args)
    {
        IHost host = CreateHostBuilder(args).Build();
        var program = host.Services.GetRequiredService<Program>();
        await program.RunAsync();
    }

    public async Task RunAsync()
    {
        await _loadStaticData.Load();
        return;
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<Program>();

                services.AddTransient(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
                services.AddDbContext<EveDbContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("EveDb")));
                services.AddTransient<ILoadStaticData, LoadStaticData>();
            });
    }
}
