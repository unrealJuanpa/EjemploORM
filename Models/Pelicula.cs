using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploORM.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Duracion { get; set; }
        
        public ICollection<Genero> TablaGenero { get; set; }

    }
}