using System.Collections.Generic;
using Domain_Layer.Dtos;
using Entity_Layer.Model;

namespace Domain_Layer.Converters
{
    internal class DJuegoGeneroConverter
    {
        internal static DJuegoGeneroDto ToDto(JUEGO_GENERO entity)
        {
            var dto = new DJuegoGeneroDto();
            dto.Id = entity.ID;
            dto.IdJuego = entity.JUEGO.ID;
            dto.NombreJuego = entity.JUEGO.NOMBRE;
            dto.PrecioJuego = entity.JUEGO.PRECIO;
            dto.IdGenero = entity.GENERO.ID;
            dto.NombreGenero = entity.GENERO.NOMBRE;
            return dto;
        }
        internal static List<DJuegoGeneroDto> ToDtos(List<JUEGO_GENERO> entities)
        {
            var dtos = new List<DJuegoGeneroDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        internal static JUEGO_GENERO ToEntity(DJuegoGeneroDto dto)
        {
            var entity = new JUEGO_GENERO();
            entity.ID = dto.Id;
            entity.ID_JUEGO = dto.IdJuego;
            entity.ID_GENERO = dto.IdGenero;
            return entity;
        }
    }
}