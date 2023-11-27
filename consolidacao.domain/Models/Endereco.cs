namespace consolidacao.domain.Models
{
    public class Endereco
    {
        public virtual int Id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string PontoReferencia { get; set; }
    }
}
