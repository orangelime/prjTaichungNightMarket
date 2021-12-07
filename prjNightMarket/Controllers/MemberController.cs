using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjNightMarket.Models;

namespace prjNightMarket.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Member member)
        {
            string msg = "";
            msg = "註冊資料如下：<br>" +
                        "帳號：" + member.UserId + "<br>" +
                        "密碼：" + member.Pwd + "<br>" +
                        "姓名：" + member.Name + "<br>" +
                        "信箱：" + member.Email + "<br>" +
                        "生日：" + member.BirthDay.ToShortDateString();
            ViewBag.Msg = msg;
            return View(member);
        }
    }
}