using Microsoft.AspNetCore.Mvc;
using ProjetoDeLicitacoes.Models;
using System.Diagnostics;
using ProjetoDeLicitacoes.Data;
using ProjetoDeLicitacoes.Models;
using System;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Salvar(Licitacao licitacao)
        {
            if (ModelState.IsValid)
            {
                if (licitacao.Id == 0)
                {
                    _licitacoesDbContext.Licitacao.Add(licitacao);
                }
                else
                {
                    _licitacoesDbContext.Licitacao.Update(licitacao);
                }

                _licitacoesDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View("Cadastrar", licitacao);
        }
        public IActionResult Excluir(int id)
        {
            var licitacao = _licitacoesDbContext.Licitacao.Find(id);

            if (licitacao == null)
            {
                return NotFound();
            }

            _licitacoesDbContext.Licitacao.Remove(licitacao);
            _licitacoesDbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Editar(int id)
        {
            var licitacao = _licitacoesDbContext.Licitacao.Find(id);

            if (licitacao == null)
            {
                return NotFound();
            }

            return View("Form", licitacao);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}