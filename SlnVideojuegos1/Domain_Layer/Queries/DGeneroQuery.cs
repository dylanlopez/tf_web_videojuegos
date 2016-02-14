using System;
using System.Collections.Generic;
using System.Linq;
using Domain_Layer.Converters;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public partial class DQuerys : IDGeneroQuery
    {
        public DGeneroDto Find(DGeneroDto dto)
        {
            var result = new DGeneroDto();
            try
            {
                var query = _dbContext.GENERO.Where(s => s.ID == dto.Id);
                //var query = _dbContext.GENERO.Find(dto.Id);
                result = DGeneroConverter.ToDto(query.FirstOrDefault());
                //result = DGeneroConverter.ToDto(_dbContext.Genero.Find(dto.Id));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }
        }
        public int Delete(DGeneroDto dto)
        {
            try
            {
                var entity = _dbContext.GENERO.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    _dbContext.GENERO.Remove(entity);
                    _dbContext.SaveChanges();
                    return entity.ID;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
                return 0;
            }
        }
        public int Insert(DGeneroDto dto)
        {
            try
            {
                var entity = DGeneroConverter.ToEntity(dto);
                _dbContext.GENERO.Add(entity);
                _dbContext.SaveChanges();
                return entity.ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<DGeneroDto> List(DGeneroDto dto)
        {
            var result = new List<DGeneroDto>();
            try
            {
                result = DGeneroConverter.ToDtos(_dbContext.GENERO.ToList());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }
        }
        public int Update(DGeneroDto dto)
        {
            try
            {
                var entity = _dbContext.GENERO.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    entity.NOMBRE = dto.Nombre;
                    entity.DESCRIPCION = dto.Descripcion;
                    _dbContext.SaveChanges();
                    return entity.ID;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
                return 0;
            }
        }
    }
}