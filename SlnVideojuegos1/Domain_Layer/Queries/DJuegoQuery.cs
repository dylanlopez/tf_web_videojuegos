using System;
using System.Collections.Generic;
using System.Linq;
using Domain_Layer.Converters;
using Domain_Layer.Dtos;

namespace Domain_Layer.Queries
{
    public partial class DQuerys : IDJuegoQuery
    {
        public DJuegoDto Find(DJuegoDto dto)
        {
            var result = new DJuegoDto();
            try
            {
                var query = _dbContext.JUEGO.Where(s => s.ID == dto.Id);
                result = DJuegoConverter.ToDto(query.FirstOrDefault());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Delete(DJuegoDto dto)
        {
            try
            {
                var entity = _dbContext.JUEGO.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    _dbContext.JUEGO.Remove(entity);
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
        public int Insert(DJuegoDto dto)
        {
            try
            {
                var entity = DJuegoConverter.ToEntity(dto);
                _dbContext.JUEGO.Add(entity);
                _dbContext.SaveChanges();
                return entity.ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<DJuegoDto> List(DJuegoDto dto)
        {
            var result = new List<DJuegoDto>();
            try
            {
                result = DJuegoConverter.ToDtos(_dbContext.JUEGO.ToList());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Update(DJuegoDto dto)
        {
            try
            {
                var entity = _dbContext.JUEGO.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    _dbContext.Entry(entity).CurrentValues.SetValues(DJuegoConverter.ToEntity(dto));
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