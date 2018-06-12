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
    public class Estudio
    {
        List<Estudio> Estudios = new List<Estudio>();
        string nombre;
        string direccion;
        string fechaapertura;

        public Estudio(string nombre, string direccion, string fechaapertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaapertura = fechaapertura;
        }
    }
}
