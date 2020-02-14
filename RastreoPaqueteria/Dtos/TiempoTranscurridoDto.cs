using System;

namespace RastreoPaqueteria.Dtos
{
    public class TiempoTranscurridoDto
    {
        public TimeSpan TotalTiempoTranscurrido { get; set; }
        public bool EsTiempoPasado { get; set; }
    }
}
