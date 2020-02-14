using System;

namespace RastreoPaqueteria.Mensajes
{
    public interface IReloj
    {
        DateTime FechaActual { get; }
    }
}