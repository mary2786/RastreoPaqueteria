using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Transportes
{
    public class TrenFactory : ITransporteFactory
    {
        public ITransporte CrearTransporte()
        {
            return new Tren()
            {
                Nombre = "Tren",
                CostoXKilometro = 5,
                VelocidadEntrega = 80
            };
        }
    }
}
