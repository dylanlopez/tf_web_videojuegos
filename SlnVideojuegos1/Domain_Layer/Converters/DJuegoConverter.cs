using System.Collections.Generic;
using Domain_Layer.Dtos;
using Entity_Layer.Model;

namespace Domain_Layer.Converters
{
    internal class DJuegoConverter
    {
        internal static DJuegoDto ToDto(JUEGO entity)
        {
            var dto = new DJuegoDto();
            dto.Id = entity.ID;
            dto.Nombre = entity.NOMBRE;
            dto.Anho = entity.ANHO;
            dto.FechaLanzamiento = entity.FECHA_LANZAMIENTO;
            dto.Estudio = entity.ESTUDIO;
            dto.Precio = entity.PRECIO;
            dto.Tags = entity.TAGS;
            dto.Descripcion = entity.DESCRIPCION;
            return dto;
        }
        internal static List<DJuegoDto> ToDtos(List<JUEGO> entities)
        {
            var dtos = new List<DJuegoDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        internal static JUEGO ToEntity(DJuegoDto dto)
        {
            var entity = new JUEGO();
            entity.ID = dto.Id;
            entity.NOMBRE = dto.Nombre;
            entity.ANHO = dto.Anho;
            entity.FECHA_LANZAMIENTO = dto.FechaLanzamiento;
            entity.ESTUDIO = dto.Estudio;
            entity.PRECIO = dto.Precio;
            entity.TAGS = dto.Tags;
            entity.DESCRIPCION = dto.Descripcion;
            return entity;
        }
    }
}