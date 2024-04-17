using EcoReservasDAL;
using EcoReservasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoReservasBL
{
    public class ReservasBL
    {
        public static async Task<int> Create(Reservas pReservas)
        {
            return await ReservasDAL.Create(pReservas);
        }

        public static async Task<List<Reservas>> GetAllUsers(int id)
        {
            return await ReservasDAL.GetAllUsers(id);
        }
    }
}