using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_Abstraccion
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public int Antiguedad { get; set; }
        public double Salario { get; set; }


        public abstract double CalcularSalario();


    }
}
