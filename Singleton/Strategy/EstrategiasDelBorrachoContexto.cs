using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy
{
    public class EstrategiasDelBorrachoContexto
    {
        private IBorracho oBorracho;
        public EstrategiasDelBorrachoContexto()
        {
            //Estrategia por defecto
            this.oBorracho = new EstrategiaOjitos();
        }

        public void EstablecerConquistarOjitos() 
        {
            this.oBorracho = new EstrategiaOjitos();
        }

        public void EstablecerConquistarCerveza()
        {
            this.oBorracho = new EstrategiaInvitarCerveza();
        }

        public void Conquistar() 
        {
            this.oBorracho.Conquistar();
        }

    }
}
