using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using System.Collections.Generic;
using System.Web.Mvc;

namespace VideoJuegosSite.Controllers
{
    public class JuegoController : Controller
    {
        private IDJuegoQuery query;

        public ActionResult JuegoMain()
        {
            return View();
        }

        public ActionResult JuegoView()
        {
            return View();
        }

        public JsonResult ActualizarJuego(DJuegoDto dto)
        {
            query = new DQuerys();
            query.Update(dto);
            return null;
        }

        public JsonResult EliminarJuego(DJuegoDto dto)
        {
            query = new DQuerys();
            query.Delete(dto);
            return null;
        }

        public JsonResult InsertarJuego(DJuegoDto dto)
        {
            query = new DQuerys();
            query.Insert(dto);
            return null;
        }

        public JsonResult ListarJuego()
        {
            var list = new List<DJuegoDto>();
            query = new DQuerys();
            list = query.List(new DJuegoDto());
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}