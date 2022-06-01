using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_UnitTest
{
    public class Logic:Exception
    {
        public Logic() : base("Acá estoy en el base!")
        {

        }

        public string Message(Exception ex)
        {
            
            string Mensaje = "";
            Mensaje = Convert.ToString("Ubicación y nombre de la excepción: " + ex.GetType())+ "\nMensaje del ejercicio 4"
                + "\nExcepción general: " + ex.Message;

            return Mensaje;
        } 

        public void Ejercicio3()
        {
            throw new NotImplementedException();
        }
    }
}
