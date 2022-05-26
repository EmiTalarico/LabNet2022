using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_TransportesPublicos
{
    public abstract class TransportePublico
    {
        //Atributos
        //Agregué 2 atributos más como para que sea más representativo.
        public string marca { get; set; }
        public string motor { get; set; }
        public int pasajeros { get; set; }

        //Constructor
        public TransportePublico(string marca, string motor, int pasajeros)
        {
            this.marca = marca;
            this.motor = motor;
            this.pasajeros = pasajeros;
        }

        //Metodos
        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}
