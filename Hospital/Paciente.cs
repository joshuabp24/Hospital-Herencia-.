using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    //Aqui se heredan los atributos de la clase Persona a la clase paciente
    public class Paciente:Persona
    {
        public int Id { get; set; }
        public string TipoPaciente { get; set; }
    }
}
