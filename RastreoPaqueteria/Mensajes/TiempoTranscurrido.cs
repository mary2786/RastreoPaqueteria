using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Mensajes
{
    public class TiempoTranscurrido : ITiempoTranscurrido
    {
        private readonly IReloj _reloj;
        public TiempoTranscurrido(IReloj reloj)
        {
            _reloj = reloj;
        }
        public TiempoTranscurridoDto ObtenerTiempoTranscurrido(DateTime FechaEntrega)
        {
            DateTime FechaActual = _reloj.FechaActual;
            TimeSpan totalTiempoTranscurrido = FechaEntrega - FechaActual;

            bool esTiempoPasado = false;
            if (DateTime.Compare(FechaEntrega, FechaActual) < 0)
            {
                esTiempoPasado = true;
                totalTiempoTranscurrido *= -1;
            }

            return new TiempoTranscurridoDto()
            {
                EsTiempoPasado = esTiempoPasado,
                TotalTiempoTranscurrido = totalTiempoTranscurrido
            };
        }
    }
}
