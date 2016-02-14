namespace Domain_Layer.Dtos
{
    public class DPackDetalleDto
    {
        public DPackDetalleDto()
        {
            Id = 0;
            IdPack = 0;
            IdJuego = 0;
        }

        public int Id { get; set; }
        public int IdPack { get; set; }
        public string NombrePack { get; set; }
        public decimal PrecioPack { get; set; }
        public int IdJuego { get; set; }
        public string NombreJuego { get; set; }
    }
}