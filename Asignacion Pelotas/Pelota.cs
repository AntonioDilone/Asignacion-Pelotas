using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion_Pelotas
{
    internal class Pelota
    {
        public Pelota() {
        
        }

        public string nombre { get; set; }
        public decimal longitud { get; set; }
        public string forma { get; set; }
        public Boolean disponible { get; set; }

        public void Disponibilidad() {
            if (disponible == true)
            {
                Console.WriteLine( "La pelota esta disponible");
            }
            else {
                Console.WriteLine("La pelota no esta disponible");
            }
        }

    }
}
