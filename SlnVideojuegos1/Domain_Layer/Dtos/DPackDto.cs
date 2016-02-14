namespace Domain_Layer.Dtos
{
    public class DPackDto
    {
        public DPackDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Precio = 0;
            Descripcion = string.Empty;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
    }
}