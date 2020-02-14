using System;

namespace RastreoPaqueteria.Mensajes
{
    public abstract class AbstractTiempoTranscurridoHandler : ITiempoTranscurridoHandler
    {
        public ITiempoTranscurridoHandler Next { get; set; }
        public abstract double RangoTiempoMaximo { get; }

        public abstract string ObtenerMensajeTiempoTranscurrido(TimeSpan tiempoTranscurrido);
    }
}
