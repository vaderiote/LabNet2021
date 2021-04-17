using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    public class Avion : Transporte
    {
        public Avion(int pasajeros, string v) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return string.Format("El avion despega del aeropuerto con {0} pasajeros", getpasajeros());
        }

        public override string Detenerse()
        {
            return string.Format("El avion aterriza en el aeropuerto con {0} pasajeros", getpasajeros());
        }
    }
}
