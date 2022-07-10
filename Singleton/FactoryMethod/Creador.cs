using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class Creador
    {
        public enum Bebida
        {
            VINO_TINTO = 0,
            CERVEZA = 1
        }

        public static BebidaEmbriagante CreadorBebida(int tipo)
        {
            switch (tipo) 
            {
                case (int) Bebida.VINO_TINTO:
                    return new VinoTinto();
                break;

                case (int) Bebida.CERVEZA:
                    return new Cerveza();  
                break;

                default:return null;
            }
                
        }
    }
}
