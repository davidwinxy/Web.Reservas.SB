using System;
using System.Threading.Tasks;
using EcoReservasBL;
using EcoReservasEN;
using Microsoft.AspNetCore.Mvc;


namespace TuProyecto.Controllers
{
    public class ReservasController : Controller
    {
        [HttpGet]
        public IActionResult Creates(int id)
        {
            var rese = new Reservas();
            rese.LugarId = id;
            return View(rese);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservas reserva)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var id = User.Claims.FirstOrDefault(u => u.Type == "Id");
                    var idUser = id.Value;
                    reserva.UserId = Convert.ToInt32(idUser);

                
                    int result = await ReservasBL.Create(reserva);

                    if (result > 0)
                    {
                  
                        return RedirectToAction("Index", "Lugares"); 
                    }
                    else
                    {
                        
                        ModelState.AddModelError(string.Empty, "Error al crear la reserva. Por favor, intenta nuevamente.");
                        return View(reserva);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Error al crear la reserva: {ex.Message}");
                    return View(reserva);
                }
            }
            else
            {
                
                return View(reserva);
            }
        }

  
        private int ObtenerUserIdActual()
        {
            return 0; 
        }


        public IActionResult Confirmacion()
        {
            return View(); 
        }

       public async Task<IActionResult> GetAllUsers()
        {

            var id = User.Claims.FirstOrDefault(u => u.Type == "Id");
            var idUser = id.Value;
            var reservas = await ReservasBL.GetAllUsers(Convert.ToInt32(idUser));
            return View(reservas);
        }
    }
}

