using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista.clase
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamanoArreglo = 0;        

        public int GetTamanoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(int[] arregloParametro)
        {
            datos = arregloParametro;
            tamanoArreglo = datos.Length;
        }

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for (i = 0; i < tamanoArreglo-1; i++)
            {
                for (j=i+1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] < ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }     
    }
}
