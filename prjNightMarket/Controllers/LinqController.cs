//LINQ擴充方法和查詢運算式
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjNightMarket.Controllers
{
    public class LinqController : Controller
    {
        // GET: LinqExpression
        public ActionResult Index()
        {
            return View();
        }
        //整數陣列遞減排序
        public string ShowArrayDesc()
        {
            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";
            //LINQ擴充方法寫法
            var result = score.OrderByDescending(m => m);
            //LINQ查詢運算式寫法
            //var result = from m in score
            //             orderby m descending
            //             select m;
            show = "遞減排序：";
            foreach(var m in result)
            {
                show += m + ",";
            }
            show += "<br/>";
            show += "總和" + result.Sum();
            return show;

        }
        //整數陣列遞增排序
        public string ShowArrayAsc()
        {
            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";
            //LINQ擴充方法寫法
            var result = score.OrderBy(m => m);
            //LINQ查詢運算式寫法
            //var result = from m in score
            //             orderby m ascending
            //             select m;
            show = "遞減排序：";
            foreach (var m in result)
            {
                show += m + ",";
            }
            show += "<br/>";
            show += "平均" + result.Average();
            return show;

        }
    }
}