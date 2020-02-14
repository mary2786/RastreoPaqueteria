using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Transportes.Interfaces;
using System.Collections.Generic;

namespace RastreoPaqueteria.Paqueterias
{
    public class Fedex : IPaqueteria
    {
        private readonly List<ITransporte> _transportes = new List<ITransporte>();
        public string Nombre { get; set; }
        public double MargenUtilidad { get; set; }
        public IReadOnlyList<ITransporte> Transportes => _transportes;

        public void AgregarTransporte(ITransporte transporte)
        {
            _transportes.Add(transporte);
        }
    }
}