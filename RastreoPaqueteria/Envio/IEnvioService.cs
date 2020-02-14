using System;

namespace RastreoPaqueteria.Envio
{
    public interface IEnvioService
    {
        double CalcularCostoEnvio(double distancia, double margenUtilidad, double costoKilometro);
        DateTime CalcularFechaEntrega(DateTime fechaPedido, double tiempoTraslado);
        double CalcularTiempoTraslado(double distancia, double velocidadEntrega);
    }
}