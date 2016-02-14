using Domain_Layer.Converters;
using Domain_Layer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain_Layer.Queries
{
    public partial class DQuerys : IDJuegoGeneroQuery
    {
        public DJuegoGeneroDto Find(DJuegoGeneroDto dto)
        {
            var result = new DJuegoGeneroDto();
            try
            {
                var query = _dbContext.JUEGO_GENERO.Where(s => s.ID == dto.Id);
                result = DJuegoGeneroConverter.ToDto(query.FirstOrDefault());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Delete(DJuegoGeneroDto dto)
        {
            try
            {
                var entity = _dbContext.JUEGO_GENERO.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    _dbContext.JUEGO_GENERO.Remove(entity);
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
        public int Insert(DJuegoGeneroDto dto)
        {
            try
            {
                var entity = DJuegoGeneroConverter.ToEntity(dto);
                _dbContext.JUEGO_GENERO.Add(entity);
                _dbContext.SaveChanges();
                return entity.ID;
            }
            catch (Exception ex)
            {
                throw ex;
                return 0;
            }
        }
        public List<DJuegoGeneroDto> List(DJuegoGeneroDto dto)
        {
            var result = new List<DJuegoGeneroDto>();
            try
            {
                result = DJuegoGeneroConverter.ToDtos(_dbContext.JUEGO_GENERO.ToList());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Update(DJuegoGeneroDto dto)
        {
            try
            {
                var entity = _dbContext.JUEGO_GENERO.FirstOrDefault(c => c.ID == dto.Id);
                if (entity != null)
                {
                    entity.ID_GENERO = dto.IdGenero;
                    entity.ID_JUEGO = dto.IdJuego;
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