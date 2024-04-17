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

        public static async Task Create(Users user)
        {
            // Aquí puedes realizar cualquier lógica adicional antes de crear el usuario, si es necesario
            await UsersDAL.Create(user);
        }
    }
}
