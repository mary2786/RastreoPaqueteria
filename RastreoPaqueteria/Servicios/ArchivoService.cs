using RastreoPaqueteria.Archivos.Interfaces;
using RastreoPaqueteria.Servicios.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace RastreoPaqueteria.Servicios
{
    public class ArchivoService : IArchivoService
    {
        private readonly IFileWrapper _fileWrapper;
        private readonly ILectorArchivo _lectorArchivo;

        public ArchivoService(IFileWrapper fileWrapper, ILectorArchivo lectorArchivo)
        {
            _fileWrapper = fileWrapper;
            _lectorArchivo = lectorArchivo;
        }
        public List<string> ObtenerLineas(string path)
        {

            if (!_fileWrapper.ValidarRutaArchivo(path))
            {
                throw new DirectoryNotFoundException("No se encontró el archivo.");
            }

            return _lectorArchivo.LeerLineas(path);
        }
    }
}
