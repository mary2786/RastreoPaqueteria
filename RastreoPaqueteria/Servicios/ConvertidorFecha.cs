using System;
using System.Globalization;

namespace RastreoPaqueteria.Servicios
{
    public class ConvertidorFecha : IConvertidorFecha
    {
        public DateTime ConvertirTextoAFecha(string fechaTexto)
        {
            if (!DateTime.TryParseExact(fechaTexto, "dd-MM-yyyy HH:mm:ss", null, DateTimeStyles.None, out DateTime fecha))
            {
                throw new FormatException("No se pudo convertir el string '" + fecha + "' a fecha. El formato del string, debe ser 'dd/MM/yyyy hh:mm:ss'");
            }

            return fecha;
        }
    }
}
