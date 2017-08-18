using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioCap05.Models
{
    public class HelpersModel
    {
        public List<System.Web.Mvc.SelectListItem> DropDownEstado { get; set; }

        public string EstadoSelecionado { get; set; }
    }
}