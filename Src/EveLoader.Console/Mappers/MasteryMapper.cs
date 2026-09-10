using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MasteryMapper
{
    public static Mastery ToDbEntity(this Console.StaticDataModels.MasteryFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MasteryFile, Mastery>();
}
