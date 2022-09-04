using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjemploORM.Models
{
    public class DbContext
    {
        public DbContext() : base("DBPelicula")
        {

        }

        public DbSet <Genero> Generos { get; set; }
        public DbSet <Pelicula> Peliculas { get; set; }
    }
}