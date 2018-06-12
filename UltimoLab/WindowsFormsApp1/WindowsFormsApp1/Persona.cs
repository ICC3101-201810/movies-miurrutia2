using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Persona
    {
        public List<Persona> Personas = new List<Persona>();
        String nombre;
        String apellido;
        String fechadenacimiento;
        String profesion;
        String Biografia;

        public Persona(string nombre, string apellido, string fechadenacimiento, string profesion, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechadenacimiento = fechadenacimiento;
            this.profesion = profesion;
            Biografia = biografia;
        }
    }

}
