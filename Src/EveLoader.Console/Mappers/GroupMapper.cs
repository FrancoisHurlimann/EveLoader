using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class GroupMapper
{
    public static Group ToDbEntity(this Console.StaticDataModels.GroupFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.GroupFile, Group>();
}
