using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.InyeccionDependencias
{
    public class PiñaColada:IBebida
    {
        public void Preparar() 
        {
            Console.WriteLine("Se prepara una piña colada");
        }
    }
}
