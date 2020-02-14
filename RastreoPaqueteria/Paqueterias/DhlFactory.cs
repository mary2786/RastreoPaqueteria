using RastreoPaqueteria.Paqueterias.Interfaces;

namespace RastreoPaqueteria.Paqueterias
{
    public class DhlFactory : IPaqueteriaFactory
    {
        public IPaqueteria CrearPaqueteria()
        {
            return new Dhl()
            {
                Nombre = "Dhl",
                MargenUtilidad = 40
            };
        }
    }
}
