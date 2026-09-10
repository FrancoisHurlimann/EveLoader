using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class DogmaEffectMapper
{
    public static DogmaEffect ToDbEntity(this Console.StaticDataModels.DogmaEffectFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.DogmaEffectFile, DogmaEffect>();
}
