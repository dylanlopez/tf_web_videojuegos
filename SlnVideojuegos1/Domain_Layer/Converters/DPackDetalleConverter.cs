using System.Collections.Generic;
using Domain_Layer.Dtos;
using Entity_Layer.Model;

namespace Domain_Layer.Converters
{
    internal class DPackDetalleConverter
    {
        internal static DPackDetalleDto ToDto(PACK_DETALLE entity)
        {
            var dto = new DPackDetalleDto();
            dto.Id = entity.ID;
            dto.IdPack = entity.PACK.ID;
            dto.NombrePack = entity.PACK.NOMBRE;
            dto.PrecioPack = entity.PACK.PRECIO;
            dto.IdJuego = entity.JUEGO.ID;
            dto.NombreJuego = entity.JUEGO.NOMBRE;
            return dto;
        }
        internal static List<DPackDetalleDto> ToDtos(List<PACK_DETALLE> entities)
        {
            var dtos = new List<DPackDetalleDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        internal static PACK_DETALLE ToEntity(DPackDetalleDto dto)
        {
            var entity = new PACK_DETALLE();
            entity.ID = dto.Id;
            entity.ID_PACK = dto.IdPack;
            entity.ID_JUEGO = dto.IdJuego;
            return entity;
        }
    }
}