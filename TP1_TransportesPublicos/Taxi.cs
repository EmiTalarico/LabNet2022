using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_TransportesPublicos
{
    class Taxi : TransportePublico
    {
        //Constructor
        public Taxi(string marca, string motor, int pasajeros) : base(marca, motor, pasajeros)
        {
        }

        //Metodos
        public override void Avanzar()
        {
            Console.WriteLine("El taxi está avanzando");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El omnibus se está deteniendo");
        }

        //Metodo para que se muestre a mi gusto el objeto.
        public override string ToString()
        {
            return "Marca: " + marca +
               "\nMotor: " + motor +
               "\nPasajeros: " + pasajeros +
               "\n";
        }
    }
}
