using Microsoft.AspNetCore.Mvc;
using ProjetoDeLicitacoes.Models;
using System.Diagnostics;
using ProjetoDeLicitacoes.Data;
using ProjetoDeLicitacoes.Models;
using System;
using Microsoft.EntityFrameworkCore;
using ProjetoDeLicitacoes.Models.Business;

namespace ProjetoDeLicitacoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LicitacaoBusiness _licitacaoBusiness;
        private readonly LicitacaoDbContext _licitacaoDbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _licitacaoBusiness = new LicitacaoBusiness();
            _licitacaoDbContext = new LicitacaoDbContext();
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Cadastrar()
        {
            try
            {
                return View();

            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro para o usuário
                ModelState.AddModelError("", "Não foi possível cadastrar a licitação.");
                return View("Cadastrar");
            }
        }
        public IActionResult Licitacao()
        {
            var licitacoes = _licitacaoDbContext.Licitacao.ToList();
            // Verifica se o campo é nulo.
            if (licitacoes== null)
            {
                // Retorna um erro.
                return NotFound("Não há licitações disponíveis.");
            }
            // Retorna a lista de licitações para a view.
            return View(licitacoes);

        }
        public IActionResult Salvar(Licitacao licitacao)
        {
            try
            {
                _licitacaoBusiness.CriarLicitacao(licitacao);

                return View("Cadastrar", licitacao);
            }

            catch (Exception ex)
            {
                // Exibe uma mensagem de erro para o usuário
                ModelState.AddModelError("", "Não foi possível salvar a licitação.");
                return View("Cadastrar", licitacao);
            }
        }
        public IActionResult Excluir(int id)
        {
            try
            {
                var licitacao = _licitacaoDbContext.Licitacao.Find(id);

                if (licitacao == null)
                {
                    return NotFound();
                }

                _licitacaoDbContext.Licitacao.Remove(licitacao);
                _licitacaoDbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Handle the exception here and return an appropriate response
                ModelState.AddModelError("", "Não foi possível excluir a licitação.");
                return View("Index");
            }
        }
        public IActionResult Editar(int id)
        {
            try
            {
                var licitacao = _licitacaoDbContext.Licitacao.Find(id);

                if (licitacao == null)
                {
                    return NotFound();
                }

                return View("Cadastrar", licitacao);
            }
            catch (Exception ex)
            {
                // Handle the exception here and return an appropriate response
                ModelState.AddModelError("", "Não foi possível editar a licitação.");
                return View("Cadastrar");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}