using RastreoPaqueteria.Paqueterias.Interfaces;
using System.Linq;

namespace RastreoPaqueteria.ConfiguracionPaqueterias
{
    public class PaqueteriasService : IPaqueteriasService
    {
        private readonly IPaqueteriasRepositorio _paqueteriasRepositorio;
        public PaqueteriasService(IPaqueteriasRepositorio paqueteriasRepositorio)
        {
            _paqueteriasRepositorio = paqueteriasRepositorio;
        }

        public IPaqueteria BuscarPaqueteria(string nombre)
        {
            return _paqueteriasRepositorio.ObtenerPaqueterias().FirstOrDefault(x => x.Nombre.ToLower() == nombre.ToLower());
        }
    }
}
