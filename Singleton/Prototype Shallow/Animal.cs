using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype_Shallow
{
    public class Animal:ICloneable
    {
        public int patas { get; set; }
        public string? nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
