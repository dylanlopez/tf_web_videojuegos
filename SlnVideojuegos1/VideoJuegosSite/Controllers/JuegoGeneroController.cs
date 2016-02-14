using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using System.Collections.Generic;
using System.Web.Mvc;

namespace VideoJuegosSite.Controllers
{
    public class JuegoGeneroController : Controller
    {
        private IDJuegoGeneroQuery query;

        public ActionResult JuegoGeneroMain()
        {
            return View();
        }

        public ActionResult JuegoGeneroView()
        {
            return View();
        }

        public JsonResult ActualizarJuegoGenero(DJuegoGeneroDto dto)
        {
            query = new DQuerys();
            query.Update(dto);
            return null;
        }

        public JsonResult EliminarJuegoGenero(DJuegoGeneroDto dto)
        {
            query = new DQuerys();
            query.Delete(dto);
            return null;
        }

        public JsonResult InsertarJuegoGenero(DJuegoGeneroDto dto)
        {
            query = new DQuerys();
            query.Insert(dto);
            return null;
        }

        public JsonResult ListarJuegoGenero()
        {
            var list = new List<DJuegoGeneroDto>();
            query = new DQuerys();
            list = query.List(new DJuegoGeneroDto());
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}