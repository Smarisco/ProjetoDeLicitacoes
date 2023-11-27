using ProjetoDeLicitacoes.Data;
using ProjetoDeLicitacoes.Models.DataApplicator;
using ProjetoDeLicitacoes.Models.ViewModel;
using System.Text;
using ProjetoDeLicitacoes.Data;

namespace ProjetoDeLicitacoes.Models.Business
{
    public class LicitacaoBusiness
    {
        private readonly LicitacaoDataApplicator _licitaDA;
        private LicitacaoDbContext _context;
        public LicitacaoBusiness()
        {
            _licitaDA = new LicitacaoDataApplicator();
            _context = new LicitacaoDbContext();

        }
        public LicitacaoViewModel ConvertView(Licitacao licitacao)
        {
            LicitacaoViewModel viewModel = new LicitacaoViewModel();

            viewModel.Numero = licitacao.Numero;
            viewModel.Descricao = licitacao.Descricao;
            viewModel.DataAbertura = licitacao.DataAbertura;
            viewModel.Status = licitacao.Status;

            return viewModel;
        }

        public LicitacaoViewModel CriarLicitacao(Licitacao licitacao)
        {
            IQueryable<Licitacao> licitacoesAbertas =_context.Licitacao.Where(l => l.Status == "Aberta");

            StringBuilder mensagem = new StringBuilder();

            try
            {

                if (licitacao.Id == 0)
                {
                    _context.Licitacao.Add(licitacao);
                }
                else
                {
                    _context.Licitacao.Update(licitacao);
                }

                _context.SaveChanges();
                return ConvertView(licitacao);
            }

            catch (Exception)
            {
                throw new Exception(Convert.ToString(mensagem.Append($"A Licitação não pode ser cadastrada.")));
            }

        }
    }
}
