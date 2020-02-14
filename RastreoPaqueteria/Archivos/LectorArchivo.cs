using RastreoPaqueteria.Archivos.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace RastreoPaqueteria.Archivos
{
    public class LectorArchivo : ILectorArchivo
    {
        public List<string> LeerLineas(string path)
        {
            List<string> lineas = new List<string>();
            using StreamReader reader = new StreamReader(path);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                lineas.Add(linea);
            }
            return lineas;
        }
    }
}
