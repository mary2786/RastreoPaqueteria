using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Transportes
{
    public class AvionFactory : ITransporteFactory
    {
        public ITransporte CrearTransporte()
        {
            return new Avion()
            {
                Nombre = "Avión",
                CostoXKilometro = 10,
                VelocidadEntrega = 600
            };
        }
    }
}

