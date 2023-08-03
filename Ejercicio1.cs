using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Ejercicio1
    {
        static public void Run(int number) 
        {
            Console.WriteLine();
            Console.WriteLine($"Numero ingresado: {number}");

            int nextNumber = Modify(number);
            int prevNumber = Modify(number, false);
            Console.WriteLine($"Numero siguiente: {nextNumber}");
            Console.WriteLine($"Numero anterior: {prevNumber}");

           

        }

        static public int Modify(int num, bool value = true)
        {
            int number = value ? num += 1 : num -= 1;
            return number;
        }
    }
}
