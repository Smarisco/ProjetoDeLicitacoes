using Microsoft.AspNetCore.Mvc;
using ProjetoDeLicitacoes.Models;
using System.Diagnostics;
using ProjetoDeLicitacoes.Data;
using ProjetoDeLicitacoes.Models;
using System;

namespace ProjetoDeLicitacoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LicitacaoDbContext _licitacoesDbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Licitacao()
        {
            // Obtém todas as licitações do banco de dados.
            var licitacoes = _licitacoesDbContext.Licitacao.ToList();

            // Retorna a lista de licitações para a view.
            return View(licitacoes);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}