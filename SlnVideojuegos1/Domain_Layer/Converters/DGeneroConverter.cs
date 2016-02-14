using System.Collections.Generic;
using Domain_Layer.Dtos;
using Entity_Layer.Model;

namespace Domain_Layer.Converters
{
    internal class DGeneroConverter
    {
        internal static DGeneroDto ToDto(GENERO entity)
        {
            var dto = new DGeneroDto();
            dto.Id = entity.ID;
            dto.Nombre = entity.NOMBRE;
            dto.Descripcion = entity.DESCRIPCION;
            return dto;
        }
        internal static List<DGeneroDto> ToDtos(List<GENERO> entities)
        {
            var dtos = new List<DGeneroDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        internal static GENERO ToEntity(DGeneroDto dto)
        {
            var entity = new GENERO();
            entity.ID = dto.Id;
            entity.NOMBRE = dto.Nombre;
            entity.DESCRIPCION = dto.Descripcion;
            return entity;
        }
    }
}