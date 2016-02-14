using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using System.Collections.Generic;
using System.Web.Mvc;

namespace VideoJuegosSite.Controllers
{
    public class PackController : Controller
    {
        private IDPackQuery query;

        public ActionResult PackMain()
        {
            return View();
        }

        public ActionResult PackView()
        {
            return View();
        }

        public JsonResult ActualizarPack(DPackDto dto)
        {
            query = new DQuerys();
            query.Update(dto);
            return null;
        }

        public JsonResult EliminarPack(DPackDto dto)
        {
            query = new DQuerys();
            query.Delete(dto);
            return null;
        }

        public JsonResult InsertarPack(DPackDto dto)
        {
            query = new DQuerys();
            query.Insert(dto);
            return null;
        }

        public JsonResult ListarPack()
        {
            var list = new List<DPackDto>();
            query = new DQuerys();
            list = query.List(new DPackDto());
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}