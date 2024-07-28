namespace CalculadoraApp
{
    internal class Program
    {
        private static float[] numeros;

        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        PedirNumeros();
                        break;
                    case 2:
                        MostrarResultado("La media es: ", Calculadora.CalcularMedia(numeros));
                        break;
                    case 3:
                        MostrarResultado("La mediana es: ", Calculadora.CalcularMediana(numeros));
                        break;
                    case 4:
                        MostrarResultado("La moda es: ", Calculadora.CalcularModa(numeros));
                        break;
                    case 5:
                        MostrarResultado("La desviación estándar es: ", Calculadora.CalcularDesviacionEstandar(numeros));
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Menú de Funciones:");
            Console.WriteLine("1. Ingresar números");
            Console.WriteLine("2. Calcular y mostrar la media");
            Console.WriteLine("3. Calcular y mostrar la mediana");
            Console.WriteLine("4. Calcular y mostrar la moda");
            Console.WriteLine("5. Calcular y mostrar la desviación estándar");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción: ");
        }

        static void PedirNumeros()
        {
            Console.Write("¿Cuántos números deseas ingresar? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            numeros = new float[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                numeros[i] = Convert.ToSingle(Console.ReadLine());
            }
        }

        static void MostrarResultado(string mensaje, float resultado)
        {
            Console.WriteLine($"{mensaje} {resultado}");
        }
    }
}