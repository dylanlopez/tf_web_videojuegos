using System;
using System.Collections.Generic;
using System.Linq;
using Domain_Layer.Converters;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public partial class DQuerys : IDUsuarioQuery
    {
        public DUsuarioDto Find(DUsuarioDto dto)
        {
            var result = new DUsuarioDto();
            try
            {
                var query = _dbContext.USUARIO.Where(s => s.USERNAME == dto.Username);
                result = DUsuarioConverter.ToDto(query.FirstOrDefault());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }
        }
        public int Delete(DUsuarioDto dto)
        {
            try
            {
                var id = dto.Id;
                _dbContext.USUARIO.Remove(DUsuarioConverter.ToEntity(dto));
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int Insert(DUsuarioDto dto)
        {
            try
            {
                var entity = DUsuarioConverter.ToEntity(dto);
                _dbContext.USUARIO.Add(entity);
                _dbContext.SaveChanges();
                return entity.ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<DUsuarioDto> List(DUsuarioDto dto)
        {
            var result = new List<DUsuarioDto>();
            try
            {
                result = DUsuarioConverter.ToDtos(_dbContext.USUARIO.ToList());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Update(DUsuarioDto dto)
        {
            try
            {
                var entity = DUsuarioConverter.ToEntity(Find(dto));
                if (entity != null)
                {
                    _dbContext.Entry(entity).CurrentValues.SetValues(DUsuarioConverter.ToEntity(dto));
                    _dbContext.SaveChanges();
                    return entity.ID;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}