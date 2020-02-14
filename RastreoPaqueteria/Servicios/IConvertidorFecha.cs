using System;

namespace RastreoPaqueteria.Servicios
{
    public interface IConvertidorFecha
    {
        DateTime ConvertirTextoAFecha(string fechaTexto);
    }
}