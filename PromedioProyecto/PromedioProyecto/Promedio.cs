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
        private double[] promedio = new double[100];
        public Promedio()
        {
            cantidad = 0;
        }
        public void AgregarValor(double value)
        {
            promedio[cantidad] = value;
            cantidad++;
        }
        public double CalcularPromedio() 
        {
            double acum = 0.0;
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    acum += promedio[i];
                }
            }
            return acum / cantidad;
        }
    }
}
