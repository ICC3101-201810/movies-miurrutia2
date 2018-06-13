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
    public class Pelicula
    {
        List<Pelicula> Peliculas = new List<Pelicula>();
        string nombre;
        string director;
        string fechaestreno;
        string descripcion;
        int presupuesto;
        string estudio;

        public Pelicula(string nombre, string director, string fechaestreno, string descripcion, int presupuesto, string estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaestreno = fechaestreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
    }
}
