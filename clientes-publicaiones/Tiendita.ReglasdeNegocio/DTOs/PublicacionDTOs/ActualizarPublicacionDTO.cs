namespace Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs
{
    public class ActualizarPublicacionDTO
    {
        public int IdPublicacion { get; set; }
        public string? NombrePublicacion { get; set; }
        public short? DescripcionPorducto { get; set; }
        public string? ImagenURL { get; set; }
    }
}
