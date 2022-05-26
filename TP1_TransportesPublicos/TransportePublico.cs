using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_TransportesPublicos
{
    public abstract class TransportePublico
    {
        public string marca { get; set; }
        public string motor { get; set; }
        public int pasajeros { get; set; }

        public TransportePublico(string marca, string motor, int pasajeros)
        {
            this.marca = marca;
            this.motor = motor;
            this.pasajeros = pasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}
