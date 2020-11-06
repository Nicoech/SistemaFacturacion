namespace DesignSistemVentas.Model
{
    public class UserSessionModel
    {
        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string TipoUsuario { get; set; }
        public int categoria_id { get; set; }
    }
}
