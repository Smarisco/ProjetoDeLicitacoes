namespace ProjetoDeLicitacoes.Models
{
    public class Licitacao
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Status { get; set; }
        public Licitacao(string numero, string descricao, DateTime dataAbertura, string status)
        {
            this.Numero = numero;
            this.Descricao = descricao;
            this.DataAbertura = dataAbertura;
            this.Status = status;
        }
    }
}
