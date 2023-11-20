namespace Tiendita.Entity.Common
{
    public class Entitycommon
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaActualizacion { get; set; } = DateTime.Now;

    }
}
