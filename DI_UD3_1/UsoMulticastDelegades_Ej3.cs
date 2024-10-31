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
         

        public static void Main()
        { 
            Operacion op = Sumar;
            op += Restar;
            op += Multiplicar;
            op += Dividir;

            
            foreach (Operacion metodo in op.GetInvocationList())
            {
                Console.WriteLine(metodo(10, 2));
            }

            Console.WriteLine("Ahora probemos a meterle un 0 haber si lanza la expecion");

            foreach (Operacion metodo in op.GetInvocationList())
            {
                try
                {
                    Console.WriteLine(metodo(10, 0));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
