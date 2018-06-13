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
    public class BasedeDatos
    {
        public List<Persona> Personas;
        public List<Pelicula> Peliculas;
        public List<Estudio> Estudios;
        public List<PeliculaActor> peliculaactor;
        public List<PeliculaProductor> peliculaproductor;

        public BasedeDatos(List<Persona> personas, List<Pelicula> peliculas, List<Estudio> estudios, List<PeliculaActor> peliculaactor, List<PeliculaProductor> peliculaproductor)
        {
            Personas = personas;
            this.Peliculas = peliculas;
            Estudios = estudios;
            this.peliculaactor = peliculaactor;
            this.peliculaproductor = peliculaproductor;
        }
    }
}
