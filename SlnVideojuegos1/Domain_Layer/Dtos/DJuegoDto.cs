using System;

namespace Domain_Layer.Dtos
{
    public class DJuegoDto
    {
        public DJuegoDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Anho = 0;
            FechaLanzamiento = DateTime.Now;
            Estudio = string.Empty;
            Precio = 0;
            Tags = string.Empty;
            Descripcion = string.Empty;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Anho { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Estudio { get; set; }
        public decimal Precio { get; set; } 
        public string Tags { get; set; }
        public string Descripcion { get; set; }
    }
}