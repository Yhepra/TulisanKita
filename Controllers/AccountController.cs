using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TulisanKita.Data;
using TulisanKita.Models;

namespace TulisanKita.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Daftar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Daftar(User datanya)
        {
            _context.Add(datanya);
            _context.SaveChanges();

            return RedirectToAction("Masuk");
        }

        public IActionResult Masuk()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Masuk(User datanya)
        {
            //var cari = _context.Tb_User.Where(carii => carii.Username == datanya.Username
            //                                           && carii.Password == carii.Password
            //                                  ).FirstOrDefault();
            //if (cari != null)
            //{
            //    return RedirectToAction(controllerName:"Blog", actionName:"Index");
            //}

            var cariUsername = _context.Users.Where(x => x.Username == datanya.Username).FirstOrDefault();

            if (cariUsername != null)
            {
                var cekPassword = _context.Users.Where(x => x.Username == datanya.Username
                                                         && x.Password == datanya.Password).FirstOrDefault();

                if (cekPassword != null)
                {
                    return RedirectToAction(controllerName: "Blog", actionName: "Index");
                }
                ViewBag.pesan = "Password Salah !";
                return View(datanya);
            }

            ViewBag.pesan = "Username Salah !";
            return View(datanya);
        }
    }
}
