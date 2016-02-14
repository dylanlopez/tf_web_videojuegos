namespace Domain_Layer.Dtos
{
    public class DGeneroDto
    {
        public DGeneroDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}