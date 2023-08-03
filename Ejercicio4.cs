using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Operadores
{
    internal class Ejercicio4
    {
        static public void Run()
        {

            Alumno alumno = new Alumno();
            Console.WriteLine("Ingrese las notas del alumno");

            List<int> notas = alumno.pedirNotas();

            int promedio = alumno.CalcularPromedio();

            Console.WriteLine($"El promedio del alumno es: {promedio}");



        }
    }

    public class Alumno
    {
        private List<int> listaNotas = new List<int>();

        public List<int> pedirNotas()
        {
           
            for (int i = 0; i < 3; i++)
            {
                int nota = Convert.ToInt32(Console.ReadLine());
                listaNotas.Add(nota);

            }

            return listaNotas;
        }

        public int CalcularPromedio()
        {
            int total = 0;
            foreach (var nota in listaNotas)
            {
                total += nota;                
            }

            int promedio = total / listaNotas.Count;
            return promedio;

        }
    }
}
