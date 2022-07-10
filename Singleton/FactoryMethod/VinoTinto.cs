using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class VinoTinto : BebidaEmbriagante
    {
        public override string CuantoMeEmbriagaPorHora()
        {
            int cantidad = 20;
            return $"Te embriaga {cantidad}%";
            
        }
    }
}
