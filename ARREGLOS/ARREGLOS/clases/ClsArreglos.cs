using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS.clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j;
        private int tamanoArreglo = 0;

        public ClsArreglos(int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; //numero de datos
        }

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;
            int datoTemporal;
            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
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
