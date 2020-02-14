using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Transportes
{
    public class Avion : ITransporte
    {
        public double CostoXKilometro { get; set; }
        public string Nombre { get; set; }
        public double VelocidadEntrega { get; set; }
    }
}
