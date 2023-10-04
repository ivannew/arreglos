using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos.arreglos
{
    internal class arreglitos
    {
        public int[] InicializarArreglo()
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            return array;
        }

        public void MostrarArreglo(int[] array)
        {
            foreach (int valor in array)
            {
                Console.WriteLine(valor);
            }
        }

        public void InicializarArreglo(int[] arreglo)
        {
            arreglo[0] = 1;
            arreglo[1] = 2;
            arreglo[2] = 3;
            arreglo[3] = 4;
            arreglo[4] = 5;
            arreglo[5] = 6;
            arreglo[6] = 7;
            arreglo[7] = 8;
            arreglo[8] = 9;
            arreglo[9] = 10;
        }

        public double CalcularMedia(int[] arreglo)
        {
            double suma = 0;
            foreach (int valor in arreglo)
            {
                suma += valor;
            }
            return suma / arreglo.Length;
        }

        public void MostrarMedia(double media)
        {
            Console.WriteLine("La media de los valores en el arreglo es: " + media);
        }

        public int[] GenerarMultiplos(int tamaño, int numero)
        {
            int[] arreglo = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = (i + 1) * numero;
            }

            return arreglo;
        }


        public void MostrarArreglos(int[] arreglo)
        {
            Console.WriteLine("Valores del arreglo:");
            foreach (int valor in arreglo)
            {
                Console.WriteLine(valor);
            }
        }

        //NO LE ENTENDI
        /*static void ProcesarArreglos()
        {
            Console.Write("Ingrese el tamaño de los arreglos: ");
            int tamaño = LeerEnteroPositivo();

            if (tamaño < 1)
            {
                Console.WriteLine("Entrada no válida. El tamaño debe ser mayor que cero.");
                return;
            }

            string[] nombres = new string[tamaño];
            int[] longitudes = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Ingrese el nombre {i + 1}: ");
                nombres[i] = Console.ReadLine();
                longitudes[i] = nombres[i].Length;
            }

            MostrarNombresYLongitudes(nombres, longitudes);
        }

        static int LeerEnteroPositivo()
        {
            int numero;
            int.TryParse(Console.ReadLine(), out numero);
            return numero;
        }

        static void MostrarNombresYLongitudes(string[] nombres, int[] longitudes)
        {
            Console.WriteLine("Nombres y sus longitudes:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{nombres[i]} - {longitudes[i]} caracteres");
            }
        }*/
    }
}
