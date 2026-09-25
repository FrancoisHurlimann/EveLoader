namespace EveLoader.Mappers;

public static class TypeMapper
{
    public static EveLoaderEntities.Type ToDbEntity(this Console.StaticDataModels.TypeFile model)
        => new EveLoaderEntities.Type
        {
            Key = model.Key,
            BasePrice = model.BasePrice,
            Capacity = model.Capacity,
            Description = model.Description != null && model.Description.TryGetValue("en", out var description)
                ? description
                : model.Description?.Values.FirstOrDefault(),
            GraphicID = model.GraphicID,
            GroupID = model.GroupID,
            IconID = model.IconID,
            Mass = model.Mass,
            Name = model.Name != null && model.Name.TryGetValue("en", out var name)
                ? name
                : model.Name?.Values.FirstOrDefault(),
            PortionSize = model.PortionSize,
            Published = model.Published,
            RaceID = model.RaceID,
            Radius = model.Radius,
            SoundID = model.SoundID,
            Volume = model.Volume
        };
}
