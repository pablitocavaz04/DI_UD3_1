using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DI_UD3_1
{
    public class Excercise
    {
        public delegate int Operacion(int x, int y);

        public static int Sumar(int x, int y) => x + y;

        public static void Main()
        {
            Operacion op = Sumar;
            Console.WriteLine(op(8,2));
        }
    }
}
