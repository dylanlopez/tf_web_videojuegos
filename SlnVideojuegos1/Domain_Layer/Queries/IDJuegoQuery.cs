using System.Collections.Generic;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public interface IDJuegoQuery
    {
        DJuegoDto Find(DJuegoDto dto);
        int Delete(DJuegoDto dto);
        int Insert(DJuegoDto dto);
        List<DJuegoDto> List(DJuegoDto dto);
        int Update(DJuegoDto dto);
    }
}