using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoReservasEN;
namespace EcoReservasDAL
{
    public class RolesDAL
    {
        public static async Task<Roles> GetById(Roles pRole)
        {
            var role = new Roles();

            using (var dbCOntext = new comunDB())
            {
                role = await dbCOntext.Roles.FirstOrDefaultAsync(s => s.Id == pRole.Id);
            }
            return role;
        }

    }
}
