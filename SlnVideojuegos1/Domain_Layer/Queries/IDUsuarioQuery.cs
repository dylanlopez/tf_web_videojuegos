using System.Collections.Generic;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public interface IDUsuarioQuery
    {
        DUsuarioDto Find(DUsuarioDto dto);
        int Delete(DUsuarioDto dto);
        int Insert(DUsuarioDto dto);
        List<DUsuarioDto> List(DUsuarioDto dto);
        int Update(DUsuarioDto dto);
    }
}