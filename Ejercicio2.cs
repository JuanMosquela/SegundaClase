using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Ejercicio2
    {    

        static public void Run()
        {
            Cuadrado cuadrado = new Cuadrado();

            Console.WriteLine("Ingresa el lado del cuadrado");
            cuadrado.Lado = Convert.ToInt32(Console.ReadLine());

            int sup = cuadrado.CalculateSup();
            Console.WriteLine($"La superficie del cuadrado es de : {sup}");
        }        
    }

    public class Cuadrado
    {
        private int lado;

        public int Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public int CalculateSup()
        {
            int sup = lado * lado;
            return sup;
        }

    }

    
}
