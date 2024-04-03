using EcoReservasEN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoReservasDAL
{
    public class UsersDAL
    {
        
            public static async Task<Users> Login(Users pUser)
            {
                Users user = new Users();
                using (var dbContext = new comunDB())
                {
                    user = await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == pUser.UserName && u.Password == pUser.Password);
                }
                return user;
            }
        
    }
}
