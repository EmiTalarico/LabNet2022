using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_TransportesPublicos
{
    class Omnibus : TransportePublico
    {
        public Omnibus(string marca, string motor, int pasajeros) : base(marca, motor, pasajeros)
        {
        }

        public override void Avanzar()
        {
            Console.WriteLine("El omnibus está avanzando");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El omnibus se está detiendo");
        }

        public override string ToString()
        {
            return "Marca: " + marca +
               "\nMotor: " + motor +
               "\nPasajeros: " + pasajeros +
               "\n";
        }
    }
}
