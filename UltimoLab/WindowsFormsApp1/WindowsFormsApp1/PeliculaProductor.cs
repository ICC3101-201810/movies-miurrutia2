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
    public class PeliculaProductor
    {
        List<PeliculaProductor> peliculaproductor = new List<PeliculaProductor>();
        Pelicula pelicula;
        string productor;

        public PeliculaProductor(Pelicula pelicula, string productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}
