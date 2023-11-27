namespace consolidacao.domain.Models
{
    public class Email
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual EnumTipo TipoEmail { get; set; }

    }
}
