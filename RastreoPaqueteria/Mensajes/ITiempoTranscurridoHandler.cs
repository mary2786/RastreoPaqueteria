using System;

namespace RastreoPaqueteria.Mensajes
{
    public interface ITiempoTranscurridoHandler
    {
        ITiempoTranscurridoHandler Next { get; set; }
        double RangoTiempoMaximo { get; }
        string ObtenerMensajeTiempoTranscurrido(TimeSpan tiempoTranscurrido);
    }
}