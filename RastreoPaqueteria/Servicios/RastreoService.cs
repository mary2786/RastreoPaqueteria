using RastreoPaqueteria.Dtos;
using RastreoPaqueteria.Envio;
using RastreoPaqueteria.Mensajes;
using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Transportes.Interfaces;
using System;

namespace RastreoPaqueteria.Servicios
{
    public class RastreoService : IRastreoService
    {
        private readonly IEnvioService _envioService;
        private readonly IAdministradorMensaje _administradorMensaje;

        public RastreoService(IEnvioService envioService, IAdministradorMensaje administradorMensaje)
        {
            _administradorMensaje = administradorMensaje;
            _envioService = envioService;
        }

        public MensajeDto ObtenerMensajeRastreo(PedidoDto pedido, IPaqueteria paqueteria, ITransporte transporte)
        {
            double tiempoTraslado = _envioService.CalcularTiempoTraslado(pedido.Distancia, transporte.VelocidadEntrega);
            DateTime fechaEntrega = _envioService.CalcularFechaEntrega(pedido.Fecha, tiempoTraslado);
            double costoEnvio = _envioService.CalcularCostoEnvio(pedido.Distancia, paqueteria.MargenUtilidad, transporte.CostoXKilometro);

            return _administradorMensaje.ObtenerMensajeEnvio(pedido, fechaEntrega, costoEnvio);
        }
    }
}
