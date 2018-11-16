﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class ContatoController : Controller
    {
        /// <summary>
        /// Carrega a página de Contato
        /// </summary>
        /// <returns>View index Contato</returns>
        public ActionResult Index()
        {
            return View("IndexContato");
        }
    }
}