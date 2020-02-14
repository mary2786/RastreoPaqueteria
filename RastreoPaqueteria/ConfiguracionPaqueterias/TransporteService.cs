using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Transportes.Interfaces;
using System.Linq;

namespace RastreoPaqueteria.ConfiguracionPaqueterias
{
    public class TransporteService : ITransporteService
    {
        public ITransporte BuscarTransporte(IPaqueteria paqueteria, string nombreTransporte)
        {
            return paqueteria.Transportes.FirstOrDefault(x => x.Nombre.ToLower() == nombreTransporte.ToLower());
        }
    }
}
