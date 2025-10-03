namespace E_Commerce_Project.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        // Relación con Usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
