using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rehber.API.Abstract;
using Rehber.API.Data;
using Rehber.Entity.Model;
using Rehber.Entity.ViewModel;
using Rehber.UI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Rehber.UI.Controllers
{
  
    public class KullaniciController : Controller
    {
        //private readonly Context _context;

        //public KullaniciController(Context context)
        //{
        //    _context = context;
        //}
     
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin([FromBody] UserModel userModel)
        {
            User user = new EfUserRepository().Login(userModel.UserMail,userModel.Password);
            if(user!=null)
            {
                HttpContext.Session.SetObject("KullaniciAktif", user);
            }
            else
            {

                ModelState.AddModelError(string.Empty, "Invalid ");
               
            }
            return Json(user);
        }
        public IActionResult KayitEkle()
        {
            return View();
        }

        public IActionResult Page()
        {
            
            return View();
        }

        public IActionResult Listele()
        {
            
            return View();

        }
       
        public IActionResult Ekle(Rehberr rehberModel)
        {
            return View();
        }
        public ActionResult Logout()
        {
           
            HttpContext.Session.Clear();
            return RedirectToAction("UserLogin");
        }

        //public IActionResult Create()
        //{
        //    ViewBag.Rehberr = new SelectList(_context.Rehberrs, "ID", "Rehberİsim");
        //    return View();
        //}

        //public JsonResult Load(int id)
        //{
        //    var state = _context.Rehberrs.Where(z => z.UserID == id).ToList();
        //    return Json(new SelectList(state, "ID", "Rehberİsim"));

        //}
        //public JsonResult LoadUser(int id)
        //{
        //    var stati = _context.Users.Where(z => z.ID == id).ToList();
        //    return Json(new SelectList(stati, "ID", "Rehberİsim"));

        //}
    }
}
