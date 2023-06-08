using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
    internal class Promedio
    {
        private int cantidad;
        private double promedio;
        public Promedio()
        {
            cantidad = 0;
            promedio = 0.0;
        }
        public void AgregarValor(double value)
        {
            promedio += value;
            cantidad++;
        }
        public double CalcularPromedio() 
        {
            if (cantidad == 0)
            {
                return 0;
            }
            return promedio / cantidad;
        }
    }
}
