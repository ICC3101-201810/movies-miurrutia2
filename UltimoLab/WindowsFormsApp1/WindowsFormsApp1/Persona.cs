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
        String Biografia;

        public Persona(string nombre, string apellido, string fechadenacimiento, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechadenacimiento = fechadenacimiento;
            Biografia = biografia;
        }
    }

    public class Actor : Persona 
    {
        public Actor(string nombre, string apellido, string fechadenacimiento, string biografia) : base(nombre, apellido, fechadenacimiento, biografia)
        {
        }
    }

    public class Director : Persona
    {
        public Director(string nombre, string apellido, string fechadenacimiento, string biografia) : base(nombre, apellido, fechadenacimiento, biografia)
        {
        }
    }

    public class Productor : Persona
    {
        public Productor(string nombre, string apellido, string fechadenacimiento, string biografia) : base(nombre, apellido, fechadenacimiento, biografia)
        {
        }
    }
}
