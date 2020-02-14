using System.Collections.Generic;

namespace RastreoPaqueteria.Archivos.Interfaces
{
    public interface ILectorArchivo
    {
        List<string> LeerLineas(string path);
    }
}