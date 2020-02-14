using RastreoPaqueteria.Dtos;

namespace RastreoPaqueteria.Mensajes
{
    public interface IGeneradorMensaje
    {
        string GenerarMensaje(PedidoDto pedido, bool esTiempoPasado, string rangoTiempo, double costoEnvio);
    }
}
