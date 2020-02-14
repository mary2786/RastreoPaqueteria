using RastreoPaqueteria.Paqueterias;
using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Transportes;
using RastreoPaqueteria.Transportes.Interfaces;
using System.Collections.Generic;

namespace RastreoPaqueteria.ConfiguracionPaqueterias
{
    public class PaqueteriasRepositorio : IPaqueteriasRepositorio
    {
        public List<IPaqueteria> ObtenerPaqueterias()
        {
            ITransporteFactory transporteFactory = new BarcoFactory();
            ITransporte barco = transporteFactory.CrearTransporte();


            transporteFactory = new TrenFactory();
            ITransporte tren = transporteFactory.CrearTransporte();

            transporteFactory = new AvionFactory();
            ITransporte avion = transporteFactory.CrearTransporte();


            IPaqueteriaFactory factory = new FedexFactory();
            IPaqueteria fedex = factory.CrearPaqueteria();
            fedex.AgregarTransporte(barco);

            factory = new DhlFactory();
            IPaqueteria dhl = factory.CrearPaqueteria();
            dhl.AgregarTransporte(avion);
            dhl.AgregarTransporte(barco);

            factory = new EstafetaFactory();
            IPaqueteria estafeta = factory.CrearPaqueteria();
            estafeta.AgregarTransporte(tren);
            estafeta.AgregarTransporte(barco);

            return new List<IPaqueteria>() { fedex, dhl, estafeta };

        }
    }
}
