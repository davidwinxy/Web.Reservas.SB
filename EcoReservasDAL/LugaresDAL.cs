using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoReservasEN;
using Microsoft.EntityFrameworkCore;
namespace EcoReservasDAL
{
    public class LugaresDAL
    {

        public static async Task<Lugares> GetById(int pId)
        {
            var lugares = new Lugares();

            using (var dbCOntext = new comunDB())
            {
                lugares = await dbCOntext.Lugares.FirstOrDefaultAsync(s => s.Id == pId);
            }
            return lugares;
        }

        public static async Task<int> Create(Lugares pLugares)
        {
            int result = 0;
            using (var dbContext = new comunDB())
            {
                dbContext.Add(pLugares);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Update(Lugares pLugares)
        {
            int result = 0;
            using (var dbContext = new comunDB())
            {
                var datos = await dbContext.Lugares.FirstOrDefaultAsync(r => r.Id == pLugares.Id);

                datos.Nombre = pLugares.Nombre;
                datos.Direccion = pLugares.Direccion;
                datos.Capacidad = pLugares.Capacidad;
                datos.Descripcion = pLugares.Descripcion;
                datos.ImagenUrl = pLugares.ImagenUrl;
                datos.URL2 = pLugares.URL2;
                datos.URL3 = pLugares.URL3;
                datos.SitioWeb = pLugares.SitioWeb;
                datos.Requisitos = pLugares.Requisitos;
                datos.Normativas = pLugares.Normativas;
                dbContext.Update(datos);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Delete(Lugares pLugares)
        {
            int result = 0;
            using (var dbContext = new comunDB())
            {
                var lugares = await dbContext.Lugares.FirstOrDefaultAsync(r => r.Id == pLugares.Id);
                dbContext.Remove(lugares);
                result = await dbContext.SaveChangesAsync();
            }
            return result;


        }
        public static async Task<List<Lugares>> GetAll()
        {
            var lugares = new List<Lugares>();
            using (var bdContext = new comunDB())
            {
                lugares = await bdContext.Lugares.ToListAsync();
            }
            return lugares;
        }
    }
}
