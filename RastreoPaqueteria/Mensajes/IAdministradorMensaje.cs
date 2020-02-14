using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Mensajes
{
    public interface IAdministradorMensaje
    {
        MensajeDto ObtenerMensajeEnvio(PedidoDto pedido, DateTime fechaEntrega, double costoEnvio);
    }
}