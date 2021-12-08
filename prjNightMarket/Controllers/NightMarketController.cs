using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//使用NightMarket類別
using prjNightMarket.Models;
//使用PagedList套件
using PagedList;

namespace prjNightMarket.Controllers
{
    public class NightMarketController : Controller
    {
        // GET: NightMarket
        //page參數預設值為1，代表指定預設的分頁為第一頁
        public ActionResult Index(int page = 1)
        {
            //一頁顯示3筆紀錄
            int pagesize = 3;
            //參數小於1表示目前在第一頁，不是的話就是目前的頁數
            int pagecurrent = page < 1 ? 1 : page;

            string[] id = new string[] { "A01", "A02", "A03", "A04", "A05", "A06", "A07" };
            string[] name = new string[] { "逢甲夜市", "一中街商圈", "中華路夜市", "忠孝路夜市", "豐原廟東夜市", "東海夜市", "霧峰樹仁商圈夜市" };
            string[] address = new string[] {"407台中市西屯區文華路","404台中市北區一中街","400台中市中區公園路",
                                                                            "402台中市南區忠孝路","420台中市豐原區中正路167巷","433台中市龍井區新興路",
                                                                            "413台中市霧峰區樹仁路"};
            List<NightMarket> list = new List<NightMarket>();
            //依陣列大小執行迴圈次數
            for (var i = 0; i < id.Length; i++)
            {
                NightMarket nightmarket = new NightMarket();
                nightmarket.Id = id[i];
                nightmarket.Name = name[i];
                nightmarket.Address = address[i];
                list.Add(nightmarket);
            }
            //使用ToPagedList方法設定list要顯示第幾頁(pagecurrent)和一頁要顯示幾筆資料(pagesize)
            var pagedlist = list.ToPagedList(pagecurrent, pagesize);
            return View(pagedlist);
        }
        
        
    }
}