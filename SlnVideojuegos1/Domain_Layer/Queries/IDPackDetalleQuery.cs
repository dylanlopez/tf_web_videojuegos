using System.Collections.Generic;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public interface IDPackDetalleQuery
    {
        DPackDetalleDto Find(DPackDetalleDto dto);
        int Delete(DPackDetalleDto dto);
        int Insert(DPackDetalleDto dto);
        List<DPackDetalleDto> List(DPackDetalleDto dto);
        int Update(DPackDetalleDto dto);
    }
}