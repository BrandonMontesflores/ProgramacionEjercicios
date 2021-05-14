using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace baseD.Clases.Archivos
{
    public class ClsArchivo
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo, Encoding.Default);
            return Lineas;
        }
    }
}