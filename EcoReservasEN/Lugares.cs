using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoReservasEN
{
    public class Lugares
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Capacidad { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public string URL2 { get; set; }
        public string URL3 { get; set; }
        public string SitioWeb { get; set; }
        public string Requisitos { get; set; }
        public string Normativas { get; set; }
    }
}
