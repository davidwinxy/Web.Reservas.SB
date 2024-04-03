using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
using EcoReservasEN;
using EcoReservasBL;

namespace EcoReservas.app.Web.Controllers
{
    public class Userscontroller : Controller
    {
        // GET: Userscontroller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Userscontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Userscontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Userscontroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Userscontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Userscontroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Userscontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Userscontroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public async Task<IActionResult> Login(string returnUrl)
        {
            ViewBag.Url = returnUrl;
            ViewBag.Error = "";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Users pUser, string pReturnURL = null)
        {
            try
            {
                var user = await UsersBL.Login(pUser);
                if (user != null && user.Id > 0 && pUser.UserName == user.UserName)
                {
                    user.Role = await RolesBL.GetById(new Roles { Id = user.RoleId });

                    var claims = new[] { new Claim(ClaimTypes.Name, user.UserName), new Claim(ClaimTypes.Role, user.Role.Name) };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                }
                else
                {
                    throw new Exception("Credenciales incorrectas");
                }
                if (!string.IsNullOrWhiteSpace(pReturnURL))
                {
                    return Redirect(pReturnURL);
                }
                else
                {
                    return RedirectToAction("Index", "Lugares");

                }

            }
            catch (Exception ex)
            {
                ViewBag.Url = pReturnURL;
                ViewBag.Error = ex.Message;
                return View(new Users { UserName = pUser.UserName });
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Users");
        }

        public IActionResult RedireccionarAIndexEnLugares()
        {
            // Redirecciona a la acción Index del controlador Lugares
            return RedirectToAction("Index", "Lugares");
        }
    }
}

