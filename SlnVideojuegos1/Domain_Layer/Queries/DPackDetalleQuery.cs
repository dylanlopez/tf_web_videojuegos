using Domain_Layer.Converters;
using Domain_Layer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain_Layer.Queries
{
    public partial class DQuerys : IDPackDetalleQuery
    {
        public DPackDetalleDto Find(DPackDetalleDto dto)
        {
            var result = new DPackDetalleDto();
            try
            {
                var query = _dbContext.PACK_DETALLE.Where(s => s.ID == dto.Id);
                result = DPackDetalleConverter.ToDto(query.FirstOrDefault());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Delete(DPackDetalleDto dto)
        {
            try
            {
                var id = dto.Id;
                _dbContext.PACK_DETALLE.Remove(DPackDetalleConverter.ToEntity(dto));
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int Insert(DPackDetalleDto dto)
        {
            try
            {
                var entity = DPackDetalleConverter.ToEntity(dto);
                _dbContext.PACK_DETALLE.Add(entity);
                _dbContext.SaveChanges();
                return entity.ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<DPackDetalleDto> List(DPackDetalleDto dto)
        {
            var result = new List<DPackDetalleDto>();
            try
            {
                result = DPackDetalleConverter.ToDtos(_dbContext.PACK_DETALLE.ToList());
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Update(DPackDetalleDto dto)
        {
            try
            {
                var entity = DPackDetalleConverter.ToEntity(Find(dto));
                if (entity != null)
                {
                    _dbContext.Entry(entity).CurrentValues.SetValues(DPackDetalleConverter.ToEntity(dto));
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