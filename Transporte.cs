using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    public abstract class Transporte
    {
        private int pasajeros;

        public int getpasajeros()
        {
            return pasajeros;
        }


        public Transporte(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
