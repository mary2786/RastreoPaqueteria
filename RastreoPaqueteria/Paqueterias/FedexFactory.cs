using RastreoPaqueteria.Paqueterias.Interfaces;

namespace RastreoPaqueteria.Paqueterias
{
    public class FedexFactory : IPaqueteriaFactory
    {
        public IPaqueteria CrearPaqueteria()
        {
            return new Fedex()
            {
                Nombre = "Fedex",
                MargenUtilidad = 50
            };
        }
    }
}

