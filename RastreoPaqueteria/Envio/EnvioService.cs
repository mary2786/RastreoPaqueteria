using System;

namespace RastreoPaqueteria.Envio
{
    public class EnvioService : IEnvioService
    {
        public double CalcularCostoEnvio(double distancia, double margenUtilidad, double costoKilometro)
        {
            return (costoKilometro * distancia) * (1 + margenUtilidad / 100);
        }

        public DateTime CalcularFechaEntrega(DateTime fechaPedido, double tiempoTraslado)
        {
            return fechaPedido.AddHours(tiempoTraslado);
        }

        public double CalcularTiempoTraslado(double distancia, double velocidadEntrega)
        {
            return distancia / velocidadEntrega;
        }
    }
}
