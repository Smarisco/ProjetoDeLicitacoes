namespace ProjetoDeLicitacoes.Models.Interface
{
    public interface ILicitacao: IDisposable
    {        
        Licitacao ObterDadosViewModel(Licitacao licitacao);
    }
}
