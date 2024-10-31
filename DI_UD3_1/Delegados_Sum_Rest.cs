﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_1
{
    delegate int Operacion(int x, int y);
    internal class Program
    {
        static int Sumar(int a, int b) => a + b;
        static int Restar(int a, int b) => a - b;
        static void Main(string[] args)
        {
            Operacion op = Sumar;
            op += Restar;
            foreach (Operacion metodo in op.GetInvocationList())
            {
                Console.WriteLine(metodo(5, 3));
            }
        }
    } 
}