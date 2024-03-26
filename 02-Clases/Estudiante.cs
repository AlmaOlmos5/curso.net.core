using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    internal class Estudiante
    {
        //Campo
        public int id;

        //Propiedad
        public int EstudianteId
        {
            set { id = value; }
            get { return this.id; }
        }
        //PROPIEDADES
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        //MÉTODO
        public String NombreCompleto()
        {
            String NombreCompleto = this.Nombre + " " + this.ApellidoPaterno + " " + this.ApellidoMaterno;
            return NombreCompleto;
        }
        //CONSTRUCTOR
        public Estudiante()
        {
            Console.WriteLine("Se creó un objeto estudiante");
            this.Nombre = "";
            this.ApellidoPaterno = "";
            this.ApellidoMaterno = "";

        }

        public Estudiante(int id, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            Console.WriteLine("Se creó un objeto estudiante");
            this.id = id;
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;

        }
    }
}
