using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype_Deep
{
    public class Animal1 : ICloneable
    {
        public int Patas { get; set; }
        public string? Nombre { get; set; }

        public Detalles? Razgos { get; set; }

        public object Clone()
        {
            Animal1 clonado = (Animal1)MemberwiseClone();
            Detalles detalles = new Detalles();
            detalles.Color = this.Razgos.Color;
            detalles.Raza = this.Razgos.Raza;
            clonado.Razgos = detalles;
            return clonado;
        }
    }

    public class Detalles 
    {
        public string Color { get; set; }
        public string Raza { get; set; }
    }
}
