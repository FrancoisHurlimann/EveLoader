using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class MetaGroupMapper
{
    public static MetaGroup ToDbEntity(this Console.StaticDataModels.MetaGroupFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.MetaGroupFile, MetaGroup>();
}
