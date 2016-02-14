using System.Collections.Generic;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public interface IDPackQuery
    {
        DPackDto Find(DPackDto dto);
        int Delete(DPackDto dto);
        int Insert(DPackDto dto);
        List<DPackDto> List(DPackDto dto);
        int Update(DPackDto dto);
    }
}