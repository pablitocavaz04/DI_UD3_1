using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DI_UD3_1
{
    public delegate double Calculo(double x);

    public class Excercise
    {
        static double RaizCuadrada(double x)
        {
            if (x < 0)
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            return Math.Sqrt(x);
        }

        static double Logaritmo(double x)
        {
            if (x <= 0)
                throw new ArgumentException("No se puede calcular el logaritmo de un número menor o igual a cero.");
            return Math.Log(x);
        }

        static void EjecutarCalculo(Calculo calculo, double numero)
        {
            try
            {
                double resultado = calculo(numero);
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void Main()
        {
            EjecutarCalculo(RaizCuadrada, 16);
            EjecutarCalculo(RaizCuadrada, -4);

            EjecutarCalculo(Logaritmo, 10);
            EjecutarCalculo(Logaritmo, 0);
        }
    }
}

