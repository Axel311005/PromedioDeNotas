using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioDeNotas
{
    internal class Calificacionescs
    {

        public string nombreEstudiante { get; set; }

        public int[] Calificaciones { get; set; }

        

        public double ObtenerPromedio()
        {
            int total=0;
            for (int i = 0; i < Calificaciones.Length; i++)
            {
                total += Calificaciones[i];

            }

            double promedio = total / 3;
            return promedio;
        }

      
    }
}
