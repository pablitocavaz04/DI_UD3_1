using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_1
{
    delegate int OperacionCallback(int x, int y);
    internal class Program
    {
       static int Sumar(int a, int b) => a + b;

        static int EjecutarOperacion(OperacionCallback op, int x, int y)
        {
            return op(x, y);    
        }

        static void Main()
        {
            Console.WriteLine("Suma : " + EjecutarOperacion(Sumar, 5, 3));
        }
    } 
}
