using System;

namespace RastreoPaqueteria.Dtos
{
    public class PedidoDto
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double Distancia { get; set; }
        public string Paqueteria { get; set; }
        public string Transporte { get; set; }
        public DateTime Fecha { get; set; }
    }
}
