using System.Collections.Generic;

namespace RastreoPaqueteria.Servicios.Interfaces
{
    public interface IArchivoService
    {
        List<string> ObtenerLineas(string path);
    }
}