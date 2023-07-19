using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_Abstraccion
{
    public class Programador : Empleado
    {
        public override double CalcularSalario()
        {
            return Salario + (Salario * 1 / 100 + 50000); 
        }
    }
}
