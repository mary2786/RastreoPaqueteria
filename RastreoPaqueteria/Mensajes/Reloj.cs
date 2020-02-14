using System;

namespace RastreoPaqueteria.Mensajes
{
    public class Reloj : IReloj
    {
        public DateTime FechaActual => DateTime.Now;
    }
}
