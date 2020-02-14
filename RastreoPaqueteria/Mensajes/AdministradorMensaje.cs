using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Mensajes
{
    public class AdministradorMensaje : IAdministradorMensaje
    {
        private readonly IGeneradorMensaje _generadorMensaje;
        private readonly ITiempoTranscurrido _tiempoTranscurrido;
        public AdministradorMensaje(ITiempoTranscurrido tiempoTranscurrido, IGeneradorMensaje generadorMensaje)
        {
            _generadorMensaje = generadorMensaje;
            _tiempoTranscurrido = tiempoTranscurrido;
        }

        public MensajeDto ObtenerMensajeEnvio(PedidoDto pedido, DateTime fechaEntrega, double costoEnvio)
        {
            TiempoTranscurridoDto tiempoTranscurridoDto = _tiempoTranscurrido.ObtenerTiempoTranscurrido(fechaEntrega);

            ITiempoTranscurridoHandler tiempoTranscurridoMes = new TiempoTranscurridoMes();
            ITiempoTranscurridoHandler tiempoTranscurridoDia = new TiempoTranscurridoDia();
            ITiempoTranscurridoHandler tiempoTranscurridoHora = new TiempoTranscurridoHora();
            ITiempoTranscurridoHandler tiempoTranscurridoMinuto = new TiempoTranscurridoMinuto();

            tiempoTranscurridoMes.Next = tiempoTranscurridoDia;
            tiempoTranscurridoDia.Next = tiempoTranscurridoHora;
            tiempoTranscurridoHora.Next = tiempoTranscurridoMinuto;

            string mensajeTiempoTranscurrido = tiempoTranscurridoMes.ObtenerMensajeTiempoTranscurrido(tiempoTranscurridoDto.TotalTiempoTranscurrido);
            string mensaje = _generadorMensaje.GenerarMensaje(pedido, tiempoTranscurridoDto.EsTiempoPasado, mensajeTiempoTranscurrido, costoEnvio);

            ConsoleColor color = ConsoleColor.Yellow;
            if (tiempoTranscurridoDto.EsTiempoPasado)
            {
                color = ConsoleColor.Green;
            }

            return new MensajeDto()
            {
                Mensaje = mensaje,
                Color = color
            };
        }
    }
}
