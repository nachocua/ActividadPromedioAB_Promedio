using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Promedio UnPromedio = new Promedio();
            int opcion;
            double value;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Agregar un valor");
                Console.WriteLine("2 - Mostrar el promedio");
                Console.WriteLine("3 - Salir");
                if(!(int.TryParse(Console.ReadLine(), out opcion)))
                {
                    Console.WriteLine("Debe seleccionar una opción valida");
                }
                switch (opcion) 
                {
                    case 1:
                        Console.WriteLine("Ingrese un valor");
                        while(!(double.TryParse(Console.ReadLine(), out value)))
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        UnPromedio.AgregarValor(value);
                    break;
                    case 2:
                        Console.WriteLine("El promedio es: " + UnPromedio.CalcularPromedio());
                        Console.ReadKey();
                    break;
                }
            } while (opcion != 3);
        }
    }
}