using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjNightMarket.Models;

namespace prjNightMarket.Controllers
{
    public class LoginMemberController : Controller
    {
        //查詢Member會員陣列的帳號與密碼
        public string Login(string UserId,string Pwd)
        {
            Member[] members = new Member[]
            {
                new Member{UserId="Tom",Pwd="123",Name="湯姆"},
                new Member{UserId="Jasper",Pwd="456",Name="賈斯柏"},
                new Member{UserId="Mary",Pwd="789",Name="瑪莉"}
            };
            //Linq擴充方法
            var result = members.Where(m => m.UserId == UserId && m.Pwd == Pwd).FirstOrDefault();
            //Linq查詢運算式
            //var result = (from m in members
            //              where m.UserId == UserId && m.Pwd == Pwd
            //              select m).FirstOrDefault();
            string show = "";
            if(result != null)
            {
                show = "歡迎" + result.Name;
            }
            else
            {
                show = "帳號密碼錯誤";
            }
            return show;
        }
    }
}