namespace Domain_Layer.Dtos
{
    public class DUsuarioDto
    {
        public DUsuarioDto()
        {
            Id = 0;
            Username = string.Empty;
            Password = string.Empty;
            EstaActivo = false;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool EstaActivo { get; set; }
    }
}