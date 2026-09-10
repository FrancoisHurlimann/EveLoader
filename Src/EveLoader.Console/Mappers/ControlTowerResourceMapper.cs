using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class ControlTowerResourceMapper
{
    public static ControlTowerResource ToDbEntity(this Console.StaticDataModels.ControlTowerResourceFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.ControlTowerResourceFile, ControlTowerResource>();
}
