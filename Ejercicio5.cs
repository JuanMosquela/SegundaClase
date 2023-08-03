using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Ejercicio5
    {        

        static public void Run()
        {
            Producto producto = new Producto();

            Console.WriteLine("Ingrese el costo del producto");
            producto.Costo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de venta del producto");
            producto.Venta = Convert.ToInt32(Console.ReadLine());

            int beneficio = producto.CalcularBeneficio();
            Console.WriteLine($"El beneficio del producto es de {beneficio}");


        }

        

        

        

    }

    public class Producto
    {
        public int Costo { get; set; }
        public int Venta { get; set; }

        public int CalcularBeneficio()
        {
            int beneficio = Venta - Costo;
            return beneficio;

        }


    }
}
