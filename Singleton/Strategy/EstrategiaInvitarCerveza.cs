using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy
{
    public class EstrategiaInvitarCerveza : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le invito a una cerveza");
        }
    }
}
