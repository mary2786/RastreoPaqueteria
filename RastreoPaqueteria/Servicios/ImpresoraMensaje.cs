using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Servicios
{
    public class ImpresoraMensaje : IImpresoraMensaje
    {
        public void ImprimirMensaje(MensajeDto mensaje)
        {
            Console.ForegroundColor = mensaje.Color;
            Console.WriteLine(mensaje.Mensaje);
        }
    }
}
