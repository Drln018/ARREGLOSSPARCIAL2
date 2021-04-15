using ARREGLOS.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARREGLOS
{
    public partial class Form1 : Form
    {
        private string[] arregloNotas;

        public Form1()
        {
            InitializeComponent();
        }
        public int promedios(string [,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(1);//tamaño de filas

            for(int fila=1; fila < matriz.GetLength(0); fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);
            }
            promedio = acumulador / (matriz.GetLength(0) - 1);
            return promedio;
        }

        private void buttonCargar_Click_1(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\13237\OneDrive\Desktop";
            ofd.Filter = "archivoPloano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.leerTodoArchivo(archivo);
                arregloNotas = ar.leerArchivo(archivo);
                textBoxResultado.Text = resultado;
            }
        }
        private void buttonNombres_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string[] ordenNombres = new string[arregloNotas.Length - 1];

            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    ordenNombres[contador - 1] = datos[1];
       
                }
                contador++;
            }
            ClsArchivo objArchivo = new ClsArchivo();
            ordenNombres = objArchivo.MetodoBurbujaCadena();
            for (int i=0; i < ordenNombres.Length; i++)
            {
                listBoxResultado.Items.Add(ordenNombres[i]);
            }
    
        }

        private void buttonNota1_Click_1(object sender, EventArgs e)
        {
            int promedio, acumulador=0;
            int contador = 0;
            string[,] arregloDosDimensiones = new string[arregloNotas.Length, 5];

            int[] ordenParcial = new int[arregloNotas.Length-1]; //arreglo para extraer lasnotas
            foreach (string linea in arregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {
                    acumulador = acumulador + Convert.ToInt32(datos[2]);
                    ordenParcial[contador - 1] = Convert.ToInt32(datos[2]); //las notas convertidas en enteros
                }
                arregloDosDimensiones[contador, 0] = datos[0];
                arregloDosDimensiones[contador, 1] = datos[1];
                arregloDosDimensiones[contador, 2] = datos[2];
                arregloDosDimensiones[contador, 3] = datos[3];
                arregloDosDimensiones[contador, 4] = datos[4];

                contador++;   
            }
            ClsArreglos fncArreglos = new ClsArreglos(ordenParcial); //variable clsarreglo  como parametro orden parcial
            ordenParcial = fncArreglos.MetodoBurbuja(); //funcionarreglos
            foreach (int recorrido in ordenParcial)
            {
                listBoxNota1.Items.Add(recorrido);
            }
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length-1];
            promedio = acumulador / contador - 1;
            MessageBox.Show($"Promedio es {promedio} \n min{min} \n max{max} ");

        }

        private void buttonNota2_Click(object sender, EventArgs e)
        {
            int promedio, acumulador = 0;
            int contador = 0;

            int[] ordenParcial = new int[arregloNotas.Length - 1]; //arreglo para extraer lasnotas
            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');

                    acumulador = acumulador + Convert.ToInt32(datos[3]);
                    ordenParcial[contador - 1] = Convert.ToInt32(datos[3]); //las notas convertidas en enteros
                }
                contador++;
            }
            ClsArreglos fncArreglos = new ClsArreglos(ordenParcial); //variable clsarreglo  como parametro orden parcial
            ordenParcial = fncArreglos.MetodoBurbuja(); //funcionarreglos
            foreach (int recorrido in ordenParcial)
            {
                listBoxNota2.Items.Add(recorrido);
            }
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length - 1];
            promedio = acumulador / contador - 1;
            MessageBox.Show($"Promedio es {promedio} \n min{min} \n max{max} ");
        }

        private void buttonNota3_Click(object sender, EventArgs e)
        {
            int promedio, acumulador = 0;
            int contador = 0;

            int[] ordenParcial = new int[arregloNotas.Length - 1]; //arreglo para extraer lasnotas
            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');

                    acumulador = acumulador + Convert.ToInt32(datos[4]);
                    ordenParcial[contador - 1] = Convert.ToInt32(datos[4]); //las notas convertidas en enteros
                }
                contador++;
            }
            ClsArreglos fncArreglos = new ClsArreglos(ordenParcial); //variable clsarreglo  como parametro orden parcial
            ordenParcial = fncArreglos.MetodoBurbuja(); //funcionarreglos
            foreach (int recorrido in ordenParcial)
            {
                listBoxNota3.Items.Add(recorrido);
            }
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length - 1];
            promedio = acumulador / contador - 1;
            MessageBox.Show($"Promedio es {promedio} \n min{min} \n max{max} ");
        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            int promedioG, acumulador = 0;
            int contador = 0;

            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    string nota1 = datos[2];
                    string nota2 = datos[3];
                    string nota3 = datos[4];
                    acumulador = acumulador + Convert.ToInt32(datos[2])+Convert.ToInt32(datos[3])+Convert.ToInt32(datos[4]);
                }
                contador++;
            }
            promedioG = acumulador / contador - 1;
            MessageBox.Show($"Promedio es {promedioG}");
        }
    }
}
