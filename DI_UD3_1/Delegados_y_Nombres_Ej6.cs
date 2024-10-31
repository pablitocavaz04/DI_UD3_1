using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DI_UD3_1
{
    public delegate int Transformar(int x);

    public class Excercise
    {
        static int Doblar(int x) => x * 2;
        static int Triplicar(int x) => x * 3;
        static int Cuadrado(int x) => x * x;

        public static void Main()
        {
            Transformar transformaciones = Doblar;
            transformaciones += Triplicar;
            transformaciones += Cuadrado;

            int numero = 5;

            foreach (Transformar transformacion in transformaciones.GetInvocationList())
            {
                int resultado = transformacion(numero);
                Console.WriteLine($"{transformacion.Method.Name}: {resultado}");
            }
        }
    }
}

