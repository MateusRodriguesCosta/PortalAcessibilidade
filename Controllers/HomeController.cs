using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortalAcessibilidade.Models;
using PortalAcessibilidade.Models.Dao;

namespace PortalAcessibilidade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public AtividadeDao Atividades { get; set; }

        public HomeController(ILogger<HomeController> logger, AtividadeDao atividadeDao)
        {
            _logger = logger;
            this.Atividades = atividadeDao;
        }

        public IActionResult Index()
        {
            Atividade atividade = new Atividade()
            {
                Nome = "Daltonismo",
                Area = "Oftalmologia",
                IdadeInicial = 8,
                IdadeFinal = 11,
                Tipo = ""
            };

            Atividades.Adicionar(atividade);

            return View();
        }

        public IActionResult Politica()
        {
            return View();
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
