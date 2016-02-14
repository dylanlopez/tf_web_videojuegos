using System;
using Entity_Layer.Model;

namespace Domain_Layer.Queries
{
    public partial class DQuerys
    {
        private readonly DB_VIDEOJUEGOS _dbContext;
        public DQuerys()
        {
            try
            {
                _dbContext = new DB_VIDEOJUEGOS();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}