using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;


namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.PublicacionGetways.OuputPorts
{

    public interface ITraerTodasPublicacionesOutputPort
    {

        ValueTask Handle(TraerTodasPublicacionesWRP Publicaciones);
    }

}
