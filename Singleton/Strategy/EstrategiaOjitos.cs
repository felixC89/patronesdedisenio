using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy
{
    public class EstrategiaOjitos : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le hago ojitos a la muchacha ;D");
        }
    }
}
