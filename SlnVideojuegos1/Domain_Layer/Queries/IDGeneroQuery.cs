using System.Collections.Generic;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public interface IDGeneroQuery
    {
        DGeneroDto Find(DGeneroDto dto);
        int Delete(DGeneroDto dto);
        int Insert(DGeneroDto dto);
        List<DGeneroDto> List(DGeneroDto dto); 
        int Update(DGeneroDto dto);
    }
}