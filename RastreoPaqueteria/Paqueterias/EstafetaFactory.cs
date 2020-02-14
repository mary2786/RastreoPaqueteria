using RastreoPaqueteria.Paqueterias.Interfaces;

namespace RastreoPaqueteria.Paqueterias
{
    public class EstafetaFactory : IPaqueteriaFactory
    {
        public IPaqueteria CrearPaqueteria()
        {
            return new Estafeta()
            {
                Nombre = "Estafeta",
                MargenUtilidad = 20
            };
        }
    }
}
