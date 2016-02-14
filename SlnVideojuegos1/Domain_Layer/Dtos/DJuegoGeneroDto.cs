namespace Domain_Layer.Dtos
{
    public class DJuegoGeneroDto
    {
        public DJuegoGeneroDto()
        {
            Id = 0;
            IdJuego = 0;
            NombreJuego = string.Empty;
            PrecioJuego = 0;
            IdGenero = 0;
            NombreGenero = string.Empty;
        }

        public int Id { get; set; }
        public int IdJuego { get; set; }
        public string NombreJuego { get; set; }
        public decimal PrecioJuego { get; set; }
        public int IdGenero { get; set; }
        public string NombreGenero { get; set; }
    }
}