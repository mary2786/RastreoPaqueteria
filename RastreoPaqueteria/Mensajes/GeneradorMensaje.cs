using RastreoPaqueteria.Dtos;

namespace RastreoPaqueteria.Mensajes
{
    public class GeneradorMensaje : IGeneradorMensaje
    {
        public string GenerarMensaje(PedidoDto pedido, bool esTiempoPasado, string rangoTiempo, double costoEnvio)
        {
            string expresion1 = "ha salido";
            string origen = pedido.Origen;
            string expresion2 = "llegará";
            string destino = pedido.Destino;
            string expresion3 = "dentro de";
            string expresion4 = "tendrá";
            string paqueteria = pedido.Paqueteria;

            if (esTiempoPasado)
            {
                expresion1 = "salió";
                expresion2 = "llegó";
                expresion3 = "hace";
                expresion4 = "tuvo";
            }

            return string.Format("Tu paquete {0} de {1} y {2} a {3} {4} {5} y {6} un costo de {7:C} de envío (Cualquier reclamación con {8})",
                expresion1, origen, expresion2, destino, expresion3, rangoTiempo, expresion4, costoEnvio.ToString(), paqueteria);
        }
    }
}
