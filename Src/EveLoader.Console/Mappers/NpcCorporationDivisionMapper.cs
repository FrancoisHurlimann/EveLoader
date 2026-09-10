using EveLoader.Console.Entities;

namespace EveLoader.Mappers;

public static class NpcCorporationDivisionMapper
{
    public static NpcCorporationDivision ToDbEntity(this Console.StaticDataModels.NpcCorporationDivisionFile model)
        => model.ToDbEntityViaJson<Console.StaticDataModels.NpcCorporationDivisionFile, NpcCorporationDivision>();
}
