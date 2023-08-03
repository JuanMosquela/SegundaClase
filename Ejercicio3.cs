using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Ejercicio3
    {
        static public void Run()
        {
            Product product = new Product();

            Console.WriteLine("Ingrese el precio del producto:");
            product.precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad del producto:");
            product.cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de descuento:");
            product.porcentajeDescuento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de IVA:");
            product.porcentajeIVA = Convert.ToDouble(Console.ReadLine());

            double precioVenta = product.CalcularPrecioVenta();

            Console.WriteLine("El precio de venta es: " + precioVenta);

            Console.ReadKey();
        }

    }

    public class Product 
    {
   
        public double precio { get; set; }  

        public int cantidad { get; set; }
        public double porcentajeDescuento { get; set; }

        public double porcentajeIVA { get; set; }

        public double CalcularPrecioVenta()
        {
            double descuento = precio * porcentajeDescuento / 100;
            double iva = (cantidad * precio - descuento) * porcentajeIVA / 100;
            double precioVenta = cantidad * precio - descuento + iva;

            return precioVenta;


        }
    }
}
