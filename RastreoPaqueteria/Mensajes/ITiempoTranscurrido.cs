using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Mensajes
{
    public interface ITiempoTranscurrido
    {
        TiempoTranscurridoDto ObtenerTiempoTranscurrido(DateTime FechaEntrega);
    }
}
