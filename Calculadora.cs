using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CalculadoraApp
{
    public static class Calculadora
    {
        public static float CalcularMedia(float[] numeros)
        {
            float suma = 0;
            foreach (float num in numeros)
            {
                suma += num;
            }
            return suma / numeros.Length;
        }

        public static float CalcularMediana(float[] numeros)
        {
            float[] copia = new float[numeros.Length];
            Array.Copy(numeros, copia, numeros.Length);
            Array.Sort(copia);

            int mitad = copia.Length / 2;
            if (copia.Length % 2 == 0)
            {
                return (copia[mitad - 1] + copia[mitad]) / 2;
            }
            else
            {
                return copia[mitad];
            }
        }

        public static float CalcularModa(float[] numeros)
        {
            Array.Sort(numeros);
            float moda = numeros[0];
            int maxCount = 1, count = 1;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] == numeros[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    moda = numeros[i];
                }
            }

            return moda;
        }

        public static float CalcularDesviacionEstandar(float[] numeros)
        {
            float media = CalcularMedia(numeros);
            float sumaDesviacion = 0;

            foreach (float num in numeros)
            {
                sumaDesviacion += (num - media) * (num - media);
            }

            return (float)Math.Sqrt(sumaDesviacion / numeros.Length);
        }
    }
}
