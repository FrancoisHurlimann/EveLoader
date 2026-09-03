using System.Text.Json;

namespace EveLoader.Mappers;

internal static class JsonMapperExtensions
{
    public static TEntity ToDbEntityViaJson<TModel, TEntity>(this TModel model)
        where TModel : class
        where TEntity : class
    {
        var json = JsonSerializer.Serialize(model);
        return JsonSerializer.Deserialize<TEntity>(json)!;
    }
}
