using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoReservasDAL;
using EcoReservasEN;
namespace EcoReservasBL
{
    public class UsersBL
    {
        public static async Task<Users> Login(Users pUser)
        {
            return await UsersDAL.Login(pUser);
        }
    }
}
