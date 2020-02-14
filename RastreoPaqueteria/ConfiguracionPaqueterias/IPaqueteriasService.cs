using RastreoPaqueteria.Paqueterias.Interfaces;

namespace RastreoPaqueteria.ConfiguracionPaqueterias
{
    public interface IPaqueteriasService
    {
        IPaqueteria BuscarPaqueteria(string nombre);
    }
}