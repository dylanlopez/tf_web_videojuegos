using Domain_Layer.Converters;
using Domain_Layer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain_Layer.Queries
{
    public partial class DQuerys : IDPackQuery
    {
        public DPackDto Find(DPackDto dto)
        {
            var result = new DPackDto();
            try
            {
                var query = _dbContext.PACK.Where(s => s.ID == dto.Id);
                result = DPackConverter.ToDto(query.FirstOrDefault());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Delete(DPackDto dto)
        {
            try
            {
                var entity = _dbContext.PACK.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    _dbContext.PACK.Remove(entity);
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
        public int Insert(DPackDto dto)
        {
            try
            {
                var entity = DPackConverter.ToEntity(dto);
                _dbContext.PACK.Add(entity);
                _dbContext.SaveChanges();
                return entity.ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<DPackDto> List(DPackDto dto)
        {
            var result = new List<DPackDto>();
            try
            {
                result = DPackConverter.ToDtos(_dbContext.PACK.ToList());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Update(DPackDto dto)
        {
            try
            {
                var entity = _dbContext.PACK.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    entity.NOMBRE = dto.Nombre;
                    entity.PRECIO = dto.Precio;
                    entity.DESCRIPCION = dto.Descripcion;
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