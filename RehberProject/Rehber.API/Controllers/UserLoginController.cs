using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rehber.API.Abstract;
using Rehber.API.Data;
using Rehber.Entity.Model;
using Rehber.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : Controller
    {

        [HttpPost("Login")]
        public IActionResult Login(UserModel usermodel)
        {
            User user = new EfUserRepository().Login(usermodel.UserMail, usermodel.Password);
            return Json(user);

        }

        [HttpGet("{id}")]
        public IActionResult DateResult(int id)
        {
            List<Rehberr> rehberlist = new EfRehberRepository().Getlist(x=>x.UserID==id);
            return Json(rehberlist);

        }

        [HttpPost("Add")]
        public IActionResult Add(RehberModel rehberModel)
        {
            Rehberr rehberr = new Rehberr();
            if (ModelState.IsValid)
            {
            rehberr.Rehberİsim = rehberModel.Rehberİsim;
            rehberr.Soyisim = rehberModel.Soyisim;
            rehberr.UserID =rehberModel.UserID;
            rehberr.Telno = rehberModel.Telno;
            
            new EfRehberRepository().Add(rehberr);
            return Json(rehberr);
            
            }
            else if(!ModelState.IsValid){

                return View(rehberModel);
            }
            return View(rehberModel);
         
        }

        [HttpPost("UserKayit")]
        public IActionResult UserKayit(UserRegister userRegister)
        {
            User user = new User();
            user.userMail = userRegister.UserMail;
            user.password = userRegister.Password;
            user.GirisDatetime = DateTime.Now;
            new EfUserRepository().Add(user);
            return Json(user);
        }

        [HttpGet("Detail")]
        public IActionResult Detail(int id)
        {
            Rehberr rehberr = new EfRehberRepository().GetById(id);
            RehberModel rehberModel = new RehberModel();
            rehberModel.ID = rehberr.ID;
            rehberModel.Rehberİsim = rehberr.Rehberİsim;
            rehberModel.Soyisim = rehberr.Soyisim;
            rehberModel.Telno = rehberr.Telno;
            return Json(rehberModel);
            
        }
        [HttpPost("Update")]
        public IActionResult Update(UpdateRehber updateRehber)
        {
            
            Rehberr rehberr = new EfRehberRepository().GetById(updateRehber.ID);
            rehberr.Rehberİsim = updateRehber.Rehberİsim;
            rehberr.Soyisim = updateRehber.Soyisim;
            rehberr.Telno = updateRehber.Telno;
            new EfRehberRepository().Update(rehberr);
            return Json(rehberr);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(int id)
        {
            Rehberr rehberr = new EfRehberRepository().GetById(id);
            new EfRehberRepository().Delete(rehberr);
            return Json(rehberr);
        }
      
    }
}
