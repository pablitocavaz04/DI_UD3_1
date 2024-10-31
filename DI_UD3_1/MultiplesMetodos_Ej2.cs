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

        public static void Main()
        {
            Operacion op = Sumar;
            op += Restar;
            op += Multiplicar;

            foreach (Operacion metodo in op.GetInvocationList())
            {
                Console.WriteLine(metodo(10, 2));
            }
        }
    }
}
