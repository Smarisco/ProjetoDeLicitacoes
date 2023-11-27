namespace ProjetoDeLicitacoes.Models.ViewModel
{
    public class LicitacaoViewModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Status { get; set; }

        public LicitacaoViewModel()
        {
                
        }
    }
}

