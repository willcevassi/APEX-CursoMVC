using ExercicioCap05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExercicioCap05.Controllers
{
    public class HelpersController : Controller
    {
        public ActionResult Index()
        {
            HelpersModel model = new HelpersModel();
            List<SelectListItem> estadosModel = new List<SelectListItem>();
            estadosModel.Add(new SelectListItem() { Text = "SC", Value = "Santa Catarina" });
            estadosModel.Add(new SelectListItem() { Text = "PR", Value = "Parana" });
            estadosModel.Add(new SelectListItem() { Text = "RS", Value = "Rio Grande do Sul" });
            model.DropDownEstado = estadosModel;

            List<EstadoModel> estadosListBox = new List<EstadoModel>();
            estadosListBox.Add(new EstadoModel() { Sigla = "SC", Nome = "Santa Catarina" });
            estadosListBox.Add(new EstadoModel() { Sigla = "PR", Nome = "Parana" });
            estadosListBox.Add(new EstadoModel() { Sigla = "RS", Nome = "Rio Grande do Sul" });

            ViewBag.EstadosListBox = estadosListBox;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}