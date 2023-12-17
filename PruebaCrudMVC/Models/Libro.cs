using System;
using System.Collections.Generic;

namespace PruebaCrudMVC.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string? Descripcion { get; set; }
        public string? Autor { get; set; }
    }
}
