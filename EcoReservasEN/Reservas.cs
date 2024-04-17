using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoReservasEN
{
    public class Reservas
    {
        public int Id { get; set; }
        public int LugarId { get; set; }
        public int UserId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int Correlativo { get; set; }
    }
}
