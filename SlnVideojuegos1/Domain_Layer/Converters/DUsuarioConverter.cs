using System.Collections.Generic;
using Domain_Layer.Dtos;
using Entity_Layer.Model;

namespace Domain_Layer.Converters
{
    internal class DUsuarioConverter
    {
        internal static DUsuarioDto ToDto(USUARIO entity)
        {
            var dto = new DUsuarioDto();
            dto.Id = entity.ID;
            dto.Username = entity.USERNAME;
            dto.Password = entity.PASSWORD;
            dto.EstaActivo = entity.ACTIVO;
            return dto;
        }
        internal static List<DUsuarioDto> ToDtos(List<USUARIO> entities)
        {
            var dtos = new List<DUsuarioDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        internal static USUARIO ToEntity(DUsuarioDto dto)
        {
            var entity = new USUARIO();
            entity.ID = dto.Id;
            entity.USERNAME = dto.Username;
            entity.PASSWORD = dto.Password;
            entity.ACTIVO = dto.EstaActivo;
            return entity;
        }
    }
}