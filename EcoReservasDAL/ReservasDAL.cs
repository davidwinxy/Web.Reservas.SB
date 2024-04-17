using EcoReservasEN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoReservasDAL
{
    public class ReservasDAL
    {
        public static async Task<int> Create(Reservas pReservas)
        {
            int result = 0;
            using (var dbContext = new comunDB())
            {
                dbContext.Add(pReservas);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<List<Reservas>> GetAllUsers(int id)
        {
            var reservas = new List<Reservas>();
            using (var bdContext = new comunDB())
            {
                reservas = await bdContext.Reservas.Where(s => s.UserId == id).ToListAsync();
            }
            return reservas;
        }

    }
}
