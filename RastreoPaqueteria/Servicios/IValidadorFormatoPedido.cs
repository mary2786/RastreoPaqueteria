using RastreoPaqueteria.Dtos;

namespace RastreoPaqueteria.Servicios
{
    public interface IValidadorFormatoPedido
    {
        PedidoDto ValidarFormatoPedido(string pedido);
    }
}