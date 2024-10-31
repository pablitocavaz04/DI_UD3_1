using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DI_UD3_1
{
    public delegate int Operacion(int x, int y);
    public class Excercise
    {

         static int Sumar(int x, int y) => x + y;
         static int Restar(int x, int y) => x - y;
         static int Multiplicar(int x, int y) => x * y;
         static int Dividir(int x, int y)
         {
            if (y == 0)
            {
                throw new DivideByZeroException("No puedes dividir entre 0");
            }
            else
                return x / y;
         }

        public static void EjecutarOperacion(Operacion operacion,int x, int y)
        {
            int resultado = operacion(x,y);
            Console.WriteLine(resultado);
        }
         

        public static void Main()
        {
            EjecutarOperacion(Sumar, 10, 5);
            EjecutarOperacion(Restar, 10, 5);
            EjecutarOperacion(Multiplicar, 10, 5);
            EjecutarOperacion(Dividir, 10, 5);
            Console.WriteLine("Ahora vamos a meterle un 0 a la division.");
            EjecutarOperacion(Dividir, 10, 0);
        }
    }
}
