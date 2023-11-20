using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;


namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.PublicacionGetways.OuputPorts
{


    public interface IBorrarPublicacionOutputPort
    {

        Task Handle(BorrarPublicacionWRP Publicacion);
    }

}
