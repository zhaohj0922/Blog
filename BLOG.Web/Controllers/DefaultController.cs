using BLOG.IBLL.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLOG.Web.Controllers
{
    public class DefaultController : Controller
    {
        //自动为属性注入
        public IProvinceContract ProvinceContrator { get; set; }
        public ICityContract CityContract { get; set; }
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetProvinceList()
        {
            var list = CityContract.GetList(p => p.Id > 0);
            return Json(list);
        }
    }
}