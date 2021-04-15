using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS.clases
{
    class ClsArchivo
    {
        private int[] ArregloTemporal;
        private string[] ArregloTemporalCadena;
        private string[] datos;
        private int i, j;
        private int tamanoArreglo = 0;

        public string[] leerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            return lineas;
        }

        public string leerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using (StreamReader reader =new  StreamReader(archivo))
            {
                contenidoArchivo = reader.ReadToEnd();
            }
            return contenidoArchivo;
        
        }
        public string[] MetodoBurbujaCadena()
        {
            ArregloTemporalCadena = datos;
            string datoTemporalCadena;

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporalCadena[i].CompareTo(ArregloTemporalCadena[j]) > 0)
                    {
                        datoTemporalCadena = ArregloTemporalCadena[i];
                        ArregloTemporalCadena[i] = ArregloTemporalCadena[j];
                        ArregloTemporalCadena[j] = datoTemporalCadena;
                    }
                }
            }
            return ArregloTemporalCadena;
        }
    }

}
