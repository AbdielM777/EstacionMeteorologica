using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionMeteorologica.Sensores
{
 public abstract class Sensor
    {
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public double Valor { get; set; }

        public Sensor(string nombre, string unidad)
        {
            Nombre = nombre;
            Unidad = unidad;
        }

        public abstract Task ActualizarValorAsync();
    }
}
