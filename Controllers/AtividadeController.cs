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
    public class AtividadeController : Controller
    {
        private readonly ILogger<AtividadeController> _logger;
        public AtividadeDao Atividades { get; set; }
        public FerramentaDao Ferramentas { get; set; }

        public AtividadeController(ILogger<AtividadeController> logger, AtividadeDao atividadeDao, FerramentaDao ferramentaDao)
        {
            _logger = logger;
            this.Atividades = atividadeDao;
            this.Ferramentas = ferramentaDao;
        }

        public IActionResult Index()
        {                        
            return View();
        }

        public IActionResult AtividadeInfo(int? id)
        {            
            return View("Oftalmologia/Info", Atividades.Procurar(id));
        }

        public IActionResult FerramentaIniciar(int? id)
        {
            Ferramenta ferramenta = Ferramentas.Procurar(id);

            return View("Oftalmologia/Ferramentas/" + ferramenta.Nome, ferramenta);
        }

        public IActionResult FerramentaResultados(int? id)
        {
            Ferramenta ferramenta = Ferramentas.Procurar(id);

            return View("Oftalmologia/Ferramentas/Resultados", ferramenta);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
