using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    public class Auto : Transporte
    {

        public Auto (int pasajeros, string v) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return string.Format("El auto avanza con {0} pasajeros", getpasajeros());
        }

        public override string Detenerse()
        {
            return string.Format("El auto se detiene con {0} pasajeros", getpasajeros());
        }
    }
}
