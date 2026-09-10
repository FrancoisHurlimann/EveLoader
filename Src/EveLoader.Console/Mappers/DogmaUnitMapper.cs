using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DogmaUnitMapper
{
    public static DogmaUnit ToDbEntity(this Console.StaticDataModels.DogmaUnitFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.DogmaUnitFile, DogmaUnit>();
}
