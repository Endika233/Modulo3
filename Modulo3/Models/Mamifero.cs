using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo3.Models
{
    public class Mamifero
    {
        //[Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Patas { get; set; }
        public string NombreCientifico { get; set; }
        public bool EcoLocalizacion { get; set; }
    }
}
