using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.ConfiguracionPaqueterias
{
    public interface ITransporteService
    {
        ITransporte BuscarTransporte(IPaqueteria paqueteria, string nombreTransporte);
    }
}