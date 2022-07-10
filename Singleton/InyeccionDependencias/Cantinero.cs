using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.InyeccionDependencias
{
    public class Cantinero
    {
        IBebida _bebida;

        public Cantinero(IBebida bebida)
        {
            this._bebida = bebida;
        }

        public void Preparar() 
        {
            this._bebida.Preparar();
        }
    }
}
