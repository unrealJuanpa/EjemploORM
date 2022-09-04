using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjemploORM.Models
{
    [Table("Genero")]

    public class Genero
    {
        

        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public String Nombre { get; set; }
        

    }
}