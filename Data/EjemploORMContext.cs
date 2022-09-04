﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjemploORM.Data
{
    public class EjemploORMContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EjemploORMContext() : base("name=EjemploORMContext")
        {
        }

        public System.Data.Entity.DbSet<EjemploORM.Models.Genero> Generoes { get; set; }

        public System.Data.Entity.DbSet<EjemploORM.Models.Pelicula> Peliculas { get; set; }
    }
}
