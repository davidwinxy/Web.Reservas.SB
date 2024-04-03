using EcoReservasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EcoReservasEN;
using System.Data;
namespace EcoReservasBL
{
    public class LugaresBL
    {
        public static async Task<Lugares> GetById(int pId)
        {
            return await LugaresDAL.GetById(pId);
        }

        public static async Task<int> Create(Lugares pLugares)
        {
            return await LugaresDAL.Create(pLugares);
        }
        public static async Task<int> Update(Lugares pLugares)
        {
            return await LugaresDAL.Update(pLugares);
        }
        public static async Task<int> Delete(Lugares pLugares)
        {
            return await LugaresDAL.Delete(pLugares);
        }
        public static async Task<List<Lugares>> GetAll()
        {
            return await LugaresDAL.GetAll();
        }

    }
}
