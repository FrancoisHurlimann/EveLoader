using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class LandmarkMapper
{
    public static Landmark ToDbEntity(this Console.StaticDataModels.LandmarkFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.LandmarkFile, Landmark>();
}
