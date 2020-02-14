using RastreoPaqueteria.Archivos.Interfaces;
using System.IO;

namespace RastreoPaqueteria.Archivos
{
    public class FileWrapper : IFileWrapper
    {
        public bool ValidarRutaArchivo(string path)
        {
            return File.Exists(path);
        }
    }
}
