using System;

namespace RastreoPaqueteria.Servicios
{
    public class ConvertidorDouble : IConvertidorDouble
    {
        public double ConvertirTextoADouble(string texto)
        {
            if (!Double.TryParse(texto, out double numero))
            {
                throw new FormatException("No se pudo convertir el string '" + texto + "' a double.");
            }

            return numero;
        }
    }
}
