using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Esta clase sera la super clase la cual heredara atributos a las demas
    public class Persona
    {
        public string Nombre { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
}
