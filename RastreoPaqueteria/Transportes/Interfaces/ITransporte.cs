namespace RastreoPaqueteria.Transportes.Interfaces
{
    public interface ITransporte
    {
        double CostoXKilometro { get; set; }
        string Nombre { get; set; }
        double VelocidadEntrega { get; set; }
    }
}
