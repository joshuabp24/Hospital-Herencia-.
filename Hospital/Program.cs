using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciacion de las clases
            Paciente paciente = new Paciente();
            Enfermera enfermera = new Enfermera();
            Hombre hombre = new Hombre();
            Mujer mujer = new Mujer();
            Medico medico = new Medico();
            Fisioterapeuta fisio = new Fisioterapeuta();
            Cirujano cirujano = new Cirujano();
            Familiar familiar = new Familiar();
            //Creacion e impresion de objetos
            paciente.Id = 1;
            paciente.Nombre = "Elber";
            paciente.FechaDeNacimiento = "21/oct/2000";
            paciente.Correo = "elber123@gmail.com";
            paciente.Telefono = "664-123-45-67";
            paciente.TipoPaciente = "Paciente en urgencias";
            Console.WriteLine(paciente.Id);
            Console.WriteLine(paciente.Nombre);
            Console.WriteLine(paciente.FechaDeNacimiento);
            Console.WriteLine(paciente.Correo);
            Console.WriteLine(paciente.Telefono);
            Console.WriteLine(paciente.TipoPaciente);
            enfermera.Id = 2;
            enfermera.Nombre = "Maria";
            enfermera.FechaDeNacimiento = "22/oct/2000";
            enfermera.Correo = "MariaJuana@gmail.com";
            enfermera.Telefono = "664-987-65-43";
            enfermera.Area = "Pediatria";
            Console.WriteLine(enfermera.Id);
            Console.WriteLine(enfermera.Nombre);
            Console.WriteLine(enfermera.FechaDeNacimiento);
            Console.WriteLine(enfermera.Correo);
            Console.WriteLine(enfermera.Telefono);
            Console.WriteLine(enfermera.Area);

            //Creacion de los demas objetos
            hombre.Id = 3;
            hombre.Nombre = "jose";
            hombre.FechaDeNacimiento = "ayer pero hace 20 años";
            hombre.Correo = "Thejose@tectepito.edu.mx";
            hombre.Telefono = "664-240-69-11";
            hombre.EstadoCivil = "Mas solo que El naufrago cuando perdio a wilson :c, F ";

            mujer.Id = 4;
            mujer.Nombre = "Maria Gamesa";
            mujer.FechaDeNacimiento = "30/02/1975";
            mujer.Correo = "M4r14@gmail.com";
            mujer.Telefono = "666";
            mujer.EstadoCivil = "Luchona";

            medico.Id = 5;
            medico.Nombre = "Mata Sanos";
            medico.FechaDeNacimiento = "32/03/1982";
            medico.Correo = "elms@IMSS.mx";
            medico.Telefono = "991-01";
            medico.Departamento = "Proctologia";

            fisio.Id = 6;
            fisio.Nombre = "Uvuvwevwevwe Onyetenyevwe Ugwemuhwem Osas";
            fisio.FechaDeNacimiento = "01/13/1992";
            fisio.Correo = "UsainBolt@outlook.com";
            fisio.Telefono = "664-111-11-11";
            fisio.Area = "Deportiva";

            familiar.Id = 7;
            familiar.Nombre = "Abdul";
            familiar.FechaDeNacimiento = "11/09/2001";
            familiar.Correo = "ElSimi@akbar.com";
            familiar.Telefono = "7355608";
            familiar.Consultorio = "Similar";

            cirujano.Id = 0;
            cirujano.Nombre = "Xavier López Rodríguez";
            cirujano.FechaDeNacimiento = "Antes de la gran explosion";
            cirujano.Correo = "Chavelo@hotmail.com";
            cirujano.Telefono = "1";
            cirujano.Especialidad = "El bromas";

            Console.ReadKey();

            


        }
    }
}
