using RastreoPaqueteria.Dtos;
using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Servicios
{
    public interface IRastreoService
    {
        MensajeDto ObtenerMensajeRastreo(PedidoDto pedido, IPaqueteria paqueteria, ITransporte transporte);
    }
}