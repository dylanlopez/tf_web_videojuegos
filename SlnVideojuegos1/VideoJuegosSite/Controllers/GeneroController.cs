using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using System.Collections.Generic;
using System.Web.Mvc;

namespace VideoJuegosSite.Controllers
{
    public class GeneroController : Controller
    {
        private IDGeneroQuery query;

        public ActionResult GeneroMain()
        {
            return View();
        }

        public ActionResult GeneroView()
        {
            return View();
        }

        public JsonResult ActualizarGenero(DGeneroDto dto)
        {
            query = new DQuerys();
            query.Update(dto);
            return null;
        }

        public JsonResult EliminarGenero(DGeneroDto dto)
        {
            query = new DQuerys();
            query.Delete(dto);
            return null;
        }

        public JsonResult InsertarGenero(DGeneroDto dto)
        {
            query = new DQuerys();
            query.Insert(dto);
            return null;
        }

        public JsonResult ListarGenero()
        {
            var list = new List<DGeneroDto>();
            query = new DQuerys();
            list = query.List(new DGeneroDto());
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}