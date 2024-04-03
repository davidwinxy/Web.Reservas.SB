using EcoReservasBL;
using EcoReservasDAL;
using EcoReservasEN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EcoReservas.app.Web.Controllers
{
    public class Lugarescontroller : Controller
    {
        // GET: Lugarescontroller
        public async Task<ActionResult> Index()
        {
            var lugares = await LugaresBL.GetAll();
            return View(lugares);
        }

       

        // GET: Lugarescontroller/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Lugarescontroller/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Lugarescontroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Lugares pLugares)
        {
            try
            {
                var result = await LugaresBL.Create(pLugares);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lugarescontroller/Edit/5
        public async Task<ActionResult> Edit(int pId)
        {
            var lugar = await LugaresBL.GetById(pId);
            return View(lugar);
        }

        // POST: Lugarescontroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Lugares pLugares)
        {
            try
            {
                var result = await LugaresBL.Update(pLugares);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lugarescontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lugarescontroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Lugares pLugares)
        {
            try
            {
                var result = await LugaresBL.Delete(pLugares);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
