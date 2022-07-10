using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.InyeccionDependencias
{
    public class MediasDeCeda : IBebida
    {
        public string tipo { get; set; }
        public MediasDeCeda(string tipo)
        {
            this.tipo = tipo;
        }
        public void Preparar()
        {
            Console.WriteLine("Se prepara una media de ceda "+tipo);
        }
    }
}
