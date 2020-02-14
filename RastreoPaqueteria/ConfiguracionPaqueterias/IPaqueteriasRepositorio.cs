using RastreoPaqueteria.Paqueterias.Interfaces;
using System.Collections.Generic;

namespace RastreoPaqueteria.ConfiguracionPaqueterias
{
    public interface IPaqueteriasRepositorio
    {
        List<IPaqueteria> ObtenerPaqueterias();
    }
}