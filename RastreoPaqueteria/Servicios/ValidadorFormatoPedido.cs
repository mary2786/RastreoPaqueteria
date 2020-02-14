using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Servicios
{
    public class ValidadorFormatoPedido : IValidadorFormatoPedido
    {
        private readonly IConvertidorFecha _convertidorFecha;
        private readonly IConvertidorDouble _convertidorDouble;

        public ValidadorFormatoPedido(IConvertidorFecha convertidorFecha, IConvertidorDouble convertidorDouble)
        {
            _convertidorFecha = convertidorFecha;
            _convertidorDouble = convertidorDouble;
        }

        public PedidoDto ValidarFormatoPedido(string pedido)
        {

            string[] arregloPedido = pedido.Split(",".ToCharArray());
            if (arregloPedido.Length < 6)
            {
                throw new FormatException("El texto con los datos del pedido no tiene el formato correcto. (" + pedido + ")");
            }

            string fecha = arregloPedido[5].Trim();
            string distancia = arregloPedido[2].Trim();
            DateTime fechaPedido = _convertidorFecha.ConvertirTextoAFecha(fecha);
            double distanciaPedido = _convertidorDouble.ConvertirTextoADouble(distancia);

            PedidoDto pedidoDto = new PedidoDto()
            {
                Origen = arregloPedido[0].Trim(),
                Destino = arregloPedido[1].Trim(),
                Distancia = distanciaPedido,
                Paqueteria = arregloPedido[3].Trim(),
                Transporte = arregloPedido[4].Trim(),
                Fecha = fechaPedido
            };

            return pedidoDto;
        }
    }
}