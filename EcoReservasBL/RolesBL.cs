using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoReservasDAL;
using EcoReservasEN;
namespace EcoReservasBL
{
    public class RolesBL
    {
        public static async Task<Roles> GetById(Roles pRole)
        {
            return await RolesDAL.GetById(pRole);
        }

        
    }
}
