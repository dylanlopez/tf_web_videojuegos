using System.Collections.Generic;
using Domain_Layer.Dtos;
using Entity_Layer.Model;

namespace Domain_Layer.Converters
{
    internal class DPackConverter
    {
        internal static DPackDto ToDto(PACK entity)
        {
            var dto = new DPackDto();
            dto.Id = entity.ID;
            dto.Nombre = entity.NOMBRE;
            dto.Precio = entity.PRECIO;
            dto.Descripcion = entity.DESCRIPCION;
            return dto;
        }
        internal static List<DPackDto> ToDtos(List<PACK> entities)
        {
            var dtos = new List<DPackDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        internal static PACK ToEntity(DPackDto dto)
        {
            var entity = new PACK();
            entity.ID = dto.Id;
            entity.NOMBRE = dto.Nombre;
            entity.PRECIO = dto.Precio;
            entity.DESCRIPCION = dto.Descripcion;
            return entity;
        }
    }
}