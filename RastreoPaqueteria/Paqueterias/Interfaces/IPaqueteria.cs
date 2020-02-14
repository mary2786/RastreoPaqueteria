using RastreoPaqueteria.Transportes.Interfaces;
using System.Collections.Generic;

namespace RastreoPaqueteria.Paqueterias.Interfaces
{
    public interface IPaqueteria
    {
        string Nombre { get; set; }
        double MargenUtilidad { get; set; }
        public IReadOnlyList<ITransporte> Transportes { get; }
        void AgregarTransporte(ITransporte transporte);
    }
}
