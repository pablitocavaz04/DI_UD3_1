using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DI_UD3_1
{
    public delegate int Operar(int x, int y);
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

    }
         

        public static void Main()
        {
            Operar operaciones = Sumar;
            operaciones += Restar;
            operaciones += Multiplicar;
            operaciones += Dividir;

            int a = 10, b = 5;
            foreach(Operar operacion in operaciones.GetInvocationList())
            {
            int resultado = operacion(a, b);
             Console.WriteLine($"{operacion.Method.Name}: {resultado}");
            }
        }
    
}
