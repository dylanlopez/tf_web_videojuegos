using System.Collections.Generic;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public interface IDJuegoGeneroQuery
    {
        DJuegoGeneroDto Find(DJuegoGeneroDto dto);
        int Delete(DJuegoGeneroDto dto);
        int Insert(DJuegoGeneroDto dto);
        List<DJuegoGeneroDto> List(DJuegoGeneroDto dto);
        int Update(DJuegoGeneroDto dto);
    }
}