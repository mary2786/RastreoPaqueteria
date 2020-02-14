using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Transportes
{
    public class BarcoFactory : ITransporteFactory
    {
        public ITransporte CrearTransporte()
        {
            return new Barco()
            {
                Nombre = "Barco",
                CostoXKilometro = 1,
                VelocidadEntrega = 46
            };
        }
    }
}
