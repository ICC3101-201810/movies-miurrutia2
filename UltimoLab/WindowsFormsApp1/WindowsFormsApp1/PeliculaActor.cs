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
    public class PeliculaActor
    {
        List<PeliculaActor> peliculaactor = new List<PeliculaActor>();
        Pelicula pelicula;
        Persona actor;

        public PeliculaActor(Pelicula pelicula, Persona actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
}
