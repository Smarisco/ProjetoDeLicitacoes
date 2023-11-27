namespace ProjetoDeLicitacoes.Models.Model
{
    public class Licitacao
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Status { get; set; }


        public Licitacao()
        {
        }
    }
}
